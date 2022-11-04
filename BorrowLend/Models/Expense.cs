using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BorrowLend.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Expense Name")]
        public string? ExpenseName { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "The amount must be positive number!")]
        public double ExpenseAmount { get; set; }
        public int ExpenseTypeId { get; set; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType? ExpenseType { get; set; }
    }
}
