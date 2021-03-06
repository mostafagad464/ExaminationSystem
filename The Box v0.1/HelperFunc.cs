using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Box_v0._1
{
    public  static class HelperFunc
    {

        public static void GenerateExam(this ExaminationSystemEntities Database, int ExamId, string insName, int Duration, String courseName, int spiltMCQ, int spiltT_f, List<GroupBox> Groupsbox, AdminForm form)


        {

            try
            {
                int insId =
              (from Instructor in Database.Instructors
               where Instructor.Ins_Name == insName
               select Instructor.Ins_ID).First();


                int courseId =
            (from courses in Database.Courses
             where courses.Course_Name == courseName
             select courses.Course_Id).First();
                List<GetRandomQuestions_Result> Exam =
                 Database.GetRandomQuestions(courseId, ExamId, Duration, insId, spiltMCQ, spiltT_f).ToList();
                RadioButton radio;
                for (int i = 0; i < Exam.Count; i++)
                {
                    GroupBox box = GroupItemConfig(Exam[i], i);

                    var choicesofQ = Database.GetChoiceOfQ(Exam[i].Question_id).ToList();
                    int lengthofChoice = choicesofQ.Count;


                    int positionOfradiobutton = 50;

                    for (int j = 0; j < lengthofChoice; j++)
                    {

                        radio = new RadioButton();

                        radio.AutoSize = true;

                        radio.Location = new System.Drawing.Point(box.Location.X, positionOfradiobutton);

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
                                radio.Text = "False";
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
             
            catch (FormatException ex)
            {
                MessageBox.Show("Unable to convert '{0}'." );
            }
            catch (OverflowException ex )
            {
                MessageBox.Show("'{0}' is out of range of the Int32 type.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again "); 

            }



        }

      public  static string ComputeSha256Hash(this ExaminationSystemEntities Database, string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }

            public static GroupBox GroupItemConfig(GetRandomQuestions_Result Exam, int i)
        {
            GroupBox box = new System.Windows.Forms.GroupBox();
            Label Qtest = new Label();
            box.Location = new System.Drawing.Point(200, 150);
            //  box.Name = "groupBox" + i.ToString();
            box.Size = new System.Drawing.Size(900, 400);

            box.TabIndex = i;
            box.TabStop = false;
            box.Text = "groupBox" + i.ToString();

            Qtest.Text =Exam.Q_Text;

            Qtest.Location = new System.Drawing.Point(box.Location.X, 10);
            Qtest.AutoSize = true;

            box.BackColor = Color.Transparent;
            box.Controls.Add(Qtest);

            return box;

        }
        public static Instructor InstructorsAuthentication(this ExaminationSystemEntities Database,string UName,String pass)
        {
            string cipherText = Database.ComputeSha256Hash(pass);
            foreach (Instructor ins in Database.Instructors)
            {

               if ( ins.Ins_UserName== UName && ins.Ins_Password== cipherText)
                {
                    return Database.Instructors.Find(ins.Ins_ID);
                }

              
            }
            return null;

        }


        public static Student  Studentuthentication(this ExaminationSystemEntities Database, string UName, String pass)
        {
            string cipherText = Database.ComputeSha256Hash(pass);
            foreach (Student std  in Database.Students)
            {

                if (std.Std_UserName == UName && std.Std_Password == cipherText)
                {       
                    return Database.Students.Find(std.Std_ID);
                }


            }
            return null;

        }
    }
}
