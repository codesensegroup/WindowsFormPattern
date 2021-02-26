using System;
using System.Windows.Forms;
using WinFormMVC.Controller;
using WinFormMVC.Model;
using WinFormMVC.View;

namespace MVCSample
{
    static class Program
    {
        /// <summary>
        ///     應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //  Start up
            var view = new ViewForm();          //  Create view
            var model = new Model();            //  Create model
            _ = new Controller(view, model);    //  Create controller
            Application.Run(view);
        }
    }
}
