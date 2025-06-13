using System.ComponentModel.DataAnnotations;

namespace Appdev2.Models
{
    public class Expense
    {
        public int id { get; set; }
        public decimal value { get; set; }
        [Required]
        public string? description { get; set; }

    }
}