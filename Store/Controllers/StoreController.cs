using Microsoft.AspNetCore.Mvc;
using Store.Api.Сontracts;
using Store.Domain.Abstractions;
using Store.Domain.Errors;
using Store.Domain.Models;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("/items")]
    public class StoreController : ControllerBase
    {
        private IItemSevice _service;
        public StoreController(IItemSevice sevice)
        {
            _service = sevice;
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemResponce>>> GetItems()
        {
            var items = await _service.GetAllItems();

            return Ok(items.Select(i => new ItemResponce(i.Id, i.Name, i.Discription, i.Price)).ToList());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ItemResponce>> GetItem(Guid id) 
        {
            var item = await _service.GetItem(id);

            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> PostItem([FromBody] ItemRequest request)
        {
            try
            {
                var item = new StoreItem(Guid.NewGuid(), request.Name, request.Discription, request.Price);
                Guid id = await _service.CreateItem(item);
                return Ok(id);
            }
            catch (WrongItemData error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> PutItem(Guid id, [FromBody] ItemRequest request)
        {
            try
            {
                var item = new StoreItem(Guid.NewGuid(), request.Name, request.Discription, request.Price);
                await _service.UpdateItem(id, item);
                return Ok(id);
            }
            catch (WrongItemData error)
            {
                return BadRequest(error.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteItem(Guid id)
        {
            await _service.DeleteItem(id);
            return Ok(id);
        }
    }
}
