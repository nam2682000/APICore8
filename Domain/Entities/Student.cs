using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Database.Entity
{
    public class Student: BaseEntityAuditable<int>
    {
        [Key]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
