using CodingBlogs.API.Models.Domain;

namespace CodingBlogs.API.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);
    }
}
