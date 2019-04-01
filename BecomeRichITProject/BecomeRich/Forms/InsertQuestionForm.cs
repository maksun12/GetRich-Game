using BecomeRich.Controllers;
using BecomeRich.Views;
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
    public partial class InsertQuestionForm : Form
    {
        private InsertController insert;
        private MessegeApp message;
        public InsertQuestionForm(InsertController insert, MessegeApp message)
        {
            InitializeComponent();
            this.insert = insert;
            this.message = message;
            comboBox1.Items.Add("Лесно");
            comboBox1.Items.Add("Средно");
            comboBox1.Items.Add("Трудно");
            comboBox1.Text= comboBox1.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            
            string qustion = textBox1.Text;
            string answearA ="A: " + textBox2.Text;
            string answearB ="B: " + textBox3.Text;
            string answearC ="C: " + textBox4.Text;
            string answearD ="D: " + textBox5.Text;
           string correctAnswear=string.Empty;
            if (radioButton1.Checked)
            {
                correctAnswear = answearA;
            }
            else if (radioButton2.Checked)
            {
                correctAnswear = answearB;
            }
            else if (radioButton3.Checked)
            {
                correctAnswear = answearC;
            }
           else  if (radioButton4.Checked)
            {
                correctAnswear = answearD;
            }

            int category=0;
            if (comboBox1.Text=="Трудно")
            {
                category = 3;
            }
            else if (comboBox1.Text == "Средно")
            {
                category = 2;
            }
            else
            { 
                category = 1;
            }



            bool isAdd = false;
            if (qustion!=string.Empty && answearA != string.Empty && answearB != string.Empty && answearC != string.Empty && answearD != string.Empty )

            {
                isAdd = insert.InsertIntoQuestions(qustion, answearA, answearB, answearC, answearD, correctAnswear, category);
                if (isAdd)
                {
                    MessageBox.Show(message.MessegeInsertQuestionsTrue(qustion, answearA, answearB, answearC, answearD, correctAnswear, category));


                }
                else
                {
                    MessageBox.Show(message.MessegeInsertQuestionsFalse(qustion, answearA, answearB, answearC, answearD, correctAnswear, category));
                   
                }
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
              
                comboBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Въведи нужните данни в полетата!");
            }

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
