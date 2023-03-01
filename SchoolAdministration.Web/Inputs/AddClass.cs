using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Web.Inputs
{
    public record AddClassInput(
        string Name
    );

    public class AddClassPayload
    {
        public AddClassPayload(Class @class)
        {
            Class = @class;
        }

        public Class Class { get; }
    }
}
