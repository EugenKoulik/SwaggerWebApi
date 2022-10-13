using System.ComponentModel.DataAnnotations;

namespace RusLabTest.DbContext.Models
{
    public sealed class Course : BaseModel
    {
        [Required]
        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<CourseReview> CourseReviews { get; set; }
    }
}

