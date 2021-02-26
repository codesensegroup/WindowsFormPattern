using System;
using WinFormMVC.Controller;

namespace WinFormMVC.Model
{
    public interface IModel
    {
        /// <summary>
        ///     Set controller
        /// </summary>
        /// <param name="controller"> controller </param>
        void SetController(IController controller);

        /// <summary>
        ///     Add the delegate event to model
        /// </summary>
        /// <param name="action"> delegate event </param>
        void AddHandler(Action<int> action);

        /// <summary>
        ///     Call model execution increase
        /// </summary>
        /// <param name="nowVal"> Now value </param>
        void Incvalue(int nowVal);

        /// <summary>
        ///     Call model execution reduce (use delegate)
        /// </summary>
        /// <param name="nowVal"> Now value </param>
        void OnReduce(int nowVal);
    }
}
