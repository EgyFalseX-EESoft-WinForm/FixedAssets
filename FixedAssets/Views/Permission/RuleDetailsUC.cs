using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.XtraTreeList.Nodes;

namespace FixedAssets.Views.Permission
{
    public partial class RuleDetailsUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(RuleDetailsUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        #endregion
        #region - Fun -
        public RuleDetailsUC(FixedAssets.Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadRulesList()
        {
            rolesTableAdapter.Fill(dsData.Roles);
        }
        public static void LoadDefaultNodes(DevExpress.XtraTreeList.TreeList Tree, FixedAssets.Views.Main.MainForm MainFrm)
        {
            Tree.Nodes.Clear();
            //NICSQLTools.Forms.Main.MainTilesFrm MainFrm = (NICSQLTools.Forms.Main.MainTilesFrm)Parent.Parent.Parent;

            Tree.BeginUnboundLoad();

            // Create a root node .
            TreeListNode RootNode = null;
            TreeListNode RootDashBoardNode = Tree.AppendNode(new object[] { "Code", false, false, false, false }, RootNode);
            TreeListNode RootEditorNode = Tree.AppendNode(new object[] { "Data", false, false, false, false }, RootNode);
            TreeListNode RootQueriesNode = Tree.AppendNode(new object[] { "Queries", false, false, false, false }, RootNode);
            TreeListNode RootRulesNode = Tree.AppendNode(new object[] { "Rules", false, false, false, false }, RootNode);
            TreeListNode RootReportsNode = Tree.AppendNode(new object[] { "Reports", false, false, false, false }, RootNode);
            

            //RootEditorNode.Tag = "root"; RootQueriesNode.Tag = "root"; RootRulesNode.Tag = "root"; RootReportsNode.Tag = "root"; RootDashBoardNode.Tag = "root";

            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerCode.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootDashBoardNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerData.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootEditorNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerQry.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootQueriesNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerRule.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootRulesNode);
            }
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in MainFrm.tileContainerReport.Items)
            {
                Tree.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootReportsNode);
            }
            
            Tree.EndUnboundLoad();
        }
        void LoadUserData(int RuleID)
        {
            ruleDetailTableAdapter.FillByRoleID(dsData.RoleDetial, RuleID);

            foreach (FixedAssets.Datasource.dsData.RoleDetialRow row in dsData.RoleDetial)
            {
                TreeListNode node = (TreeListNode)TLItems.FindNodeByFieldValue("ID", row.MenuItemName);
                if (node != null)
                {
                    node.SetValue(tlcSelect, row.Selecting);
                    node.SetValue(tlcInsert, row.Inserting);
                    node.SetValue(tlcUpdate, row.Updateing);
                    node.SetValue(tlcDelete, row.Deleting);
                }
            }
        }
        void SaveUserData(int RuleID)
        {

            ruleDetailTableAdapter.DeleteByRoleID(RuleID);//Delete All Rule Contains To Add New
            ruleDetailTableAdapter.FillByRoleID(dsData.RoleDetial, RuleID);//Empty RuleDetail Table
            List<TreeListNode> Nodes = GetAllItems(TLItems);

            foreach (TreeListNode node in Nodes)
            {
                FixedAssets.Datasource.dsData.RoleDetialRow row = dsData.RoleDetial.NewRoleDetialRow();
                row.RoleID = RuleID; row.MenuItemName = node.GetValue(tlcID).ToString();
                row.Selecting = Convert.ToBoolean(node.GetValue(tlcSelect)); row.Inserting = Convert.ToBoolean(node.GetValue(tlcInsert));
                row.Updateing = Convert.ToBoolean(node.GetValue(tlcUpdate)); row.Deleting = Convert.ToBoolean(node.GetValue(tlcDelete));
                dsData.RoleDetial.AddRoleDetialRow(row);
            }
            ruleDetailTableAdapter.Update(dsData.RoleDetial);
        }
        public static List<TreeListNode> GetAllItems(DevExpress.XtraTreeList.TreeList Tree)
        {
            List<TreeListNode> Nodes = new List<TreeListNode>();
            foreach (TreeListNode node in Tree.Nodes)
                GetSubNodes(node, ref Nodes);
            return Nodes;
        }
        static void GetSubNodes(TreeListNode NodesParent, ref List<TreeListNode> Nodes)
        {
            foreach (TreeListNode node in NodesParent.Nodes)
            {
                if (node.HasChildren)
                    GetSubNodes(node, ref Nodes);
                else
                    Nodes.Add(node);
            }
        }
        public void ActivateRules()
        {
            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            
        }
        #endregion
        #region -  EventWhnd - 
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadRulesList();
            ActivateRules();
        }
        private void bbiRule_EditValueChanged(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(FixedAssets.Views.Main.WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LoadDefaultNodes(TLItems, (FixedAssets.Views.Main.MainForm)Parent.Parent.Parent);
                    LoadUserData(Convert.ToInt32(bbiRule.EditValue));
                }));
                SplashScreenManager.CloseForm();
            });
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(bbiRule.EditValue))
                return;
            int RuleID = Convert.ToInt32(bbiRule.EditValue);

            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            SplashScreenManager.ShowForm(typeof(FixedAssets.Views.Main.WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    SaveUserData(RuleID);
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                   
                }
                SplashScreenManager.CloseForm();
            });
            
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!TLItems.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            TLItems.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            LoadRulesList();
            bbiRule_EditValueChanged(bbiRule, EventArgs.Empty);
        }
        #endregion

    }
}
