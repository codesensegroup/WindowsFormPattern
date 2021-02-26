using WinFormMVC.Controller;

namespace WinFormMVC.View
{
    public interface IView
    {
        /// <summary>
        ///     Set controller
        /// </summary>
        /// <param name="controller"> controller </param>
        void SetController(IController controller);

        /// <summary>
        ///     Show result
        /// </summary>
        /// <param name="IncVal"> Increased value </param>
        void ShowResult(int IncVal);
    }
}
