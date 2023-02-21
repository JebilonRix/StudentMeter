using System.Data;

namespace StudentMeter
{
    public static class DataViewer
    {
        private static readonly DataTable _dataTable = new();

        public static void Start()
        {
            //Adds columns to data table.
            _dataTable.Columns.Add("Name", typeof(string));
            _dataTable.Columns.Add("Total Hours", typeof(float));
            _dataTable.Columns.Add("Total Debt", typeof(int));
            _dataTable.Columns.Add("Total Paid Money", typeof(int));
            _dataTable.Columns.Add("Difference", typeof(int));

            //makes columns read only because i dont want to change values via cells.
            for (int i = 0; i < _dataTable.Columns.Count; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                _dataTable.Columns[i].ReadOnly = true;
            }
        }

        public static void Update(DataGridView dataGridView)
        {
            //Bug guard.
            _dataTable.Clear();

            //Adds data table to data grid view
            foreach (Student student in StudentMethods.Students)
            {
                //Calculates the difference
                float difference = student.TotalDebt - student.TotalPaidMoney;

                //Adds row to data table
                _dataTable.Rows.Add(student.StudentName, student.TotalHours,
                    student.TotalDebt, student.TotalPaidMoney, difference);
            }

            //Loads the data table to data grid view.
            dataGridView.DataSource = _dataTable;
        }

        public static void ShowLessonEntries(DataGridView dataGridView, string studentName)
        {
            DataTable dt = new();

            //Generates columns
            dt.Columns.Add("Student Name", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Start", typeof(string));
            dt.Columns.Add("End", typeof(string));
            dt.Columns.Add("Cost", typeof(string));

            //Makes all columns read only.
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].ReadOnly = true;
            }

            //Gets current students lesson entries
            List<LessonEntry> lessonEntries = StudentMethods.GetStudent(studentName).LessonEntries;

            //Adds rows to data table
            for (int i = 0; i < lessonEntries.Count; i++)
            {
                LessonEntry lessonEntry = lessonEntries[i];

                dt.Rows.Add(studentName, lessonEntry.Date, lessonEntry.StartTime,
                    lessonEntry.FinishTime, lessonEntry.LessonCost);
            }

            //Shows the data of data table in data grid view.
            dataGridView.DataSource = dt;
        }
    }
}