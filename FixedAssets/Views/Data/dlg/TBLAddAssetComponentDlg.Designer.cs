﻿namespace FixedAssets.Views.Data
{
    partial class TBLAddAssetComponentDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLAddAssetComponentDlg));
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tbAddReson = new DevExpress.XtraEditors.TextEdit();
            this.tbPriceOne = new DevExpress.XtraEditors.TextEdit();
            this.tbAddComponentezn = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lueComponentId = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSCDComponents = new DevExpress.Data.Linq.LinqServerModeSource();
            this.tbAddQuantity = new DevExpress.XtraEditors.TextEdit();
            this.deAdddate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetplaceId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpOhda = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddReson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPriceOne.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddComponentezn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueComponentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdddate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdddate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpOhda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.tbAddReson);
            this.dataLayoutControlMain.Controls.Add(this.tbPriceOne);
            this.dataLayoutControlMain.Controls.Add(this.tbAddComponentezn);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.lueComponentId);
            this.dataLayoutControlMain.Controls.Add(this.tbAddQuantity);
            this.dataLayoutControlMain.Controls.Add(this.deAdddate);
            this.dataLayoutControlMain.DataMember = "TblAssets";
            this.dataLayoutControlMain.DataSource = this.dsData;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(789, 140, 330, 510);
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControlMain.Root = this.layoutControlGroupMain;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(414, 197);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // tbAddReson
            // 
            this.tbAddReson.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAddAssetComponent.AddReson", true));
            this.tbAddReson.Location = new System.Drawing.Point(12, 136);
            this.tbAddReson.Name = "tbAddReson";
            this.tbAddReson.Size = new System.Drawing.Size(326, 20);
            this.tbAddReson.StyleController = this.dataLayoutControlMain;
            this.tbAddReson.TabIndex = 21;
            // 
            // tbPriceOne
            // 
            this.tbPriceOne.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAddAssetComponent.PriceOne", true));
            this.tbPriceOne.Location = new System.Drawing.Point(12, 88);
            this.tbPriceOne.Name = "tbPriceOne";
            this.tbPriceOne.Properties.Mask.EditMask = "f2";
            this.tbPriceOne.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbPriceOne.Size = new System.Drawing.Size(326, 20);
            this.tbPriceOne.StyleController = this.dataLayoutControlMain;
            this.tbPriceOne.TabIndex = 19;
            // 
            // tbAddComponentezn
            // 
            this.tbAddComponentezn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAddAssetComponent.AddComponentezn", true));
            this.tbAddComponentezn.Location = new System.Drawing.Point(12, 12);
            this.tbAddComponentezn.Name = "tbAddComponentezn";
            this.tbAddComponentezn.Size = new System.Drawing.Size(326, 20);
            this.tbAddComponentezn.StyleController = this.dataLayoutControlMain;
            this.tbAddComponentezn.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(100, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(302, 24);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::FixedAssets.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(12, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // lueComponentId
            // 
            this.lueComponentId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAddAssetComponent.ComponentId", true));
            this.lueComponentId.Location = new System.Drawing.Point(12, 36);
            this.lueComponentId.Name = "lueComponentId";
            this.lueComponentId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueComponentId.Properties.Appearance.Options.UseFont = true;
            this.lueComponentId.Properties.Appearance.Options.UseTextOptions = true;
            this.lueComponentId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueComponentId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueComponentId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Component", "Component", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueComponentId.Properties.DataSource = this.LSMSCDComponents;
            this.lueComponentId.Properties.DisplayMember = "Component";
            this.lueComponentId.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueComponentId.Properties.NullText = "";
            this.lueComponentId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueComponentId.Properties.ValueMember = "ComponentId";
            this.lueComponentId.Size = new System.Drawing.Size(326, 22);
            this.lueComponentId.StyleController = this.dataLayoutControlMain;
            this.lueComponentId.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.lueComponentId, conditionValidationRule1);
            // 
            // LSMSCDComponents
            // 
            this.LSMSCDComponents.ElementType = typeof(FixedAssets.Datasource.linq.CDComponent);
            this.LSMSCDComponents.KeyExpression = "[ComponentId]";
            // 
            // tbAddQuantity
            // 
            this.tbAddQuantity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAddAssetComponent.AddQuantity", true));
            this.tbAddQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbAddQuantity.Location = new System.Drawing.Point(12, 62);
            this.tbAddQuantity.Name = "tbAddQuantity";
            this.tbAddQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbAddQuantity.Properties.Appearance.Options.UseFont = true;
            this.tbAddQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAddQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbAddQuantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.tbAddQuantity.Properties.Mask.EditMask = "f2";
            this.tbAddQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbAddQuantity.Size = new System.Drawing.Size(326, 22);
            this.tbAddQuantity.StyleController = this.dataLayoutControlMain;
            this.tbAddQuantity.TabIndex = 14;
            // 
            // deAdddate
            // 
            this.deAdddate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAddAssetComponent.Adddate", true));
            this.deAdddate.EditValue = null;
            this.deAdddate.Location = new System.Drawing.Point(12, 112);
            this.deAdddate.Name = "deAdddate";
            this.deAdddate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAdddate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deAdddate.Properties.Mask.EditMask = "d/M/yyyy";
            this.deAdddate.Size = new System.Drawing.Size(326, 20);
            this.deAdddate.StyleController = this.dataLayoutControlMain;
            this.deAdddate.TabIndex = 20;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(414, 197);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAssetplaceId,
            this.ItemForEmpOhda,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(394, 177);
            // 
            // ItemForAssetplaceId
            // 
            this.ItemForAssetplaceId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetplaceId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetplaceId.Control = this.lueComponentId;
            this.ItemForAssetplaceId.Location = new System.Drawing.Point(0, 24);
            this.ItemForAssetplaceId.Name = "ItemForAssetplaceId";
            this.ItemForAssetplaceId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetplaceId.Text = "المكون";
            this.ItemForAssetplaceId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetplaceId.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForEmpOhda
            // 
            this.ItemForEmpOhda.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmpOhda.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForEmpOhda.Control = this.tbAddQuantity;
            this.ItemForEmpOhda.Location = new System.Drawing.Point(0, 50);
            this.ItemForEmpOhda.Name = "ItemForEmpOhda";
            this.ItemForEmpOhda.Size = new System.Drawing.Size(394, 26);
            this.ItemForEmpOhda.Text = "الكمية";
            this.ItemForEmpOhda.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForEmpOhda.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(88, 29);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(88, 148);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(306, 29);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.tbAddComponentezn;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem3.Text = "اذن الاضافة";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.tbPriceOne;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem4.Text = "سعر الوحدة";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.deAdddate;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem5.Text = "تاريخ الاضافة";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.tbAddReson;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem6.Text = "سبب الاضافة";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(61, 13);
            // 
            // TBLAddAssetComponentDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 197);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLAddAssetComponentDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbAddReson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPriceOne.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddComponentezn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueComponentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdddate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deAdddate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpOhda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetplaceId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpOhda;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lueComponentId;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDComponents;
        private DevExpress.XtraEditors.TextEdit tbAddQuantity;
        private DevExpress.XtraEditors.TextEdit tbAddComponentezn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit tbAddReson;
        private DevExpress.XtraEditors.TextEdit tbPriceOne;
        private DevExpress.XtraEditors.DateEdit deAdddate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}