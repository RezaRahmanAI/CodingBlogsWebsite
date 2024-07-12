using CodingBlogs.API.Data;
using CodingBlogs.API.Models.Domain;
using CodingBlogs.API.Models.DTOs;
using CodingBlogs.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodingBlogs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _category;

        public CategoriesController(ICategoryRepository category)
        {
            this._category = category;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            // Map DTO to Domain Model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };


            await _category.CreateCategoryAsync(category);


            // Map Domain Model to DTO
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle= category.UrlHandle,
            };

            return Ok(response);
        }
    }
}
