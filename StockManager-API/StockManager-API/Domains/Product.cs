using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager_API.Domains
{
    [Table("TB_Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(15,2)")]
        public decimal Value { get; set; }
        public string Ean { get; set; }
        public string Amount { get; set; }


        public Product() { }
    }
}
