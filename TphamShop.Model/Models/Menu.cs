using System.ComponentModel.DataAnnotations;

namespace TphamShop.Model.Model
{
    public class Menu
    {
        public int Id { get; set; }

        [StringLength(255)]
        public required string Name { get; set; }

        [StringLength(255)]
        public required string URL { get; set; }

        public int DisplayOder { get; set; }

        public Menugroup Menugroup { get; set; }

        [StringLength(255)]
        public string? Target { get; set; }

        public bool Status { get; set; }
    }
}