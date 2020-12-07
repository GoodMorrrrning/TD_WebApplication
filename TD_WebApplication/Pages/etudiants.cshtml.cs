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
        public List<EtudiantDTO> ListeEtudiants = new List<EtudiantDTO>();
        public void OnGet()
        {
            coucou = "coucou";
        }
    }
}
