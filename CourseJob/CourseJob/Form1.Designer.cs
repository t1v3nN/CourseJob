namespace CourseJob
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGroupRating = new System.Windows.Forms.TextBox();
            this.btnGroupRating = new System.Windows.Forms.Button();
            this.btnFacultyRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "ім'я";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(12, 38);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(150, 20);
            this.txtGroup.TabIndex = 1;
            this.txtGroup.Text = "группа";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 64);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(150, 23);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Додати студента";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(12, 93);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(150, 147);
            this.lbStudents.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(168, 12);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(150, 20);
            this.txtSubject.TabIndex = 4;
            this.txtSubject.Text = "предмет";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(168, 38);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(150, 20);
            this.txtGrade.TabIndex = 5;
            this.txtGrade.Text = "оцінка";
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(168, 64);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(150, 23);
            this.btnAddGrade.TabIndex = 6;
            this.btnAddGrade.Text = "Додати оцінку";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(324, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 7;
             this.txtSearch.Text = "пошук";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(324, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGroupRating
            // 
            this.txtGroupRating.Location = new System.Drawing.Point(324, 93);
            this.txtGroupRating.Name = "txtGroupRating";
            this.txtGroupRating.Size = new System.Drawing.Size(150, 20);
            this.txtGroupRating.TabIndex = 9;
            // 
            // btnGroupRating
            // 
            this.btnGroupRating.Location = new System.Drawing.Point(324, 119);
            this.btnGroupRating.Name = "btnGroupRating";
            this.btnGroupRating.Size = new System.Drawing.Size(150, 23);
            this.btnGroupRating.TabIndex = 10;
            this.btnGroupRating.Text = "Рейтинг групи";
            this.btnGroupRating.UseVisualStyleBackColor = true;
            this.btnGroupRating.Click += new System.EventHandler(this.btnGroupRating_Click);
            // 
            // btnFacultyRating
            // 
            this.btnFacultyRating.Location = new System.Drawing.Point(324, 148);
            this.btnFacultyRating.Name = "btnFacultyRating";
            this.btnFacultyRating.Size = new System.Drawing.Size(150, 23);
            this.btnFacultyRating.TabIndex = 11;
            this.btnFacultyRating.Text = "Загальний рейтинг";
            this.btnFacultyRating.UseVisualStyleBackColor = true;
            this.btnFacultyRating.Click += new System.EventHandler(this.btnFacultyRating_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 253);
            this.Controls.Add(this.btnFacultyRating);
            this.Controls.Add(this.btnGroupRating);
            this.Controls.Add(this.txtGroupRating);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtName);
            this.Name = "MainForm";
            this.Text = "Факультет";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    


        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtGroupRating;
        private System.Windows.Forms.Button btnGroupRating;
        private System.Windows.Forms.Button btnFacultyRating;
    }
}

