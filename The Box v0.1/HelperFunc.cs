using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public  static class HelperFunc
    {

        public static void GenerateExam (this ExaminationSystemEntities Database,int ExamId,int insId,int Duration,int courseId,int spiltMCQ,int spiltT_f,List<GroupBox> Groupsbox,AdminForm form)

        {

            var Exam = Database.GetRandomQuestions(courseId, ExamId, Duration, insId, spiltMCQ, spiltT_f).ToList();
            RadioButton radio;
            for (int i = 0; i < Exam.Count; i++)
            {
                GroupBox box = new System.Windows.Forms.GroupBox();
                Label Qtest = new Label();
                box.Location = new System.Drawing.Point(200, 150);
                //  box.Name = "groupBox" + i.ToString();
                box.Size = new System.Drawing.Size(1600, 400);

                box.TabIndex = i;
                box.TabStop = false;
                box.Text = "groupBox" + i.ToString();

                Qtest.Text = Exam[i].Q_Text;

                Qtest.Location = new System.Drawing.Point(box.Location.X, 10);
                Qtest.AutoSize = true;
                //   Qtest.Size= new System.Drawing.Size(500, 17);
                box.BackColor = Color.Transparent;
                // MessageBox.Show((box.Location).ToString());

                box.Controls.Add(Qtest);

                var choicesofQ = Database.GetChoiceOfQ(Exam[i].Question_id).ToList();
                int lengthofChoice = choicesofQ.Count;
                if (choicesofQ.Count == 0)
                {
                    lengthofChoice = 2;
                }

                int positionOfradiobutton = 50;

                for (int j = 0; j < lengthofChoice; j++)
                {

                    radio = new RadioButton();

                    radio.AutoSize = true;

                    radio.Location = new System.Drawing.Point(box.Location.X, positionOfradiobutton);

                    // MessageBox.Show((radio.Location).ToString());
                    //  radio.Name = "Q" + i.ToString() + "ch" + j.ToString();
                    // radio.Size = new System.Drawing.Size(40, 17);
                    radio.TabIndex = 0;
                    radio.TabStop = true;
                    if (lengthofChoice == 2)
                    {

                        if (j == 0)
                        {
                            radio.Name = "t";
                            radio.Text = "True";
                        }
                        else
                        {
                            radio.Name = "f";
                            radio.Text = "false";
                        }
                    }
                    else

                    {
                        radio.Name = choicesofQ[j].ChoiceId.ToString();
                        radio.Text = choicesofQ[j].Choice_text;
                    }


                    radio.UseVisualStyleBackColor = true;


                    radio.Visible = true;

                    positionOfradiobutton = positionOfradiobutton + 60;
                    box.Controls.Add(radio);

                    // adio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
                }


                Groupsbox.Add(box);
                form.Exams_tap.Controls.Add(box);

                foreach (GroupBox boxIterator in Groupsbox)
                {

                    boxIterator.Visible = false;

                }

                Groupsbox[0].Visible = true;


            }



        }
    }
}
