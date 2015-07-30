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
            this.adxDigitalGroup = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxSubjectBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxSSNBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxRibbonButton1 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.adxPhysicalDeliveryGroup = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxPhysicalDeliveryCB = new AddinExpress.MSO.ADXRibbonCheckBox(this.components);
            this.adxControlBox = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxDigitalDeliveryCB = new AddinExpress.MSO.ADXRibbonCheckBox(this.components);
            this.adxNameBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxAddressBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxPostalCodeBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxCityBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxIdentifyType = new AddinExpress.MSO.ADXRibbonDropDown(this.components);
            this.adxIdentifyTypeSSN = new AddinExpress.MSO.ADXRibbonItem(this.components);
            this.adxIdentifyTypeNameAndAddress = new AddinExpress.MSO.ADXRibbonItem(this.components);
            this.adxReturnNameBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxRetPostalBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxRetCityBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxRetAddressBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxDigitalSSNGroup = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxDigitalFullNameGroup = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxDigitalFullNameBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxDigitalPostalCodeBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxDigitalCityBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            this.adxDigitalAddressBox = new AddinExpress.MSO.ADXRibbonEditBox(this.components);
            // 
            // adxRibbonTab1
            // 
            this.adxRibbonTab1.Caption = "Digipost";
            this.adxRibbonTab1.Controls.Add(this.adxControlBox);
            this.adxRibbonTab1.Controls.Add(this.adxDigitalGroup);
            this.adxRibbonTab1.Controls.Add(this.adxDigitalSSNGroup);
            this.adxRibbonTab1.Controls.Add(this.adxDigitalFullNameGroup);
            this.adxRibbonTab1.Controls.Add(this.adxPhysicalDeliveryGroup);
            this.adxRibbonTab1.Id = "adxRibbonTab_f4f3a06680774e52a4c17af049390062";
            this.adxRibbonTab1.InsertAfterIdMso = "TabInsert";
            this.adxRibbonTab1.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxDigitalGroup
            // 
            this.adxDigitalGroup.Caption = " ";
            this.adxDigitalGroup.Controls.Add(this.adxSubjectBox);
            this.adxDigitalGroup.Controls.Add(this.adxIdentifyType);
            this.adxDigitalGroup.Id = "adxRibbonGroup_984f4cac3b87409aa2ca784f42958dfe";
            this.adxDigitalGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalGroup.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
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
            this.adxRibbonButton1.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large;
            this.adxRibbonButton1.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton1_OnClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "digipost_icon_128.png");
            // 
            // adxPhysicalDeliveryGroup
            // 
            this.adxPhysicalDeliveryGroup.Caption = "  ";
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxNameBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxAddressBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxPostalCodeBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxCityBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxReturnNameBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxRetPostalBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxRetCityBox);
            this.adxPhysicalDeliveryGroup.Controls.Add(this.adxRetAddressBox);
            this.adxPhysicalDeliveryGroup.Id = "adxRibbonGroup_caf27065ecad475da3b9352d2d192196";
            this.adxPhysicalDeliveryGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxPhysicalDeliveryGroup.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxPhysicalDeliveryGroup.Visible = false;
            // 
            // adxPhysicalDeliveryCB
            // 
            this.adxPhysicalDeliveryCB.Caption = "Physical delivery";
            this.adxPhysicalDeliveryCB.Id = "adxRibbonCheckBox_9886518cfa6f45c28f2d919f1fdc420d";
            this.adxPhysicalDeliveryCB.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxPhysicalDeliveryCB.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxPhysicalDeliveryCB_OnClick);
            this.adxPhysicalDeliveryCB.PropertyChanging += new AddinExpress.MSO.ADXRibbonPropertyChanging_EventHandler(this.adxPhysicalDeliveryCB_PropertyChanging);
            // 
            // adxControlBox
            // 
            this.adxControlBox.Caption = "  ";
            this.adxControlBox.Controls.Add(this.adxDigitalDeliveryCB);
            this.adxControlBox.Controls.Add(this.adxPhysicalDeliveryCB);
            this.adxControlBox.Controls.Add(this.adxRibbonButton1);
            this.adxControlBox.Id = "adxRibbonGroup_587e3ac02e7d4733af4c3f059e639913";
            this.adxControlBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxControlBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxDigitalDeliveryCB
            // 
            this.adxDigitalDeliveryCB.Caption = "Digital";
            this.adxDigitalDeliveryCB.Id = "adxRibbonCheckBox_855b55556593481ca6ef14154e788446";
            this.adxDigitalDeliveryCB.Pressed = true;
            this.adxDigitalDeliveryCB.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxDigitalDeliveryCB.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxDigitalDeliveryCB_OnClick);
            this.adxDigitalDeliveryCB.PropertyChanging += new AddinExpress.MSO.ADXRibbonPropertyChanging_EventHandler(this.adxDigitalDeliveryCB_PropertyChanging);
            // 
            // adxNameBox
            // 
            this.adxNameBox.Caption = "Full name";
            this.adxNameBox.Id = "adxRibbonEditBox_ca8a975afc614337a54bdf097de74f85";
            this.adxNameBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxNameBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxAddressBox
            // 
            this.adxAddressBox.Caption = "Address";
            this.adxAddressBox.Id = "adxRibbonEditBox_55fdf3b0f6604948bea810ce8e08651b";
            this.adxAddressBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxAddressBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxPostalCodeBox
            // 
            this.adxPostalCodeBox.Caption = "Postal code";
            this.adxPostalCodeBox.Id = "adxRibbonEditBox_f0555302479c45e096174e216711bcdb";
            this.adxPostalCodeBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxPostalCodeBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxCityBox
            // 
            this.adxCityBox.Caption = "City";
            this.adxCityBox.Id = "adxRibbonEditBox_4bf6204f92fd45b39a40b6c0bcbcfef6";
            this.adxCityBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxCityBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxIdentifyType
            // 
            this.adxIdentifyType.Caption = "Identify reciever";
            this.adxIdentifyType.Id = "adxRibbonDropDown_89e25be495bc49918fe85040444a1f38";
            this.adxIdentifyType.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxIdentifyType.Items.Add(this.adxIdentifyTypeSSN);
            this.adxIdentifyType.Items.Add(this.adxIdentifyTypeNameAndAddress);
            this.adxIdentifyType.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxIdentifyType.OnAction += new AddinExpress.MSO.ADXRibbonOnActionSelected_EventHandler(this.adxIdentifyType_OnAction);
            // 
            // adxIdentifyTypeSSN
            // 
            this.adxIdentifyTypeSSN.Caption = "SSN";
            this.adxIdentifyTypeSSN.Id = "adxIdentifyTypeSSN";
            this.adxIdentifyTypeSSN.ImageTransparentColor = System.Drawing.Color.Transparent;
            // 
            // adxIdentifyTypeNameAndAddress
            // 
            this.adxIdentifyTypeNameAndAddress.Caption = "Name and Address";
            this.adxIdentifyTypeNameAndAddress.Id = "adxIdentifyTypeNameAndAddress";
            this.adxIdentifyTypeNameAndAddress.ImageTransparentColor = System.Drawing.Color.Transparent;
            // 
            // adxReturnNameBox
            // 
            this.adxReturnNameBox.Caption = "Return name";
            this.adxReturnNameBox.Id = "adxRibbonEditBox_bda99cd22f7f4cf29895f0e7952ce12e";
            this.adxReturnNameBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxReturnNameBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxRetPostalBox
            // 
            this.adxRetPostalBox.Caption = "Return postal code";
            this.adxRetPostalBox.Id = "adxRibbonEditBox_4c72d534c04749fc9c8f417ab8bca2e7";
            this.adxRetPostalBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRetPostalBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxRetCityBox
            // 
            this.adxRetCityBox.Caption = "Return city";
            this.adxRetCityBox.Id = "adxRibbonEditBox_4c8b07883dd94f8ab117f16289ff003f";
            this.adxRetCityBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRetCityBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxRetAddressBox
            // 
            this.adxRetAddressBox.Caption = "Return address";
            this.adxRetAddressBox.Id = "adxRibbonEditBox_c905b5c559e34dce9720beba8f4f04b7";
            this.adxRetAddressBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRetAddressBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxDigitalSSNGroup
            // 
            this.adxDigitalSSNGroup.Caption = "SSN";
            this.adxDigitalSSNGroup.Controls.Add(this.adxSSNBox);
            this.adxDigitalSSNGroup.Id = "adxRibbonGroup_693f68c1deaf4d21bb67427258546bca";
            this.adxDigitalSSNGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalSSNGroup.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxDigitalSSNGroup.Visible = false;
            // 
            // adxDigitalFullNameGroup
            // 
            this.adxDigitalFullNameGroup.Caption = "Name and address";
            this.adxDigitalFullNameGroup.Controls.Add(this.adxDigitalFullNameBox);
            this.adxDigitalFullNameGroup.Controls.Add(this.adxDigitalPostalCodeBox);
            this.adxDigitalFullNameGroup.Controls.Add(this.adxDigitalCityBox);
            this.adxDigitalFullNameGroup.Controls.Add(this.adxDigitalAddressBox);
            this.adxDigitalFullNameGroup.Id = "adxRibbonGroup_844217687cf04839a0da5043254a9ba2";
            this.adxDigitalFullNameGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalFullNameGroup.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            this.adxDigitalFullNameGroup.Visible = false;
            // 
            // adxDigitalFullNameBox
            // 
            this.adxDigitalFullNameBox.Caption = "Full name";
            this.adxDigitalFullNameBox.Id = "adxRibbonEditBox_6fdb32bb5f22479b83251671a7a5ba3e";
            this.adxDigitalFullNameBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalFullNameBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxDigitalPostalCodeBox
            // 
            this.adxDigitalPostalCodeBox.Caption = "Postal code";
            this.adxDigitalPostalCodeBox.Id = "adxRibbonEditBox_4a9c89f385234805a7d8304fdd372de4";
            this.adxDigitalPostalCodeBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalPostalCodeBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxDigitalCityBox
            // 
            this.adxDigitalCityBox.Caption = "City";
            this.adxDigitalCityBox.Id = "adxRibbonEditBox_284a28a8e880474faf7292a998140c0d";
            this.adxDigitalCityBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalCityBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // adxDigitalAddressBox
            // 
            this.adxDigitalAddressBox.Caption = "Address";
            this.adxDigitalAddressBox.Id = "adxRibbonEditBox_47bb2e0689ed451a9bd68fdb1478cb4a";
            this.adxDigitalAddressBox.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxDigitalAddressBox.Ribbons = AddinExpress.MSO.ADXRibbons.msrWordDocument;
            // 
            // AddinModule
            // 
            this.AddinName = "DigipostAddin_CSharp";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaWord;

        }
        #endregion

        private AddinExpress.MSO.ADXRibbonTab adxRibbonTab1;
        private AddinExpress.MSO.ADXRibbonGroup adxDigitalGroup;
        private AddinExpress.MSO.ADXRibbonEditBox adxSubjectBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxSSNBox;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton1;
        private System.Windows.Forms.ImageList imageList1;
        private AddinExpress.MSO.ADXRibbonGroup adxPhysicalDeliveryGroup;
        private AddinExpress.MSO.ADXRibbonCheckBox adxPhysicalDeliveryCB;
        private AddinExpress.MSO.ADXRibbonGroup adxControlBox;
        private AddinExpress.MSO.ADXRibbonCheckBox adxDigitalDeliveryCB;
        private AddinExpress.MSO.ADXRibbonEditBox adxNameBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxAddressBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxPostalCodeBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxCityBox;
        private AddinExpress.MSO.ADXRibbonDropDown adxIdentifyType;
        private AddinExpress.MSO.ADXRibbonItem adxIdentifyTypeSSN;
        private AddinExpress.MSO.ADXRibbonItem adxIdentifyTypeNameAndAddress;
        private AddinExpress.MSO.ADXRibbonEditBox adxReturnNameBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxRetPostalBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxRetCityBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxRetAddressBox;
        private AddinExpress.MSO.ADXRibbonGroup adxDigitalSSNGroup;
        private AddinExpress.MSO.ADXRibbonGroup adxDigitalFullNameGroup;
        private AddinExpress.MSO.ADXRibbonEditBox adxDigitalFullNameBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxDigitalPostalCodeBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxDigitalCityBox;
        private AddinExpress.MSO.ADXRibbonEditBox adxDigitalAddressBox;
    }
}

