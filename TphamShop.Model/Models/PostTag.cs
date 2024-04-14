using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public Post Post { get; set; }  
    }
}
