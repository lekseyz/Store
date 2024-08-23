using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Errors
{
    public class WrongItemData : Exception
    {
        public WrongItemData(string discription)
            : base(discription) { }
    }
}
