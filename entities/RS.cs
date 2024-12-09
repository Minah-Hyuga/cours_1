namespace Cours.Models
{
    public class RS
    {
        private static int count = 0;
        private int id;
        private string surnom;
        private List<Course> courses;

        public RS(string surnom, string? email)
        {
            count++;
            this.id = count;
            this.surnom = surnom;
            this.courses = new List<Course>();
        }

        public int Id => id;
        public string Surnom => surnom;
        public List<Course> Courses => courses;

        public string? Name { get; internal set; }
        public string? Email { get; internal set; }

        public void AddCourse(string name, DateTime date, string time, string semester)
        {
            courses.Add(new Course(name, date, time, semester));
        }

        public void MarkStudentAbsent(int studentId, int courseId)
        {
            Course course = courses.FirstOrDefault(c => c.Id == courseId);
            if (course != null)
            {
                course.MarkAbsence(studentId);
            }
        }
    }

    public class Course
    {
        private static int count = 0;
        public int Id { get; }
        public string Name { get; }
        public DateTime Date { get; }
        public string Time { get; }
        public string Semester { get; }
        private List<int> absentStudents;

        public Course(string name, DateTime date, string time, string semester)
        {
            count++;
            Id = count;
            Name = name;
            Date = date;
            Time = time;
            Semester = semester;
            absentStudents = new List<int>();
        }

        public void MarkAbsence(int studentId)
        {
            if (!absentStudents.Contains(studentId))
                absentStudents.Add(studentId);
        }

        public List<int> GetAbsentStudents()
        {
            return absentStudents;
        }
    }
}
