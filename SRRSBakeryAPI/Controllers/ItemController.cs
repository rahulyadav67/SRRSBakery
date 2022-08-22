using Microsoft.AspNetCore.Mvc;
using SRRSBakeryAPI.Models;

namespace SRRSBakeryAPI.Controllers
{
    [ApiController]
    [Route("API/Item")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository itemRepository;
        public ItemController(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        [HttpGet]
        [Route("GetAllItem")]
        public IActionResult List(int id)
        {
            try
            {
                IEnumerable<Item> items;

                if (id > 0)
                {
                    items = itemRepository.GetCategoryById(id);
                }
                else
                {
                    items = itemRepository.GetAll;
                }
                return Ok(items);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetAllCakes")]
        public IActionResult ListCakes()
        {
            try
            {
                IEnumerable<Item> items;
                items = itemRepository.GetCakes;
                return Ok(items);
            }
            catch(Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("BestSeller")]
        public IActionResult BestSeller()
        {
            try
            {
                var item=itemRepository.BestSeller;
                return Ok(item);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet("{id}",Name ="GetItemDetail")]
        public IActionResult GetItemDetail(int id)
        {
            try
            {
                var item = itemRepository.GetItemById(id);
            return Ok(item);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }
        [HttpPost]
        [Route("InsertItem")]
        public IActionResult AddItem(Item item)
        {
            try
            {
                var items=itemRepository.AddItem(item);
                return Ok(items);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateItem(Item item)
        {
            try
            {
                var items=itemRepository.UpdateItem(item);
                return Ok(items);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpDelete]
        [Route("DeleteItem")]
        public IActionResult DeleteItem(int itemId)
        {
            try
            {
                var items=itemRepository.DeleteItem(itemId);
                return Ok(items);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
    }
}
