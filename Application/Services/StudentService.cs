
namespace MyApp.Service
{

    public interface IStudentService
    {
        public Task<List<Student>> GetAllStudent();
    }

    public class StudentService : IStudentService
    {
        public Task<List<Student>> GetAllStudent()
        {
            throw new NotImplementedException();
        }
    }
}
