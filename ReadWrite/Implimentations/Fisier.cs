﻿using ReadWrite.Interfaces;
using System.IO;

namespace ReadWrite.Implimentations
{
    public class Fisier : IReadWrite
    {
        private readonly string filePath;
        public Fisier(string path)
        {
            filePath = path;
        }
        public string Read()
        {
            string data = "";
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