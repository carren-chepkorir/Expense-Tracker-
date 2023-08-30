using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransactionTracker.Models
{
    public class Transaction
    {
       
        public Guid TransactionId { get; set; }
        public  Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public int Amount { get; set; }
        [Column(TypeName ="nvarchar(75)")]
        public string Description { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
