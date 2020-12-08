using EpsiDTO;
using EtudiantsServices;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TD_WebApplication.Controllers
{
    [Route("api/LesDevoirs")]
    [ApiController]
    public class DevoirController : ControllerBase
    {
        private IDevoirService _serv;

        public DevoirController(IDevoirService ledevoir)
        {
            _serv = ledevoir;
        }
        public List<DevoirDto> GetDevoirDtos()
        {
            // var services = new EtudiantsServicess();
            return _serv.GetDevoirDtos();
        }

    }
}
