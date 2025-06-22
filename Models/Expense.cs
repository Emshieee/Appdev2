using System.ComponentModel.DataAnnotations;

namespace Appdev2.Models
{
    public class Expense
    {
        public int id { get; set; }

        [Required(ErrorMessage = "💰 Value is required!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "💵 Value must be greater than 0!")]
        public decimal value { get; set; }

        [Required(ErrorMessage = "🗒️ Description is required!")]
        [StringLength(100, ErrorMessage = "🗒️ Description must be at most 100 characters long.")]
        public string? description { get; set; }
    }
}
