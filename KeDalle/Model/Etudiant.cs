using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KeDalle.Model
{
   public class Etudiant
    {
        [Key]
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

    }

}
