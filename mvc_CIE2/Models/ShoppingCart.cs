using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_CIE2.Models
{
    public class ShoppingCart
    {
        [Table("ShoppingCart")]

        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CartDetail> CartDetails { get; set; }
    }
}
