using SchoolAdministration.Data.Models;

namespace SchoolAdministration.Web.Inputs
{
    public record AddTestResultInput(
        int ClassId,
        int StudentId,
        int Grade
    );

    public class AddTestResultPayload
    {
        public AddTestResultPayload(TestResult testResult)
        {
            TestResult = testResult;
        }

        public TestResult TestResult { get; }
    }
}
