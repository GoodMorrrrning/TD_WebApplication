using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpsiDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TD_WebApplication.Helper;

namespace TD_WebApplication.Pages
{
    public class LesDevoirsModel : PageModel
    {
        private IProxy _prox;
        public LesDevoirsModel(IProxy pr)
        {
            _prox = pr;
        }
        public List<DevoirDto> DevoirDtos { get; set; }

        public async Task OnGetAsync()
        {
            DevoirDtos = await _prox.GetDevoirDTOasync();
        }
    }
}
