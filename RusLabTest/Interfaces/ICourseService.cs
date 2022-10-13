using RusLabTest.Dto;

namespace RusLabTest.Interfaces
{
    public interface ICourseService
    {
        public Task<List<CourseDto>> GetAsync();
    }
}

