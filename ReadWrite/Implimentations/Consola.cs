using ReadWrite.Interfaces;
using System;

namespace ReadWrite.Implimentations
{
    public class Consola : IReadWrite
    {
        public string Read()
        {
            var data = Console.ReadLine();
            return data;
        }

        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
