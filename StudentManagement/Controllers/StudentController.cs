using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.DTOs;
using StudentManagementAPI.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace StudentManagementAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        // GET: api/student
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _service.GetAllStudents();
            return Ok(students);
        }

        // GET: api/student/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _service.GetStudentById(id);

            if (student == null)
                return NotFound(new { message = "Student not found" });

            return Ok(student);
        }

        // POST: api/student
        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentDto dto)
        {
            var student = await _service.AddStudent(dto);

            return CreatedAtAction(nameof(GetStudentById),
                new { id = student.Id }, student);
        }

        // PUT: api/student/1
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, StudentDto dto)
        {
            var student = await _service.UpdateStudent(id, dto);

            if (student == null)
                return NotFound(new { message = "Student not found" });

            return Ok(student);
        }

        // DELETE: api/student/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var deleted = await _service.DeleteStudent(id);

            if (!deleted)
                return NotFound(new { message = "Student not found" });

            return Ok(new { message = "Student deleted successfully" });
        }
    }
}