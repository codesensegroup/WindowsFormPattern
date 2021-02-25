using System;
using System.Windows.Forms;
using WinFormMVP.Presenter;
using WinFormMVP.View;

namespace WinFormMVP
{
    public partial class Form1 : Form, IFormView
    {
        private IForm1Presenter _presenter;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(IForm1Presenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        public void SetPresenter(IForm1Presenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowDataContent(string content)
        {
            RichTextBox1.Text = content;
        }

        public void ShowMessageBox(string text)
        {
            MessageBox.Show(text);
        }

        
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (!InvalidTxtPara(RichTextBox1.Text, "Pls edit the content"))
                return;

            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _presenter.NewTextFile(sfd.FileName, RichTextBox1.Text);
                FilePathTxt.Text = sfd.FileName;
            }
              

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Text files|*.txt|All files|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _presenter.ReadTextFile(ofd.FileName);
                FilePathTxt.Text = ofd.FileName;
            }
            

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!InvalidTxtPara(FilePathTxt.Text, "Pls open the file"))
                return;

            _presenter.SaveTxtFile(FilePathTxt.Text, RichTextBox1.Text);

        
        }

        private bool InvalidTxtPara(string text, string errorMessage)
        {
            try
            {
                AssertText(text, errorMessage);
                return true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }   
        private void AssertText(string text, string errorMessage)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(errorMessage);
            }
        }
    }
}
