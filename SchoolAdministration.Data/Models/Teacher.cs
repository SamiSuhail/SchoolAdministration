using System.ComponentModel.DataAnnotations;

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

        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public Subject Subject { get; set; }
    }
}
