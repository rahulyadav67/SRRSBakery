using Microsoft.AspNetCore.Mvc;
using SRRSBakeryAPI.Models;

namespace SRRSBakeryAPI.Controllers
{
    [ApiController]
    [Route("API/Category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        [HttpGet]
        [Route("GetAllCategory")]
        public IActionResult GetAllCatgeory()
        {
            try
            {
                var category = categoryRepository.AllCategories;
                return Ok(category);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpPost]
        [Route("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            try
            {
                var categories = categoryRepository.AddCategory(category);
                return Ok(categories);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpPut]
        [Route("UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            try
            {
                var categories = categoryRepository.UpdateCategory(category);
                return Ok(categories);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpDelete]
        [Route("DeleteCategory")]
        public IActionResult DeleteCategory(int categoryId)
        {
            try
            {
                var categories=categoryRepository.DeleteCategory(categoryId);
                return Ok(categories);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

    }
}
