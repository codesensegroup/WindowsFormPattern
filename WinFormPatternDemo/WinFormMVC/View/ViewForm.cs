using System;
using System.Windows.Forms;
using WinFormMVC.Controller;

namespace WinFormMVC.View
{
    public partial class ViewForm : Form
    {
        private ICalculateontroller _controller;

        private int Value { set => txt_Result.Text = value.ToString(); }

        public ViewForm()
        {
            InitializeComponent();          
        }

        private void ViewForm_Shown(object sender, EventArgs e)
        {
            _controller = new CalculateController();
            _controller.AddHandler(ReduceHandler);
        }

        private void btn_Incvalue_Click(object sender, EventArgs e)
        {
            var value = _controller.Incvalue();
            Value = value;
        }

        private void btn_OnReduce_Click(object sender, EventArgs e)
        {
            _controller.OnReduce();
        }

        private void ReduceHandler(int resultCount)
        {
            txt_Result.Text = $"{resultCount}";
        }

      
    }
}
