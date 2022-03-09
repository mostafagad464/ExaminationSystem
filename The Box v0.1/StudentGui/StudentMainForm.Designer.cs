namespace The_Box_v0._1
{
    partial class MainForm
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
            this.HdrPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowMessage = new System.Windows.Forms.Label();
            this.WelcPanel = new System.Windows.Forms.Panel();
            this.StudentName = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.MaximizeAppbtn = new System.Windows.Forms.Button();
            this.CloseFormbtn = new System.Windows.Forms.Button();
            this.Course_Label = new System.Windows.Forms.Button();
            this.Grade_label = new System.Windows.Forms.Button();
            this.Exam_label = new System.Windows.Forms.Button();
            this.InfoStudent_label = new System.Windows.Forms.Button();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.SignoutBtn = new System.Windows.Forms.Button();
            this.HdrPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.WelcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // HdrPanel
            // 
            this.HdrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.HdrPanel.Controls.Add(this.CloseAppbtn);
            this.HdrPanel.Controls.Add(this.Minimize);
            this.HdrPanel.Controls.Add(this.MaximizeAppbtn);
            this.HdrPanel.Controls.Add(this.CloseFormbtn);
            this.HdrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HdrPanel.Location = new System.Drawing.Point(190, 0);
            this.HdrPanel.Name = "HdrPanel";
            this.HdrPanel.Size = new System.Drawing.Size(850, 78);
            this.HdrPanel.TabIndex = 4;
            this.HdrPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HdrPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.LeftPanel);
            this.panel1.Controls.Add(this.WelcPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 600);
            this.panel1.TabIndex = 3;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.LeftPanel.Controls.Add(this.ImagePanel);
            this.LeftPanel.Controls.Add(this.SignoutBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.LeftPanel.Location = new System.Drawing.Point(0, 78);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(190, 522);
            this.LeftPanel.TabIndex = 1;
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.panel2);
            this.ImagePanel.Controls.Add(this.MainImage);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(190, 462);
            this.ImagePanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.Course_Label);
            this.panel2.Controls.Add(this.Grade_label);
            this.panel2.Controls.Add(this.Exam_label);
            this.panel2.Controls.Add(this.InfoStudent_label);
            this.panel2.Controls.Add(this.ShowMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 462);
            this.panel2.TabIndex = 2;
            // 
            // ShowMessage
            // 
            this.ShowMessage.AutoSize = true;
            this.ShowMessage.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.ShowMessage.ForeColor = System.Drawing.Color.White;
            this.ShowMessage.Location = new System.Drawing.Point(183, 124);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(396, 23);
            this.ShowMessage.TabIndex = 23;
            this.ShowMessage.Text = "Will be array of Labels defined with size of array";
            // 
            // WelcPanel
            // 
            this.WelcPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.WelcPanel.Controls.Add(this.StudentName);
            this.WelcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.WelcPanel.Location = new System.Drawing.Point(0, 0);
            this.WelcPanel.Name = "WelcPanel";
            this.WelcPanel.Size = new System.Drawing.Size(190, 78);
            this.WelcPanel.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.StudentName.Location = new System.Drawing.Point(12, 22);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(176, 35);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "studentName";
            this.StudentName.Click += new System.EventHandler(this.StudentName_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BackgroundImage = global::The_Box_v0._1.Properties.Resources.iti_logo;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPanel.CausesValidation = false;
            this.MainPanel.Location = new System.Drawing.Point(190, 78);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(850, 522);
            this.MainPanel.TabIndex = 5;
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppbtn.FlatAppearance.BorderSize = 0;
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = global::The_Box_v0._1.Properties.Resources.close__2_;
            this.CloseAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseAppbtn.Location = new System.Drawing.Point(817, 3);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(28, 23);
            this.CloseAppbtn.TabIndex = 5;
            this.CloseAppbtn.UseVisualStyleBackColor = true;
            this.CloseAppbtn.Click += new System.EventHandler(this.CloseAppbtn_Click_1);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Image = global::The_Box_v0._1.Properties.Resources.minus;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize.Location = new System.Drawing.Point(749, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(28, 23);
            this.Minimize.TabIndex = 4;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click_1);
            // 
            // MaximizeAppbtn
            // 
            this.MaximizeAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppbtn.FlatAppearance.BorderSize = 0;
            this.MaximizeAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppbtn.Image = global::The_Box_v0._1.Properties.Resources.fullscreen;
            this.MaximizeAppbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaximizeAppbtn.Location = new System.Drawing.Point(783, 3);
            this.MaximizeAppbtn.Name = "MaximizeAppbtn";
            this.MaximizeAppbtn.Size = new System.Drawing.Size(28, 23);
            this.MaximizeAppbtn.TabIndex = 3;
            this.MaximizeAppbtn.UseVisualStyleBackColor = true;
            this.MaximizeAppbtn.Click += new System.EventHandler(this.MaximizeAppbtn_Click_1);
            // 
            // CloseFormbtn
            // 
            this.CloseFormbtn.FlatAppearance.BorderSize = 0;
            this.CloseFormbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormbtn.Image = global::The_Box_v0._1.Properties.Resources.close__1_;
            this.CloseFormbtn.Location = new System.Drawing.Point(24, 29);
            this.CloseFormbtn.Name = "CloseFormbtn";
            this.CloseFormbtn.Size = new System.Drawing.Size(26, 25);
            this.CloseFormbtn.TabIndex = 2;
            this.CloseFormbtn.UseVisualStyleBackColor = true;
            // 
            // Course_Label
            // 
            this.Course_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Course_Label.FlatAppearance.BorderSize = 0;
            this.Course_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Course_Label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Label.ForeColor = System.Drawing.Color.White;
            this.Course_Label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.Course_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Course_Label.Location = new System.Drawing.Point(0, 121);
            this.Course_Label.Name = "Course_Label";
            this.Course_Label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Course_Label.Size = new System.Drawing.Size(190, 40);
            this.Course_Label.TabIndex = 27;
            this.Course_Label.Text = "Courses";
            this.Course_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Course_Label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Course_Label.UseVisualStyleBackColor = true;
            this.Course_Label.Click += new System.EventHandler(this.Course_Label_Click_1);
            // 
            // Grade_label
            // 
            this.Grade_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grade_label.FlatAppearance.BorderSize = 0;
            this.Grade_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grade_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade_label.ForeColor = System.Drawing.Color.White;
            this.Grade_label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.Grade_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Grade_label.Location = new System.Drawing.Point(0, 79);
            this.Grade_label.Name = "Grade_label";
            this.Grade_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Grade_label.Size = new System.Drawing.Size(190, 42);
            this.Grade_label.TabIndex = 26;
            this.Grade_label.Text = "Grades";
            this.Grade_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Grade_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Grade_label.UseVisualStyleBackColor = true;
            this.Grade_label.Click += new System.EventHandler(this.Grade_label_Click_1);
            // 
            // Exam_label
            // 
            this.Exam_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exam_label.FlatAppearance.BorderSize = 0;
            this.Exam_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exam_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_label.ForeColor = System.Drawing.Color.White;
            this.Exam_label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.Exam_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exam_label.Location = new System.Drawing.Point(0, 38);
            this.Exam_label.Name = "Exam_label";
            this.Exam_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Exam_label.Size = new System.Drawing.Size(190, 41);
            this.Exam_label.TabIndex = 25;
            this.Exam_label.Text = "Exam";
            this.Exam_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exam_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exam_label.UseVisualStyleBackColor = true;
            this.Exam_label.Click += new System.EventHandler(this.Exam_label_Click);
            // 
            // InfoStudent_label
            // 
            this.InfoStudent_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoStudent_label.FlatAppearance.BorderSize = 0;
            this.InfoStudent_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoStudent_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoStudent_label.ForeColor = System.Drawing.Color.White;
            this.InfoStudent_label.Image = global::The_Box_v0._1.Properties.Resources.man;
            this.InfoStudent_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoStudent_label.Location = new System.Drawing.Point(0, 0);
            this.InfoStudent_label.Name = "InfoStudent_label";
            this.InfoStudent_label.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.InfoStudent_label.Size = new System.Drawing.Size(190, 38);
            this.InfoStudent_label.TabIndex = 24;
            this.InfoStudent_label.Text = "Student Info";
            this.InfoStudent_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoStudent_label.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InfoStudent_label.UseVisualStyleBackColor = true;
            this.InfoStudent_label.Click += new System.EventHandler(this.InfoStudent_label_Click);
            // 
            // MainImage
            // 
            this.MainImage.Location = new System.Drawing.Point(0, 0);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(800, 344);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignoutBtn.FlatAppearance.BorderSize = 0;
            this.SignoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignoutBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignoutBtn.ForeColor = System.Drawing.Color.White;
            this.SignoutBtn.Image = global::The_Box_v0._1.Properties.Resources.logout;
            this.SignoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignoutBtn.Location = new System.Drawing.Point(0, 462);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.SignoutBtn.Size = new System.Drawing.Size(190, 60);
            this.SignoutBtn.TabIndex = 3;
            this.SignoutBtn.Text = "  SignOut";
            this.SignoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SignoutBtn.UseVisualStyleBackColor = true;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HdrPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HdrPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ImagePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.WelcPanel.ResumeLayout(false);
            this.WelcPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel HdrPanel;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button MaximizeAppbtn;
        private System.Windows.Forms.Button CloseFormbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button SignoutBtn;
        private System.Windows.Forms.Panel WelcPanel;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Course_Label;
        private System.Windows.Forms.Button Grade_label;
        private System.Windows.Forms.Button Exam_label;
        internal System.Windows.Forms.Button InfoStudent_label;
        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.PictureBox MainImage;
    }
}