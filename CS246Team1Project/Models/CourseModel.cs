using System.Security.Claims;

namespace CS246Team1Project.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string CoursePrefix { get; set; } = string.Empty;

        public string CourseNumber { get; set; } = string.Empty;

        public List<CourseModel> Term { get; set; }

        public string PassingGrade { get; set; } = string.Empty;

    }
}
