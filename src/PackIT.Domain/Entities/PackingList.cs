using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Entities
{
    public class PackingList
    {
        public Guid id { get; private set; }
        private PackingList _name;
        private string _localization;

    }
}
