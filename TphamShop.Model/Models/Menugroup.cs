using System.ComponentModel.DataAnnotations;

namespace TphamShop.Model.Model
{
    public class Menugroup
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public List<Menu> menus { get; set; }
    }
}