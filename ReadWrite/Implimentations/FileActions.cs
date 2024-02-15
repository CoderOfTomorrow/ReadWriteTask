using ReadWrite.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace ReadWrite.Implimentations
{
    public class FileActions : IRead , IWrite , IReadAsync , IWriteAsync
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

        public async Task<string> ReadAsync()
        {
            string data = null;
            if (File.Exists(filePath))
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    data = await file.ReadToEndAsync();
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

        public async Task WriteAsync(string data)
        {
            using (StreamWriter file = new StreamWriter(filePath))
            {
                await file.WriteAsync(data);
            }
        }

        
    }
}
