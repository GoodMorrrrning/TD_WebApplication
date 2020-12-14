using EpsiDTO;
using EtudiantsServices;
using KeDalle;
using KeDalle.Model;
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
    public class EtudiantSSController : ControllerBase
    {
        private IEtudiantServices _service;
        private IEpsiContext _context;
        public EtudiantSSController(IEtudiantServices etudiant, IEpsiContext ctx)
        {
            _service = etudiant;
            _context = ctx;
        }
        [HttpPost]
        public EtudiantDTO AjoutEtudiants(EtudiantDTO etu)
        {
            if (etu.ID > 0)
            {
                throw new InvalidOperationException(" il existe deja !");
            }
            var etudiantajout = new Etudiant
            {
                Nom = etu.Nom,
                AGE = etu.AGE,
                Prenom = etu.Prenom
            };
            _service.AjoutEtudiants(etudiantajout);
            _context.SaveChanges();
            return GetEtudiant(etu.ID);
        }

        [HttpGet]
        public EtudiantDTO GetEtudiant(int id)
        {
            // var services = new EtudiantsServicess();
            var etudiant = _service.GetEtudiant(id);

            return new EtudiantDTO
            {
                ID = etudiant.ID,
                Nom = etudiant.Nom,
                Prenom = etudiant.Prenom,
            };
        }

        [HttpPut]
        public EtudiantDTO UpdateEtudiant(EtudiantDTO etu)
        {
            if(etu.ID < 1)
            {
                throw new InvalidOperationException("Il existe pas fais un effort Stp");
            }
            var etudiantupdate = new Etudiant
            {
                Nom = etu.Nom,
                Prenom = etu.Prenom,
                AGE = etu.AGE
            };
            _service.UpdateEtudiant(etudiantupdate);
            _context.SaveChanges();
            return etu;
        }

        [HttpDelete]
        public void DeleteEtudiant(int id)
        {
            // var services = new EtudiantsServicess();
            _service.DeleteEtudiant(id);
            _context.SaveChanges();
        }
       
    }
}
