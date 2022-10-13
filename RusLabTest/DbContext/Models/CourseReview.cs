using System.ComponentModel.DataAnnotations;

namespace RusLabTest.DbContext.Models
{
    public class CourseReview : BaseModel
    {
        [Required]
        public Guid CourseId { get; set; }
        public Course Course { get; set; }

        [Required]
        public float Rating { get; set; }
        
        public string Review { get; set; }
    }
}

