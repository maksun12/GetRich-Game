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
    public partial class MainForm : Form
    {
        private BecomeRichContext context ;
        private ReadController read ;
        private InsertController insert ;
        private InOutConsole inOut ;
        private MessegeApp message ;

        public MainForm(BecomeRichContext context, ReadController read, InsertController insert, InOutConsole inOut, MessegeApp messege)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            this.insert = insert;
            this.inOut = inOut;
            this.message = messege;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayForm form = new PlayForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertCountryForm form = new InsertCountryForm(insert,message);
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertQuestionForm form = new InsertQuestionForm(insert, message) ;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertFriendForm form = new InsertFriendForm(insert,message);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertPlayerForm form = new InsertPlayerForm(read,insert,message);
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertTownForm form = new InsertTownForm(insert, message);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "Списък с държави:";
            listBox1.Items.Clear();
            List<Country> countries = read.CountriesList();
            foreach (var c in countries)
            {
                string coutryInfo = string.Format($"{c.Id} - {c.Name}");
                listBox1.Items.Add(coutryInfo);
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = "Списък с градове:";
            listBox1.Items.Clear();
            List<Town> towns = read.TownList();
            foreach (var t in towns)
            {
                string townInfo = string.Format($"{t.Id} - {t.Name} - {t.Country.Name}");
                listBox1.Items.Add(townInfo);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = "Списък с въпроси:";
            listBox1.Items.Clear();
            List<Question> questions = read.QuestionList();
            foreach (var q in questions)
            {
                string questionInfo = string.Format($"{q.Id} - {q.Question1} - {q.A} - {q.B} - {q.C} - {q.D} - {q.Answear}");
                listBox1.Items.Add(questionInfo);
            }
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Text = "Списък с приятели:";
            listBox1.Items.Clear();
            List<Friend> friends = read.FriendsList();
            foreach (var f in friends)
            {
                string friendInfo = string.Format($"ID:{f.Id} -- Name:{f.Name} -- Age:{f.Age} -- HomeTown:{f.Town.Name}");
                listBox1.Items.Add(friendInfo);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Text = "Списък с играчи:";
            listBox1.Items.Clear();
            List<Player> players = read.PlayerList();
            foreach (var p in players)
            {
                string playerInfo = string.Format($"ID:{p.Id} -- Name:{p.Name} -- Age:{p.Age} -- HomeTown:{p.Town.Name} -- Friend:{p.Friend.Name}");
                listBox1.Items.Add(playerInfo);
            }
        }
    }
}
