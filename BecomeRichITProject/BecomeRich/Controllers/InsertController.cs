using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Controllers
{
 public   class InsertController
    {
        private static BecomeRichContext context = new BecomeRichContext();
        private static Find find = new Find();
        public bool InsertIntoCountries(string countryName)
        {
            if (find.FindCountry(countryName) == null)
            {
                context.Countries.Add(new Country() { Name = countryName });
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool InsertIntoTowns(string townName, string countryName)
        {
            Town findTown = find.FindTown(countryName, townName);
            if (findTown == null)
            {
                InsertIntoCountries(countryName);
                Town newTown = new Town()
                {
                    Name = townName,
                    CountryId = find.FindCountry(countryName).Id
                };
                context.Towns.Add(newTown);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool InsertIntoQuestions(string addQuestion, string addA,string addB,string addC,string addD,string addAnswear,int addCategoryId)
        {
          
            context.Questions.Add(new Question(addQuestion,addA,addB,addC,addD,addAnswear,addCategoryId));
            context.SaveChanges();
            return true;

        }
        public bool InsertIntoPlayer(string playerName, int playerAge, string townName, string countryName, int playerFriendId)
        {
            InsertIntoTowns(townName, countryName);
            Town findTown = find.FindTown(countryName, townName);
            context.Players.Add(new Player(playerName, playerAge, findTown.Id, playerFriendId));
            context.SaveChanges();
            return true;
        }
        public bool InsertIntoFriend(string friendName, int friendAge, string townName, string countryName)
        {
            InsertIntoTowns(townName, countryName);
            Town findTown = find.FindTown(countryName, townName);
            context.Friends.Add(new Friend(friendName,friendAge, findTown.Id));
            context.SaveChanges();
            return true;
        }
    }
}
