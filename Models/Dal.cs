using System;
using System.Collections.Generic;
using System.Linq;

namespace VitalWeb.Models
{
    public class Dal : IDal
    {
        private readonly DatabaseCxt bdd;

        public Dal(DatabaseCxt context)
        {
            bdd = context;
        }

        public List<Resto> ObtientTousLesRestaurants()
        {
            return bdd.Restos.ToList();
        }

        public void CreerRestaurant(string nom, string telephone)
        {
            bdd.Restos.Add(new Resto { Nom = nom, Telephone = telephone });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}
