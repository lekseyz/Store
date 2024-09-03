﻿using Store.Domain.Models;

namespace Store.Domain.Abstractions
{
    public interface IItemsRepository
    {
        Task<Guid> Create(Item item);
        Task<Guid> Delete(Guid id);
        Task<List<Item>> Get();
        Task<Guid> Update(Guid id, string name, string discription, decimal price);
    }
}