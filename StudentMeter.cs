namespace DersTakip
{
    public partial class FollowUpForm : Form
    {
        private readonly List<ComboBox> _comboBoxes = new();
        private string _selectedName = "";

        #region Form

        public FollowUpForm()
        {
            InitializeComponent();
        }

        private void FollowUpForm_Load(object sender, EventArgs e)
        {
            //Adds combo boxes to list.
            _comboBoxes.Add(studentNameComboBox1);
            _comboBoxes.Add(studentNameComboBox2);
            _comboBoxes.Add(studentNameComboBox3);

            //Loads the data
            SaveLoad.Load();

            //Start the data viewer.
            DataViewer.Start();

            //Updates the form.
            UpdateForm();
        }

        private void UpdateForm()
        {
            Student[] students = DebtMethods.Students.ToArray();
            string[] allStudents = new string[students.Length];

            //Gets students' names.
            for (int i = 0; i < students.Length; i++)
            {
                allStudents[i] = students[i].StudentName;
            }

            //Clears combo boxes.
            for (int i = 0; i < _comboBoxes.Count; i++)
            {
                _comboBoxes[i].Text = "";
                _comboBoxes[i].Items.Clear();
            }

            //Adds the names to combo boxes
            for (int j = 0; j < _comboBoxes.Count; j++)
            {
                _comboBoxes[j].Items.AddRange(allStudents);
            }

            //Updates data grid view.
            DataViewer.Update(dataGridViewer);
        }

        #endregion Form

        #region Data Grid View

        private void DataGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the name.
            _selectedName = GetFirstCellValue(e);

            //Changes value of combo boxes to selected name.
            for (int i = 0; i < _comboBoxes.Count; i++)
            {
                _comboBoxes[i].Text = _selectedName;
            }
        }

        private void DataGridViewer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the name.
            string currentName = GetFirstCellValue(e);

            //If selected name and current name are same. Do not update the form.
            if (_selectedName == currentName)
            {
                return;
            }

            //Updates the list of students.
            DebtMethods.UpdateStudent(_selectedName, currentName);

            //Resets selecting name.
            _selectedName = "";

            //Updates data grid view.
            UpdateForm();
        }

        private string GetFirstCellValue(DataGridViewCellEventArgs e)
        {
            //Bug guard
            int index = e.RowIndex;

            //Bug guard
            if (index < 0)
            {
                return "";
            }

            //Gets the row from data grid view.
            DataGridViewRow dataGridViewRow = dataGridViewer.Rows[index];

            //Gets name from cell as string.
            string? result = dataGridViewRow.Cells[0].Value.ToString();

            //Bug guard
            if (result == null)
            {
                return "";
            }

            return result;
        }

        #endregion Data Grid View

        #region Button Methods

        private void CurrentTimeStartButton_Click(object sender, EventArgs e)
        {
            FormMethods.SetTimeToBoxes(startTime_Hour, startTime_Minutes);
        }

        private void CurrentTimeFinishButton_Click(object sender, EventArgs e)
        {
            FormMethods.SetTimeToBoxes(finishTime_Hour, finishTime_Minutes);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Saves the data.
            SaveLoad.Save();

            //Updates data grid view.
            UpdateForm();

            MessageBox.Show("Saved");
        }

        private void AddDebtButton_Click(object sender, EventArgs e)
        {
            //Gets the student's _selectedName from combo box.
            string studentName = studentNameComboBox1.Text;

            //Handle empty areas
            startTime_Hour.Text = TimeMethods.IsEmpty(startTime_Hour.Text);
            startTime_Minutes.Text = TimeMethods.IsEmpty(startTime_Minutes.Text);
            finishTime_Hour.Text = TimeMethods.IsEmpty(finishTime_Hour.Text);
            finishTime_Minutes.Text = TimeMethods.IsEmpty(finishTime_Minutes.Text);

            //Calculates hours.
            float timeDifference = TimeMethods.CalculateHours(startTime_Hour.Text, startTime_Minutes.Text, finishTime_Hour.Text, finishTime_Minutes.Text);

            //Gets the payment of lessons per hour.
            float cost = CustomConvert.ToFloat(costTextBox.Text);

            //Adds debt to the student.
            DebtMethods.AddDebt(studentName, timeDifference, cost);

            //Updates data grid view.
            UpdateForm();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            //Gets the student's _selectedName from combo box.
            string studentName = studentNameComboBox2.Text;

            //Gets the payment value.
            float payment = CustomConvert.ToFloat(paidMoneyTextBox.Text);

            //Paies the debt
            DebtMethods.PayDebt(studentName, payment);

            //Updates data grid view.
            UpdateForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Gets student's _selectedName
            string name = studentNameComboBox3.Text;

            //Gets the student
            Student student = DebtMethods.GetStudent(name);

            //If the _selectedName is exist, deletes it.
            DebtMethods.Students.Remove(student);

            //Updates data grid view.
            UpdateForm();
        }

        private void ShowProfitButton_Click(object sender, EventArgs e)
        {
            //Gets list.
            List<Student> students = DebtMethods.Students;

            float sum = 0;

            //Adds total paid money to the sum.
            for (int i = 0; i < students.Count; i++)
            {
                sum += students[i].TotalPaidMoney;
            }

            MessageBox.Show($"Your profit is = {sum}");
        }

        #endregion Button Methods
    }
}