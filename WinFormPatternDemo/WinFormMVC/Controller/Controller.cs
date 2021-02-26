using System;
using WinFormMVC.Model;
using WinFormMVC.View;

namespace WinFormMVC.Controller
{
    public class Controller : IController
    {
        private readonly IView _view = null;
        private readonly IModel _model = null;

        public Controller(IView view, IModel model)
        {
            _view = view;
            _model = model;

            _view.SetController(this);
            _model.SetController(this);
        }

        public void AddHandler(Action<int> action) => _model.AddHandler(action);

        public void Incvalue(int nowVal) => _model.Incvalue(nowVal);

        public void OnReduce(int nowVal) => _model.OnReduce(nowVal);

        public void Result(int IncVal) => _view.ShowResult(IncVal);
    }
}
