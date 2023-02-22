namespace StudentMeter
{
    public partial class StudentMeterForm : Form
    {
        private string _selectedName = "";

        #region Form

        public StudentMeterForm()
        {
            InitializeComponent();
        }

        private void FollowUpForm_Load(object sender, EventArgs e)
        {
            //Loads the data
            SaveLoad.Load();

            //Start the data viewer.
            DataViewer.Start();

            //Updates the form.
            UpdateForm("");
        }

        private void UpdateForm(string currentStudentName)
        {
            Student[] students = StudentMethods.Students.ToArray();
            string[] nameOfStudents = new string[students.Length];

            //Gets students' names.
            for (int i = 0; i < students.Length; i++)
            {
                nameOfStudents[i] = students[i].StudentName;
            }

            //Clears combo box.
            studentNameComboBox.Items.Clear();

            //Adds the names to combo box
            studentNameComboBox.Items.AddRange(nameOfStudents);

            //Clears selected name.
            studentNameComboBox.Text = currentStudentName;

            //Updates data grid view.
            DataViewer.UpdateTotalView(dataGridView_TotalValues);
            DataViewer.UpdateEntryView(dataGridView_LessonEntry, studentNameComboBox.Text);
        }

        #endregion Form

        #region Data Grid View

        private void DataGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the name.
            _selectedName = GetFirstCellValue(e);

            //Changes value of combo boxes to selected name.
            studentNameComboBox.Text = _selectedName;
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
            StudentMethods.UpdateStudent(_selectedName, currentName);

            //Resets selecting name.
            _selectedName = "";

            //Updates data grid view.
            UpdateForm(currentName);
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
            DataGridViewRow dataGridViewRow = dataGridView_TotalValues.Rows[index];

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
            //Sets current time to text boxes.
            FormMethods.SetTimeToBoxes(startTime_Hour, startTime_Minutes);
        }

        private void CurrentTimeFinishButton_Click(object sender, EventArgs e)
        {
            //Sets current time to text boxes.
            FormMethods.SetTimeToBoxes(finishTime_Hour, finishTime_Minutes);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Saves the data.
            SaveLoad.Save();

            //Updates data grid view.
            UpdateForm("");
        }

        private void AddDebtButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentNameComboBox.Text))
            {
                MessageBox.Show("There is no name. Please select a student name or enter new name.");
                return;
            }

            //Handle empty areas
            startTime_Hour.Text = TimeMethods.FixFormatting(startTime_Hour.Text);
            startTime_Minutes.Text = TimeMethods.FixFormatting(startTime_Minutes.Text);
            finishTime_Hour.Text = TimeMethods.FixFormatting(finishTime_Hour.Text);
            finishTime_Minutes.Text = TimeMethods.FixFormatting(finishTime_Minutes.Text);

            if (Convert.ToInt16(startTime_Hour.Text) > 23 || Convert.ToInt16(finishTime_Hour.Text) > 23)
            {
                MessageBox.Show("Hours can not be bigger than 23.");
                return;
            }

            if (Convert.ToInt16(startTime_Minutes.Text) > 59 || Convert.ToInt16(finishTime_Minutes.Text) > 59)
            {
                MessageBox.Show("Minutes can not be bigger than 59.");
                return;
            }

            //Gets the student's _selectedName from combo box.
            string studentName = studentNameComboBox.Text;

            //Handle formating.
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string startTime = startTime_Hour.Text + ":" + startTime_Minutes.Text;
            string finishTime = finishTime_Hour.Text + ":" + finishTime_Minutes.Text;
            string costText = costTextBox.Text;

            //Generates new lesson entry
            LessonEntry lessonEntry = new(date, startTime, finishTime, costText);

            //Handles lesson lessonEntry and adds it to the student.
            Student student = StudentMethods.GetStudent(studentName);

            //Check if last lesson and new entry is same or not. If they are same, the method do not continue.
            if (StudentMethods.CheckLastLessonWithCurrentLesson(student, lessonEntry) == false)
            {
                MessageBox.Show("Lesson entries cannot be the same or a new lesson entry cannot be started before the last lesson entry.");
                return;
            }

            //Adds lesson entry to student.
            student.LessonEntries.Add(lessonEntry);

            //Calculates hours.
            float timeDifference = TimeMethods.CalculateHoursSplitted(startTime_Hour.Text, startTime_Minutes.Text, finishTime_Hour.Text, finishTime_Minutes.Text);

            //Gets the payment of lessons per hour.
            int cost = Convert.ToInt16(costText);

            //Adds debt to the student.
            StudentMethods.AddDebt(studentName, timeDifference, cost);

            //Updates data grid view.
            UpdateForm(studentName);

            //Auto-save
            SaveLoad.Save();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentNameComboBox.Text))
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            //Gets the student's _selectedName from combo box.
            string studentName = studentNameComboBox.Text;

            //Gets the payment value.
            int payment = Convert.ToInt16(paidMoneyTextBox.Text);

            //Paies the debt
            StudentMethods.PayDebt(studentName, payment);

            //Updates data grid view.
            UpdateForm(studentName);

            //Auto-save
            SaveLoad.Save();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentNameComboBox.Text))
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            //Gets student's _selectedName
            string name = studentNameComboBox.Text;

            //Gets the student
            Student student = StudentMethods.GetStudent(name);

            //If the _selectedName is exist, deletes it.
            StudentMethods.Students.Remove(student);

            //Updates data grid view.
            UpdateForm("");
        }

        private void StudentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataViewer.UpdateEntryView(dataGridView_LessonEntry, studentNameComboBox.Text);
        }

        #endregion Button Methods
    }
}