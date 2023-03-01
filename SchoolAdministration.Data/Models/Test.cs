namespace SchoolAdministration.Data.Models
{
    public class Test
    {
        public int Id { get; set; }
        public TestResult[] Results { get; set; } = default!;
    }
}
