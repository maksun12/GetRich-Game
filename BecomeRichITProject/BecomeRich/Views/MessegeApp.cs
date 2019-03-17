using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Views
{
    class MessegeApp
    {
        
        public string MessegeInsertCountryTrue(string countryName)
        {
            string message = $"{countryName} е добавена успешно в таблицата с държави!";
            return message;
        }
        public string MessegeInsertCountryFalse(string countryName)
        {
            string message = $"{countryName} вече съществува в таблицата с държави!";
            return message;
        }
        public string MessegeInsertTownTrue(string countryName, string townName)
        {
            string message = $"В държавата '{countryName}' е добавен нов град с име'{townName}'!";
            return message;
        }
        public string MessegeInsertTownFalse(string countryName, string townName)
        {
            string message = $"В '{countryName}' вече съществува град с име '{townName}'";
            return message;
        }
        public string MessegeInsertQuestionsTrue(string addQuestion, string addA, string addB, string addC, string addD, string addAnswear, int addCategoryId)
        {
            string message = $"Въпросът е добавен успешно";
            return message;
        }
        public string MessegeInsertQuestionsFalse(string addQuestion, string addA, string addB, string addC, string addD, string addAnswear, int addCategoryId)
        {
            string message = $"Въпросът не е добавен успешно";
            return message;
        }
        public string MessegeInsertPlayerTrue(string playerName,int playerAge,string townName,string countryName,int playerFriendId)
        {
            string message = $"Играчът е добавен успешно";
            return message;
        }
        public string MessegeInsertFriendTrue(string friendName, int friendAge, string townName,string countryName)
        {
            string message = $"Приятелят е добавен успешно";
            return message;
        }

    }

}

