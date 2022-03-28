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
    public partial class Login : Form
    {
        ExaminationSystemEntities examinationSystemEntities;
        public Login()
        {
            InitializeComponent();
            examinationSystemEntities = new ExaminationSystemEntities();

        }

        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            if (InsRadioBtn.Checked == true)
            {

                Instructor ins = examinationSystemEntities.InstructorsAuthentication(UserNameText.Text, passwordText.Text);

                if (ins!=null)
                {
                    instructorGUI.InstructorMainForm Imf = new instructorGUI.InstructorMainForm(this,ins);
                    Imf.Show();
                    this.Hide();
                    //   Console.WriteLine(examinationSystemEntities.ComputeSha256Hash(passwordText.Text));
                }
                else
                {

                    MessageBox.Show("Wrong Password .... try again ! ");
                }



       

              
            }

           else  if (StuRadioBtn.Checked == true)
            {

                Student std = examinationSystemEntities.Studentuthentication(UserNameText.Text, passwordText.Text);
                if (std != null)
                {   
                    StudentMainForm   stdForm= new StudentMainForm(this,std);


                    stdForm.Show();
                    this.Hide();
                    //   Console.WriteLine(examinationSystemEntities.ComputeSha256Hash(passwordText.Text));
                }
                else
                {

                    MessageBox.Show("Wrong Password .... try again ! ");
                }






            }
            else if(AdminRadioBtn.Checked == true)
            {
                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
                this.Hide();
            }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
