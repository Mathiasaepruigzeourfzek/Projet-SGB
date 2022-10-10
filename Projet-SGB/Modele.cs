using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SGB
{
    internal static class Modele
    {
        private static Connect_GSB ma_connexion;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            ma_connexion = new Connect_GSB();
        }
        public static List<Visiteur> listeVisiteur()
        {
            return ma_connexion.Visiteur.ToList();
        }
    }
}
