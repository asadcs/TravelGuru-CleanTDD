using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackItExceptions
    {
        public EmptyPackingListNameException():base(message:"Packet List Name cannot be Empty")
        {

        }
    }
}
