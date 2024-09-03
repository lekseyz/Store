using Store.Domain.Models;

namespace Store.Domain.Abstractions
{
    public interface IItemSevice
    {
        Task<Guid> CreateItem(Item item);
        Task<Guid> DeleteItem(Guid id);
        Task<List<Item>> GetAllItems();
        Task<Item?> GetItem(Guid id);
        Task<Guid> UpdateItem(Guid id, Item item);
    }
}