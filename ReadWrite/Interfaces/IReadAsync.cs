using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite.Interfaces
{
    public interface IReadAsync
    {
        public Task<string> ReadAsync();
    }
}
