using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TphamShop.Model.Abstract;

namespace TphamShop.Model.Models
{
    [PrimaryKey(nameof(OderId), nameof(ProductId))]
    public class OderDetail
    {
        public int OderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Oder Oder { get; set; }
        public Product Product {  get; set; } 
    }
}
