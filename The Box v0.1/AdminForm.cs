using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public partial class AdminForm : Form
    {
        Login loginPage;
        List<GroupBox> Groupsbox = new List<GroupBox>();
        int iteratorOfQ=0;
        ExaminationSystemEntities examinationSystemEntities= new ExaminationSystemEntities();


        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(Login login)
        {
            InitializeComponent();
            loginPage = login;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Exams_tap_Click(object sender, EventArgs e)
        {
            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (GroupBox boxIterator in Groupsbox)
            {

                boxIterator.Visible = false;

            }

            Groupsbox[(iteratorOfQ++)% Groupsbox.Count].Visible = true;
        }

        private void GenerateExam_Click(object sender, EventArgs e)
        {
            examinationSystemEntities.GenerateExam(int.Parse(IdOfExam.Text), int.Parse(instructorId.Text),int.Parse(textBox4.Text), int.Parse(idOfcourse.Text), int.Parse(mcqSpilt.Text), int.Parse(T_f_spilt.Text),Groupsbox,this);
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {

        }

        private void Courses_label_Click(object sender, EventArgs e)
        {

        }
    }
}
