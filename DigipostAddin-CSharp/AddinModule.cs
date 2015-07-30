using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using AddinExpress.MSO;
using Digipost.Api.Client;
using System.Diagnostics;
using Digipost.Api.Client.Api;
using Microsoft.Office.Interop.Word;

namespace DigipostAddin_CSharp
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("BEE06C06-7F4A-45D0-8716-01830A7DBEE5"), ProgId("DigipostAddin_CSharp.AddinModule")]
    public partial class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        public AddinModule()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }
 
        #region Add-in Express automatic code
 
        // Required by Add-in Express - do not modify
        // the methods within this region
 
        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }
 
        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }
 
        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }
 
        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance 
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Word._Application WordApp
        {
            get
            {
                return (HostApplication as Word._Application);
            }
        }

        private void adxRibbonButton1_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            const string SenderId = "779052"; //"106768801";
            string Thumbprint = "84e492a972b7edc197a32d9e9c94ea27bd5ac4d9".ToUpper();
            var config = new ClientConfig(SenderId)
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
            var client = new DigipostClient(config, Thumbprint);
            
            byte[] _contentBytes = null;
            var curdoc = WordApp.ActiveDocument;
            var range = curdoc.Content;
            var newDocument = new Word.Document();

            object destFilename = "E:\\Test\\test.pdf";

            object missing = Type.Missing;
            curdoc.SaveAs( ref destFilename,  WdExportFormat.wdExportFormatPDF, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            
            
            var fullname = curdoc.FullName;

            
            //for(int i =1; i< range.PageSetup) //loop through pages
            var str = "";
            for (int i = 1; i < range.Paragraphs.Count; i++)
            {
                str = str + range.Paragraphs.Item(i).Range.Text;
            }

            _contentBytes = System.Text.Encoding.UTF8.GetBytes(str);
            

            var recipient = new Digipost.Api.Client.Domain.Recipient(Digipost.Api.Client.Domain.Enums.IdentificationChoice.PersonalidentificationNumber, adxSSNBox.Text.Trim());
            var document = new Digipost.Api.Client.Domain.Document(adxSubjectBox.Text, "pdf",(string) destFilename);

            var message = new Digipost.Api.Client.Domain.Message(recipient, document);
            client.SendMessage(message);

            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(curdoc);

            

        }
        private void Test()
        {
            object visible = true;
            object readOnly = true;
            object sourceFilename = "";
            string targetFilename = "";
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            Document doc = wordApp.Documents.Open(ref sourceFilename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                                                  ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing,
                                                  ref missing, ref missing);
            
            doc.ExportAsFixedFormat(targetFilename, WdExportFormat.wdExportFormatPDF, false, WdExportOptimizeFor.wdExportOptimizeForOnScreen,
                                    WdExportRange.wdExportAllDocument, 0, 0, WdExportItem.wdExportDocumentContent, false, false,
                                    WdExportCreateBookmarks.wdExportCreateNoBookmarks, false, false, false, ref missing);

            object saveChanges = false;
            doc.Close(ref saveChanges, ref missing, ref missing);
            wordApp.Quit(ref saveChanges, ref missing, ref missing);
        }

        static object missing = Type.Missing;
    }
    
}

