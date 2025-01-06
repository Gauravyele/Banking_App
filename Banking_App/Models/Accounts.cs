using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_App.Models
{
    [Index(("AccountNumber"), IsUnique = true )]

    public class Accounts
    {
        [Key]
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
        [ForeignKey("Branches")]
        public string BranchID { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
    }
}
