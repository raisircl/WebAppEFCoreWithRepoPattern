using Microsoft.EntityFrameworkCore;
using WebAppEFCoreWithRepoPattern.Models;
using WebAppEFCoreWithRepoPattern.Repos.Interfaces;

namespace WebAppEFCoreWithRepoPattern.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;
        public StudentRepo(AppDbContext context)
        {
            _context = context; 
        }
        public Task AddStudentAsync(Student student)
        {
            _context.Students.Add(student); 
            return _context.SaveChangesAsync();

        }

        public Task DeleteStudentAsync(int id)
        {
            var st=_context.Students.FirstOrDefault(s => s.Id == id);
            if (st != null)
            {
                _context.Students.Remove(st);
                return _context.SaveChangesAsync();
            }
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public Task<Student?> GetStudentByIdAsync(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);    
            return Task.FromResult(student);
        }

        public Task UpdateStudentAsync(Student student)
        {
            var st=_context.Students.FirstOrDefault(s => s.Id == student.Id);   
            if (st != null)
            {
                st.Name = student.Name;
                st.Age = student.Age;
                return  _context.SaveChangesAsync();
            }
            return Task.CompletedTask;
        }
    }
}
