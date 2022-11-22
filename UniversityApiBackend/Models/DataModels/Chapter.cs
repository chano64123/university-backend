using Microsoft.Build.Framework;

namespace UniversityApiBackend.Models.DataModels {
    public class Chapter : BaseEntity{
        public int courseId { get; set; }
        public virtual Course course { get; set; } = new Course();

        [Required]
        public string chapters { get; set; } = string.Empty;
    }
}
