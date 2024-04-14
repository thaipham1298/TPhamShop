using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Abstract
{
    public class Auditabale : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string? UpdateBy { get; set; }

        public string? MetaKeyword { get; set; }

        public string? MetaDescription { get; set; }

        public required bool Status { get; set; }
    }
}
