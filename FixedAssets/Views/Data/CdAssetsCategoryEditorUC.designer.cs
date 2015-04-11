namespace FixedAssets.Views.Data
{
    partial class CdAssetsCategoryEditorUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CdAssetsCategoryEditorUC));
            this.repositoryItemButtonEditParamDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAddNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.XPSCSCat = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionCat = new DevExpress.Xpo.Session(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.colAssetsCategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollectionNormal = new DevExpress.Utils.ImageCollection(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParamDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEditParamDel
            // 
            this.repositoryItemButtonEditParamDel.AutoHeight = false;
            this.repositoryItemButtonEditParamDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEditParamDel.Name = "repositoryItemButtonEditParamDel";
            this.repositoryItemButtonEditParamDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiExport,
            this.bbiRefresh,
            this.bbiAddNode,
            this.bbiDeleteNode});
            this.barManagerMain.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeleteNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiAddNode
            // 
            this.bbiAddNode.Caption = "اضافة فئة جديدة";
            this.bbiAddNode.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiAddNode.Glyph")));
            this.bbiAddNode.Id = 3;
            this.bbiAddNode.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiAddNode.LargeGlyph")));
            this.bbiAddNode.Name = "bbiAddNode";
            this.bbiAddNode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAddNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddNode_ItemClick);
            // 
            // bbiDeleteNode
            // 
            this.bbiDeleteNode.Caption = "حذف فئة";
            this.bbiDeleteNode.Glyph = global::FixedAssets.Properties.Resources.cancel_16x16;
            this.bbiDeleteNode.Id = 4;
            this.bbiDeleteNode.Name = "bbiDeleteNode";
            this.bbiDeleteNode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDeleteNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeleteNode_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "اعادة تحميل الفئات";
            this.bbiRefresh.Glyph = global::FixedAssets.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.LargeGlyph = global::FixedAssets.Properties.Resources.up_32x32;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "تصدير";
            this.bbiExport.Glyph = global::FixedAssets.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(927, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Size = new System.Drawing.Size(927, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(927, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // XPSCSCat
            // 
            this.XPSCSCat.AllowEdit = true;
            this.XPSCSCat.AllowNew = true;
            this.XPSCSCat.AllowRemove = true;
            this.XPSCSCat.DeleteObjectOnRemove = true;
            this.XPSCSCat.ObjectType = typeof(FixedAssets.Datasource.dsData.CdAssetsCategoryDataTable);
            this.XPSCSCat.Session = this.sessionCat;
            // 
            // sessionCat
            // 
            this.sessionCat.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionCat.TrackPropertiesModifications = false;
            this.sessionCat.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.sessionCat_BeforeCommitTransaction);
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // treeListMain
            // 
            this.treeListMain.AllowDrop = true;
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colAssetsCategoryName});
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.DragNodesMode = DevExpress.XtraTreeList.TreeListDragNodesMode.Advanced;
            this.treeListMain.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always;
            this.treeListMain.KeyFieldName = "AssetsCategoryID";
            this.treeListMain.Location = new System.Drawing.Point(0, 0);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.DragNodes = true;
            this.treeListMain.OptionsBehavior.EnableFiltering = true;
            this.treeListMain.OptionsBehavior.ImmediateEditor = false;
            this.treeListMain.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.treeListMain.OptionsLayout.LayoutVersion = "1";
            this.treeListMain.OptionsNavigation.AutoFocusNewNode = true;
            this.treeListMain.OptionsNavigation.AutoMoveRowFocus = true;
            this.treeListMain.OptionsNavigation.EnterMovesNextColumn = true;
            this.treeListMain.OptionsView.AutoWidth = false;
            this.treeListMain.ParentFieldName = "parentID";
            this.treeListMain.SelectImageList = this.imageCollectionNormal;
            this.treeListMain.Size = new System.Drawing.Size(889, 419);
            this.treeListMain.TabIndex = 10;
            this.treeListMain.AfterExpand += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListMain_AfterExpand);
            // 
            // colAssetsCategoryName
            // 
            this.colAssetsCategoryName.Caption = "اسم الفئة";
            this.colAssetsCategoryName.FieldName = "AssetsCategoryName";
            this.colAssetsCategoryName.MinWidth = 34;
            this.colAssetsCategoryName.Name = "colAssetsCategoryName";
            this.colAssetsCategoryName.Visible = true;
            this.colAssetsCategoryName.VisibleIndex = 0;
            this.colAssetsCategoryName.Width = 193;
            // 
            // imageCollectionNormal
            // 
            this.imageCollectionNormal.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionNormal.ImageStream")));
            this.imageCollectionNormal.InsertImage(global::FixedAssets.Properties.Resources.open_16x16, "open_16x16", typeof(global::FixedAssets.Properties.Resources), 0);
            this.imageCollectionNormal.Images.SetKeyName(0, "open_16x16");
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeListMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(927, 419);
            this.splitContainerControl1.SplitterPosition = 889;
            this.splitContainerControl1.TabIndex = 15;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // CdAssetsCategoryEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CdAssetsCategoryEditorUC";
            this.Size = new System.Drawing.Size(927, 450);
            this.Load += new System.EventHandler(this.ProductEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditParamDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSCat;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAssetsCategoryName;
        private DevExpress.XtraBars.BarButtonItem bbiAddNode;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteNode;
        private DevExpress.Xpo.Session sessionCat;
        private DevExpress.Utils.ImageCollection imageCollectionNormal;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditParamDel;
    }
}
