using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        public List<StudentModel> Students { get; set; }

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;

            Students = new List<StudentModel>()
            {
                new StudentModel() { Id = Guid.NewGuid(), FirstName = "Mukesh", LastName = "Setty", Email = "m.sku@gmail.com" },
                new StudentModel() { Id = Guid.NewGuid(), FirstName = "Mukesh2", LastName = "1Setty", Email = "m1.sku@gmail.com" },
                new StudentModel() { Id = Guid.NewGuid(), FirstName = "Mukesh3", LastName = "2Setty", Email = "m2.sku@gmail.com" },
                new StudentModel() { Id = Guid.NewGuid(), FirstName = "Mukesh4", LastName = "3Setty", Email = "m3.sku@gmail.com" },
                new StudentModel() { Id = Guid.NewGuid(), FirstName = "Mukesh5", LastName = "4Setty", Email = "m4.sku@gmail.com" }
            };
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            _logger.LogInformation("Your Student API is running");
            return Ok(Students);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateStudent([FromBody] StudentModel studentModel)
        {
            Students.Add(studentModel);
            return Ok(Students);
        }

        [HttpPost]
        [Route("bulkCreate")]
        public IActionResult CreateStudents([FromBody] List<StudentModel> studentModels)
        {
            Students.AddRange(studentModels);
            return Ok(Students);
        }

        [HttpPut]
        [Route("update")]
        public void ChangeStudent()
        {
        }

        [HttpDelete]
        [Route("remove")]
        public void RemoveStudent()
        {
        }
    }
}
