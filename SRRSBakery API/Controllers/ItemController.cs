using Microsoft.AspNetCore.Mvc;
using SRRSBakery_API.Model;

namespace SRRSBakery_API.Controllers
{
    [ApiController]
    [Route("api/pies")]
    public class ItemController : Controller
    {
        private readonly IitemRepository _ItemRepository;
        private readonly AppDbContext appDbContext;
        private readonly LinkGenerator linkGenrator;
        private readonly IConfiguration configuration;
        public ItemController(IitemRepository ItemRepository,AppDbContext appDbContext)
        {
            
            this._ItemRepository = ItemRepository;
            this.appDbContext = appDbContext;
        }
        [HttpGet]
        [Route("GetAllItem")]
        public IActionResult GetAll()
        {
            try
            {
                var item = this._ItemRepository.GetAll;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
       
        /*[HttpPost]
        [Route("GetCategoryById")]
        public IActionResult InsertPie(int id=1)
        {
            try
            {
                var item=this.appDbContext.Items.Where(u=>u.CategoryId==id);

                return Ok(item);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Severerror");
            }
        }*/


        /*[HttpGet]
        [Route("GetCakes")]
        public IActionResult GetAllCakes()
        {
            try
            {
                var item = this._ItemRepository.GetCakes;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }*/
        //for Cakes you want do Rahul
        [HttpGet]
        [Route("GetBread")]
        public IActionResult GetAllBread()
        {
            try
            {
                var item = this._ItemRepository.GetBreads;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
        [HttpGet]
        [Route("GetAllChips")]
        public IActionResult GetAllChips()
        {
            try
            {
                var item = this._ItemRepository.GetChips;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
        [HttpGet]
        [Route("GetAllCookies")]
        public IActionResult GetAllCookies()
        {
            try
            {
                var item = this._ItemRepository.GetCookies;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
        [HttpGet]
        [Route("GetAllCupCakes")]
        public IActionResult GeAllCupCakes()
        {
            try
            {
                var item = this._ItemRepository.GetCupCake;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
        [HttpGet]
        [Route("GetAllDonuts")]
        public IActionResult GetAllDonuts()
        {
            try
            {
                var item = this._ItemRepository.GetDonuts;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
        [HttpGet]
        [Route("GetAllPanCakes")]
        public IActionResult GetAllPies()
        {
            try
            {
                var item = this._ItemRepository.GetPancakes;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }
        [HttpGet]
        [Route("GetAllPizzas")]
        public IActionResult GetAllPizzas()
        {
            try
            {
                var item = this._ItemRepository.GetPizza;
                return Ok(item);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "sever Error");
            }
        }



    }
}
