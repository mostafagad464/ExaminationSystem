using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Color color;
        Login loginPage;


        public MainForm()
        {
            InitializeComponent();
        }


        public MainForm(Login login)
        {
            InitializeComponent();
            loginPage = login;
            random = new Random();
            CloseFormbtn.Visible = false;
  
         
        }


        // To Make Form Movable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void HdrPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Methods
        private Color SelectThemeColor()
        {
           
            string color = ThemeColor.ColorList[0];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Trebuchet MS", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    HdrPanel.BackColor = color;
                    WelcPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    CloseFormbtn.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in LeftPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
          //  ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        //    boxLabel.Text = childForm.Text;
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void student_infoClick(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StudentDetailsInfo(), sender);



        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void SignoutBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Close();
            loginPage.Show();
        }

        private void CloseFormbtn_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            //boxLabel.Text = "Examination System";
            HdrPanel.BackColor = Color.FromArgb(0, 150, 136);
            WelcPanel.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            CloseFormbtn.Visible = false;
        }

        private void CloseAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeAppbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Grade_label_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentGrades(), sender);
        }

        private void Course_Label_Click(object sender, EventArgs e)
        {
             OpenChildForm(new Coursescs() ,sender);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {

        }

        private void InfoStudent_label_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StudentDetailsInfo(), sender);

        }

        private void Exam_label_Click(object sender, EventArgs e)
        {

        }

        private void Course_Label_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Coursescs(), sender);

        }

        private void Grade_label_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentGrades(), sender);
        }

        private void SignoutBtn_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Close();
            loginPage.Show();
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeAppbtn_Click_1(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void CloseAppbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void HdrPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseFormbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void ShowMessage_Click(object sender, EventArgs e)
        {

        }

        private void MainImage_Click(object sender, EventArgs e)
        {

        }

        private void WelcPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentName_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
