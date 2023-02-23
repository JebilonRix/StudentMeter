using System.Data;

namespace StudentMeter
{
    public static class DataViewer
    {
        private static readonly DataTable _dataTableTotal = new();
        private static readonly DataTable _dataTableEntries = new();

        public static void Start()
        {
            //Adds columns to data table.
            _dataTableTotal.Columns.Add("Name", typeof(string));
            _dataTableTotal.Columns.Add("Total Hours", typeof(float));
            _dataTableTotal.Columns.Add("Total Debt", typeof(int));
            _dataTableTotal.Columns.Add("Total Paid Money", typeof(int));
            _dataTableTotal.Columns.Add("Difference", typeof(int));

            //Makes columns read only because i dont want to change values via cells except names.
            for (int i = 1; i < _dataTableTotal.Columns.Count; i++)
            {
                _dataTableTotal.Columns[i].ReadOnly = true;
            }

            //Generates columns
            _dataTableEntries.Columns.Add("Student Name", typeof(string));
            _dataTableEntries.Columns.Add("Date", typeof(string));
            _dataTableEntries.Columns.Add("Start", typeof(string));
            _dataTableEntries.Columns.Add("End", typeof(string));
            _dataTableEntries.Columns.Add("Cost", typeof(string));
            _dataTableEntries.Columns.Add("Difference", typeof(string));

            //Makes all columns read only.
            for (int i = 0; i < _dataTableEntries.Columns.Count; i++)
            {
                _dataTableEntries.Columns[i].ReadOnly = true;
            }
        }

        public static void UpdateTotalView(DataGridView dataGridView)
        {
            //Bug guard.
            _dataTableTotal.Clear();

            //Adds data table to data grid view
            foreach (Student student in StudentMethods.Students)
            {
                //Calculates the difference
                float difference = student.TotalDebt - student.TotalPaidMoney;

                //Adds row to data table
                _dataTableTotal.Rows.Add(student.StudentName, student.TotalHours,
                    student.TotalDebt, student.TotalPaidMoney, difference);
            }

            //Loads the data table to data grid view.
            dataGridView.DataSource = _dataTableTotal;
        }

        public static void UpdateEntryView(DataGridView dataGridView, string studentName)
        {
            //Bug guard.
            _dataTableEntries.Clear();

            //This blocks to show last student's lesson entries.
            if (string.IsNullOrEmpty(studentName))
            {
                return;
            }

            //Gets current students lesson entries
            List<LessonEntry> lessonEntries = StudentMethods.GetStudent(studentName).LessonEntries;

            //Adds rows to data table
            for (int i = 0; i < lessonEntries.Count; i++)
            {
                LessonEntry lessonEntry = lessonEntries[i];

                //Adds rows to data table entries.
                _dataTableEntries.Rows.Add(studentName, lessonEntry.Date,
                    lessonEntry.StartTime, lessonEntry.FinishTime, lessonEntry.LessonCost,
                    TimeMethods.CalculateHoursUnsplitted(lessonEntry.StartTime, lessonEntry.FinishTime)
                    * Convert.ToInt16(lessonEntry.LessonCost));
            }

            //Shows the data of data table in data grid view.
            dataGridView.DataSource = _dataTableEntries;
        }
    }
}