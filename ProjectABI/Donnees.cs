using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectABI

/// <summary>
/// classe générale des données à gérer
/// -----------------------------------
/// classe qui regroupe les données
/// de l'application de gestion des Clients et Contacts 
/// dans deux collections d'objets définie en static (= non instanciable)
/// </summary>
{
    internal class Donnees
    {


        /// <summary> 
        ///  collection d'objets MClient
        /// </summary>
  //      public static List<MClient> ListClient = new List<MClient>();


        /// <summary> 
        ///  collection d'objets MContact
        /// </summary>
        public static List<MContact> ListContact = new List<MContact>();



        /// <summary>
        /// collection Entity
        /// </summary>
        public static BDDABIProjectEntities Db = new BDDABIProjectEntities();


    }
}
