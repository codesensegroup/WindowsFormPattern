using System;
using System.IO;

namespace WinFormMVP.Model.Repo
{
    public class TxtRepository : ITextRepository
    {

        public bool Create(TxtFile obj)
        {
            if (File.Exists(obj.Path))
                throw new ArgumentException("File already exist");

            using (StreamWriter sw = File.CreateText(obj.Path))
            {
                sw.WriteLine(obj.Content);
            }

            return true;
        }

        public bool Delete(TxtFile obj)
        {
            if (!File.Exists(obj.Path))
                throw new ArgumentException("File not found");

            try
            {
                File.Delete(obj.Path);
                return true;
            }
            catch
            {
                throw;
            }
        }

        public string Read(TxtFile obj)
        {
            using (StreamReader sr = File.OpenText(obj.Path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    obj.Content += s+"\n";
                }
            }

            return obj.Content;
        }

        public bool Upadate(TxtFile obj)
        {
            if (!File.Exists(obj.Path))
                throw new ArgumentException("File not found");

            try
            {
                var text = File.ReadAllText(obj.Path);
                text = text.Replace(text, obj.Content);
                File.WriteAllText(obj.Path, text);
                return true;
            }
            catch
            {
                throw;
            }
           
        }
    }
}
