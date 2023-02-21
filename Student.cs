namespace StudentMeter
{
    public class Student
    {
        public Student(string studentName)
        {
            StudentName = studentName;
        }

        public string StudentName { get; private set; } = "";
        public float TotalHours { get; set; } = 0;
        public float TotalDebt { get; set; } = 0;
        public float TotalPaidMoney { get; set; } = 0;
        public List<LessonEntry> LessonEntries { get; } = new();
    }
}