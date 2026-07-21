using StudentManagementAPI.DTOs;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();

        Task<Student?> GetStudentById(int id);

        Task<Student> AddStudent(StudentDto dto);

        Task<Student?> UpdateStudent(int id, StudentDto dto);

        Task<bool> DeleteStudent(int id);
    }
}