using Store.Domain.Abstractions;
using Store.Domain.Models;

namespace Store.Application.Services
{
    public class ItemSevice : IItemSevice
    {
        private IItemsRepository _repository;

        public ItemSevice(IItemsRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<Item>> GetAllItems()
        {
            return await _repository.Get();
        }

        public async Task<Item?> GetItem(Guid id)
        {
            var items = await _repository.Get();
            return items.Where(i => i.Id == id).FirstOrDefault();
        }

        public async Task<Guid> CreateItem(Item item)
        {
            return await _repository.Create(item);
        }

        public async Task<Guid> UpdateItem(Guid id, Item item)
        {
            return await _repository.Update(id, item.Name, item.Discription, item.Price);
        }

        public async Task<Guid> DeleteItem(Guid id)
        {
            return await _repository.Delete(id);
        }
    }
}
