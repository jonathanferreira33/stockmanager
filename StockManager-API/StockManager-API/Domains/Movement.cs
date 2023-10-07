using System.ComponentModel.DataAnnotations;

namespace StockManager_API.Domains
{
    public class Movement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Employee Responsible { get; set; }
        [Required]
        public Product Product { get; set;}
        [Required]
        public int Value { get; set; }

    }
}
