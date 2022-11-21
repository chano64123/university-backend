using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels {
    public class BaseEntity {
        [Required]
        [Key]
        public int id { get; set; }
        public string createdBy { get; set; } = string.Empty;
        public DateTime createdAt { get; set; } = DateTime.Now;
        public string updatedBy { get; set; } = string.Empty;
        public DateTime? updatedAt { get; set; }
        public string deletedBy { get; set; } = string.Empty;
        public DateTime? deletedAt { get; set; }
        public bool isDeleted { get; set; }
    }
}
