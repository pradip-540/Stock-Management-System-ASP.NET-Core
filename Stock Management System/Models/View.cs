using System.ComponentModel.DataAnnotations;

namespace Stock_Management_System.Models
{
    public class View
    {
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public int Item { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
