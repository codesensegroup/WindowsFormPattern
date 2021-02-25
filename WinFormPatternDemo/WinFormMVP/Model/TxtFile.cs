namespace WinFormMVP.Model
{
    public class TxtFile
    {
        public string Path { get; set; }
        public string Content { get; set; }

        public TxtFile(string path, string content) {
            Path = path;
            Content = content;
        }
    }
}
