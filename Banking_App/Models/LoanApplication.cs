using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_App.Models
{
    public class LoanApplication
    {
        [Key]
        public int LoanAppID { get; set; }
        public string LoanType { get; set; }
        public  double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int DurationMonths { get; set; }
        public string Status { get; set; }
        [ForeignKey("Users")]
        public int UserID   { get; set; }
        public DateTime AppliedAt { get; set; }
        public DateTime ProcessedAt { get; set; }
        public string Remarks { get; set; }

    }
}
