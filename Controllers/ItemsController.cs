using Microsoft.AspNetCore.Mvc;
using Catlog.Repositories;
using System.Collections.Generic;
using Catlog.Entites;
using System;

namespace Catlog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        // controller constructor
        public ItemsController(IItemsRepository _itemsRepository)
        {
            this._itemsRepository = _itemsRepository;
        }

        // cretae an IEnumerable method to get all items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return (IEnumerable<Item>)_itemsRepository.GetItems();
        }
        
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = _itemsRepository.GetItem(id);
            if(item is null)
            {
                return NotFound();
            }
            return Ok(item);
        }   
    }
}