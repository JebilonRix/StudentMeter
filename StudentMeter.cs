namespace StudentMeter
{
    public partial class StudentMeterForm : Form
    {
        private const string _errorHeader = "Error!";
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

            //Clears selected studentName.
            studentNameComboBox.Text = currentStudentName;

            //Updates data grid view.
            DataViewer.UpdateTotalView(dataGridView_TotalValues);
            DataViewer.UpdateEntryView(dataGridView_LessonEntry, studentNameComboBox.Text);

            if (currentStudentName != "")
            {
                SelectRowViaStudentName(currentStudentName);
            }
        }

        #endregion Form

        #region Data Grid View

        private void SelectRowViaStudentName(string selectedStudentName)
        {
            foreach (DataGridViewRow row in dataGridView_TotalValues.Rows)
            {
                if (row.Cells["Name"].Value?.ToString() == selectedStudentName)
                {
                    //Makes row selected
                    row.Selected = true;

                    //Sets current cell.
                    dataGridView_TotalValues.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void DataGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the studentName.
            _selectedName = GetFirstCellValue(e);

            //Changes value of combo boxes to selected studentName.
            studentNameComboBox.Text = _selectedName;
        }

        private void DataGridViewer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the studentName.
            string currentName = GetFirstCellValue(e);

            //If selected studentName and current studentName are same. Do not update the form.
            if (_selectedName == currentName)
            {
                return;
            }

            //Updates the list of students.
            StudentMethods.UpdateStudent(_selectedName, currentName);

            //Resets selecting studentName.
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

            //Gets studentName from cell as string.
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

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            //Gets the name from studentNameComboBox
            string studentName = studentNameComboBox.Text;

            //Checks if the student name is empty.
            if (string.IsNullOrEmpty(studentName))
            {
                MessageBox.Show("Please enter a studentName.");
                return;
            }

            //Checks if the student already exists.
            if (StudentMethods.DoesStudentExist(studentName))
            {
                MessageBox.Show("Student has already existed.");
                return;
            }

            //Adds the student.
            StudentMethods.AddStudent(studentName);

            //Updates the form
            UpdateForm(studentName);
        }

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

        private void AddDebtButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentNameComboBox.Text))
            {
                MessageBox.Show("There is no studentName. Please select a student studentName or enter new studentName.");
                return;
            }

            //Gets the payment of lessons per hour.
            string costText = costTextBox.Text;
            int costValue;

            try
            {
                costValue = Convert.ToInt16(costText);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, _errorHeader);
                costTextBox.Text = "00";
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, _errorHeader);
                costTextBox.Text = "32767";
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
            float timeDifference = TimeMethods.CalculateHoursSplitted(startTime_Hour.Text, startTime_Minutes.Text,
                finishTime_Hour.Text, finishTime_Minutes.Text);

            //Adds debt to the student.
            StudentMethods.AddDebt(studentName, timeDifference, costValue);

            //Updates data grid view.
            UpdateForm(studentName);

            //Auto-save
            SaveLoad.Save();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            //Checks if student name is selected
            if (string.IsNullOrEmpty(studentNameComboBox.Text))
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            //Gets payment text from paidMoneyTextBox
            string paymentText = paidMoneyTextBox.Text;

            //Converts payment text to payment value
            int paymentValue;

            try
            {
                paymentValue = Convert.ToInt16(paymentText);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, _errorHeader);
                paidMoneyTextBox.Text = "0";
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, _errorHeader);
                paidMoneyTextBox.Text = "32767";
                return;
            }

            //Get the name of the selected student
            string studentName = studentNameComboBox.Text;

            //Paies the debt of the student.
            StudentMethods.PayDebt(studentName, paymentValue);

            //Updates data grid view.
            UpdateForm(studentName);

            //Auto-save the changes
            SaveLoad.Save();

            MessageBox.Show("Payment is added.");
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

            if (!StudentMethods.DoesStudentExist(name))
            {
                MessageBox.Show("Student does not exist. The deleting is cancelled.");
                return;
            }

            //Gets the student
            Student student = StudentMethods.GetStudent(name);

            //If the _selectedName is exist, deletes it.
            StudentMethods.Students.Remove(student);

            //Saves the data.
            SaveLoad.Save();

            //Updates data grid view.
            UpdateForm("");
        }

        private void StudentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Null check
            if (string.IsNullOrEmpty(studentNameComboBox.Text))
            {
                return;
            }

            //Gets name from combo box
            string selectedStudentName = studentNameComboBox.Text;

            //update entry grid view
            DataViewer.UpdateEntryView(dataGridView_LessonEntry, selectedStudentName);

            //select the row from dataGridView_TotalValues
            SelectRowViaStudentName(selectedStudentName);
        }

        #endregion Button Methods

        #region Input Handling

        private void StartTime_Hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckNumber(e);
        }

        private void StartTime_Minutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckNumber(e);
        }

        private void FinishTime_Hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckNumber(e);
        }

        private void FinishTime_Minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckNumber(e);
        }

        private void StudentNameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckName(e);
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckNumber(e);
        }

        private void PaidMoneyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckNumber(e);
        }

        //Todo: çalýþmýyor
        private void DataGridView_TotalValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FormMethods.InputCheckName(e);
        }

        #endregion Input Handling
    }
}