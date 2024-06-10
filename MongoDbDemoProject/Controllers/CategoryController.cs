using Microsoft.AspNetCore.Mvc;
using MongoDbDemoProject.Dtos.CategoryDtos;
using MongoDbDemoProject.Services.CategoryServices;

namespace MongoDbDemoProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto dto)
        {
            await _categoryService.CreateCategoryAsycn(dto);
            return RedirectToAction("CategoryList");
        }
    }
}
