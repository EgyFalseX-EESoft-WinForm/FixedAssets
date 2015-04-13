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
using DevExpress.Xpo.Metadata;

namespace FixedAssets.Views.Data
{
    public partial class CdAssetsCategoryEditorUC : XtraUserControl
    {
        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CdAssetsCategoryEditorUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
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
            LSMSAssetplaceId.QueryableSource = from q in dsLinq.CdAssetplaces select q;
            LSMSAssetStateId.QueryableSource = from q in dsLinq.CdAssetStates select q;
            LSMSEmp.QueryableSource = from q in dsLinq.TblEmps select q;
            LSMSCdAssetPropertiy.QueryableSource = from q in dsLinq.CdAssetPropertiys select q;
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
        private void treeListMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            object id = null;
            if (treeListMain.FocusedNode == null)
                id = -1;
            else
                id = e.Node.GetValue("AssetsCategoryID");

            gridViewAsset.ShowLoadingPanel();
            XPCSAsset.FixedFilterString = "[AssetsCategoryID] = " + id;
            sessionAsset.DropIdentityMap();
            XPCSAsset.Reload();
            gridViewAsset.RefreshData();
            gridViewAsset.HideLoadingPanel();


            //LoadParamGrid();

        }
        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                object id = null;
                if (treeListMain.FocusedNode == null)
                    return;
                id = treeListMain.FocusedNode.GetValue("AssetsCategoryID");
                AssetEditorFrm frm = new AssetEditorFrm((int)id, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sessionAsset.DropIdentityMap();
                    XPCSAsset.Reload();
                    gridViewAsset.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                AssetEditorFrm frm = new AssetEditorFrm(Convert.ToInt32(row.GetMemberValue("AssetsID")), false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sessionAsset.DropIdentityMap();
                    XPCSAsset.Reload();
                    gridViewAsset.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
            if (row == null)
                return;
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
            {
                gridViewAsset.DeleteSelectedRows();
                sessionAsset.DropIdentityMap();
                XPCSAsset.Reload();
                gridViewAsset.RefreshData();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void gridViewAsset_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewAsset.GetRow(e.RowHandle));
            if (row != null && row.GetMemberValue("AssetsID") != null)
            {
                //Load TBLAssetPropertiy Grid
                gridViewTBLAssetPropertiy.ShowLoadingPanel();
                tBLAssetPropertiyTableAdapter.FillByAssetsID(dsData.TBLAssetPropertiy, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAssetPropertiy.RefreshData();
                gridViewTBLAssetPropertiy.HideLoadingPanel();

                //Load TBLReEvaluation Grid
                gridViewTBLReEvaluation.ShowLoadingPanel();
                tBLReEvaluationTableAdapter.FillByAssetsID(dsData.TBLReEvaluation, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLReEvaluation.RefreshData();
                gridViewTBLReEvaluation.HideLoadingPanel();

                //Load TBLAssetPlace Grid
                gridViewTBLAssetPlace.ShowLoadingPanel();
                tBLAssetPlaceTableAdapter.FillByAssetsID(dsData.TBLAssetPlace, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAssetPlace.RefreshData();
                gridViewTBLAssetPlace.HideLoadingPanel();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLAssetPropertiy_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                TBLAssetPropertiyDlg frm = new TBLAssetPropertiyDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetPropertiy.ShowLoadingPanel();
                    tBLAssetPropertiyTableAdapter.FillByAssetsID(dsData.TBLAssetPropertiy, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAssetPropertiy.RefreshData();
                    gridViewTBLAssetPropertiy.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAssetPropertiy_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAssetPropertiy.GetRow(gridViewTBLAssetPropertiy.FocusedRowHandle);
            if (drv == null)
                return;
            Datasource.dsData.TBLAssetPropertiyRow row = (Datasource.dsData.TBLAssetPropertiyRow)(drv).Row;
            if (row == null)
                return;
            TBLAssetPropertiyDlg frm = new TBLAssetPropertiyDlg(row.AssetsID, row.AssetPropertiyId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                gridViewTBLAssetPropertiy.ShowLoadingPanel();
                tBLAssetPropertiyTableAdapter.FillByAssetsID(dsData.TBLAssetPropertiy, row.AssetsID);
                gridViewTBLAssetPropertiy.RefreshData();
                gridViewTBLAssetPropertiy.HideLoadingPanel();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAssetPropertiy_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAssetPropertiyRow row = (Datasource.dsData.TBLAssetPropertiyRow)((DataRowView)gridViewTBLAssetPropertiy.GetRow(gridViewTBLAssetPropertiy.FocusedRowHandle)).Row;
            if (row == null)
                return;
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
            {
                gridViewTBLAssetPropertiy.ShowLoadingPanel();
                tBLAssetPropertiyTableAdapter.Delete(row.AssetsID, row.AssetPropertiyId);
                gridViewTBLAssetPropertiy.DeleteRow(gridViewTBLAssetPropertiy.FocusedRowHandle);
                gridViewTBLAssetPropertiy.RefreshData();
                gridViewTBLAssetPropertiy.HideLoadingPanel();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLReEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLReEvaluationDlg frm = new TBLReEvaluationDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLReEvaluation.ShowLoadingPanel();
                    tBLReEvaluationTableAdapter.FillByAssetsID(dsData.TBLReEvaluation, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLReEvaluation.RefreshData();
                    gridViewTBLReEvaluation.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLReEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLReEvaluation.GetRow(gridViewTBLReEvaluation.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLReEvaluationRow row = (Datasource.dsData.TBLReEvaluationRow)(drv).Row;
                if (row == null)
                    return;
                TBLReEvaluationDlg frm = new TBLReEvaluationDlg(row.ReEvaluationId, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLReEvaluation.ShowLoadingPanel();
                    tBLReEvaluationTableAdapter.FillByAssetsID(dsData.TBLReEvaluation, row.AssetsID);
                    gridViewTBLReEvaluation.RefreshData();
                    gridViewTBLReEvaluation.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLReEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLReEvaluationRow row = (Datasource.dsData.TBLReEvaluationRow)((DataRowView)gridViewTBLReEvaluation.GetRow(gridViewTBLReEvaluation.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLReEvaluation.ShowLoadingPanel();
                    tBLReEvaluationTableAdapter.Delete(row.AssetsID, row.datere);
                    gridViewTBLReEvaluation.DeleteRow(gridViewTBLReEvaluation.FocusedRowHandle);
                    gridViewTBLReEvaluation.RefreshData();
                    gridViewTBLReEvaluation.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        
        private void btnAddTBLAssetPlace_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLAssetPlaceDlg frm = new TBLAssetPlaceDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetPlace.ShowLoadingPanel();
                    tBLAssetPlaceTableAdapter.FillByAssetsID(dsData.TBLAssetPlace, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAssetPlace.RefreshData();
                    gridViewTBLAssetPlace.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAssetPlace_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAssetPlace.GetRow(gridViewTBLAssetPlace.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLAssetPlaceRow row = (Datasource.dsData.TBLAssetPlaceRow)(drv).Row;
                if (row == null)
                    return;
                TBLAssetPlaceDlg frm = new TBLAssetPlaceDlg(row.AssetRePlaceId, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetPlace.ShowLoadingPanel();
                    tBLAssetPlaceTableAdapter.FillByAssetsID(dsData.TBLAssetPlace, row.AssetsID);
                    gridViewTBLAssetPlace.RefreshData();
                    gridViewTBLAssetPlace.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAssetPlace_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAssetPlaceRow row = (Datasource.dsData.TBLAssetPlaceRow)((DataRowView)gridViewTBLAssetPlace.GetRow(gridViewTBLAssetPlace.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLAssetPlace.ShowLoadingPanel();
                    tBLAssetPlaceTableAdapter.Delete(row.AssetsID, row.datep, row.AssetplaceId);
                    gridViewTBLAssetPlace.DeleteRow(gridViewTBLAssetPlace.FocusedRowHandle);
                    gridViewTBLAssetPlace.RefreshData();
                    gridViewTBLAssetPlace.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        #endregion

    }
}
