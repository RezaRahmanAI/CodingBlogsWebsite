namespace CodingBlogs.API.Models.Domain
{
    public class BlogPost
    {
        public int Id { get; set; }
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
