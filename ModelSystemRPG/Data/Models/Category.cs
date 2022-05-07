using System.ComponentModel.DataAnnotations.Schema;

namespace ModelSystemRPG.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int PropertiesCount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
