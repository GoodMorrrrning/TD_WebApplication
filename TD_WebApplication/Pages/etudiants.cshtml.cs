using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EpsiDTO;
using TD_WebApplication.Helper;

namespace TD_WebApplication.Pages
{
    public class etudiantsModel : PageModel
    {
        private IProxy _proxy;

        public etudiantsModel(IProxy prox)
        {
            _proxy = prox;
        }

        public string coucou { get; set; }
        public List<EtudiantDTO> ListeEtudiants {get;set;}
        public async Task OnGetAsync()
        {
            
            ListeEtudiants = await _proxy.GetEtudiantDTOsAsync();
            

        }
    }
}
