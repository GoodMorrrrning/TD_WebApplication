using EpsiDTO;
using EtudiantsServices;
using KeDalle.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TD_WebApplication.Controllers
{
    [Route("api/etudiantss")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {
        private IEtudiantServices _service;
        public EtudiantController(IEtudiantServices etudiant)
        {
            _service = etudiant;
        }

      

        [HttpGet]
        public List<EtudiantDTO> GetEtudiants()
        {
            return _service.GetEtudiants().Select(e => new EtudiantDTO
            {
                ID = e.ID,
                Nom = e.Nom,
                Prenom = e.Prenom
            }).ToList();
        }
    }
}
