using System;
using System.Collections.Generic;
using Catlog.Entites;

namespace Catlog.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}