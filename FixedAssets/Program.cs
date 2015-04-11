using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace FixedAssets
{
    static class Program
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));

        public static string TilesLayoutFile = Application.StartupPath + @"\TilesLayoutFile";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Log.L4N.Init();

            if (FXFW.SqlDB.LoadSqlDBPath("FixedAssets"))
            {
                Properties.Settings.Default["FixedAssetsConnectionString"] = FXFW.SqlDB.SqlConStr;
                DevExpress.Xpo.XpoDefault.ConnectionString = FXFW.SqlDB.SqlConStr;
                ApplicationStart();
            }

            
        }
        public static void Init()
        {
            Classes.Managers.DataManager.Init();
            Classes.Managers.UserManager.Init();
            //Classes.Dashboard.Init();
            //Classes.QueryLayout.Init();
        }
        public static void ApplicationStart()
        {
            // Init
            Init();
            // Login
            //if (new Views.Main.LoginFrm().ShowDialog() == DialogResult.Cancel)
            //    return;
            FixedAssets.Classes.Managers.UserManager.defaultInstance.Login("admin", "admin");

            Application.Run(new Views.Main.MainForm());
            
        }
    }
}
