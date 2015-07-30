namespace DigipostAddin_CSharp
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinModule));
            this.adxRibbonTab1 = new AddinExpress.MSO.ADXRibbonTab(this.components);
            this.adxRibbonGroup1 = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxSubjectBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxSSNBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxRibbonButton1 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            // 
            // adxRibbonTab1
            // 
            this.adxRibbonTab1.Caption = "Digipost";
            this.adxRibbonTab1.Controls.Add(this.adxRibbonGroup1);
            this.adxRibbonTab1.Id = "adxRibbonTab_f4f3a06680774e52a4c17af049390062";
            this.adxRibbonTab1.InsertAfterIdMso = "TabInsert";
            this.adxRibbonTab1.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxRibbonGroup1
            // 
            this.adxRibbonGroup1.Caption = " ";
            this.adxRibbonGroup1.Controls.Add(this.adxSubjectBox);
            this.adxRibbonGroup1.Controls.Add(this.adxSSNBox);
            this.adxRibbonGroup1.Controls.Add(this.adxRibbonButton1);
            this.adxRibbonGroup1.Id = "adxRibbonGroup_984f4cac3b87409aa2ca784f42958dfe";
            this.adxRibbonGroup1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonGroup1.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxSubjectBox
            // 
            this.adxSubjectBox.Caption = "Subject";
            this.adxSubjectBox.Id = "adxRibbonEditBox_ed565c2a7915454f9dfd1247753c3da0";
            this.adxSubjectBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxSubjectBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxSSNBox
            // 
            this.adxSSNBox.Caption = "SSN";
            this.adxSSNBox.Id = "adxRibbonEditBox_9060d55fc6b64545ae5b400b13477be5";
            this.adxSSNBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxSSNBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxRibbonButton1
            // 
            this.adxRibbonButton1.Caption = "Send";
            this.adxRibbonButton1.Id = "adxRibbonButton_e4e24ad77f164b3389d1c9c1f28cbac1";
            this.adxRibbonButton1.Image = 0;
            this.adxRibbonButton1.ImageList = this.imageList1;
            this.adxRibbonButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton1.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxRibbonButton1.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton1_OnClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "digipost_icon_128.png");
            // 
            // AddinModule
            // 
            this.AddinName = "DigipostAddin_CSharp";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaWord;

        }
        #endregion

        private AddinExpress.MSO.ADXRibbonTab adxRibbonTab1;
        private AddinExpress.MSO.ADXRibbonGroup adxRibbonGroup1;
        private AddinExpress.MSO.ADXRibbonEditBox adxSubjectBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxSSNBox;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

