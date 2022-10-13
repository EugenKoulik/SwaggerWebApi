using System.ComponentModel.DataAnnotations;

namespace RusLabTest.DbContext.Models
{
    public sealed class Student : BaseModel
    {
        [Required]
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

