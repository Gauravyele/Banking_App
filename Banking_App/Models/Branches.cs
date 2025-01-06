using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Banking_App.Models
{
    [Index(("IfscCode"), IsUnique = true)]
    public class Branches
    {
        [Key]
        public int BranchID { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string IfscCode {  get; set; }
        public string Address { get; set; }
        public string ContactNumber {  get; set; }
    }
}
