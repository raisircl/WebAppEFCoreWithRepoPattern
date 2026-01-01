using Microsoft.AspNetCore.Mvc;
using WebAppEFCoreWithRepoPattern.Models;
using WebAppEFCoreWithRepoPattern.Repos.Interfaces; 
using WebAppEFCoreWithRepoPattern.Repos;
namespace WebAppEFCoreWithRepoPattern.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo repo;

        public StudentController(IStudentRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Student> students = repo.GetAllStudentsAsync().Result.ToList();

            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            ModelState.Remove("Id");    

            if (ModelState.IsValid)
            {
                repo.AddStudentAsync(student).Wait();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}