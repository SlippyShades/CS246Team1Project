namespace CS246Team1Project.Models
{
    public class CourseGradeModel
    {
        public CourseGradeModel(CourseModel c)
        {
            this.Course = c;
        }

        public CourseModel Course { get; set; }

        public string Grade { get; set; } = string.Empty;

    }
}
