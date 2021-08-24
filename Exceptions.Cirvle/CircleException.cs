using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Cirvle
{
    public class CircleException : Exception
    {
        public int CircleErrorNum { get; set; }

        public CircleException(string message)
            :base(message)
        {

        }

        public CircleException(string message, int errorNum)
            :this(message)
        {
            CircleErrorNum = errorNum;
        }
    }
}
