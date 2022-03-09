
namespace The_Box_v0._1
{
    partial class StudentGrades
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
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowMessage = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.ShowMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.panel2);
            this.ImagePanel.Controls.Add(this.MainImage);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(800, 450);
            this.ImagePanel.TabIndex = 1;
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagePanel);
            this.Name = "StudentGrades";
            this.Text = "StudentGrades";
            this.Load += new System.EventHandler(this.StudentGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.Panel ImagePanel;
    }
}