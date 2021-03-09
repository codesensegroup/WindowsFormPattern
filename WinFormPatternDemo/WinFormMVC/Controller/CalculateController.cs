using System;
using WinFormMVC.Model;
using WinFormMVC.View;

namespace WinFormMVC.Controller
{
    public class CalculateController : ICalculateontroller
    {
        private readonly NumberModel _numberModel;

        public CalculateController()
        {
            _numberModel = new NumberModel();
        }

        public void AddHandler(Action<int> action) => _numberModel.AddHandler(action);

        public int Incvalue() => ++_numberModel.Value;

        public void OnReduce() => _numberModel.OnReduce();

    }
}
