using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Models.Enum;

namespace UniversityApiBackend.Models.DataModels {
    public class Course : BaseEntity {
        [Required]
        public string name { get; set; } = String.Empty;

        [Required, StringLength(280)]
        public string shortDescription { get; set; } = String.Empty;

        [Required]
        public string longDescription { get; set; } = String.Empty;

        [Required]
        public string targetAudience { get; set; } = String.Empty;

        [Required]
        public string objectives { get; set; } = String.Empty;

        [Required]
        public string requirements { get; set; } = String.Empty;

        [Required]
        public Level level { get; set; } = Level.Basic;

        [Required]
        public ICollection<Category> categories { get; set; } = new List<Category>();

        [Required]
        public Chapter chapter { get; set; } = new Chapter();

        [Required]
        public ICollection<Student> student { get; set; } = new List<Student>();
    }
}
