namespace DersTakip
{
    partial class FollowUpForm
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
            this.studentNameComboBox1 = new System.Windows.Forms.ComboBox();
            this.lessonPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.finishTime_Minutes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.startTime_Minutes = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTimeFinishButton = new System.Windows.Forms.Button();
            this.currentTimeStartButton = new System.Windows.Forms.Button();
            this.finishTime_Hour = new System.Windows.Forms.TextBox();
            this.startTime_Hour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.paidMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentNameComboBox2 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteEntryPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.studentNameComboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridViewer = new System.Windows.Forms.DataGridView();
            this.showProfitButton = new System.Windows.Forms.Button();
            this.lessonPanel.SuspendLayout();
            this.paymentPanel.SuspendLayout();
            this.deleteEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // addLessonButton
            // 
            this.addLessonButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLessonButton.Location = new System.Drawing.Point(150, 163);
            this.addLessonButton.Name = "addLessonButton";
            this.addLessonButton.Size = new System.Drawing.Size(100, 40);
            this.addLessonButton.TabIndex = 1;
            this.addLessonButton.Text = "Add";
            this.addLessonButton.UseVisualStyleBackColor = true;
            this.addLessonButton.Click += new System.EventHandler(this.AddDebtButton_Click);
            // 
            // studentNameComboBox1
            // 
            this.studentNameComboBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameComboBox1.FormattingEnabled = true;
            this.studentNameComboBox1.Location = new System.Drawing.Point(150, 15);
            this.studentNameComboBox1.Name = "studentNameComboBox1";
            this.studentNameComboBox1.Size = new System.Drawing.Size(193, 25);
            this.studentNameComboBox1.TabIndex = 2;
            // 
            // lessonPanel
            // 
            this.lessonPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lessonPanel.Controls.Add(this.label11);
            this.lessonPanel.Controls.Add(this.finishTime_Minutes);
            this.lessonPanel.Controls.Add(this.label10);
            this.lessonPanel.Controls.Add(this.startTime_Minutes);
            this.lessonPanel.Controls.Add(this.costTextBox);
            this.lessonPanel.Controls.Add(this.label5);
            this.lessonPanel.Controls.Add(this.currentTimeFinishButton);
            this.lessonPanel.Controls.Add(this.currentTimeStartButton);
            this.lessonPanel.Controls.Add(this.finishTime_Hour);
            this.lessonPanel.Controls.Add(this.startTime_Hour);
            this.lessonPanel.Controls.Add(this.label4);
            this.lessonPanel.Controls.Add(this.label3);
            this.lessonPanel.Controls.Add(this.label1);
            this.lessonPanel.Controls.Add(this.studentNameComboBox1);
            this.lessonPanel.Controls.Add(this.addLessonButton);
            this.lessonPanel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lessonPanel.Location = new System.Drawing.Point(9, 12);
            this.lessonPanel.Name = "lessonPanel";
            this.lessonPanel.Size = new System.Drawing.Size(400, 208);
            this.lessonPanel.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = ":";
            // 
            // finishTime_Minutes
            // 
            this.finishTime_Minutes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishTime_Minutes.Location = new System.Drawing.Point(256, 94);
            this.finishTime_Minutes.Name = "finishTime_Minutes";
            this.finishTime_Minutes.Size = new System.Drawing.Size(75, 24);
            this.finishTime_Minutes.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = ":";
            // 
            // startTime_Minutes
            // 
            this.startTime_Minutes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTime_Minutes.Location = new System.Drawing.Point(256, 53);
            this.startTime_Minutes.Name = "startTime_Minutes";
            this.startTime_Minutes.Size = new System.Drawing.Size(75, 24);
            this.startTime_Minutes.TabIndex = 12;
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costTextBox.Location = new System.Drawing.Point(150, 133);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(193, 24);
            this.costTextBox.TabIndex = 13;
            this.costTextBox.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cost(Hours)";
            // 
            // currentTimeFinishButton
            // 
            this.currentTimeFinishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentTimeFinishButton.Location = new System.Drawing.Point(360, 96);
            this.currentTimeFinishButton.Name = "currentTimeFinishButton";
            this.currentTimeFinishButton.Size = new System.Drawing.Size(20, 20);
            this.currentTimeFinishButton.TabIndex = 11;
            this.currentTimeFinishButton.UseVisualStyleBackColor = false;
            this.currentTimeFinishButton.Click += new System.EventHandler(this.CurrentTimeFinishButton_Click);
            // 
            // currentTimeStartButton
            // 
            this.currentTimeStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentTimeStartButton.Location = new System.Drawing.Point(360, 55);
            this.currentTimeStartButton.Name = "currentTimeStartButton";
            this.currentTimeStartButton.Size = new System.Drawing.Size(20, 20);
            this.currentTimeStartButton.TabIndex = 10;
            this.currentTimeStartButton.UseVisualStyleBackColor = false;
            this.currentTimeStartButton.Click += new System.EventHandler(this.CurrentTimeStartButton_Click);
            // 
            // finishTime_Hour
            // 
            this.finishTime_Hour.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishTime_Hour.Location = new System.Drawing.Point(150, 93);
            this.finishTime_Hour.Name = "finishTime_Hour";
            this.finishTime_Hour.Size = new System.Drawing.Size(75, 24);
            this.finishTime_Hour.TabIndex = 9;
            // 
            // startTime_Hour
            // 
            this.startTime_Hour.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTime_Hour.Location = new System.Drawing.Point(150, 53);
            this.startTime_Hour.Name = "startTime_Hour";
            this.startTime_Hour.Size = new System.Drawing.Size(75, 24);
            this.startTime_Hour.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Finish Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name(Student)";
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentPanel.Controls.Add(this.addPaymentButton);
            this.paymentPanel.Controls.Add(this.paidMoneyTextBox);
            this.paymentPanel.Controls.Add(this.label7);
            this.paymentPanel.Controls.Add(this.label6);
            this.paymentPanel.Controls.Add(this.studentNameComboBox2);
            this.paymentPanel.Location = new System.Drawing.Point(9, 226);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(401, 127);
            this.paymentPanel.TabIndex = 5;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPaymentButton.Location = new System.Drawing.Point(150, 81);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(100, 40);
            this.addPaymentButton.TabIndex = 15;
            this.addPaymentButton.Text = "Add";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // paidMoneyTextBox
            // 
            this.paidMoneyTextBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paidMoneyTextBox.Location = new System.Drawing.Point(150, 51);
            this.paidMoneyTextBox.Name = "paidMoneyTextBox";
            this.paidMoneyTextBox.Size = new System.Drawing.Size(193, 24);
            this.paidMoneyTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Paid Money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name(Student)";
            // 
            // studentNameComboBox2
            // 
            this.studentNameComboBox2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameComboBox2.FormattingEnabled = true;
            this.studentNameComboBox2.Location = new System.Drawing.Point(150, 13);
            this.studentNameComboBox2.Name = "studentNameComboBox2";
            this.studentNameComboBox2.Size = new System.Drawing.Size(193, 25);
            this.studentNameComboBox2.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 441);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteEntryPanel
            // 
            this.deleteEntryPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteEntryPanel.Controls.Add(this.deleteButton);
            this.deleteEntryPanel.Controls.Add(this.label8);
            this.deleteEntryPanel.Controls.Add(this.studentNameComboBox3);
            this.deleteEntryPanel.Location = new System.Drawing.Point(8, 359);
            this.deleteEntryPanel.Name = "deleteEntryPanel";
            this.deleteEntryPanel.Size = new System.Drawing.Size(401, 71);
            this.deleteEntryPanel.TabIndex = 7;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(151, 36);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 31);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name(Student)";
            // 
            // studentNameComboBox3
            // 
            this.studentNameComboBox3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNameComboBox3.FormattingEnabled = true;
            this.studentNameComboBox3.Location = new System.Drawing.Point(151, 5);
            this.studentNameComboBox3.Name = "studentNameComboBox3";
            this.studentNameComboBox3.Size = new System.Drawing.Size(193, 25);
            this.studentNameComboBox3.TabIndex = 6;
            // 
            // dataGridViewer
            // 
            this.dataGridViewer.AllowUserToAddRows = false;
            this.dataGridViewer.AllowUserToDeleteRows = false;
            this.dataGridViewer.AllowUserToResizeRows = false;
            this.dataGridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewer.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewer.Location = new System.Drawing.Point(463, 0);
            this.dataGridViewer.Name = "dataGridViewer";
            this.dataGridViewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewer.RowHeadersWidth = 20;
            this.dataGridViewer.RowTemplate.Height = 25;
            this.dataGridViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewer.ShowCellErrors = false;
            this.dataGridViewer.ShowCellToolTips = false;
            this.dataGridViewer.ShowRowErrors = false;
            this.dataGridViewer.Size = new System.Drawing.Size(544, 483);
            this.dataGridViewer.TabIndex = 10;
            this.dataGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewer_CellClick);
            this.dataGridViewer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewer_CellValueChanged);
            // 
            // showProfitButton
            // 
            this.showProfitButton.Location = new System.Drawing.Point(159, 441);
            this.showProfitButton.Name = "showProfitButton";
            this.showProfitButton.Size = new System.Drawing.Size(125, 25);
            this.showProfitButton.TabIndex = 11;
            this.showProfitButton.Text = "Profit";
            this.showProfitButton.UseVisualStyleBackColor = true;
            this.showProfitButton.Click += new System.EventHandler(this.ShowProfitButton_Click);
            // 
            // FollowUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 483);
            this.Controls.Add(this.showProfitButton);
            this.Controls.Add(this.dataGridViewer);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteEntryPanel);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.lessonPanel);
            this.Name = "FollowUpForm";
            this.Text = "StudentMeter";
            this.Load += new System.EventHandler(this.FollowUpForm_Load);
            this.lessonPanel.ResumeLayout(false);
            this.lessonPanel.PerformLayout();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.deleteEntryPanel.ResumeLayout(false);
            this.deleteEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button addLessonButton;
        private Button addPaymentButton;
        private Button currentTimeFinishButton;
        private Button currentTimeStartButton;
        private Button deleteButton;
        private Button saveButton;
        private ComboBox studentNameComboBox1;
        private ComboBox studentNameComboBox2;
        private ComboBox studentNameComboBox3;
        private DataGridView dataGridViewer;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel deleteEntryPanel;
        private Panel lessonPanel;
        private Panel paymentPanel;
        private TextBox costTextBox;
        private TextBox finishTime_Hour;
        private TextBox paidMoneyTextBox;
        private TextBox startTime_Hour;
        private Button showProfitButton;
        private Label label10;
        private TextBox startTime_Minutes;
        private Label label11;
        private TextBox finishTime_Minutes;
    }
}