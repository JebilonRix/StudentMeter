namespace StudentMeter
{
    public static class StudentMethods
    {
        public static List<Student> Students { get; } = new();

        /// <summary>
        /// Checks the student exist in list.
        /// </summary>
        public static bool DoesStudentExist(string studentName)
        {
            //Searches currrent student in list.
            foreach (Student student in Students)
            {
                if (student.StudentName == studentName)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Adds the student to list
        /// </summary>
        public static void AddStudent(string studentName)
        {
            //Checks the student exists.
            if (DoesStudentExist(studentName))
            {
                return;
            }

            //Generates a new student.
            GenerateStudent(studentName);
        }

        public static Student GetStudent(string studentName)
        {
            //Searches the student
            Student? student = Students.FirstOrDefault(x => x.StudentName == studentName);

            //if the student does not exists, generates new one
            student ??= GenerateStudent(studentName);

            // returns the student.
            return student;
        }

        public static void UpdateStudent(string oldName, string newName)
        {
            //Gets the old student's lastLessonEntry.
            Student oldStudent = GetStudent(oldName);

            //Generates new lastLessonEntry.
            Student newStudent = new(newName)
            {
                TotalHours = oldStudent.TotalHours,
                TotalDebt = oldStudent.TotalDebt,
                TotalPaidMoney = oldStudent.TotalPaidMoney,
                LessonEntries = oldStudent.LessonEntries
            };

            //Removes old lastLessonEntry.
            Students.Remove(oldStudent);

            //Adds new lastLessonEntry.
            Students.Add(newStudent);
        }

        public static void AddDebt(string studentName, float hours, int costOfLesson)
        {
            //Gets the current newStudent.
            Student student = GetStudent(studentName);

            //Total hours are added.
            student.TotalHours += hours;

            //Calculates the debt and adds it to the total debt.
            student.TotalDebt += (int)(costOfLesson * hours);
        }

        public static void PayDebt(string studentName, int paidMoney)
        {
            //Gets the current student.
            Student student = GetStudent(studentName);

            //Adds paid money to total paid money.
            student.TotalPaidMoney += paidMoney;
        }

        public static bool CheckLastLessonWithCurrentLesson(Student student, LessonEntry lessonEntry)
        {
            //Checks is there any lesson entry?
            if (student.LessonEntries.Count == 0)
            {
                return true;
            }

            //Gets last lesson entry
            LessonEntry lastLessonEntry = student.LessonEntries.Last();

            if (lastLessonEntry.Date != lessonEntry.Date)
            {
                return true;
            }

            //Checks starts time of two lesson entries.
            if (lastLessonEntry.StartTime == lessonEntry.StartTime)
            {
                return false;
            }

            //Checks finish time of two lesson entries.
            if (lastLessonEntry.FinishTime == lessonEntry.FinishTime)
            {
                return false;
            }

            //Formats times
            string[] lastEntryTime = TimeMethods.SplitTime(lastLessonEntry.FinishTime);
            string[] newEntryTime = TimeMethods.SplitTime(lessonEntry.StartTime);

            //Calculates time differences
            int minutes = Convert.ToInt16(newEntryTime[1]) - Convert.ToInt16(lastEntryTime[1]);
            int hour = Convert.ToInt16(newEntryTime[0]) - Convert.ToInt16(lastEntryTime[0]);
            int dif = (hour * 60) + minutes;

            //Checks if the new lesson starts before the last lesson.
            if (dif < 0)
            {
                return false;
            }

            return true;
        }

        private static Student GenerateStudent(string studentName)
        {
            //If the student does not exist in list, generates new lastLessonEntry
            Student student = new(studentName);

            //And adds it to list.
            Students.Add(student);

            return student;
        }
    }
}