using Microsoft.EntityFrameworkCore;
using Store.Domain.Abstractions;
using Store.DataAccess.Entites;
using Store.Domain.Models;

namespace Store.DataAccess.Repository
{
    public class ItemsRepository : IItemsRepository
    {
        private StoreDbContext _context;

        public ItemsRepository(StoreDbContext context)
        {
            this._context = context;
        }

        public async Task<List<Item>> Get()
        {
            var items = await _context.Items
                .AsNoTracking()
                .ToListAsync();

            return items
                .Select(_Transform)
                .ToList();
        }

        public async Task<Guid> Create(Item item)
        {
            var entity = new StoreItemEntity
            {
                Id = item.Id,
                Name = item.Name,
                Discription = item.Discription,
                Price = item.Price
            };

            await _context.Items
                .AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<Guid> Update(Guid id, string name, string discription, decimal price)
        {
            await _context.Items
                .Where(i => i.Id == id)
                .ExecuteUpdateAsync(i => i
                .SetProperty(ie => ie.Name, ie => name)
                .SetProperty(ie => ie.Discription, ie => discription)
                .SetProperty(ie => ie.Price, ie => price));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Items
                .Where(i => i.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        private Item _Transform(StoreItemEntity entity)
        {
            return new Item(entity.Id, entity.Name, entity.Discription, entity.Price);
        }
    }
}
