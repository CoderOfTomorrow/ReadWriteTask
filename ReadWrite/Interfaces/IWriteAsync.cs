using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite.Interfaces
{
    public interface IWriteAsync
    {
        public Task WriteAsync(string data);
    }
}
