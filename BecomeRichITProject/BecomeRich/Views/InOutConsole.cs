using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Views
{
    class InOutConsole
    {
        public void Line(char c,int length)
        {
            Console.WriteLine(new string(c,length));
        }
        public string ReadCountryName()
        {
            Console.Write("Въведи име на държава: ");
            return Console.ReadLine();
        }
        public string ReadTownName()
        {
            Console.Write("Въведи име на град: ");
            return Console.ReadLine();
        }
        public string ReadQuestions()
        {
            Console.Write("Въведи въпрос: ");
           return Console.ReadLine();
        }
        public string ReadAnswear()
        {
            Console.Write("Въведи отговор: ");
            return Console.ReadLine();
        }

        public string ReadCorrectAnswear()
        {
            Console.Write("Въведи правилния отговор: ");
            return Console.ReadLine();
        }
        public int ReadCategoryId()
        {
            Console.Write("Въведи категория на въпроса: ");
            return int.Parse(Console.ReadLine());
        }
        //играч
        public string ReadPlayerName()
        {
            Console.Write("Въведи име на играч: ");
            return Console.ReadLine();
        }
        public int ReadPlayerAge()
        {
            Console.Write("Въведи години на играч: ");
            return int.Parse(Console.ReadLine());
        }
        public int ReadPlayerFriend()
        {
            Console.Write("Въведи приятел на играч чрез ID: ");
            return int.Parse(Console.ReadLine());
        }
        //приятел
        public string ReadFriendName()
        {
            Console.Write("Въведи име на приятел: ");
            return Console.ReadLine();
        }
        public int ReadFriendAge()
        {
            Console.Write("Въведи години на приятел: ");
            return int.Parse(Console.ReadLine());
        }
        public void PrintCountriesInfo(List<Country> countries)
        {
            Console.WriteLine($"{"ID",-4}{"Name" ,-15}");
            foreach (var c in countries)
            {
                Console.WriteLine($"{c.Id,-4}{c.Name,-15}");
            }
        }
        public void PrintTownsInfo(List<Town> towns)
        {
            Console.WriteLine($"{"ID",-4}{"Town name",-15}{"Country name",-15}");
            foreach (var t in towns)
            {
                Console.WriteLine($"{t.Id,-4}{t.Name,-15}{t.Country.Name,-15}");
            }
        }
        public void PrintQuestionsInfo(List<Question> questions)
        {
            
            foreach (var q in questions)
            {
                PrintQuestionInfo(q);
                
            }
        }
        public void PrintQuestionInfo(Question q)
        {
            Line('_', Console.BufferWidth);
            Console.WriteLine($"Id: {q.Id}");
            Console.WriteLine($"Question: {q.Question1}");
            Console.WriteLine($"Answear: {q.A}");
            Console.WriteLine($"Answear: {q.B}");
            Console.WriteLine($"Answear: {q.C}");
            Console.WriteLine($"Answear: {q.D}");
            Console.WriteLine($"Correct answear: {q.Answear}");
            Console.WriteLine($"Category:{q.Category.QuestionCategory}");
        }
        public void PrintPlayQuestions(Question q,int qNumber)
        {
            Line('_', Console.BufferWidth);
            
            Console.WriteLine($"Question {qNumber}: {q.Question1}");
            Console.WriteLine($"Answear: {q.A}");
            Console.WriteLine($"Answear: {q.B}");
            Console.WriteLine($"Answear: {q.C}");
            Console.WriteLine($"Answear: {q.D}");
        }
        public void PrintPlayersInfo(List<Player> players)
        {
            Console.WriteLine($"{"ID",-4}{"Player name",-25}{"Age",-4}{"Home Town",-20}{"Friend",-20}");
            Line('_', Console.BufferWidth);
            foreach (var p in players)
            {
                Console.WriteLine($"{p.Id,-4}{p.Name,-25}{p.Age,-4}{p.Town.Name,-20}{p.Friend.Name,-20}");
                Line('_', Console.BufferWidth);

            }
            Console.WriteLine();

        }
        public void PrintFriendsInfo(List<Friend> friends)
        {
            Console.WriteLine($"{"ID",-4}{"Friend name",-25}{"Age",-4}{"Home Town",-20}");
            Line('_', Console.BufferWidth);
            foreach (var f in friends)
            {
                Console.WriteLine($"{f.Id,-4}{f.Name,-25}{f.Age,-4}{f.Town.Name,-20}");
                Line('_', Console.BufferWidth);

            }
            Console.WriteLine();

        }


        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }


}
