using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIMS
{
    class RessourcesString
    {
        public const String _strTitle = "ABIMS - ";
        public const String _strSearch = "Rechercher";
        public const String _strSearchSentence = "Saisir les termes de votre recherche";
        public const String _strNumber = "Numéro";
        public const String _strClient = "Client";
        public const String _strContact = "Contact";
        public const String _strProject = "Projet";
        public const String _strClientMgt = "Gestion client";
        public const String _strAddClient = "Ajouter un client";
        public const String _strSeeClients = "Voir les clients";
        public const String _strDeleteClients = "Supprimer les clients";
        public const String _strWindows = "Fenêtres";
        public const String _strReopenClient = "Réouvrir le client";
        public const String _strCloseWindows = "Fermer toutes les fenêtres";
        public const String _strList = "Liste";
        public const String _strShowList = "Afficher liste";
        public const String _strDropList = "Vider liste";
        public const String _strType = "Type";
        public const String _strActivityDomain = "Domaine d'activité";
        public const String _strNature = "Nature";
        public const String _strSalesRevenu = "Chiffre d'affaire";
        public const String _strStaff = "Effectif";
        private const String _strClientList = "Liste de clients";

        public static string strClientList
        {
            get
            {
                return _strClientList;
            }
        }
    }
}
