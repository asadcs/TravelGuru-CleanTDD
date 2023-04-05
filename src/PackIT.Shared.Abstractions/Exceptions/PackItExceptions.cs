using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Exceptions
{
    public abstract class PackItExceptions:Exception
    {
        protected PackItExceptions(string message):base(message)
        {
                
        }
    }
}
