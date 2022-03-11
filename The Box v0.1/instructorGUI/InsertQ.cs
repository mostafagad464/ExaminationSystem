using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1.instructorGUI
{
    public partial class InsertQ : Form
    {
        public InsertQ()
        {
            InitializeComponent();
        }

        private void A_label_Click(object sender, EventArgs e)
        {

        }

        private void MCQ_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(MCQ_radio.Checked)
            {
                EnterCH_label.Visible = true;
                a_label.Visible = true;
                b_label.Visible = true;
                c_label.Visible = true;
                d_label.Visible = true;
                a_txt.Visible = true;
                b_txt.Visible = true;
                c_txt.Visible = true;
                d_txt.Visible = true;

            }
            else
            {
                EnterCH_label.Visible = false;
                a_label.Visible = false;
                b_label.Visible = false;
                c_label.Visible = false;
                d_label.Visible =false;
                a_txt.Visible = false;
                b_txt.Visible = false;
                c_txt.Visible = false;
                d_txt.Visible = false;

            }
        }
    }
}
