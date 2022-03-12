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
        public Login()
        {
            InitializeComponent();
        }

        private void Log_In_Button_Click(object sender, EventArgs e)
        {
            if(InsRadioBtn.Checked == true || StuRadioBtn.Checked == true)
            {
                MainForm mf = new MainForm(this);
                mf.Show();
                this.Hide();
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
