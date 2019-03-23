using BecomeRich.Controllers;
using BecomeRich.Forms;
using BecomeRich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeRich
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Application.Run(new InsertCountryForm());
        }
    }
}
