using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_App.Models
{
    public class Mfa
    {
        [Key]
        public int MfaID { get; set; }
        [ForeignKey("Users")]
        public int UserID {  get; set; }
        public string Otp {  get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
    }
}
