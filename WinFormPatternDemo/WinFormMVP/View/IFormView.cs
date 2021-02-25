using System;
using WinFormMVP.Presenter;

namespace WinFormMVP.View
{
    public interface IFormView
    {
        object Invoke(Delegate method);
        void SetPresenter(IForm1Presenter presenter);
        void ShowDataContent(string content);
        void ShowMessageBox(string text);

    }
}
