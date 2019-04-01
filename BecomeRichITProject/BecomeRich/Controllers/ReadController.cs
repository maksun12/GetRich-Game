using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Controllers
{
    public class ReadController
    {
        private BecomeRichContext context;
        public ReadController(BecomeRichContext context)
        {
            this.context = context;
        }
        public List<Country> CountriesList()
        {
            return context.Countries.OrderBy(c => c.Name).ToList();
        }
        public List<Town> TownList()
        {
            return context.Towns.OrderBy(t => t.Name).ToList();
        }
        public List<Question> QuestionList()
        {
            return context.Questions.OrderBy(q => q.CategoryId).ToList();
        }
        public List<Player> PlayerList()
        {
            return context.Players.OrderBy(p => p.Name).ToList();
        }
        public List<Friend> FriendsList()
        {
            return context.Friends.OrderBy(f => f.Name).ToList();
        }
        public Country FindCountry(string countryName)
        {
            Country find = context.Countries.FirstOrDefault(x => x.Name == countryName);
            return find;
        }

        public Town FindTown(string countryName, string townName)
        {
            Country findCountry = FindCountry(countryName);
            if (findCountry == null)
            {
                return null;
            }
            else
            {
                Town find = context.Towns.Where(x => x.Name == townName && x.Country.Name == countryName).FirstOrDefault();
                return find;

            }

        }
    }
}
