namespace CodingBlogs.API.Models.DTOs
{
    public class CreateBlogPostRequestDto
    {
        public string Title { get; set; }
        public string SortDescription { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string UrlHandle { get; set; }
        public string FeaturedImgUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsVisible { get; set; }
    }
}
