using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace CS246Team1Project.Models
{
    public class StudentModel
    {
        public StudentModel()
        {
            LastUpdate = DateTime.Now;
        }
        [Key]
        public required int LNumber { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [StringLength(10, MinimumLength = 10)]
        public string PhoneNumber { get; set; } = string.Empty;

        [EmailAddress]
        public string PersonalEmail { get; set; } = string.Empty;

        [EmailAddress]
        public string LaneEmail { get; set; } = string.Empty;

        public int CohortYear { get; set; }

        public DateTime LastUpdate {  get; set; }

        public AddressModel Address { get; set; } = new AddressModel();

        public List<CourseGradeModel> Courses { get; set; } = new List<CourseGradeModel>();

        public string Notes { get; set; } = string.Empty;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
