namespace SchoolAdministration.Web.Types
{
    public class Class
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public Test[] Tests { get; set; }
    }
}
