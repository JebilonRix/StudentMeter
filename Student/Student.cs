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
        public int TotalDebt { get; set; } = 0;
        public int TotalPaidMoney { get; set; } = 0;
        public List<LessonEntry> LessonEntries { get; } = new();
    }
}