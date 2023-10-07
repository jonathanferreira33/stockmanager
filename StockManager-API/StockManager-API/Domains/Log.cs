using StockManager_API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager_API.Domains
{
    [Table("TB_Logs")]
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; private set; }

        [Required]
        public LogTypes LogType { get; set; }

        public Log()
        {
            Date = DateTime.Now;
        }

    }
}
