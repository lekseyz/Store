using Store.Domain.Models;

namespace Store.Domain.Abstractions
{
    public interface IItemSevice
    {
        Task<Guid> CreateItem(StoreItem item);
        Task<Guid> DeleteItem(Guid id);
        Task<List<StoreItem>> GetAllItems();
        Task<StoreItem?> GetItem(Guid id);
        Task<Guid> UpdateItem(Guid id, StoreItem item);
    }
}