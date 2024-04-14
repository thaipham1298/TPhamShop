using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class Post
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Alias { get; set; }
        public int CategoryId { get; set; }
        public string? Image {  get; set; }
        public string? Description { get; set; }
        public string Content { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool Status { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFalg { get; set; }
        public int ViewCount { get; set; }
        public PostTag PostTag { get; set; }    
        public PostCategory PostCategorys { get; set; }
    }
}
