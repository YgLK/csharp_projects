using System.ComponentModel.DataAnnotations.Schema;

namespace ModelSystemRPG.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // category owner id
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
