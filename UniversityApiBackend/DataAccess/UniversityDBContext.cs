using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess {
    public class UniversityDBContext : DbContext{
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options){ 
        }
        //TODO: add DbSets (Tables for our Data Base)
        public DbSet<User>? User { get; set; }
        public DbSet<Course>? Course { get; set; }
    }
}
