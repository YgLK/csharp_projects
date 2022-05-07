using System.ComponentModel.DataAnnotations;

namespace ModelSystemRPG.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
    }
}
