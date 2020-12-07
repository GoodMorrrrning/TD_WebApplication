using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TD_WebApplication.Pages
{
    public class etudiantsModel : PageModel
    {
        public string coucou { get; set; }
        public void OnGet()
        {
            coucou = "coucou";
        }
    }
}
