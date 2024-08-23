using Store.Domain.Models;

namespace Store.Domain.Abstractions
{
    public interface IItemsRepository
    {
        Task<Guid> Create(StoreItem item);
        Task<Guid> Delete(Guid id);
        Task<List<StoreItem>> Get();
        Task<Guid> Update(Guid id, string name, string discription, decimal price);
    }
}