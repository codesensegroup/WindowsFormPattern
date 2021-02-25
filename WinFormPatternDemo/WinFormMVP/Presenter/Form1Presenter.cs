using System;
using WinFormMVP.Model;
using WinFormMVP.Model.Repo;
using WinFormMVP.View;

namespace WinFormMVP.Presenter
{
    public class Form1Presenter : IForm1Presenter
    {
        private IFormView _view;
        private ITextRepository _dataRepo;
     
        public Form1Presenter(IFormView view, ITextRepository dataRepo)
        {
            _view = view;
            _dataRepo = dataRepo;
        }

        public void NewTextFile(string path, string content)
        {
            TryFlow(() => {
                var textFile = new TxtFile(path, content);
                var createOK = _dataRepo.Create(textFile);
                if(createOK)
                    Invoke(() => _view.ShowMessageBox("Create Success"));
            });
        }

        public void ReadTextFile(string path)
        {
            var textFile = new TxtFile(path, string.Empty);
            var readStr = _dataRepo.Read(textFile);
            Invoke(() => _view.ShowDataContent(readStr));
        }

        public void SaveTxtFile(string path, string content)
        {
            var textFile = new TxtFile(path, content);
            var updateOK = _dataRepo.Upadate(textFile);
            if (updateOK)
                Invoke(() => _view.ShowMessageBox("Update Success"));
        }

        protected virtual void TryFlow(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception ex)
            {
                Invoke(() => _view.ShowMessageBox(ex.ToString()));
            }
            finally
            {
                
            }
        }

        /// <summary>
        /// Update UI
        /// </summary>        
        protected void Invoke(Action action)
        {
            _view.Invoke(action);
        }

     
    }
}
