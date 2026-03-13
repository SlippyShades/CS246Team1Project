namespace CS246Team1Project.Models
{
    public class CourseGradeModel
    {
        public CourseGradeModel()
        {
            this.Course = new();
            this.CourseNumberOriginal = this.Course.CourseNumber;
            this.CoursePrefixOriginal = this.Course.CoursePrefix;
        }
        public CourseGradeModel(CourseModel c)
        {
            this.Course = c;
            this.CourseNumberOriginal = c.CourseNumber;
            this.CoursePrefixOriginal = c.CoursePrefix;
        }

        public int Id { get; set; }

        public string CurrentGrade { get; set; } = "Not Graded Yet";

        public int CohortYear { get; set; }

        public CourseModel Course { get; set; }

        public string CoursePrefixOriginal { get; set; }

        public string CourseNumberOriginal { get; set; }

        public string Term { get; set; } = string.Empty;


    }
}
