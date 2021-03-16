using System;
using System.Collections.Generic;
using System.Text;

namespace ReadWrite.Interfaces
{
    public interface IReadWrite
    {
        public string Read();
        public void Write(string data);
    }
}
