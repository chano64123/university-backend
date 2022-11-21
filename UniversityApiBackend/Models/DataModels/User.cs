using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels {
    public class User : BaseEntity {
        [Required, StringLength(50)]
        public string name { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string lastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string email { get; set; } = string.Empty;

        [Required]
        public string password { get; set; } = string.Empty;
    }
}
