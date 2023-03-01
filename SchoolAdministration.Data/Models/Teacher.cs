namespace SchoolAdministration.Data.Models
{
    public enum Subject
    {
        None = 0,
        Math = 1,
        English = 2
    }

    public class Teacher : Person
    {
        public Subject Subject { get; set; }
        public Student[] Students { get; set; } = default!;
    }
}
