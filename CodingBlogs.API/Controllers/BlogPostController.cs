using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CodingBlogs.API.Models.DTOs;
using CodingBlogs.API.Models.Domain;
using CodingBlogs.API.Data;
using CodingBlogs.API.Repositories.Interface;

namespace CodingBlogs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostRepository _blogPost;        

        public BlogPostController(IBlogPostRepository _blogPost)
        {
            this._blogPost = _blogPost;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogPost(CreateBlogPostRequestDto request)
        {

            // Map DTO to Domain Model
            var blogPost = new BlogPost
            {
                Title = request.Title,
                Author = request.Author,
                Content = request.Content,
                CreatedDate = DateTime.Now,
                FeaturedImgUrl = request.FeaturedImgUrl,
                SortDescription = request.SortDescription,
                UrlHandle = request.UrlHandle,
                IsVisible = request.IsVisible,
            };


            await _blogPost.CreateAsync(blogPost);


            // Map Domain to Dto
            var response = new BlogPostDto
            {
                Id = blogPost.Id,
                Title = blogPost.Title,
                Author = blogPost.Author,
                Content = blogPost.Content,
                CreatedDate = DateTime.Now,
                FeaturedImgUrl = blogPost.FeaturedImgUrl,
                SortDescription = blogPost.SortDescription,
                UrlHandle = blogPost.UrlHandle,
                IsVisible = blogPost.IsVisible,
            };

            return Ok(response);

        }
    }
}
