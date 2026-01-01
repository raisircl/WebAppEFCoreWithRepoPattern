using WebAppEFCoreWithRepoPattern.Models;
using WebAppEFCoreWithRepoPattern.Repos.Interfaces;

namespace WebAppEFCoreWithRepoPattern.Repos
{
    public class StudentRepoPg : IStudentRepo
    {
        public Task AddStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Student?> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
