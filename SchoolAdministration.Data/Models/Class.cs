namespace SchoolAdministration.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public Teacher Teacher { get; set; } = default!;
        public Test[]? Tests { get; set; }
    }
}
