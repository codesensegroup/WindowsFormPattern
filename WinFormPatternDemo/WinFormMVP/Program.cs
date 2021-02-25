using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMVP.Model.Repo;
using WinFormMVP.Presenter;
using WinFormMVP.View;

namespace WinFormMVP
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ITextRepository textRepo = new TxtRepository();
            var form1 = new Form1();
            var presenter = new Form1Presenter(form1, textRepo);
            form1.SetPresenter(presenter);

            Application.Run(form1);
        }
    }
}
