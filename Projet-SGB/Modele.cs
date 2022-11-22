using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projet_SGB
{
    internal static class Modele
    {
        private static Connect_GSB ma_connexion;
        private static Visiteur utilisateur_connecte;
        private static bool connexion_valide;


        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            ma_connexion = new Connect_GSB();
        }

        public static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string validConnexion(string id, string mp)
        {
            string message = "test";
            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            return message;
        }


        public static List<Visiteur> listeVisiteur()
        {
            return ma_connexion.Visiteur.ToList();
        }

        public static bool modif_info(Visiteur visiteur_courant, string nom, string prenom, string rue, string code_postal, string ville)
        {
            /*
            requetes inutiles

            var requete_nom = "update Visiteur set nom = '" + nom + "' where Visiteur.idVisiteur = '" + nom +"';";
            var requete_prenom = "update Visiteur set prenom = '" + prenom + "' where Visiteur.idVisiteur = '" + nom + "';";
            var requete_rue = "update Visiteur set rue = '" + rue + "' where Visiteur.idVisiteur = '" + nom + "';";
            var requete_code_postal = "update Visiteur set code_postal = '" + code_postal + "' where Visiteur.idVisiteur = '" + nom + "';";
            var requete_ville = "update Visiteur set ville = '" + ville + "' where Visiteur.idVisiteur = '" + nom + "';";*/

            try
            {
                visiteur_courant.nom = nom;
                visiteur_courant.prenom = prenom;
                visiteur_courant.rue = rue;
                visiteur_courant.cp = code_postal;
                visiteur_courant.ville = ville;

                ma_connexion.SaveChanges();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                return false;
            }
            return true;
        }

        public static bool modif_mdp(Visiteur visiteur_courant, string mdp_actuel, string nv_mdp, string conf_nv_mdp)
        {
            try
            {
                if(visiteur_courant.password == Modele.GetMd5Hash(mdp_actuel) && nv_mdp == conf_nv_mdp)
                {
                    visiteur_courant.password = Modele.GetMd5Hash(nv_mdp);

                    ma_connexion.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.Message);
                return false;
            }
            return true;
        }
    }
}
