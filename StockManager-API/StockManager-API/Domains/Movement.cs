using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager_API.Domains
{
    [Table("TB_Movements")]
    public class Movement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Responsible { get; set; }
        [Required]
        [ForeignKey("Product")]
        public virtual ICollection<Product> Products { get; set;}
        [Required]
        public int Amount { get; set; }

    }
}