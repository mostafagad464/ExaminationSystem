
namespace The_Box_v0._1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Contaunter = new System.Windows.Forms.TabControl();
            this.StudentLabel = new System.Windows.Forms.TabPage();
            this.student_tap_control = new System.Windows.Forms.TabControl();
            this.ShowStudents = new System.Windows.Forms.TabPage();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.TabPage();
            this.Instructor_label = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ShowInstructors = new System.Windows.Forms.TabPage();
            this.AddInstructor = new System.Windows.Forms.TabPage();
            this.Courses_label = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AddCourse = new System.Windows.Forms.TabPage();
            this.DeleteCourse = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.UpdateStudent = new System.Windows.Forms.TabPage();
            this.DeleteStudent = new System.Windows.Forms.TabPage();
            this.UpdateInstructor = new System.Windows.Forms.TabPage();
            this.DeleteInstructor = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Report1 = new System.Windows.Forms.TabPage();
            this.Report2 = new System.Windows.Forms.TabPage();
            this.Report3 = new System.Windows.Forms.TabPage();
            this.Report4 = new System.Windows.Forms.TabPage();
            this.Report5 = new System.Windows.Forms.TabPage();
            this.Report6 = new System.Windows.Forms.TabPage();
            this.Report7 = new System.Windows.Forms.TabPage();
            this.Contaunter.SuspendLayout();
            this.StudentLabel.SuspendLayout();
            this.student_tap_control.SuspendLayout();
            this.ShowStudents.SuspendLayout();
            this.Instructor_label.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Courses_label.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contaunter
            // 
            this.Contaunter.Controls.Add(this.StudentLabel);
            this.Contaunter.Controls.Add(this.Instructor_label);
            this.Contaunter.Controls.Add(this.Courses_label);
            this.Contaunter.Controls.Add(this.tabPage5);
            this.Contaunter.Location = new System.Drawing.Point(1, 15);
            this.Contaunter.Margin = new System.Windows.Forms.Padding(4);
            this.Contaunter.Name = "Contaunter";
            this.Contaunter.SelectedIndex = 0;
            this.Contaunter.Size = new System.Drawing.Size(1064, 638);
            this.Contaunter.TabIndex = 0;
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.StudentLabel.Controls.Add(this.student_tap_control);
            this.StudentLabel.Location = new System.Drawing.Point(4, 25);
            this.StudentLabel.Margin = new System.Windows.Forms.Padding(4);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Padding = new System.Windows.Forms.Padding(4);
            this.StudentLabel.Size = new System.Drawing.Size(1056, 609);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Student";
            this.StudentLabel.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // student_tap_control
            // 
            this.student_tap_control.Controls.Add(this.ShowStudents);
            this.student_tap_control.Controls.Add(this.AddStudent);
            this.student_tap_control.Controls.Add(this.UpdateStudent);
            this.student_tap_control.Controls.Add(this.DeleteStudent);
            this.student_tap_control.ItemSize = new System.Drawing.Size(150, 21);
            this.student_tap_control.Location = new System.Drawing.Point(8, 7);
            this.student_tap_control.Margin = new System.Windows.Forms.Padding(4);
            this.student_tap_control.Name = "student_tap_control";
            this.student_tap_control.Padding = new System.Drawing.Point(0, 3);
            this.student_tap_control.SelectedIndex = 0;
            this.student_tap_control.Size = new System.Drawing.Size(1037, 594);
            this.student_tap_control.TabIndex = 0;
            // 
            // ShowStudents
            // 
            this.ShowStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ShowStudents.Controls.Add(this.passwordText);
            this.ShowStudents.Controls.Add(this.UserNameText);
            this.ShowStudents.Controls.Add(this.button3);
            this.ShowStudents.Controls.Add(this.button1);
            this.ShowStudents.Location = new System.Drawing.Point(4, 25);
            this.ShowStudents.Margin = new System.Windows.Forms.Padding(4);
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Padding = new System.Windows.Forms.Padding(4);
            this.ShowStudents.Size = new System.Drawing.Size(1029, 565);
            this.ShowStudents.TabIndex = 0;
            this.ShowStudents.Text = "Show Students";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.Turquoise;
            this.passwordText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.passwordText.Location = new System.Drawing.Point(301, 222);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(271, 48);
            this.passwordText.TabIndex = 29;
            // 
            // UserNameText
            // 
            this.UserNameText.BackColor = System.Drawing.Color.Turquoise;
            this.UserNameText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserNameText.ForeColor = System.Drawing.Color.Black;
            this.UserNameText.Location = new System.Drawing.Point(301, 139);
            this.UserNameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNameText.Multiline = true;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(271, 48);
            this.UserNameText.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button3.Location = new System.Drawing.Point(622, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 42);
            this.button3.TabIndex = 23;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button1.Location = new System.Drawing.Point(622, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(4, 25);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Padding = new System.Windows.Forms.Padding(4);
            this.AddStudent.Size = new System.Drawing.Size(1029, 565);
            this.AddStudent.TabIndex = 1;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            // 
            // Instructor_label
            // 
            this.Instructor_label.Controls.Add(this.tabControl1);
            this.Instructor_label.Location = new System.Drawing.Point(4, 25);
            this.Instructor_label.Margin = new System.Windows.Forms.Padding(4);
            this.Instructor_label.Name = "Instructor_label";
            this.Instructor_label.Padding = new System.Windows.Forms.Padding(4);
            this.Instructor_label.Size = new System.Drawing.Size(1056, 609);
            this.Instructor_label.TabIndex = 1;
            this.Instructor_label.Text = "Instructor";
            this.Instructor_label.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ShowInstructors);
            this.tabControl1.Controls.Add(this.AddInstructor);
            this.tabControl1.Controls.Add(this.UpdateInstructor);
            this.tabControl1.Controls.Add(this.DeleteInstructor);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // ShowInstructors
            // 
            this.ShowInstructors.Location = new System.Drawing.Point(4, 25);
            this.ShowInstructors.Name = "ShowInstructors";
            this.ShowInstructors.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInstructors.Size = new System.Drawing.Size(1042, 570);
            this.ShowInstructors.TabIndex = 0;
            this.ShowInstructors.Text = "Show Instructors";
            this.ShowInstructors.UseVisualStyleBackColor = true;
            // 
            // AddInstructor
            // 
            this.AddInstructor.Location = new System.Drawing.Point(4, 25);
            this.AddInstructor.Name = "AddInstructor";
            this.AddInstructor.Padding = new System.Windows.Forms.Padding(3);
            this.AddInstructor.Size = new System.Drawing.Size(1042, 570);
            this.AddInstructor.TabIndex = 1;
            this.AddInstructor.Text = "Add Instructor";
            this.AddInstructor.UseVisualStyleBackColor = true;
            // 
            // Courses_label
            // 
            this.Courses_label.Controls.Add(this.tabControl2);
            this.Courses_label.Location = new System.Drawing.Point(4, 25);
            this.Courses_label.Margin = new System.Windows.Forms.Padding(4);
            this.Courses_label.Name = "Courses_label";
            this.Courses_label.Size = new System.Drawing.Size(1056, 609);
            this.Courses_label.TabIndex = 2;
            this.Courses_label.Text = "Courses";
            this.Courses_label.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.AddCourse);
            this.tabControl2.Controls.Add(this.DeleteCourse);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1053, 603);
            this.tabControl2.TabIndex = 0;
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(4, 25);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Padding = new System.Windows.Forms.Padding(3);
            this.AddCourse.Size = new System.Drawing.Size(1045, 574);
            this.AddCourse.TabIndex = 0;
            this.AddCourse.Text = "Add Course";
            this.AddCourse.UseVisualStyleBackColor = true;
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.Location = new System.Drawing.Point(4, 25);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteCourse.Size = new System.Drawing.Size(1045, 574);
            this.DeleteCourse.TabIndex = 1;
            this.DeleteCourse.Text = "Delete Course";
            this.DeleteCourse.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl3);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1056, 609);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Reports";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Location = new System.Drawing.Point(4, 25);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(1029, 565);
            this.UpdateStudent.TabIndex = 2;
            this.UpdateStudent.Text = "Update Student Data";
            this.UpdateStudent.UseVisualStyleBackColor = true;
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(4, 25);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(1029, 565);
            this.DeleteStudent.TabIndex = 3;
            this.DeleteStudent.Text = "Delete Student";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            // 
            // UpdateInstructor
            // 
            this.UpdateInstructor.Location = new System.Drawing.Point(4, 25);
            this.UpdateInstructor.Name = "UpdateInstructor";
            this.UpdateInstructor.Size = new System.Drawing.Size(1042, 570);
            this.UpdateInstructor.TabIndex = 2;
            this.UpdateInstructor.Text = "Update Instructor";
            this.UpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // DeleteInstructor
            // 
            this.DeleteInstructor.Location = new System.Drawing.Point(4, 25);
            this.DeleteInstructor.Name = "DeleteInstructor";
            this.DeleteInstructor.Size = new System.Drawing.Size(1042, 577);
            this.DeleteInstructor.TabIndex = 3;
            this.DeleteInstructor.Text = "Delete Instructor";
            this.DeleteInstructor.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.Report1);
            this.tabControl3.Controls.Add(this.Report2);
            this.tabControl3.Controls.Add(this.Report3);
            this.tabControl3.Controls.Add(this.Report4);
            this.tabControl3.Controls.Add(this.Report5);
            this.tabControl3.Controls.Add(this.Report6);
            this.tabControl3.Controls.Add(this.Report7);
            this.tabControl3.Location = new System.Drawing.Point(-4, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1064, 609);
            this.tabControl3.TabIndex = 0;
            // 
            // Report1
            // 
            this.Report1.Location = new System.Drawing.Point(4, 25);
            this.Report1.Name = "Report1";
            this.Report1.Padding = new System.Windows.Forms.Padding(3);
            this.Report1.Size = new System.Drawing.Size(1056, 580);
            this.Report1.TabIndex = 0;
            this.Report1.Text = "Report1";
            this.Report1.UseVisualStyleBackColor = true;
            // 
            // Report2
            // 
            this.Report2.Location = new System.Drawing.Point(4, 25);
            this.Report2.Name = "Report2";
            this.Report2.Padding = new System.Windows.Forms.Padding(3);
            this.Report2.Size = new System.Drawing.Size(1056, 580);
            this.Report2.TabIndex = 1;
            this.Report2.Text = "Report2";
            this.Report2.UseVisualStyleBackColor = true;
            // 
            // Report3
            // 
            this.Report3.Location = new System.Drawing.Point(4, 25);
            this.Report3.Name = "Report3";
            this.Report3.Size = new System.Drawing.Size(1056, 580);
            this.Report3.TabIndex = 2;
            this.Report3.Text = "Report3";
            this.Report3.UseVisualStyleBackColor = true;
            // 
            // Report4
            // 
            this.Report4.Location = new System.Drawing.Point(4, 25);
            this.Report4.Name = "Report4";
            this.Report4.Size = new System.Drawing.Size(1056, 580);
            this.Report4.TabIndex = 3;
            this.Report4.Text = "Report4";
            this.Report4.UseVisualStyleBackColor = true;
            // 
            // Report5
            // 
            this.Report5.Location = new System.Drawing.Point(4, 25);
            this.Report5.Name = "Report5";
            this.Report5.Size = new System.Drawing.Size(1056, 580);
            this.Report5.TabIndex = 4;
            this.Report5.Text = "Report5";
            this.Report5.UseVisualStyleBackColor = true;
            // 
            // Report6
            // 
            this.Report6.Location = new System.Drawing.Point(4, 25);
            this.Report6.Name = "Report6";
            this.Report6.Size = new System.Drawing.Size(1056, 580);
            this.Report6.TabIndex = 5;
            this.Report6.Text = "Report6";
            this.Report6.UseVisualStyleBackColor = true;
            // 
            // Report7
            // 
            this.Report7.Location = new System.Drawing.Point(4, 25);
            this.Report7.Name = "Report7";
            this.Report7.Size = new System.Drawing.Size(1056, 580);
            this.Report7.TabIndex = 6;
            this.Report7.Text = "Report7";
            this.Report7.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 650);
            this.Controls.Add(this.Contaunter);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Contaunter.ResumeLayout(false);
            this.StudentLabel.ResumeLayout(false);
            this.student_tap_control.ResumeLayout(false);
            this.ShowStudents.ResumeLayout(false);
            this.ShowStudents.PerformLayout();
            this.Instructor_label.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Courses_label.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Contaunter;
        private System.Windows.Forms.TabPage StudentLabel;
        private System.Windows.Forms.TabPage Instructor_label;
        private System.Windows.Forms.TabControl student_tap_control;
        private System.Windows.Forms.TabPage ShowStudents;
        private System.Windows.Forms.TabPage AddStudent;
        private System.Windows.Forms.TabPage Courses_label;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShowInstructors;
        private System.Windows.Forms.TabPage AddInstructor;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage AddCourse;
        private System.Windows.Forms.TabPage DeleteCourse;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage UpdateStudent;
        private System.Windows.Forms.TabPage DeleteStudent;
        private System.Windows.Forms.TabPage UpdateInstructor;
        private System.Windows.Forms.TabPage DeleteInstructor;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage Report1;
        private System.Windows.Forms.TabPage Report2;
        private System.Windows.Forms.TabPage Report3;
        private System.Windows.Forms.TabPage Report4;
        private System.Windows.Forms.TabPage Report5;
        private System.Windows.Forms.TabPage Report6;
        private System.Windows.Forms.TabPage Report7;
    }
}