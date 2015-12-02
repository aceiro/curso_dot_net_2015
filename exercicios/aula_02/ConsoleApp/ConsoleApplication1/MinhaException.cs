using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MinhaException : Exception
    {
        private string p;

        public MinhaException(string p)
        {
            this.p = p;
        }
    }
}
