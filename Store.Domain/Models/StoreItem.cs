using Store.Domain.Errors;

namespace Store.Domain.Models
{
    public class StoreItem
    {
        public const int NAME_MAX_LENGHT = 50;
        public const int DESCRIPTION_MAX_LENGHT = 250;

        public StoreItem(Guid id, string name, string discription, decimal price)
        {
            if(!Enumerable.Range(1, NAME_MAX_LENGHT).Contains(name.Length) || 
               !Enumerable.Range(1, DESCRIPTION_MAX_LENGHT).Contains(discription.Length))
            {
                throw new WrongItemData("Incorrect item name lehgth or item discription lenght.");
            }
            if(price < 0)
            {
                throw new WrongItemData("Item's price should be >= 0");
            }

            Id = id;
            Name = name;
            Discription = discription;  
            Price = price;
        }

        public Guid Id { get; }
        public string Name { get; } = string.Empty;
        public string Discription { get; } = string.Empty;
        public decimal Price { get; }

    }
}
