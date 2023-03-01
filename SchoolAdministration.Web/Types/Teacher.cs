namespace SchoolAdministration.Web.Types
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
        public Student[] Students { get; set; }
    }
}
