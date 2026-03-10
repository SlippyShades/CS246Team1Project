namespace CS246Team1Project.Models
{
    public class CourseGradeModel
    {
        public CourseGradeModel() { }
        public CourseGradeModel(CourseModel c)
        {
            this.Course = c;
        }

        public int Id { get; set; }

        public CourseModel Course { get; set; } = new CourseModel();

        public string Grade { get; set; } = string.Empty;

    }
}
