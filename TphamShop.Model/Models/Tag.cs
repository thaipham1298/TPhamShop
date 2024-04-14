using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public ProductTag Product { get; set; }
        public List<PostTag> PostTags { get; set; }
    }
}
