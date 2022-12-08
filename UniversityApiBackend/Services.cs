using UniversityApiBackend.DataAccess;
using UniversityApiBackend.Models.DataModels;
using UniversityApiBackend.Models.Enum;

namespace UniversityApiBackend {
    public class Services {
        public static List<User> UsersByEmail(UniversityDBContext context, string email) {
            return context.User.Where(x => x.email.Equals(email)).ToList();
        }

        public static List<Student> OlderStudents(UniversityDBContext context) {
            return context.Student.Where(x => Convert.ToInt32(DateTime.Now - x.dateOfBirth) >= 18).ToList();
        }

        public static List<Student> StudentsAtLeastOneCourse(UniversityDBContext context) {
            return context.Student.Where(x => x.courses.Any()).ToList();
        }

        public static List<Course> CourseAtLeastOneStudentByLevel(UniversityDBContext context, Level level) {
            return context.Course.Where(x => x.student.Any() && x.level == level).ToList();
        }

        public static List<Course> CourseByLevelAndCategory(UniversityDBContext context, Level level, int idCategory) {
            return context.Course.Where(x => x.level == level).Where(x => x.categories).ToList();
        }

        public static List<Course> CoursesWithOutStudents(UniversityDBContext context) {
            return context.Course.Where(x => !x.student.Any()).ToList();
        }
    }
}
