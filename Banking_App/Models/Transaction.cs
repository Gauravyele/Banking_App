using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_App.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [ForeignKey("Accounts")]
        public int AccountId { get; set;}
        public string TransactionType { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
