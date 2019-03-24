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
    public partial class InsertPlayerForm : Form
    {
        public InsertPlayerForm()
        {
            InitializeComponent();
            for (int i = 1; i < 101; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void InsertPlayerForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessegeApp message = new MessegeApp();
            InsertController insert = new InsertController();
            string name = textBox1.Text;
            string homeTown = textBox2.Text;
            string homeCountry = textBox3.Text;
            int friendName = int.Parse(textBox4.Text);
            int age = int.Parse(comboBox1.Text);

            bool isAdd = false;
            if (name != string.Empty && homeTown != string.Empty)
            {
                isAdd = insert.InsertIntoPlayer(name, age, homeTown, homeCountry, friendName);
                if (isAdd)
                {
                    MessageBox.Show(message.MessegeInsertPlayerTrue(name, age, homeTown, homeCountry, friendName));
                }
                else
                {

                }
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                comboBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Въведи нужните данни в полетата!");
            }
        }
    }
}
