using Mission07_Baird.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Baird.Models
{
    public class MovieSubmission
    {
        [Key]
        [Required]
        public int MovieSubmissionId { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public int? Year { get; set; }

        [Required]
        public string? Director { get; set; }

        [Required]
        public string? Rating { get; set; }

        public bool? Edited { get; set;}

        public string? LentTo {  get; set;}

        public string? Notes { get; set;}
    }
}
