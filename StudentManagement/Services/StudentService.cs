using StudentManagementAPI.DTOs;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _repository.GetAllStudents();
        }

        public async Task<Student?> GetStudentById(int id)
        {
            return await _repository.GetStudentById(id);
        }

        public async Task<Student> AddStudent(StudentDto dto)
        {
            Student student = new Student
            {
                Name = dto.Name,
                Email = dto.Email,
                Age = dto.Age,
                Course = dto.Course,
                CreatedDate = DateTime.Now
            };

            return await _repository.AddStudent(student);
        }

        public async Task<Student?> UpdateStudent(int id, StudentDto dto)
        {
            Student student = new Student
            {
                Id = id,
                Name = dto.Name,
                Email = dto.Email,
                Age = dto.Age,
                Course = dto.Course
            };

            return await _repository.UpdateStudent(student);
        }

        public async Task<bool> DeleteStudent(int id)
        {
            return await _repository.DeleteStudent(id);
        }
    }
}