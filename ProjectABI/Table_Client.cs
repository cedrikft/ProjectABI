//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectABI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Client()
        {
            this.Table_Contact = new HashSet<Table_Contact>();
        }
    
        public int idClient { get; set; }
        public string raisonSociale { get; set; }
        public string typeClient { get; set; }
        public string domaineActivite { get; set; }
        public string adresseClient { get; set; }
        public string telephoneClient { get; set; }
        public string natureClient { get; set; }
        public int chiffreAffaireClient { get; set; }
        public int effectifClient { get; set; }
        public string commentairesClient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Contact> Table_Contact { get; set; }
    }
}