using Microsoft.AspNetCore.Mvc;
using RusLabTest.Dto;
using RusLabTest.Interfaces;

namespace RusLabTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;
        private readonly ICourseService _courseService;

        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }
        
        [HttpGet(Name = "GetDataFromDb")]
        public IEnumerable<CourseDto> GetAsync()
        {
            return _courseService.GetAsync().Result;
        }
    }
}

