using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public class Cart
    {
        public Cart(int id, int userId)
        {
            Id = id;
            UserId = userId;
        }

        public int Id { get; }
        public int UserId { get; }
    }
}
