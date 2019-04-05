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
            button3.Visible = false;
            StartStopGame3(false);
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
            StartStopGame3(true);

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
                        button3.Visible = true;
                       MessageBox.Show("Грешен отговор!");
                        if (i<=5)
                        {
                            MessageBox.Show("Спечелихте 0лв.");
                        }
                        else if  (i>5 && i<=10)
                        {
                            MessageBox.Show("Спечелихте 500лв.");
                        }
                        else if (i>10 && i<15)
                        {
                            MessageBox.Show("Спечелихте 2 500лв.");
                        }
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
                       button3.Visible = true;
                        MessageBox.Show("Грешен отговор!");
                        if (i <= 5)
                        {
                            MessageBox.Show("Спечелихте 0лв.");
                        }
                        else if (i > 5 && i <= 10)
                        {
                            MessageBox.Show("Спечелихте 500лв.");
                        }
                        else if (i > 10 && i < 15)
                        {
                            MessageBox.Show("Спечелихте 2 500лв.");
                        }
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
                        button3.Visible = true;
                       MessageBox.Show("Грешен отговор!");
                        if (i <= 5)
                        {
                            MessageBox.Show("Спечелихте 0лв.");
                        }
                        else if (i > 5 && i <= 10)
                        {
                            MessageBox.Show("Спечелихте 500лв.");
                        }
                        else if (i > 10 && i < 15)
                        {
                            MessageBox.Show("Спечелихте 2 500лв.");
                        }
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
                        button3.Visible = true;
                        MessageBox.Show("Грешен отговор!");
                        if (i <= 5)
                        {
                            MessageBox.Show("Спечелихте 0лв.");
                        }
                        else if (i > 5 && i <= 10)
                        {
                            MessageBox.Show("Спечелихте 500лв.");
                        }
                        else if (i > 10 && i < 15)
                        {
                            MessageBox.Show("Спечелихте 2 500лв.");
                        }
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

        private void StartStopGame3(bool trueOrFalse)
        {
        
            button2.Enabled = trueOrFalse;
            radioButton1.Enabled = trueOrFalse;
            radioButton2.Enabled = trueOrFalse;
            radioButton3.Enabled = trueOrFalse;
            radioButton4.Enabled = trueOrFalse;
        }
        private void StartStopGame(bool trueOrFalse)
        {
            button1.Enabled = trueOrFalse;
            button2.Enabled = trueOrFalse;
            radioButton1.Enabled = trueOrFalse;
            radioButton2.Enabled = trueOrFalse;
            radioButton3.Enabled = trueOrFalse;
            radioButton4.Enabled = trueOrFalse;
        }
        private void StartStopGame2(bool trueOrFalse)
        {
            i = 1;
            button2.Enabled = trueOrFalse;
            radioButton1.Enabled = trueOrFalse;
            radioButton2.Enabled = trueOrFalse;
            radioButton3.Enabled = trueOrFalse;
            radioButton4.Enabled = trueOrFalse;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            label2.ForeColor = SystemColors.ControlText;
            label3.ForeColor = SystemColors.ControlText;
            label4.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;
            label7.ForeColor = SystemColors.ControlText;
            label8.ForeColor = SystemColors.ControlText;
            label9.ForeColor = SystemColors.ControlText;
            label10.ForeColor = SystemColors.ControlText;
            label11.ForeColor = SystemColors.ControlText;
            label12.ForeColor = SystemColors.ControlText;
            label13.ForeColor = SystemColors.ControlText;
            label14.ForeColor = SystemColors.ControlText;
            label15.ForeColor = SystemColors.ControlText;
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
                    MessageBox.Show("Поздравления Вие достигнахте до първата сигурна сума от 500лв.");
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
                    MessageBox.Show("Поздравления Вие достигнахте до втората сигурна сума от 2 500лв.!");
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
                case 16:
                    MessageBox.Show("Честито Вие спечелихте 100 000лв.!");
                    
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StartStopGame2(true);
            button3.Visible = false;
            Next();
        }
    }
}
