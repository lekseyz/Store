using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public class User
    {

        public User(int id, string name, string email, string hashPassword)
        {
            Id = id;
            Name = name;
            Email = email;
            HashPassword = hashPassword;
        }

        public int Id { get; }
        public string Name { get; } = String.Empty;
        public string Email { get; } = String.Empty;
        public string HashPassword { get; } = String.Empty;
    }
}
