using System.Security.Claims;

namespace CS246Team1Project.Models
{
    public class CourseModel
    {
        public string CoursePrefix { get; set; } = string.Empty;

        public string CourseNumber { get; set; } = string.Empty;

        public string MinimumPassingGrade { get; set; } = string.Empty;

    }
}
