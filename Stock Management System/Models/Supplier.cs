using System.ComponentModel.DataAnnotations;

namespace Stock_Management_System.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Supplier_Name { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
