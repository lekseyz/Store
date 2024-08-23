using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Entites
{
    public class StoreItemEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Discription { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
