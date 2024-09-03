using Store.Domain.Errors;

namespace Store.Domain.Models
{
    public class Item
    {
        public const int NAME_MAX_LENGHT = 50;
        public const int DESCRIPTION_MAX_LENGHT = 250;

        public Item(int id, string name, string discription, decimal price, int ownerId)
        {
            Id = id;
            Name = name;
            Discription = discription;  
            Price = price;
            OwnerId = ownerId;
        }

        public int Id { get; }
        public string Name { get; } = string.Empty;
        public string Discription { get; } = string.Empty;
        public decimal Price { get; }
        public int OwnerId { get; }

    }
}
