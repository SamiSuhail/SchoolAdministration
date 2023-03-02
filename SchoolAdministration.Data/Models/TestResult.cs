using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Data.Models
{
    public class TestResult
    {
        public int Id { get; set; }

        public int? StudentId { get; set; }
        public virtual Student? Student { get; set; }



        public int ClassId { get; set; }
        public virtual Class? Class { get; set; }

        public int? Grade { get; set; }
    }
}
