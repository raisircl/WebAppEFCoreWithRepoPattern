namespace WebAppEFCoreWithRepoPattern.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Duration { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
