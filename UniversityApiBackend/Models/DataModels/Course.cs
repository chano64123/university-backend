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
        public Level level { get; set; }
    }
}
