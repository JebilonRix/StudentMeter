using System.Data;

namespace DersTakip
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
            _dataTable.Columns[1].ReadOnly = true;
            _dataTable.Columns[2].ReadOnly = true;
            _dataTable.Columns[3].ReadOnly = true;
            _dataTable.Columns[4].ReadOnly = true;
        }

        public static void Update(DataGridView dataGridView)
        {
            //Bug guard.
            _dataTable.Clear();

            //Adds data table to data grid view
            foreach (Student student in DebtMethods.Students)
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
    }
}