using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EpsiDTO;

namespace TD_WebApplication.Pages
{
    public class etudiantsModel : PageModel
    {
        public string coucou { get; set; }
        public List<EtudiantDTO> ListeEtudiants {get;set;}
        public void OnGet()
        {
           
            ListeEtudiants = new List<EtudiantDTO>();
            
            ListeEtudiants.Add(new EtudiantDTO { ID = 1, Nom="Jean", Prenom="Michel"});
            ListeEtudiants.Add(new EtudiantDTO { ID = 1, Nom="Jack", Prenom="Valentine"});
            ListeEtudiants.Add(new EtudiantDTO { ID = 1, Nom="Georges", Prenom="welles"});
            ListeEtudiants.Add(new EtudiantDTO { ID = 1, Nom="Charlie", Prenom="Heaton"});
            

        }
    }
}
