
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
            this.UpdateStudent = new System.Windows.Forms.TabPage();
            this.DeleteStudent = new System.Windows.Forms.TabPage();
            this.Instructor_label = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ShowInstructors = new System.Windows.Forms.TabPage();
            this.AddInstructor = new System.Windows.Forms.TabPage();
            this.UpdateInstructor = new System.Windows.Forms.TabPage();
            this.DeleteInstructor = new System.Windows.Forms.TabPage();
            this.Courses_label = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AddCourse = new System.Windows.Forms.TabPage();
            this.DeleteCourse = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Report1 = new System.Windows.Forms.TabPage();
            this.Report2 = new System.Windows.Forms.TabPage();
            this.Report3 = new System.Windows.Forms.TabPage();
            this.Report4 = new System.Windows.Forms.TabPage();
            this.Report5 = new System.Windows.Forms.TabPage();
            this.Report6 = new System.Windows.Forms.TabPage();
            this.Report7 = new System.Windows.Forms.TabPage();
            this.Exams_tap = new System.Windows.Forms.TabPage();
            this.GenerateExam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.T_f_spilt = new System.Windows.Forms.TextBox();
            this.CourseIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.instructor_id_label = new System.Windows.Forms.Label();
            this.Duration_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExamId_label = new System.Windows.Forms.Label();
            this.mcqSpilt = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.IdOfExam = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CourseIdOfExam = new System.Windows.Forms.ComboBox();
            this.instructorIDofExam = new System.Windows.Forms.ComboBox();
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
            this.Exams_tap.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contaunter
            // 
            this.Contaunter.Controls.Add(this.StudentLabel);
            this.Contaunter.Controls.Add(this.Instructor_label);
            this.Contaunter.Controls.Add(this.Courses_label);
            this.Contaunter.Controls.Add(this.tabPage5);
            this.Contaunter.Controls.Add(this.Exams_tap);
            this.Contaunter.Location = new System.Drawing.Point(1, 12);
            this.Contaunter.Name = "Contaunter";
            this.Contaunter.SelectedIndex = 0;
            this.Contaunter.Size = new System.Drawing.Size(1124, 680);
            this.Contaunter.TabIndex = 0;
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.StudentLabel.Controls.Add(this.student_tap_control);
            this.StudentLabel.Location = new System.Drawing.Point(4, 22);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Padding = new System.Windows.Forms.Padding(3);
            this.StudentLabel.Size = new System.Drawing.Size(1116, 654);
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
            this.student_tap_control.Location = new System.Drawing.Point(6, 6);
            this.student_tap_control.Name = "student_tap_control";
            this.student_tap_control.Padding = new System.Drawing.Point(0, 3);
            this.student_tap_control.SelectedIndex = 0;
            this.student_tap_control.Size = new System.Drawing.Size(778, 483);
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
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Padding = new System.Windows.Forms.Padding(3);
            this.ShowStudents.Size = new System.Drawing.Size(770, 454);
            this.ShowStudents.TabIndex = 0;
            this.ShowStudents.Text = "Show Students";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.Turquoise;
            this.passwordText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.passwordText.Location = new System.Drawing.Point(226, 180);
            this.passwordText.Margin = new System.Windows.Forms.Padding(2);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(204, 40);
            this.passwordText.TabIndex = 29;
            // 
            // UserNameText
            // 
            this.UserNameText.BackColor = System.Drawing.Color.Turquoise;
            this.UserNameText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserNameText.ForeColor = System.Drawing.Color.Black;
            this.UserNameText.Location = new System.Drawing.Point(226, 113);
            this.UserNameText.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameText.Multiline = true;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(204, 40);
            this.UserNameText.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button3.Location = new System.Drawing.Point(466, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
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
            this.button1.Location = new System.Drawing.Point(466, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(4, 25);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.AddStudent.Size = new System.Drawing.Size(770, 454);
            this.AddStudent.TabIndex = 1;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.Location = new System.Drawing.Point(4, 25);
            this.UpdateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(770, 454);
            this.UpdateStudent.TabIndex = 2;
            this.UpdateStudent.Text = "Update Student Data";
            this.UpdateStudent.UseVisualStyleBackColor = true;
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(4, 25);
            this.DeleteStudent.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(770, 454);
            this.DeleteStudent.TabIndex = 3;
            this.DeleteStudent.Text = "Delete Student";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            // 
            // Instructor_label
            // 
            this.Instructor_label.Controls.Add(this.tabControl1);
            this.Instructor_label.Location = new System.Drawing.Point(4, 22);
            this.Instructor_label.Name = "Instructor_label";
            this.Instructor_label.Padding = new System.Windows.Forms.Padding(3);
            this.Instructor_label.Size = new System.Drawing.Size(1116, 654);
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
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // ShowInstructors
            // 
            this.ShowInstructors.Location = new System.Drawing.Point(4, 22);
            this.ShowInstructors.Margin = new System.Windows.Forms.Padding(2);
            this.ShowInstructors.Name = "ShowInstructors";
            this.ShowInstructors.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInstructors.Size = new System.Drawing.Size(780, 466);
            this.ShowInstructors.TabIndex = 0;
            this.ShowInstructors.Text = "Show Instructors";
            this.ShowInstructors.UseVisualStyleBackColor = true;
            // 
            // AddInstructor
            // 
            this.AddInstructor.Location = new System.Drawing.Point(4, 22);
            this.AddInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.AddInstructor.Name = "AddInstructor";
            this.AddInstructor.Padding = new System.Windows.Forms.Padding(2);
            this.AddInstructor.Size = new System.Drawing.Size(780, 466);
            this.AddInstructor.TabIndex = 1;
            this.AddInstructor.Text = "Add Instructor";
            this.AddInstructor.UseVisualStyleBackColor = true;
            // 
            // UpdateInstructor
            // 
            this.UpdateInstructor.Location = new System.Drawing.Point(4, 22);
            this.UpdateInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateInstructor.Name = "UpdateInstructor";
            this.UpdateInstructor.Size = new System.Drawing.Size(780, 466);
            this.UpdateInstructor.TabIndex = 2;
            this.UpdateInstructor.Text = "Update Instructor";
            this.UpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // DeleteInstructor
            // 
            this.DeleteInstructor.Location = new System.Drawing.Point(4, 22);
            this.DeleteInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteInstructor.Name = "DeleteInstructor";
            this.DeleteInstructor.Size = new System.Drawing.Size(780, 466);
            this.DeleteInstructor.TabIndex = 3;
            this.DeleteInstructor.Text = "Delete Instructor";
            this.DeleteInstructor.UseVisualStyleBackColor = true;
            // 
            // Courses_label
            // 
            this.Courses_label.Controls.Add(this.tabControl2);
            this.Courses_label.Location = new System.Drawing.Point(4, 22);
            this.Courses_label.Name = "Courses_label";
            this.Courses_label.Size = new System.Drawing.Size(1116, 654);
            this.Courses_label.TabIndex = 2;
            this.Courses_label.Text = "Courses";
            this.Courses_label.UseVisualStyleBackColor = true;
            this.Courses_label.Click += new System.EventHandler(this.Courses_label_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.AddCourse);
            this.tabControl2.Controls.Add(this.DeleteCourse);
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(790, 490);
            this.tabControl2.TabIndex = 0;
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(4, 22);
            this.AddCourse.Margin = new System.Windows.Forms.Padding(2);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Padding = new System.Windows.Forms.Padding(2);
            this.AddCourse.Size = new System.Drawing.Size(782, 464);
            this.AddCourse.TabIndex = 0;
            this.AddCourse.Text = "Add Course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // DeleteCourse
            // 
            this.DeleteCourse.Location = new System.Drawing.Point(4, 22);
            this.DeleteCourse.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCourse.Name = "DeleteCourse";
            this.DeleteCourse.Padding = new System.Windows.Forms.Padding(2);
            this.DeleteCourse.Size = new System.Drawing.Size(782, 464);
            this.DeleteCourse.TabIndex = 1;
            this.DeleteCourse.Text = "Delete Course";
            this.DeleteCourse.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1116, 654);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Reports";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            this.tabControl3.Location = new System.Drawing.Point(-3, 0);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(798, 495);
            this.tabControl3.TabIndex = 0;
            // 
            // Report1
            // 
            this.Report1.Location = new System.Drawing.Point(4, 22);
            this.Report1.Margin = new System.Windows.Forms.Padding(2);
            this.Report1.Name = "Report1";
            this.Report1.Padding = new System.Windows.Forms.Padding(2);
            this.Report1.Size = new System.Drawing.Size(790, 469);
            this.Report1.TabIndex = 0;
            this.Report1.Text = "Report1";
            this.Report1.UseVisualStyleBackColor = true;
            // 
            // Report2
            // 
            this.Report2.Location = new System.Drawing.Point(4, 22);
            this.Report2.Margin = new System.Windows.Forms.Padding(2);
            this.Report2.Name = "Report2";
            this.Report2.Padding = new System.Windows.Forms.Padding(2);
            this.Report2.Size = new System.Drawing.Size(790, 469);
            this.Report2.TabIndex = 1;
            this.Report2.Text = "Report2";
            this.Report2.UseVisualStyleBackColor = true;
            // 
            // Report3
            // 
            this.Report3.Location = new System.Drawing.Point(4, 22);
            this.Report3.Margin = new System.Windows.Forms.Padding(2);
            this.Report3.Name = "Report3";
            this.Report3.Size = new System.Drawing.Size(790, 469);
            this.Report3.TabIndex = 2;
            this.Report3.Text = "Report3";
            this.Report3.UseVisualStyleBackColor = true;
            // 
            // Report4
            // 
            this.Report4.Location = new System.Drawing.Point(4, 22);
            this.Report4.Margin = new System.Windows.Forms.Padding(2);
            this.Report4.Name = "Report4";
            this.Report4.Size = new System.Drawing.Size(790, 469);
            this.Report4.TabIndex = 3;
            this.Report4.Text = "Report4";
            this.Report4.UseVisualStyleBackColor = true;
            // 
            // Report5
            // 
            this.Report5.Location = new System.Drawing.Point(4, 22);
            this.Report5.Margin = new System.Windows.Forms.Padding(2);
            this.Report5.Name = "Report5";
            this.Report5.Size = new System.Drawing.Size(790, 469);
            this.Report5.TabIndex = 4;
            this.Report5.Text = "Report5";
            this.Report5.UseVisualStyleBackColor = true;
            // 
            // Report6
            // 
            this.Report6.Location = new System.Drawing.Point(4, 22);
            this.Report6.Margin = new System.Windows.Forms.Padding(2);
            this.Report6.Name = "Report6";
            this.Report6.Size = new System.Drawing.Size(790, 469);
            this.Report6.TabIndex = 5;
            this.Report6.Text = "Report6";
            this.Report6.UseVisualStyleBackColor = true;
            // 
            // Report7
            // 
            this.Report7.Location = new System.Drawing.Point(4, 22);
            this.Report7.Margin = new System.Windows.Forms.Padding(2);
            this.Report7.Name = "Report7";
            this.Report7.Size = new System.Drawing.Size(790, 469);
            this.Report7.TabIndex = 6;
            this.Report7.Text = "Report7";
            this.Report7.UseVisualStyleBackColor = true;
            // 
            // Exams_tap
            // 
            this.Exams_tap.Controls.Add(this.instructorIDofExam);
            this.Exams_tap.Controls.Add(this.CourseIdOfExam);
            this.Exams_tap.Controls.Add(this.GenerateExam);
            this.Exams_tap.Controls.Add(this.label1);
            this.Exams_tap.Controls.Add(this.T_f_spilt);
            this.Exams_tap.Controls.Add(this.CourseIdLabel);
            this.Exams_tap.Controls.Add(this.label5);
            this.Exams_tap.Controls.Add(this.instructor_id_label);
            this.Exams_tap.Controls.Add(this.Duration_label);
            this.Exams_tap.Controls.Add(this.label2);
            this.Exams_tap.Controls.Add(this.ExamId_label);
            this.Exams_tap.Controls.Add(this.mcqSpilt);
            this.Exams_tap.Controls.Add(this.textBox4);
            this.Exams_tap.Controls.Add(this.IdOfExam);
            this.Exams_tap.Controls.Add(this.button2);
            this.Exams_tap.Location = new System.Drawing.Point(4, 22);
            this.Exams_tap.Name = "Exams_tap";
            this.Exams_tap.Padding = new System.Windows.Forms.Padding(3);
            this.Exams_tap.Size = new System.Drawing.Size(1116, 654);
            this.Exams_tap.TabIndex = 4;
            this.Exams_tap.Text = "Exams";
            this.Exams_tap.UseVisualStyleBackColor = true;
            this.Exams_tap.Click += new System.EventHandler(this.Exams_tap_Click);
            // 
            // GenerateExam
            // 
            this.GenerateExam.Location = new System.Drawing.Point(488, 74);
            this.GenerateExam.Name = "GenerateExam";
            this.GenerateExam.Size = new System.Drawing.Size(128, 23);
            this.GenerateExam.TabIndex = 14;
            this.GenerateExam.Text = "generateExam";
            this.GenerateExam.UseVisualStyleBackColor = true;
            this.GenerateExam.Click += new System.EventHandler(this.GenerateExam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(909, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "T F Spilt";
            // 
            // T_f_spilt
            // 
            this.T_f_spilt.Location = new System.Drawing.Point(909, 48);
            this.T_f_spilt.Name = "T_f_spilt";
            this.T_f_spilt.Size = new System.Drawing.Size(155, 20);
            this.T_f_spilt.TabIndex = 12;
            // 
            // CourseIdLabel
            // 
            this.CourseIdLabel.AutoSize = true;
            this.CourseIdLabel.Location = new System.Drawing.Point(263, 28);
            this.CourseIdLabel.Name = "CourseIdLabel";
            this.CourseIdLabel.Size = new System.Drawing.Size(55, 13);
            this.CourseIdLabel.TabIndex = 11;
            this.CourseIdLabel.Text = "Course Id ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "mcq Spilt";
            // 
            // instructor_id_label
            // 
            this.instructor_id_label.AutoSize = true;
            this.instructor_id_label.Location = new System.Drawing.Point(582, 29);
            this.instructor_id_label.Name = "instructor_id_label";
            this.instructor_id_label.Size = new System.Drawing.Size(62, 13);
            this.instructor_id_label.TabIndex = 9;
            this.instructor_id_label.Text = "instructor Id";
            // 
            // Duration_label
            // 
            this.Duration_label.AutoSize = true;
            this.Duration_label.Location = new System.Drawing.Point(421, 29);
            this.Duration_label.Name = "Duration_label";
            this.Duration_label.Size = new System.Drawing.Size(47, 13);
            this.Duration_label.TabIndex = 8;
            this.Duration_label.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // ExamId_label
            // 
            this.ExamId_label.AutoSize = true;
            this.ExamId_label.Location = new System.Drawing.Point(119, 29);
            this.ExamId_label.Name = "ExamId_label";
            this.ExamId_label.Size = new System.Drawing.Size(48, 13);
            this.ExamId_label.TabIndex = 6;
            this.ExamId_label.Text = "Exam Id ";
            // 
            // mcqSpilt
            // 
            this.mcqSpilt.Location = new System.Drawing.Point(748, 48);
            this.mcqSpilt.Name = "mcqSpilt";
            this.mcqSpilt.Size = new System.Drawing.Size(155, 20);
            this.mcqSpilt.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(424, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 3;
            // 
            // IdOfExam
            // 
            this.IdOfExam.Location = new System.Drawing.Point(102, 48);
            this.IdOfExam.Name = "IdOfExam";
            this.IdOfExam.Size = new System.Drawing.Size(155, 20);
            this.IdOfExam.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "NextQ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseIdOfExam
            // 
            this.CourseIdOfExam.FormattingEnabled = true;
            this.CourseIdOfExam.Location = new System.Drawing.Point(266, 46);
            this.CourseIdOfExam.Name = "CourseIdOfExam";
            this.CourseIdOfExam.Size = new System.Drawing.Size(152, 21);
            this.CourseIdOfExam.TabIndex = 15;
            this.CourseIdOfExam.SelectedIndexChanged += new System.EventHandler(this.CourseIdOfExam_SelectedIndexChanged);
            // 
            // instructorIDofExam
            // 
            this.instructorIDofExam.FormattingEnabled = true;
            this.instructorIDofExam.Location = new System.Drawing.Point(586, 46);
            this.instructorIDofExam.Name = "instructorIDofExam";
            this.instructorIDofExam.Size = new System.Drawing.Size(156, 21);
            this.instructorIDofExam.TabIndex = 16;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 693);
            this.Controls.Add(this.Contaunter);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
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
            this.Exams_tap.ResumeLayout(false);
            this.Exams_tap.PerformLayout();
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
        public System.Windows.Forms.TabPage Exams_tap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox mcqSpilt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox IdOfExam;
        private System.Windows.Forms.Label CourseIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label instructor_id_label;
        private System.Windows.Forms.Label Duration_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExamId_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_f_spilt;
        private System.Windows.Forms.Button GenerateExam;
        public System.Windows.Forms.ComboBox instructorIDofExam;
        public System.Windows.Forms.ComboBox CourseIdOfExam;
    }
}