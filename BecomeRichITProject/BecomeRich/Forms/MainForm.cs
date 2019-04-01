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
        private MessegeApp messege ;

        public MainForm(BecomeRichContext context, ReadController read, InsertController insert, InOutConsole inOut, MessegeApp messege)
        {
            InitializeComponent();
            this.context = context;
            this.read = read;
            this.insert = insert;
            this.inOut = inOut;
            this.messege = messege;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayForm form = new PlayForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertCountryForm form = new InsertCountryForm();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertQuestionForm form = new InsertQuestionForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertFriendForm form = new InsertFriendForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertPlayerForm form = new InsertPlayerForm();
            form.Show();
        }
    }
}
