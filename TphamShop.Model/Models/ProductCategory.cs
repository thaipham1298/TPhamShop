using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TphamShop.Model.Abstract;
using TphamShop.Model.Model;

namespace TphamShop.Model.Models
{
    public abstract class ProductCategory : Auditabale
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Alias { get; set; }
        public string? Description { get; set; }
        public int ParentId { get; set; }
        public int? DisplayOder {  get; set; }
        public string? Image { get; set; }
        public bool? HomeFlag { get; set; }
        public List<Product> Products { get; set; }
    }
}
