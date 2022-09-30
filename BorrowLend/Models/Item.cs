using System.ComponentModel.DataAnnotations;

namespace BorrowLend.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Item Name")]
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }
    }
}
