using AutoMapper;
using RusLabTest.Dto;
using RusLabTest.Models;

namespace RusLabTest.Mapster
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDto>();
        }
    }
    
    public class CourseReviewProfile : Profile
    {
        public CourseReviewProfile()
        {
            CreateMap<CourseReview, CourseReviewDto>();
        }
    }

    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>();
        }
    }
}

