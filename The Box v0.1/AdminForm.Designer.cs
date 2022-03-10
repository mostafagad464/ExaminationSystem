
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
            this.Instructor_label = new System.Windows.Forms.TabPage();
            this.Courses_label = new System.Windows.Forms.TabPage();
            this.student_tap_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StuRadioBtn = new System.Windows.Forms.RadioButton();
            this.InsRadioBtn = new System.Windows.Forms.RadioButton();
            this.AdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.Log_In_Button = new System.Windows.Forms.Button();
            this.Contaunter.SuspendLayout();
            this.StudentLabel.SuspendLayout();
            this.student_tap_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contaunter
            // 
            this.Contaunter.Controls.Add(this.StudentLabel);
            this.Contaunter.Controls.Add(this.Instructor_label);
            this.Contaunter.Controls.Add(this.Courses_label);
            this.Contaunter.Location = new System.Drawing.Point(1, 12);
            this.Contaunter.Name = "Contaunter";
            this.Contaunter.SelectedIndex = 0;
            this.Contaunter.Size = new System.Drawing.Size(798, 518);
            this.Contaunter.TabIndex = 0;
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.StudentLabel.Controls.Add(this.student_tap_control);
            this.StudentLabel.Location = new System.Drawing.Point(4, 22);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Padding = new System.Windows.Forms.Padding(3);
            this.StudentLabel.Size = new System.Drawing.Size(790, 492);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Student";
            this.StudentLabel.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Instructor_label
            // 
            this.Instructor_label.Location = new System.Drawing.Point(4, 22);
            this.Instructor_label.Name = "Instructor_label";
            this.Instructor_label.Padding = new System.Windows.Forms.Padding(3);
            this.Instructor_label.Size = new System.Drawing.Size(790, 492);
            this.Instructor_label.TabIndex = 1;
            this.Instructor_label.Text = "Instructor";
            this.Instructor_label.UseVisualStyleBackColor = true;
            // 
            // Courses_label
            // 
            this.Courses_label.Location = new System.Drawing.Point(4, 22);
            this.Courses_label.Name = "Courses_label";
            this.Courses_label.Size = new System.Drawing.Size(790, 492);
            this.Courses_label.TabIndex = 2;
            this.Courses_label.Text = "Courses";
            this.Courses_label.UseVisualStyleBackColor = true;
            // 
            // student_tap_control
            // 
            this.student_tap_control.Controls.Add(this.tabPage1);
            this.student_tap_control.Controls.Add(this.tabPage2);
            this.student_tap_control.Location = new System.Drawing.Point(7, 6);
            this.student_tap_control.Name = "student_tap_control";
            this.student_tap_control.Padding = new System.Drawing.Point(0, 3);
            this.student_tap_control.SelectedIndex = 0;
            this.student_tap_control.Size = new System.Drawing.Size(777, 483);
            this.student_tap_control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.tabPage1.Controls.Add(this.StuRadioBtn);
            this.tabPage1.Controls.Add(this.InsRadioBtn);
            this.tabPage1.Controls.Add(this.AdminRadioBtn);
            this.tabPage1.Controls.Add(this.passwordLabel);
            this.tabPage1.Controls.Add(this.passwordText);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Controls.Add(this.UserNameText);
            this.tabPage1.Controls.Add(this.Log_In_Button);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(769, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(769, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button1.Location = new System.Drawing.Point(463, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button2.Location = new System.Drawing.Point(492, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.button3.Location = new System.Drawing.Point(473, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 23;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // StuRadioBtn
            // 
            this.StuRadioBtn.AutoSize = true;
            this.StuRadioBtn.ForeColor = System.Drawing.Color.White;
            this.StuRadioBtn.Location = new System.Drawing.Point(361, 250);
            this.StuRadioBtn.Name = "StuRadioBtn";
            this.StuRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.StuRadioBtn.TabIndex = 33;
            this.StuRadioBtn.TabStop = true;
            this.StuRadioBtn.Text = "Student";
            this.StuRadioBtn.UseVisualStyleBackColor = true;
            // 
            // InsRadioBtn
            // 
            this.InsRadioBtn.AutoSize = true;
            this.InsRadioBtn.ForeColor = System.Drawing.Color.White;
            this.InsRadioBtn.Location = new System.Drawing.Point(286, 250);
            this.InsRadioBtn.Name = "InsRadioBtn";
            this.InsRadioBtn.Size = new System.Drawing.Size(69, 17);
            this.InsRadioBtn.TabIndex = 32;
            this.InsRadioBtn.TabStop = true;
            this.InsRadioBtn.Text = "Instructor";
            this.InsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AdminRadioBtn
            // 
            this.AdminRadioBtn.AutoSize = true;
            this.AdminRadioBtn.ForeColor = System.Drawing.Color.White;
            this.AdminRadioBtn.Location = new System.Drawing.Point(226, 250);
            this.AdminRadioBtn.Name = "AdminRadioBtn";
            this.AdminRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.AdminRadioBtn.TabIndex = 31;
            this.AdminRadioBtn.TabStop = true;
            this.AdminRadioBtn.Text = "Admin";
            this.AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(105, 183);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(101, 23);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Passsword :";
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
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(105, 118);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(107, 23);
            this.UserName.TabIndex = 28;
            this.UserName.Text = "User Name :";
            // 
            // UserNameText
            // 
            this.UserNameText.BackColor = System.Drawing.Color.Turquoise;
            this.UserNameText.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UserNameText.ForeColor = System.Drawing.Color.Black;
            this.UserNameText.Location = new System.Drawing.Point(226, 118);
            this.UserNameText.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameText.Multiline = true;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(204, 40);
            this.UserNameText.TabIndex = 27;
            // 
            // Log_In_Button
            // 
            this.Log_In_Button.BackColor = System.Drawing.Color.Turquoise;
            this.Log_In_Button.FlatAppearance.BorderSize = 0;
            this.Log_In_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In_Button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.Log_In_Button.Location = new System.Drawing.Point(255, 283);
            this.Log_In_Button.Name = "Log_In_Button";
            this.Log_In_Button.Size = new System.Drawing.Size(133, 57);
            this.Log_In_Button.TabIndex = 26;
            this.Log_In_Button.Text = "Log In";
            this.Log_In_Button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.Contaunter);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Contaunter.ResumeLayout(false);
            this.StudentLabel.ResumeLayout(false);
            this.student_tap_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Contaunter;
        private System.Windows.Forms.TabPage StudentLabel;
        private System.Windows.Forms.TabPage Instructor_label;
        private System.Windows.Forms.TabControl student_tap_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Courses_label;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton StuRadioBtn;
        private System.Windows.Forms.RadioButton InsRadioBtn;
        private System.Windows.Forms.RadioButton AdminRadioBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Button Log_In_Button;
    }
}