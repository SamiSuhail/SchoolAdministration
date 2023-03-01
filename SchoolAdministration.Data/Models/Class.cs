namespace SchoolAdministration.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public Test[] Tests { get; set; }
    }
}
