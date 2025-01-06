using System.ComponentModel.DataAnnotations;

namespace Banking_App.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public string phone {  get; set; }
        public string role { get; set; }
        public DateTime createdAt { get; set; }
    }
}
