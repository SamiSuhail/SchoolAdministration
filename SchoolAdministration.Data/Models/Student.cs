using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Data.Models
{
    public class Student : Person
    {
        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public TestResult[]? TestResults { get; set; }
    }
}
