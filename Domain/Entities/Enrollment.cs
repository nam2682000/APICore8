using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Database.Entity
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment: BaseEntity<int> 
    {
        [Key]
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
