using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess {
    public class UniversityDBContext : DbContext{
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options){ 
        }
        //TODO: add DbSets (Tables for our Data Base)
        public DbSet<User>? User { get; set; }
        public DbSet<Course>? Course { get; set; }
        public DbSet<Student>? Student { get; set; }
        public DbSet<Chapter>? Chapter { get; set; }
        public DbSet<Category>? Category { get; set; }
    }
}
