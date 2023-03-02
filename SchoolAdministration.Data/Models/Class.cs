using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Data.Models
{
    public class Class
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Name { get; set; }

        public virtual ICollection<TestResult>? TestResults { get; set; }
    }
}
