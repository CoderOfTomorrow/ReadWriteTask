using ReadWrite.Interfaces;
using System.IO;

namespace ReadWrite.Implimentations
{
    public class FileActions : IRead , IWrite
    {
        private readonly string filePath;
        public FileActions(string path)
        {
            filePath = path;
        }
        public string Read()
        {
            string data = null;
            if (File.Exists(filePath))
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    data = file.ReadToEnd();
                }
            }
            return data;
        }

        public void Write(string data)
        {
            using (StreamWriter file = new StreamWriter(filePath))
            {
                file.Write(data);
            }
        }
    }
}
