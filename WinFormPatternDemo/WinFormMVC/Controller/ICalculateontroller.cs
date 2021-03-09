using System;

namespace WinFormMVC.Controller
{
    public interface ICalculateontroller
    {
        /// <summary>
        ///     Add the delegate event
        /// </summary>
        /// <param name="action"> delegate event </param>
        void AddHandler(Action<int> action);

        /// <summary>
        ///     Increase value
        /// </summary>
        /// <param name="nowVal"> Now value </param>
        int Incvalue();

        /// <summary>
        ///     Reduce value (use delegate)
        /// </summary>
        /// <param name="nowVal"> Now value </param>
        void OnReduce();

    }
}
