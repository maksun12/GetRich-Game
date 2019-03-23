using BecomeRich.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeRich.Forms
{
    public partial class PlayForm : Form
    {
        public static BecomeRichContext context = new BecomeRichContext();
        PlayController play = new PlayController(context);
        public PlayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var questions = play.AllQuestion();
            int correctAnswer = 0;
            for (int i = 1; i <= 15; i++)
            {
                var question = play.GetQuestion(i, questions);
                questions.Remove(question);
                label1.Text = question.Question1;
                radioButton1.Text = question.A;
                radioButton2.Text = question.B;
                radioButton3.Text = question.C;
                radioButton4.Text = question.D;
                string answer = string.Empty;
                if (radioButton1.Checked)
                {
                    answer = "A";
                }
                else if (radioButton2.Checked)
                {
                    answer = "B";
                }
                else if (radioButton3.Checked)
                {
                    answer = "C";
                }
                else if (radioButton4.Checked)
                {
                    answer = "D";
                }

                switch (answer)
                {
                    case "A":
                        if (question.A == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                    case "B":
                        if (question.B == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                    case "C":
                        if (question.C == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                    case "D":
                        if (question.D == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                }

            }
            if (correctAnswer == 15)
            {
                Console.WriteLine("Rich");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
