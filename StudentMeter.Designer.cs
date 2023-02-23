namespace StudentMeter
{
    partial class StudentMeterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param _selectedName="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addLessonButton = new System.Windows.Forms.Button();
            this.studentNameComboBox = new System.Windows.Forms.ComboBox();
            this.lessonPanel = new System.Windows.Forms.Panel();
            this.label_FinishTime_Middle = new System.Windows.Forms.Label();
            this.finishTime_Minutes = new System.Windows.Forms.TextBox();
            this.label_StartTime_Middle = new System.Windows.Forms.Label();
            this.startTime_Minutes = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label_Cost = new System.Windows.Forms.Label();
            this.currentTimeFinishButton = new System.Windows.Forms.Button();
            this.currentTimeStartButton = new System.Windows.Forms.Button();
            this.finishTime_Hour = new System.Windows.Forms.TextBox();
            this.startTime_Hour = new System.Windows.Forms.TextBox();
            this.label_FinishTime = new System.Windows.Forms.Label();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.paidMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label_Money = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView_TotalValues = new System.Windows.Forms.DataGridView();
            this.dataGridView_LessonEntry = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lessonPanel.SuspendLayout();
            this.paymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TotalValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LessonEntry)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLessonButton
            // 
            this.addLessonButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLessonButton.Location = new System.Drawing.Point(143, 125);
            this.addLessonButton.Name = "addLessonButton";
            this.addLessonButton.Size = new System.Drawing.Size(181, 40);
            this.addLessonButton.TabIndex = 9;
            this.addLessonButton.Text = "Add Lesson Entry";
            this.addLessonButton.UseVisualStyleBackColor = true;
            this.addLessonButton.Click += new System.EventHandler(this.AddDebtButton_Click);
            // 
            // studentNameComboBox
            // 
            this.studentNameComboBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(156, 11);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(240, 25);
            this.studentNameComboBox.TabIndex = 1;
            this.studentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentNameComboBox_SelectedIndexChanged);
            // 
            // lessonPanel
            // 
            this.lessonPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lessonPanel.Controls.Add(this.label_FinishTime_Middle);
            this.lessonPanel.Controls.Add(this.finishTime_Minutes);
            this.lessonPanel.Controls.Add(this.label_StartTime_Middle);
            this.lessonPanel.Controls.Add(this.startTime_Minutes);
            this.lessonPanel.Controls.Add(this.costTextBox);
            this.lessonPanel.Controls.Add(this.label_Cost);
            this.lessonPanel.Controls.Add(this.currentTimeFinishButton);
            this.lessonPanel.Controls.Add(this.currentTimeStartButton);
            this.lessonPanel.Controls.Add(this.finishTime_Hour);
            this.lessonPanel.Controls.Add(this.startTime_Hour);
            this.lessonPanel.Controls.Add(this.label_FinishTime);
            this.lessonPanel.Controls.Add(this.label_StartTime);
            this.lessonPanel.Controls.Add(this.addLessonButton);
            this.lessonPanel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lessonPanel.Location = new System.Drawing.Point(12, 42);
            this.lessonPanel.Name = "lessonPanel";
            this.lessonPanel.Size = new System.Drawing.Size(384, 175);
            this.lessonPanel.TabIndex = 3;
            // 
            // label_FinishTime_Middle
            // 
            this.label_FinishTime_Middle.AutoSize = true;
            this.label_FinishTime_Middle.Location = new System.Drawing.Point(224, 61);
            this.label_FinishTime_Middle.Name = "label_FinishTime_Middle";
            this.label_FinishTime_Middle.Size = new System.Drawing.Size(17, 17);
            this.label_FinishTime_Middle.TabIndex = 16;
            this.label_FinishTime_Middle.Text = ":";
            // 
            // finishTime_Minutes
            // 
            this.finishTime_Minutes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishTime_Minutes.Location = new System.Drawing.Point(249, 56);
            this.finishTime_Minutes.MaxLength = 59;
            this.finishTime_Minutes.Name = "finishTime_Minutes";
            this.finishTime_Minutes.Size = new System.Drawing.Size(75, 24);
            this.finishTime_Minutes.TabIndex = 6;
            // 
            // label_StartTime_Middle
            // 
            this.label_StartTime_Middle.AutoSize = true;
            this.label_StartTime_Middle.Location = new System.Drawing.Point(224, 20);
            this.label_StartTime_Middle.Name = "label_StartTime_Middle";
            this.label_StartTime_Middle.Size = new System.Drawing.Size(17, 17);
            this.label_StartTime_Middle.TabIndex = 14;
            this.label_StartTime_Middle.Text = ":";
            // 
            // startTime_Minutes
            // 
            this.startTime_Minutes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTime_Minutes.Location = new System.Drawing.Point(249, 15);
            this.startTime_Minutes.MaxLength = 59;
            this.startTime_Minutes.Name = "startTime_Minutes";
            this.startTime_Minutes.Size = new System.Drawing.Size(75, 24);
            this.startTime_Minutes.TabIndex = 3;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costTextBox.Location = new System.Drawing.Point(143, 93);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(181, 24);
            this.costTextBox.TabIndex = 8;
            this.costTextBox.Text = "50";
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Cost.Location = new System.Drawing.Point(13, 98);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(107, 17);
            this.label_Cost.TabIndex = 12;
            this.label_Cost.Text = "Cost(Hours)";
            // 
            // currentTimeFinishButton
            // 
            this.currentTimeFinishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentTimeFinishButton.Location = new System.Drawing.Point(330, 58);
            this.currentTimeFinishButton.Name = "currentTimeFinishButton";
            this.currentTimeFinishButton.Size = new System.Drawing.Size(20, 20);
            this.currentTimeFinishButton.TabIndex = 7;
            this.currentTimeFinishButton.UseVisualStyleBackColor = false;
            this.currentTimeFinishButton.Click += new System.EventHandler(this.CurrentTimeFinishButton_Click);
            // 
            // currentTimeStartButton
            // 
            this.currentTimeStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentTimeStartButton.Location = new System.Drawing.Point(330, 16);
            this.currentTimeStartButton.Name = "currentTimeStartButton";
            this.currentTimeStartButton.Size = new System.Drawing.Size(20, 20);
            this.currentTimeStartButton.TabIndex = 4;
            this.currentTimeStartButton.UseVisualStyleBackColor = false;
            this.currentTimeStartButton.Click += new System.EventHandler(this.CurrentTimeStartButton_Click);
            // 
            // finishTime_Hour
            // 
            this.finishTime_Hour.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishTime_Hour.Location = new System.Drawing.Point(143, 55);
            this.finishTime_Hour.MaxLength = 23;
            this.finishTime_Hour.Name = "finishTime_Hour";
            this.finishTime_Hour.Size = new System.Drawing.Size(75, 24);
            this.finishTime_Hour.TabIndex = 5;
            // 
            // startTime_Hour
            // 
            this.startTime_Hour.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTime_Hour.Location = new System.Drawing.Point(143, 15);
            this.startTime_Hour.MaxLength = 23;
            this.startTime_Hour.Name = "startTime_Hour";
            this.startTime_Hour.Size = new System.Drawing.Size(75, 24);
            this.startTime_Hour.TabIndex = 2;
            // 
            // label_FinishTime
            // 
            this.label_FinishTime.AutoSize = true;
            this.label_FinishTime.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_FinishTime.Location = new System.Drawing.Point(13, 60);
            this.label_FinishTime.Name = "label_FinishTime";
            this.label_FinishTime.Size = new System.Drawing.Size(107, 17);
            this.label_FinishTime.TabIndex = 7;
            this.label_FinishTime.Text = "Finish Time";
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_StartTime.Location = new System.Drawing.Point(13, 20);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(98, 17);
            this.label_StartTime.TabIndex = 6;
            this.label_StartTime.Text = "Start Time";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(12, 15);
            this.label_Name.Margin = new System.Windows.Forms.Padding(3);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(125, 17);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name(Student)";
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentPanel.Controls.Add(this.addPaymentButton);
            this.paymentPanel.Controls.Add(this.paidMoneyTextBox);
            this.paymentPanel.Controls.Add(this.label_Money);
            this.paymentPanel.Location = new System.Drawing.Point(12, 223);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(384, 95);
            this.paymentPanel.TabIndex = 5;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPaymentButton.Location = new System.Drawing.Point(142, 44);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(182, 40);
            this.addPaymentButton.TabIndex = 11;
            this.addPaymentButton.Text = "Enter Payment";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // paidMoneyTextBox
            // 
            this.paidMoneyTextBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paidMoneyTextBox.Location = new System.Drawing.Point(143, 14);
            this.paidMoneyTextBox.Name = "paidMoneyTextBox";
            this.paidMoneyTextBox.Size = new System.Drawing.Size(181, 24);
            this.paidMoneyTextBox.TabIndex = 10;
            // 
            // label_Money
            // 
            this.label_Money.AutoSize = true;
            this.label_Money.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Money.Location = new System.Drawing.Point(13, 18);
            this.label_Money.Margin = new System.Windows.Forms.Padding(3);
            this.label_Money.Name = "label_Money";
            this.label_Money.Size = new System.Drawing.Size(53, 17);
            this.label_Money.TabIndex = 6;
            this.label_Money.Text = "Money";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(214, 324);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 30);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(12, 324);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(196, 30);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete Student";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView_TotalValues
            // 
            this.dataGridView_TotalValues.AllowUserToAddRows = false;
            this.dataGridView_TotalValues.AllowUserToDeleteRows = false;
            this.dataGridView_TotalValues.AllowUserToResizeRows = false;
            this.dataGridView_TotalValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TotalValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_TotalValues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TotalValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_TotalValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_TotalValues.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_TotalValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_TotalValues.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_TotalValues.Name = "dataGridView_TotalValues";
            this.dataGridView_TotalValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_TotalValues.RowHeadersWidth = 20;
            this.dataGridView_TotalValues.RowTemplate.Height = 25;
            this.dataGridView_TotalValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_TotalValues.ShowCellErrors = false;
            this.dataGridView_TotalValues.ShowCellToolTips = false;
            this.dataGridView_TotalValues.ShowRowErrors = false;
            this.dataGridView_TotalValues.Size = new System.Drawing.Size(1008, 254);
            this.dataGridView_TotalValues.TabIndex = 999;
            this.dataGridView_TotalValues.TabStop = false;
            this.dataGridView_TotalValues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewer_CellClick);
            this.dataGridView_TotalValues.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewer_CellValueChanged);
            // 
            // dataGridView_LessonEntry
            // 
            this.dataGridView_LessonEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LessonEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_LessonEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LessonEntry.Location = new System.Drawing.Point(0, 260);
            this.dataGridView_LessonEntry.Name = "dataGridView_LessonEntry";
            this.dataGridView_LessonEntry.RowTemplate.Height = 25;
            this.dataGridView_LessonEntry.Size = new System.Drawing.Size(585, 362);
            this.dataGridView_LessonEntry.TabIndex = 999;
            this.dataGridView_LessonEntry.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.RosyBrown;
            this.panelMain.Controls.Add(this.label_Name);
            this.panelMain.Controls.Add(this.deleteButton);
            this.panelMain.Controls.Add(this.studentNameComboBox);
            this.panelMain.Controls.Add(this.lessonPanel);
            this.panelMain.Controls.Add(this.saveButton);
            this.panelMain.Controls.Add(this.paymentPanel);
            this.panelMain.Location = new System.Drawing.Point(591, 260);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(411, 362);
            this.panelMain.TabIndex = 19;
            // 
            // StudentMeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.dataGridView_LessonEntry);
            this.Controls.Add(this.dataGridView_TotalValues);
            this.Name = "StudentMeterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMeter";
            this.Load += new System.EventHandler(this.FollowUpForm_Load);
            this.lessonPanel.ResumeLayout(false);
            this.lessonPanel.PerformLayout();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TotalValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LessonEntry)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button addLessonButton;
        private Button addPaymentButton;
        private Button currentTimeFinishButton;
        private Button currentTimeStartButton;
        private Button deleteButton;
        private Button saveButton;
        private ComboBox studentNameComboBox;
        private DataGridView dataGridView_LessonEntry;
        private DataGridView dataGridView_TotalValues;
        private Label label_Cost;
        private Label label_FinishTime;
        private Label label_FinishTime_Middle;
        private Label label_Money;
        private Label label_Name;
        private Label label_StartTime;
        private Label label_StartTime_Middle;
        private Panel lessonPanel;
        private Panel panelMain;
        private Panel paymentPanel;
        private TextBox costTextBox;
        private TextBox finishTime_Hour;
        private TextBox finishTime_Minutes;
        private TextBox paidMoneyTextBox;
        private TextBox startTime_Hour;
        private TextBox startTime_Minutes;
    }
}