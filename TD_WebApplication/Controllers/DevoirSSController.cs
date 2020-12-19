using EpsiDTO;
using EtudiantsServices;
using KeDalle;
using KeDalle.Model;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TD_WebApplication.Controllers
{
    [Route("api/ledevoir")]
    [ApiController]
    public class DevoirSSController : ControllerBase
    {
        private IDevoirService _serv;
        private IEpsiContext _context;
        public DevoirSSController(IDevoirService ledevoir, IEpsiContext ctx)
        {
            _serv = ledevoir;
            _context = ctx;
        }
        [HttpGet]
        public DevoirDto getUndevoir(int id)
        {
            var devoir = _serv.getUndevoir(id);

            return new DevoirDto
            {
                ID = devoir.ID,
                NomDevoir = devoir.NomDevoir,
                Note = devoir.Note
            };
        }
        [HttpPost]
        public DevoirDto AjouterUnDevoir(DevoirDto devs)
        {
          if(devs.ID > 0)
            {
                throw new InvalidOperationException("existe deja");
            }
            var devoirs = new DEVOIRS
            {
                NomDevoir = devs.NomDevoir,
                Note = devs.Note
            };
            _serv.AjouterUnDevoir(devoirs);
            _context.SaveChanges();

            return getUndevoir(devoirs.ID);
        }
        [HttpPut]
        public DevoirDto UpdateUnDevoir(DevoirDto devs)
        {
           if(devs.ID < 1)
            {
                throw new InvalidOperationException("fais un effort stp, le devoir existe pas");
            }
            var devoir = new DEVOIRS
            {
                ID = devs.ID,
                NomDevoir = devs.NomDevoir,
                Note = devs.Note,

            };
            _serv.UpdateUnDevoir(devoir);
            _context.SaveChanges();
            return devs;

        }
        [HttpDelete]
        public void DeleteUnDevoir(int id)
        {
            _serv.DeleteUnDevoir(id);
            _context.SaveChanges();
        }

      

    }
}
