using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels {
    public class Category : BaseEntity {
        [Required]
        public string name { get; set; } = string.Empty;

        [Required]
        public ICollection<Course> courses { get; set; } = new List<Course>();
    }
}
