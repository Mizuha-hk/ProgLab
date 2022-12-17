using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgLab
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgLabContext());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }

    public class ProgLabContext:ApplicationContext
    {
        public ProgLabContext()
        {
            this.MainForm = new MainWindow(this);
        }

        //Form切り替えメソッド
        public void SwitchForm(Form NextForm)
        {
            var previouseForm = this.MainForm;
            this.MainForm = NextForm;

            previouseForm.Close();
            NextForm.Show();
        }
    }
}
