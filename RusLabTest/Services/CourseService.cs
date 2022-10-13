using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RusLabTest.Dto;
using RusLabTest.Interfaces;
using RusLabTest.Models;

namespace RusLabTest.Services
{
    public class CourseService : ICourseService
    {
        private readonly RusLabDbContext _db;
        private readonly IMapper _mapper;

        public CourseService(RusLabDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        
        public async Task<List<CourseDto>> GetAsync()
        {
            var courses =  await _db.Courses
                .Include(c => c.CourseReviews)
                .Include(s=> s.Students)
                .ToListAsync();

            var coursesDto = _mapper.Map<List<Course>, List<CourseDto>>(courses);
            
            return coursesDto;
        }
    }
}

