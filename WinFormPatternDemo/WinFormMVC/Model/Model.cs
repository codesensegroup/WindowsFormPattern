using System;
using WinFormMVC.Controller;

namespace WinFormMVC.Model
{
    public class Model : IModel
    {
        private IController _controller = null;
        private Action<int> _action = null;

        public Model() { }

        public void SetController(IController controller) => _controller = controller;

        public void AddHandler(Action<int> action) => _action = action;

        public void Incvalue(int nowVal) => _controller.Result(++nowVal);

        public void OnReduce(int nowVal) => _action?.Invoke(--nowVal);
    }
}
