using System.ComponentModel.DataAnnotations;


namespace Mission07_Baird.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }

    }
}
