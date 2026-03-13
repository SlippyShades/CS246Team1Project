using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace CS246Team1Project.Models
{
    public class CourseModel
    {
        public int Id { get; set; }

        [Required]
        public string CoursePrefix { get; set; } = string.Empty;

        [Required]
        public string CourseNumber { get; set; } = string.Empty;

        public List<string> Term { get; set; } = new List<string>();

        public string PassingGrade { get; set; } = string.Empty;

    }
}
