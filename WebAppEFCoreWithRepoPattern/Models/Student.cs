using System.ComponentModel.DataAnnotations;

namespace WebAppEFCoreWithRepoPattern.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Age { get; set; }

        [StringLength(15)]
        public string? PhNo { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; } // Navigation Property  

    }
}
