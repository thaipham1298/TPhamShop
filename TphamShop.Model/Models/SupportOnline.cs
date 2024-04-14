using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TphamShop.Model.Models
{
    public class SupportOnline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department {  get; set; }
        public string Skype { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public bool Status { get; set; }
    }
}
