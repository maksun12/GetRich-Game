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
        int i = 1;
        int correctAnswer = 0;
        string answer = string.Empty;
        Question question;
        public PlayForm()
        {
            InitializeComponent();
            RadioCheckedFalse();

        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            RadioCheckedFalse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void Next()
        {
            RadioCheckedFalse();
            var questions = play.AllQuestion();

            question = play.GetQuestion(i, questions);
            questions.Remove(question);
            label1.Text = question.Question1;
            radioButton1.Text = question.A;
            radioButton2.Text = question.B;
            radioButton3.Text = question.C;
            radioButton4.Text = question.D;
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                        i++;
                        Next();
                    }
                    else
                    {
                        StartStopGame(false);
                    }
                    break;
                case "B":
                    if (question.B == question.Answear)
                    {
                        correctAnswer++;
                        i++;
                        Next();
                    }
                    else
                    {
                        StartStopGame(false);
                    }
                    break;
                case "C":
                    if (question.C == question.Answear)
                    {
                        correctAnswer++;
                        i++;
                        Next();
                    }
                    else
                    {
                        StartStopGame(false);
                    }
                    break;
                case "D":
                    if (question.D == question.Answear)
                    {
                        correctAnswer++;
                        i++;
                        Next();
                    }
                    else
                    {
                        StartStopGame(false);
                    }
                    break;
                    
            }
        }

        private void RadioCheckedFalse()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void StartStopGame(bool trueOrFalse)
        {
            button1.Enabled = trueOrFalse;
            radioButton1.Enabled = trueOrFalse;
            radioButton2.Enabled = trueOrFalse;
            radioButton3.Enabled = trueOrFalse;
            radioButton4.Enabled = trueOrFalse;
        }


    }
}
