using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KeDalle.Model
{
   public class DEVOIRS
    {
        [Key]
        public int ID { get; set; }
        public int Note { get; set; }
        public string NomDevoir { get; set; }
        public int IDETUDIANT { get; set; }
    }
}
