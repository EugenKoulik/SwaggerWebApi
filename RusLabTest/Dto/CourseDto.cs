namespace RusLabTest.Dto
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public List<StudentDto> Students { get; set; }
        public List<CourseReviewDto> CourseReviews { get; set; }
    }
}

