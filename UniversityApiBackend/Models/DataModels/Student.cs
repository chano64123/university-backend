using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels {
    public class Student : BaseEntity {
        [Required]
        public string firstName { get; set; } = string.Empty;

        [Required]
        public string lastNames { get; set; } = string.Empty;

        [Required]
        public DateTime dateOfBirth { get; set; }

        public ICollection<Course> courses { get; set; } = new List<Course>();

    }
}
