using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using AddinExpress.MSO;
using Digipost.Api.Client;
using Digipost.Api.Client.Api;
using Digipost.Api.Client.Domain;
using Digipost.Api.Client.Domain.Enums;
using Digipost.Api.Client.Domain.PersonDetails;
using Digipost.Api.Client.Domain.Print;
using Microsoft.Office.Interop.Word;
using Application = System.Windows.Forms.Application;
using Document = Word.Document;
using Message = Digipost.Api.Client.Domain.Message;
using Timer = System.Timers.Timer;
using _Application = Word._Application;

namespace DigipostAddin_CSharp
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [Guid("BEE06C06-7F4A-45D0-8716-01830A7DBEE5"), ProgId("DigipostAddin_CSharp.AddinModule")]
    public partial class AddinModule : ADXAddinModule
    {
        public AddinModule()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            
            

            // Please add any initialization code to the AddinInitialize event handler

        }
        

        #region Add-in Express automatic code

        // Required by Add-in Express - do not modify
        // the methods within this region

        public override IContainer GetContainer()
        {
            return components ?? (components = new Container());
        }

        [ComRegisterFunction]
        public static void AddinRegister(Type t)
        {
            ADXRegister(t);
        }

        [ComUnregisterFunction]
        public static void AddinUnregister(Type t)
        {
            ADXUnregister(t);
        }

        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance => ADXAddinModule.CurrentInstance as AddinModule;

        public _Application WordApp => (HostApplication as _Application);

        static DigipostClient _client = null;
        private PersonDetailsResult _personDetailsResult;

        private DigipostClient GetClient()
        {
            if (_client != null)
                return _client;

            const string senderId = "779052"; //"106768801";
            var thumbprint = "d6 5e 6c 4c 77 fc 0e 0d c5 f5 ac 32 bc 43 70 1f a8 b0 3d 21".ToUpper();
            var config = new ClientConfig(senderId)
            {
                ApiUrl = new Uri("https://api.digipost.no"),
                Logger = (severity, konversasjonsId, metode, melding) =>
                {
                    Debug.WriteLine("{0} - {1} [{2}]",
                        DateTime.Now,
                        melding,
                        konversasjonsId.GetValueOrDefault()
                    );
                }
            };

            //Logging.Initialize(config);
            return _client = new DigipostClient(config, thumbprint);
        }

        private void adxRibbonButton1_OnClick(object sender, IRibbonControl control, bool pressed)
        {

            
            var curdoc = WordApp.ActiveDocument;
            var range = curdoc.Content;
            

            object destFilename = Path.GetTempPath() + "\\tmp.pdf";

            var missing = Type.Missing;
            curdoc.SaveAs(ref destFilename, WdExportFormat.wdExportFormatPDF, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            Recipient recipient = null;
            switch (adxDeliveryMethodDDL.SelectedItemId)
            {
                case "adxDMDigital":
                    switch (adxIdentifyType.SelectedItemId)
                    {
                        case "adxIdentifyTypeNameAndAddress":
                            recipient = new Recipient(new RecipientByNameAndAddress(adxDigitalFullNameBox.Text, adxDigitalPostalCodeBox.Text, adxDigitalCityBox.Text, adxDigitalAddressBox.Text));
                            break;
                        case "adxIdentifyTypeSSN":
                            recipient = new Recipient(IdentificationChoice.PersonalidentificationNumber, adxSSNBox.Text.Trim());
                            break;
                        case "adxIdentifyTypeAutosuggest":
                            recipient = new Recipient(IdentificationChoice.DigipostAddress,adxDDLSearchResult.Items[adxDDLSearchResult.SelectedItemIndex].AsRibbonItem.Id);
                            break;
                    }
                    break;
                case "adxDMPhysical":
                    recipient = new Recipient(new PrintDetails(new PrintRecipient(adxNameBox.Text, new NorwegianAddress(adxPostalCodeBox.Text, adxCityBox.Text, adxAddressBox.Text)), new PrintReturnAddress(adxReturnNameBox.Text, new NorwegianAddress(adxRetPostalBox.Text, adxRetCityBox.Text, adxRetAddressBox.Text))));
                    break;
            }
            var document = new Digipost.Api.Client.Domain.Document(adxSubjectBox.Text, "pdf", (string)destFilename);

            var message = new Message(recipient, document);

            try
            {
                var response = GetClient().SendMessage(message);
                MessageBox.Show("Status: " + response.Status);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception " + e.Message + "," + e.InnerException);
            }
            finally
            {
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(curdoc);

                if (File.Exists((string)destFilename))
                {
                    File.Delete((string)destFilename);
                }
            }


        }
      
        
        private void adxIdentifyType_OnAction(object sender, IRibbonControl Control, string selectedId, int selectedIndex)
        {
            switch (selectedId)
            {
                case "adxIdentifyTypeSSN":
                    adxDigitalSSNGroup.Visible = true;
                    adxDigitalFullNameGroup.Visible = adxAutoSuggestBox.Visible = adxPersonGroup.Visible= false;
                    break;
                case "adxIdentifyTypeNameAndAddress":
                    adxDigitalFullNameGroup.Visible = true;
                    adxDigitalSSNGroup.Visible = adxAutoSuggestBox.Visible = adxPersonGroup.Visible =  false;
                    break;
                case "adxIdentifyTypeAutosuggest":
                    adxDigitalFullNameGroup.Visible = adxDigitalSSNGroup.Visible = false;
                    adxAutoSuggestBox.Visible = true;
                    break;
            }
        }

        private void adxDeliveryMethodDDL_OnAction(object sender, IRibbonControl Control, string selectedId, int selectedIndex)
        {
            switch (selectedId)
            {
                case "adxDMDigital":
                    adxPhysicalDeliveryGroup.Visible = false;

                    adxDigitalGroup.Visible = true;
                    
                    adxIdentifyType_OnAction(sender, Control, "adxIdentifyTypeAutosuggest", adxIdentifyType.SelectedItemIndex);

                    break;
                case "adxDMPhysical":
                    adxDigitalGroup.Visible = false;
                    adxDigitalSSNGroup.Visible = adxDigitalFullNameGroup.Visible = false;
                    adxIdentifyType.SelectedItemIndex = -1;

                    adxPhysicalDeliveryGroup.Visible = true;
                    break;
            }
        }

        private void AddResultButtons(PersonDetails personDetails)
        {
            var resultRibbon = new ADXRibbonItem(this.components)
            {
                Caption = personDetails.FirstName+ " " +personDetails.MiddleName +" "+personDetails.LastName,
                Id = personDetails.DigipostAddress,
                ImageTransparentColor = Color.Red,
                ScreenTip = personDetails.MobileNumber+ "\r\n"+personDetails.DigipostAddress
            };

            this.adxDDLSearchResult.Items.Add(resultRibbon);
            adxPersonGroup.Visible = true;

        }

        private void resetSearchResult()
        {
            adxDDLSearchResult.Items.Clear();
            
            adxPersonLBL.Caption = " ";
        }

        private void DoSearch(string searchString)
        {

            resetSearchResult();
            adxSendGroup.Visible = false;
            
            
            var suggestionsResult = _personDetailsResult = GetClient().Search(searchString);
             

             foreach (var res in suggestionsResult.PersonDetails)
             {
                AddResultButtons(res);
            }
             
        }

        private void adxRibbonTab1_PropertyChanging(object sender, ADXRibbonPropertyChangingEventArgs e)
        {
            
        }

        private void adxRibbonGroup2_PropertyChanging(object sender, ADXRibbonPropertyChangingEventArgs e)
        {
            
        }

        private void adxDDLSearchResult_OnAction(object sender, IRibbonControl Control, string selectedId, int selectedIndex)
        {
            var item = adxDDLSearchResult.Items[adxDDLSearchResult.SelectedItemIndex].AsRibbonItem;

            var name = item.Caption;
            var helpText = item.ScreenTip;

            adxPersonLBL.Caption = name + " ,\r\n" + helpText;

            adxSendGroup.Visible = true;

        }

        private void adxSearchBTN_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            DoSearch(adxRibbonEditBox1.Text);
        }
    }
}

