using EpsiDTO;
using EtudiantsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TD_WebApplication.Controllers
{
    [Route("api/etudiants")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {
        private IEtudiantServices _service;
        public EtudiantController(IEtudiantServices etudiant)
        {
            _service = etudiant;
        }

        public List<EtudiantDTO> GetEtudiantDTOs()
        {
            var services = new EtudiantsServicess();
            return _service.GetEtudiantDTOs();
        }


    }
}
