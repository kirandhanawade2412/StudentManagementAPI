using System.ComponentModel.DataAnnotations;

namespace StudentManagementAPI.DTOs
{
    public class StudentDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Course { get; set; } = string.Empty;
    }
}