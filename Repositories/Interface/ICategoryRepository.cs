using CodingBlogs.API.Models.Domain;

namespace CodingBlogs.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateCategoryAsync(Category category);
    }
}
