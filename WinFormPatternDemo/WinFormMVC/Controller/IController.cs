using System;

namespace WinFormMVC.Controller
{
    public interface IController
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
        void Incvalue(int nowVal);

        /// <summary>
        ///     Reduce value (use delegate)
        /// </summary>
        /// <param name="nowVal"> Now value </param>
        void OnReduce(int nowVal);

        /// <summary>
        ///     Increased result
        /// </summary>
        /// <param name="IncVal"> Increased value </param>
        void Result(int IncVal);
    }
}
