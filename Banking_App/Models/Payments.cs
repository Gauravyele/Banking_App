using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_App.Models
{
    public class Payments
    {
        [ForeignKey("Transaction")]
        public int TransactionID { get; set; }
        [Key]
        public int PaymentID { get; set; }
        public double Amount { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
        [ForeignKey("LoanApplication")]
        public int LoanID {  get; set; }
    }
}
