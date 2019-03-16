using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Controllers
{
    class Find
    {
        private static BecomeRichContext context = new BecomeRichContext();

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