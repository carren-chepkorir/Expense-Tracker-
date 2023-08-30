using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace TransactionTracker.Models
{
    public class Category
    {
        
        public Guid CategoryId { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Icon { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Tittle { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Type { get; set; } = "Expense";
    }
}
