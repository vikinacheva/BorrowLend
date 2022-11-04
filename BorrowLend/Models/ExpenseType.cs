using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace BorrowLend.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Expense Name")]
        public string? ExpenseTypeName { get; set; }
    }
}
