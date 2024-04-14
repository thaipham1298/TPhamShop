using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public string URL { get; set; }
        public int DisplayOder { get; set; }
        public bool Status { get; set; }
    }
}
