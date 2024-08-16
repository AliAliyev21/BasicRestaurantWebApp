using Microsoft.AspNetCore.Http;

namespace WebApplication3.Models
{
    public class ProductUpdateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public IFormFile ImageFile { get; set; } 
        public string ExistingImage { get; set; } 
    }
}
