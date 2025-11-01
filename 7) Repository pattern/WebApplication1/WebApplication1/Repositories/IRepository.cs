using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IRepository
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int id);

    }
}
