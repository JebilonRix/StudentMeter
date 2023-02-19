namespace DersTakip
{
    public class Student
    {
        private string _studentName = "";
        private float _totalHours = 0;
        private float _debtOfStudent = 0;
        private float _paidMoney = 0;

        public Student(string studentName)
        {
            StudentName = studentName;
        }

        public string StudentName { get => _studentName; private set => _studentName = value; }
        public float TotalHours { get => _totalHours; set => _totalHours = value; }
        public float TotalDebt { get => _debtOfStudent; set => _debtOfStudent = value; }
        public float TotalPaidMoney { get => _paidMoney; set => _paidMoney = value; }
    }
}