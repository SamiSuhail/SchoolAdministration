using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Data.Models
{
    public abstract class Person
    {
        public int Id { get; set; }

        [Required]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [StringLength(200)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(200)]
        public string? LastName { get; set; }
    }
}
