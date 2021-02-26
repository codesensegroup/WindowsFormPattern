using System;
using System.Windows.Forms;
using WinFormMVC.Controller;

namespace WinFormMVC.View
{
    public partial class ViewForm : Form, IView
    {
        private IController _controller = null;

        public ViewForm()
        {
            InitializeComponent();
        }

        public void SetController(IController controller)
        {
            _controller = controller;
            _controller.AddHandler(ReduceHandler);
        }

        public void ShowResult(int resultCount)
        {
            txt_Result.Text = $"{resultCount}";
        }

        private void btn_Incvalue_Click(object sender, EventArgs e)
        {
            _controller.Incvalue(GetValue());
        }

        private void btn_OnReduce_Click(object sender, EventArgs e)
        {
            _controller.OnReduce(GetValue());
        }

        private void ReduceHandler(int resultCount)
        {
            txt_Result.Text = $"{resultCount}";
        }

        private int GetValue()
        {
            int.TryParse(txt_Result.Text, out var nowCount);
            return nowCount;
        }
    }
}
