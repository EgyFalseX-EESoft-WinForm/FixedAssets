using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using DevExpress.XtraGrid;

namespace FixedAssets.Views.Data
{
    public partial class CdAssetsCategoryEditorUC : XtraUserControl
    {
        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CdAssetsCategoryEditorUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        FixedAssets.Datasource.dsDataTableAdapters.CdAssetsCategoryTableAdapter adpCategory = new FixedAssets.Datasource.dsDataTableAdapters.CdAssetsCategoryTableAdapter();
        GridHitInfo downHitInfo = null;

        #endregion
        #region - Functions -
        public CdAssetsCategoryEditorUC(FixedAssets.Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            XPSCSCat.Session.ConnectionString = Properties.Settings.Default.FixedAssetsConnectionString;
            treeListMain.DataSource = XPSCSCat;
        }
        public void ActivateRules()
        {
            XPSCSCat.AllowNew = _elementRule.Inserting;
            XPSCSCat.AllowRemove = _elementRule.Deleting;
            XPSCSCat.AllowEdit = _elementRule.Updateing;

            if (!_elementRule.Inserting)
                bbiAddNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_elementRule.Deleting)
                bbiDeleteNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        #endregion
        #region - EventWhnd -
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            ActivateRules();
            LoadData();
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             //Check whether the GridControl can be previewed.
            if (!treeListMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            treeListMain.ShowRibbonPrintPreview();
            
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            sessionCat.DropIdentityMap();
            XPSCSCat.Reload();
            treeListMain.RefreshDataSource();
        }
        private void bbiAddNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lock (this)
            {
                int ParentNode;
                if (treeListMain.FocusedNode != null)
                    ParentNode = treeListMain.FocusedNode.Id;
                else
                    ParentNode = 0;
                try
                {
                    int NewNodeId = (int)adpCategory.NewId();
                    treeListMain.AppendNode(new object[] { null, NewNodeId, "جديد" }, ParentNode, 0, 0, 0);
                }
                catch{ }
            }
        }
        private void sessionCat_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                item.SetMemberValue("UserIn", Classes.Managers.UserManager.defaultInstance.User.UserId);
                item.SetMemberValue("dateIn", Classes.Managers.DataManager.GetServerDatetime);
            }
        }
        private void bbiDeleteNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            treeListMain.DeleteSelectedNodes();
        }
        private void treeListMain_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            treeListMain.BestFitColumns();
        }
        #endregion

        
        
    }
}
