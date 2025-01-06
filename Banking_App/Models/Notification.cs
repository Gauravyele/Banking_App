using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banking_App.Models
{
    public class Notification
    {
        [ForeignKey("Users")]
        public int UserID { get; set; }
        [Key]
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
