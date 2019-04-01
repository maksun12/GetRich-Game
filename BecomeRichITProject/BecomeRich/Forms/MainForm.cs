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
    }
}
