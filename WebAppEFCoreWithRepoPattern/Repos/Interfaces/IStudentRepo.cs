using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppEFCoreWithRepoPattern.Models;
namespace WebAppEFCoreWithRepoPattern.Repos.Interfaces
{
    public interface IStudentRepo
    {
        public Task<IEnumerable<Student>> GetAllStudentsAsync();
        public Task<Student?> GetStudentByIdAsync(int id);
        public Task AddStudentAsync(Student student);
        public Task UpdateStudentAsync(Student student);
        public Task DeleteStudentAsync(int id);


    }
}
