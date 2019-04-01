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
    public partial class InsertCountryForm : Form
    {
        InsertController insert ;
        MessegeApp message ;
        public InsertCountryForm(InsertController insert, MessegeApp message )
        {
            InitializeComponent();
            this.insert = insert;
            this.message = message;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string countryName = textBox1.Text;
            bool isAdd = false;
            if (countryName != string.Empty)
            {
                isAdd = insert.InsertIntoCountries(countryName);
                if (isAdd == true)
                {
                    MessageBox.Show(message.MessegeInsertCountryTrue(countryName));
                }
                else
                {
                    MessageBox.Show(message.MessegeInsertCountryFalse(countryName));
                }
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Въведи име на държава!");
            }

        }

        private void InsertCountryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
