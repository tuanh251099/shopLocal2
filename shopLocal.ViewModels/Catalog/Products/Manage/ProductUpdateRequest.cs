using Microsoft.AspNetCore.Http;
using shopLocal.Data.Entities;

namespace shopLocal.ViewModels.Catalog.Products.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public string LanguageId { get; set; }
        public Product Product { get; set; }
        public Language Language { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
