using EpsiDTO;
using KeDalle;
using KeDalle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 
    Services
{
    public interface IDevoirService
    {
        List<DevoirDto> GetDevoirs();
        DEVOIRS getUndevoir(int id);
        DEVOIRS AjouterUnDevoir(DEVOIRS devs);
        DEVOIRS UpdateUnDevoir(DEVOIRS devs);
        void DeleteUnDevoir(int id);

    }
    public class DevService : IDevoirService
    {
        private IEpsiContext _context;
        public DevService(IEpsiContext ctx)
        {
            _context = ctx;
        }

        public DEVOIRS AjouterUnDevoir(DEVOIRS devs)
        {
           if(devs.ID > 0)
            {
                throw new InvalidOperationException("existe deja");
            }
            _context.devs.Add(devs);
            return devs;
        }

      

        public List<DevoirDto> GetDevoirs()
        {
            var devoirdal = _context.devs.ToList();

            return devoirdal.Select(e => new DevoirDto
            {
                ID = e.ID,
                NomDevoir = e.NomDevoir,
                Note = e.Note,
               

            }).ToList();


        }

        public DEVOIRS getUndevoir(int id)
        {
            var devoir = _context.devs.SingleOrDefault(e => e.ID == id);
            if(devoir == null)
            {
                throw new InvalidOperationException("Le devoir avec l'id" + id + " existe pas");
            }
            return devoir;
        }

        public DEVOIRS UpdateUnDevoir(DEVOIRS devs)
        {
            var devoiraupdate = getUndevoir(devs.ID);
            devoiraupdate.NomDevoir = devs.NomDevoir;
            devoiraupdate.Note = devs.Note;
            return devs;
        }

         public void DeleteUnDevoir(int id)
        {
            var devoir = getUndevoir(id);
            _context.devs.Remove(devoir);
        }
    }
}
