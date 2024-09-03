using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public class CartItem
    {
        public CartItem(int id, int cartId, int itemId)
        {
            Id = id;
            CartId = cartId;
            ItemId = itemId;
        }

        public int Id { get; }
        public int CartId { get; }
        public int ItemId { get; }
    }
}
