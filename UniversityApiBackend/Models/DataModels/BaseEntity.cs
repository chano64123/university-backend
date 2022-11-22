using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels {
    public class BaseEntity {
        [Required]
        [Key]
        public int id { get; set; }
        public int userIdCreated { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public int? userIdUpdate { get; set; }
        public DateTime? updatedAt { get; set; }
        public int? userIdDelete { get; set; }
        public DateTime? deletedAt { get; set; }
        public bool isDeleted { get; set; } = false;
        public virtual User user { get; set; } = new User();
    }
}
