using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitalWeb.Models
{
    public interface IDal : IDisposable
    {
        void CreerRestaurant(string nom, string telephone);
        
        // Contrat de méthode qui permet de récupérer la liste de tous les restaurants.
        List<Resto> ObtientTousLesRestaurants();
    }
}