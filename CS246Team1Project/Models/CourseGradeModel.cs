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

        public string CurrentGrade { get; set; }

        public int CohortYear { get; set; }

        public CourseModel Course { get; set; } = new CourseModel();

        public CourseModel CoursePrefix { get; set; }


        public CourseModel CourseNumber { get; set; }

        public CourseModel Term { get; set; }


    }
}
