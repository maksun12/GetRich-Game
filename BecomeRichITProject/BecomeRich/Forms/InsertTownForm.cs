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
    public partial class InsertTownForm : Form
    {
        InsertController insert;
        MessegeApp message;
        public InsertTownForm(InsertController insert, MessegeApp message)
        {
            this.insert = insert;
            this.message = message;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string townName = textBox1.Text;
            string countryName = textBox2.Text;

            bool isAdd = false;
            if (townName != string.Empty && countryName != string.Empty)
            {
                isAdd = insert.InsertIntoTowns(townName, countryName);
                if (isAdd == true)
                {
                    MessageBox.Show(message.MessegeInsertTownTrue(countryName, townName));
                }
                else
                {
                    MessageBox.Show(message.MessegeInsertTownFalse(countryName, townName));

                }
            }
            else
            {
                MessageBox.Show("Въведи име на държава и град!");
            }
        }
    }
}

