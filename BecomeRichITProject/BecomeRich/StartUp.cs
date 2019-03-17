using BecomeRich.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //ConsoleControler add = new ConsoleControler();

            BecomeRichContext context = new BecomeRichContext();
            Player player = context.Players.FirstOrDefault();
            Play play = new Play(context,player);
        }
    }
}
