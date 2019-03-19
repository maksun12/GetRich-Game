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
    }
}
