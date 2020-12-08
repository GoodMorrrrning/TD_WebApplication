using EpsiDTO;
using KeDalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 
    Services
{
    public interface IDevoirService
    {
        List<DevoirDto> GetDevoirDtos();
    }
    public class DevService : IDevoirService
    {
        private IEpsiContext _context;
        public DevService(IEpsiContext ctx)
        {
            _context = ctx;
        }

        public List<DevoirDto> GetDevoirDtos()
        {
            var devoirdal = _context.devs.ToList();

            return devoirdal.Select(e => new DevoirDto
            {
                ID = e.ID,
                NomDevoir = e.NomDevoir,
                Note = e.Note,
               

            }).ToList();


        }

    }
}
