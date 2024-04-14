using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class Oder
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string CustomerName { get; set; }
        public required string CustomerAddress { get; set; }
        public required string CustomerEmail { get; set; }
        public required string CustomerMobile { get; set; }
        public required string CustomerMesssage { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public required string PaymentMethrod { get; set; }
        public required string PaymentStatus { get; set; }
        public required bool Status { get; set; }
        public List<OderDetail> OderDetails { get; set; }
    }
}
