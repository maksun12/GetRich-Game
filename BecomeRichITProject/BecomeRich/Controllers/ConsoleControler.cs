using BecomeRich.Views;
using BecomeRich.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BecomeRich.Forms;

namespace BecomeRich.Controllers
{
    class ConsoleControler
    {
        public static BecomeRichContext context = new BecomeRichContext();
        public static ReadController read = new ReadController(context);
        public static InsertController insert = new InsertController();
        public static InOutConsole inOut = new InOutConsole();
        public static MessegeApp messege = new MessegeApp();
        public static MenuConsole menu = new MenuConsole();
        public ConsoleControler()
        {
            while (true)
            {
                switch(menu.Menu())
                    { 
                    case "Add":
                        Add();
                        break;
                    case "Read":
                        Read();
                        break;
                    case "Play":
                        ConsolePlay play = new ConsolePlay();
                        break;
                    case "MainForm":
                        Application.EnableVisualStyles();
                        Application.Run(new MainForm(context, read, insert, inOut, messege));
                        break;

                    default: return;
                        //break;

                }
            }
        }
        public void Add()
        {
            while (true)
            {
                switch (menu.MenuInsert())
                {
                    case "1":
                        InsertIntoCountries();
                        break;
                    case "2":
                        InsertIntoTowns();
                        break;
                    case "3":
                        InsertQuestion();
                        break;
                    case "4":
                        InsertPlayer();
                        break;
                    case "5":
                        InsertFriend();
                        break;
                    default: return;
                        //break;
                }
            }
        }
        public void Read()
        {
            while (true)
            {
                switch (menu.MenuRead())
                {
                    case "1":
                        PrintCountries();
                        break;
                    case "2":
                        PrintTowns();
                        break;
                    case "3":
                        PrintQuestions();
                        break;
                    case "4":
                        PrintPlayers();
                        break;
                    case "5":
                        PrintFriends();
                        break;
                    default: return;
                        //break;
                }
            }
        }
        public void InsertIntoCountries()
        {
            string countryName = inOut.ReadCountryName();
            bool isAdd = insert.InsertIntoCountries(countryName);
            if (isAdd == true)
            {
                inOut.PrintMessage(messege.MessegeInsertCountryTrue(countryName));
            }
            else
            {
                inOut.PrintMessage(messege.MessegeInsertCountryFalse(countryName));
            }
        }
        public void InsertIntoTowns()
        {
            string countryName = inOut.ReadCountryName();
            string townName = inOut.ReadTownName();
            bool isAdd = insert.InsertIntoTowns(townName, countryName);
            if (isAdd == true)
            {
                inOut.PrintMessage(messege.MessegeInsertTownTrue(countryName, townName));
            }
            else
            {
                inOut.PrintMessage(messege.MessegeInsertTownFalse(countryName, townName));
            }

        }
        public void InsertQuestion()
        {
            string addQuestion = inOut.ReadQuestions();
            string addA = inOut.ReadAnswear();
            string addB = inOut.ReadAnswear();
            string addC = inOut.ReadAnswear();
            string addD = inOut.ReadAnswear();
            string addAnswear = inOut.ReadCorrectAnswear();
            int addCategoryId = inOut.ReadCategoryId();
            bool isAdd = insert.InsertIntoQuestions(addQuestion, addA, addB, addC, addD, addAnswear, addCategoryId);
            if (isAdd == true)
            {
                inOut.PrintMessage(messege.MessegeInsertQuestionsTrue(addQuestion, addA, addB, addC, addD, addAnswear, addCategoryId));
            }
            else
            {
                inOut.PrintMessage(messege.MessegeInsertQuestionsFalse(addQuestion, addA, addB, addC, addD, addAnswear, addCategoryId));
            }

        }
        public void InsertPlayer()
        {
            string playerName = inOut.ReadPlayerName();
            int playerAge = inOut.ReadPlayerAge();
            string townName = inOut.ReadTownName();
            string countryName = inOut.ReadCountryName();
            int playerFriendId = inOut.ReadPlayerFriend();
            bool isAdd = insert.InsertIntoPlayer(playerName, playerAge,townName,countryName, playerFriendId);
            if (isAdd)
            {
                inOut.PrintMessage(messege.MessegeInsertPlayerTrue(playerName, playerAge, townName, countryName, playerFriendId));
            }
        }
        public void InsertFriend()
        {
            string friendName = inOut.ReadFriendName();
            int friendAge = inOut.ReadFriendAge();
            string townName = inOut.ReadTownName();
            string countryName = inOut.ReadCountryName();

            bool isAdd = insert.InsertIntoFriend(friendName, friendAge, townName, countryName);
            if (isAdd)
            {
                inOut.PrintMessage(messege.MessegeInsertFriendTrue(friendName, friendAge, townName, countryName));
            }
        }

        public void PrintCountries()
        {
            inOut.PrintCountriesInfo(read.CountriesList());
        }
        public void PrintTowns()
        {
            inOut.PrintTownsInfo(read.TownList());
        }
        public void PrintQuestions()
        {
            inOut.PrintQuestionsInfo(read.QuestionList());
        }
        public void PrintPlayers()
        {
            inOut.PrintPlayersInfo(read.PlayerList());
        }
        public void PrintFriends()
        {
            inOut.PrintFriendsInfo(read.FriendsList());
        }
    }
}
