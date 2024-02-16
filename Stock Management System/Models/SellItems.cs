
using System.ComponentModel.DataAnnotations;

namespace Stock_Management_System.Models
{
    public class SellItems
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Customer_Name { get; set; }
        [Required]
        public long Phone_Number { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]

        public int Product_Price { get; set;}
        [Required]
        public int Items { get; set;}
    }
    
}
