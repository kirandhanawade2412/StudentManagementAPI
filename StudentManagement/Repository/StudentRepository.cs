using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Data;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student?> GetStudentById(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student?> UpdateStudent(Student student)
        {
            var existing = await _context.Students.FindAsync(student.Id);

            if (existing == null)
                return null;

            existing.Name = student.Name;
            existing.Email = student.Email;
            existing.Age = student.Age;
            existing.Course = student.Course;

            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return false;

            _context.Students.Remove(student);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}