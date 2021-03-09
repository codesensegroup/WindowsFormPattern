using System;

namespace WinFormMVC.Model
{
    public class NumberModel
    {
        private Action<int> _action;
        public int Value { get; set; } = 0;


        public NumberModel() {         
        }

        public void AddHandler(Action<int> action) => _action = action;

        public void OnReduce() => _action?.Invoke(--Value);
    }
}
