using TphamShop.Model.Abstract;
using TphamShop.Model.Models;

namespace TphamShop.Model.Models
{
    public abstract class Product : Auditabale
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Alias { get; set; }
        public int Category { get; set; }
        public string? Image { get; set; }
        public string? MoreImage { get; set; }
        public decimal Price { get; set; }
        public decimal? Promotion { get; set; }
        public int? Warranty { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public bool? ViewCount { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<OderDetail> OderDetails { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}