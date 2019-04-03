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
            ChangeLabelProperty(i);
            button1.Visible = false;
        }

        private void Next()
        {
            RadioCheckedFalse();
            var questions = play.AllQuestion();

            question = play.GetQuestion(i, questions);
            questions.Remove(question);
           textBox1.Text = question.Question1;
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
                        ChangeLabelProperty(i);
                    }
                    else
                    {
                        StartStopGame(false);
                        button1.Visible = true;
                        MessageBox.Show("Грешен отговор! Опитайте отново!");
                    }
                    break;
                case "B":
                    if (question.B == question.Answear)
                    {
                        correctAnswer++;
                        i++;
                        Next();
                        ChangeLabelProperty(i);
                    }
                    else
                    {
                        StartStopGame(false);
                        button1.Visible = true;
                        MessageBox.Show("Грешен отговор! Опитайте отново!");
                    }
                    break;
                case "C":
                    if (question.C == question.Answear)
                    {
                        correctAnswer++;
                        i++;
                        Next();
                        ChangeLabelProperty(i);
                    }
                    else
                    {
                        StartStopGame(false);
                        button1.Visible = true;
                        MessageBox.Show("Грешен отговор! Опитайте отново!");
                    }
                    break;
                case "D":
                    if (question.D == question.Answear)
                    {
                        correctAnswer++;
                        i++;
                        Next();
                        ChangeLabelProperty(i);
                    }
                    else
                    {
                        StartStopGame(false);
                        button1.Visible = true;
                        MessageBox.Show("Грешен отговор! Опитайте отново!");
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
            
            radioButton1.Enabled = trueOrFalse;
            radioButton2.Enabled = trueOrFalse;
            radioButton3.Enabled = trueOrFalse;
            radioButton4.Enabled = trueOrFalse;
        }

        private void ChangeLabelProperty(int i)
        {
            if (i>1)
            {
                switch (i-1)
                {
                    case 1:
                        label1.Enabled = false; 
                        break;
                    case 2:
                        label2.Enabled = false;
                        break;
                    case 3:
                        label3.Enabled = false;
                        break;
                    case 4:
                        label4.Enabled = false;
                        break;
                    case 5:
                        label5.Enabled = false;
                        break;
                    case 6:
                        label6.Enabled = false;
                        break;
                    case 7:
                        label7.Enabled = false;
                        break;
                    case 8:
                        label8.Enabled = false;
                        break;
                    case 9:
                        label9.Enabled = false;
                        break;
                    case 10:
                        label10.Enabled = false;
                        break;
                    case 11:
                        label11.Enabled = false;
                        break;
                    case 12:
                        label12.Enabled = false;
                        break;
                    case 13:
                        label13.Enabled = false;
                        break;
                    case 14:
                        label14.Enabled = false;
                        break;
                    case 15:
                        label15.Enabled = false;
                        break;
                }
            }

            switch (i)
            {
                case 1:
                    label1.ForeColor = Color.Orange;
                    break;
                case 2:
                    label2.ForeColor = Color.Orange;
                    break;
                case 3:
                    label3.ForeColor = Color.Orange;
                    break;
                case 4:
                    label4.ForeColor = Color.Orange;
                    break;
                case 5:
                    label5.ForeColor = Color.Orange;
                    break;
                case 6:
                    label6.ForeColor = Color.Orange;
                    break;
                case 7:
                    label7.ForeColor = Color.Orange;
                    break;
                case 8:
                    label8.ForeColor = Color.Orange;
                    break;
                case 9:
                    label9.ForeColor = Color.Orange;
                    break;
                case 10:
                    label10.ForeColor = Color.Orange;
                    break;
                case 11:
                    label11.ForeColor = Color.Orange;
                    break;
                case 12:
                    label12.ForeColor = Color.Orange;
                    break;
                case 13:
                    label13.ForeColor = Color.Orange;
                    break;
                case 14:
                    label14.ForeColor = Color.Orange;
                    break;
                case 15:
                    label15.ForeColor = Color.Orange;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
