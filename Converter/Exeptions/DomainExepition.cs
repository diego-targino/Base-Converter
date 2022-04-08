using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Exeptions
{
    class DomainExepition : ApplicationException
    {
        public DomainExepition(string message) : base(message)
        {

        }
    }
}
