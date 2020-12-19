using EpsiDTO;
using EtudiantsServices;
using KeDalle.Model;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TD_WebApplication.Controllers
{
    [Route("api/lesdevoirs")]
    [ApiController]
    public class DevoirController : ControllerBase
    {
        private IDevoirService _serv;

        public DevoirController(IDevoirService ledevoir)
        {
            _serv = ledevoir;
        }
        [HttpGet]
        public List<DevoirDto> GetDevoirs()
        {
            // var services = new EtudiantsServicess();
            return _serv.GetDevoirs().Select(e => new DevoirDto
            {
                ID = e.ID,
                NomDevoir = e.NomDevoir,
                Note = e.Note

            }).ToList();
        }

    }
}
