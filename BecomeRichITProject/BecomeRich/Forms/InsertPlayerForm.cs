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
        private ReadController read;
        private InsertController insert;
        private List<Friend> friends;
        private MessegeApp message;
        public InsertPlayerForm(ReadController read, InsertController insert, MessegeApp message)
        {
            InitializeComponent();
            this.read = read;
            this.insert = insert;
            this.message = message;
           


        }

        private void InsertPlayerForm_Load(object sender, EventArgs e)
        {
            friends=read.FriendsList();
            for (int i = 18; i < 80; i++)
            {
                comboBox1.Items.Add(i);
            }
            foreach (var f in friends)
            {
                comboBox2.Items.Add(f.Name);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            string name = textBox1.Text;
            string homeTown = textBox2.Text;
            string homeCountry = textBox3.Text;
            int friendId = friends.FirstOrDefault(f => f.Name == comboBox2.Text).Id;
            int age = int.Parse(comboBox1.Text);

            bool isAdd = false;
            if (name != string.Empty && homeTown != string.Empty)
            {
                isAdd = insert.InsertIntoPlayer(name, age, homeTown, homeCountry, friendId);
                if (isAdd)
                {
                    MessageBox.Show("Играчът е добавен успешно!");
                }
                else
                {
                    MessageBox.Show("Играчът не е добавен успешно!");
                }
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                comboBox2.Text = string.Empty;
                comboBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Въведи нужните данни в полетата!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertFriendForm form = new InsertFriendForm(insert,message);
            form.Show();

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            friends = read.FriendsList();
            foreach (var f in friends)
            {
                comboBox2.Items.Add(f.Name);
            }
        }
    }
}
