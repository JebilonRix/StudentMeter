namespace DersTakip
{
    public static class DebtMethods
    {
        public static List<Student> Students { get; } = new();

        public static Student GetStudent(string studentName)
        {
            //Searches currrent student in list.
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentName == studentName)
                {
                    return Students[i];
                }
            }

            //If the student does not exist in list, generates new entry
            Student result = new(studentName)
            {
                TotalHours = 0,
                TotalDebt = 0,
                TotalPaidMoney = 0
            };

            //And adds it to list.
            Students.Add(result);

            return result;
        }

        public static void UpdateStudent(string oldName, string newName)
        {
            //Gets the old student's entry.
            Student oldStudent = GetStudent(oldName);

            //Generates new entry.
            Student newStudent = new(newName)
            {
                TotalHours = oldStudent.TotalHours,
                TotalDebt = oldStudent.TotalDebt,
                TotalPaidMoney = oldStudent.TotalPaidMoney
            };

            //Removes old entry.
            Students.Remove(oldStudent);

            //Adds new entry.
            Students.Add(newStudent);
        }

        public static void AddDebt(string studentName, float hours, float costOfLesson)
        {
            //Gets the current newStudent.
            Student student = GetStudent(studentName);

            //Total hours are added.
            student.TotalHours += hours;

            //Calculates the debt and adds it to the total debt.
            student.TotalDebt += costOfLesson * hours;
        }

        public static void PayDebt(string studentName, float paidMoney)
        {
            //Gets the current student.
            Student student = GetStudent(studentName);

            //Adds paid money to total paid money.
            student.TotalPaidMoney += paidMoney;
        }
    }
}