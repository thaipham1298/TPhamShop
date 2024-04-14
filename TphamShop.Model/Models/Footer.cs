using System.ComponentModel.DataAnnotations;

namespace TphamShop.Model.Model
{
    public class Footer
    {
        public int ID { set; get; }
        [StringLength(500)]
        public string? Content { set; get; }
    }
}