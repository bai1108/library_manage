using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_manage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { Database.LoadRules(); } catch(Exception e) { MessageBox.Show("借阅规则读取失败，使用默认值。\n"+e.Message); }
            Application.Run(new ReaderLoginForm());
        }
    }
}
