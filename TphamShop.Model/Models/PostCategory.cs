using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TphamShop.Model.Abstract;

namespace TphamShop.Model.Models
{
    public abstract class PostCategory : Auditabale
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public int DisplayOder {  get; set; }
        public string Image {  get; set; }
        public bool? HomeFlag {  get; set; }
        public List<Post> posts { get; set; }
    }
}
