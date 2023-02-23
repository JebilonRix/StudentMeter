namespace StudentMeter
{
    public class Student
    {
        public Student(string studentName)
        {
            StudentName = studentName;
            TotalHours = 0;
            TotalDebt = 0;
            TotalPaidMoney = 0;
            LessonEntries = new List<LessonEntry>();
        }

        public string StudentName { get; private set; } = "";
        public float TotalHours { get; set; }
        public int TotalDebt { get; set; }
        public int TotalPaidMoney { get; set; }
        public List<LessonEntry> LessonEntries { get; set; }
    }
}