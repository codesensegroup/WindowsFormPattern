namespace WinFormMVP.Presenter
{
    public interface IForm1Presenter
    {
        void NewTextFile(string path, string content);

        void ReadTextFile(string path);

        void SaveTxtFile(string path, string content);

    }
}
