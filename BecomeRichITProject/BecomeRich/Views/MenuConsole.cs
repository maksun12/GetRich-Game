using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Views
{
    public class MenuConsole
    {
        public string MenuInsert()
        {
            Console.WriteLine("1 - Добави държава");
            Console.WriteLine("2 - Добави град");
            Console.WriteLine("3 - Добави въпрос");
            Console.WriteLine("4 - Добави играч");
            Console.WriteLine("5 - Добави приятел");
            Console.Write("Избери команда: ");
            return Console.ReadLine();
        }
        public string MenuRead()
        {
            Console.WriteLine("1 - Списък с държави");
            Console.WriteLine("2 - Списък с градове");
            Console.WriteLine("3 - Списък с въпроси");
            Console.WriteLine("4 - Списък с играчи");
            Console.WriteLine("5 - Списък с приятели");
            Console.Write("Избери команда: ");
            return Console.ReadLine();
        }
        public string Menu()
        {
            Console.WriteLine("Add - Добавяне на данни");
            Console.WriteLine("Read - Отпечатване на данни");
            Console.WriteLine("Play - Започни конзолна игра");
            Console.WriteLine("MainForm - Стартирай графичен интерфейс");
            Console.Write("Избери команда: ");
            return Console.ReadLine();
        }
        

    }
}
