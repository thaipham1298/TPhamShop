using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class ProductTag
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }
        public Product Product { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
