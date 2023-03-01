namespace SchoolAdministration.Data.Models
{
    public class TestResult
    {
        public int Id { get; set; }
        public Student Student { get; set; } = default!;
        public int? Grade { get; set; }
    }
}
