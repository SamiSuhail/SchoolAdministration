using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Data.Models
{
    public class Student : Person
    {
        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }

        public virtual ICollection<TestResult>? TestResults { get; set; }
    }
}
