using EpsiDTO;
using KeDalle;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EtudiantsServices
{
    public interface IEtudiantServices
    {
        List<EtudiantDTO> GetEtudiantDTOs();
    }

    public class EtudiantsServicess : IEtudiantServices
    {
        private IEpsiContext _context;
        public EtudiantsServicess(IEpsiContext ctx)
        {
            _context = ctx;
        }

        public List<EtudiantDTO> GetEtudiantDTOs()
        {
            var etudiantDal = _context.etudiants.ToList();

            return etudiantDal.Select(e => new EtudiantDTO
            {
                ID = e.ID,
                Nom = e.Nom,
                Prenom = e.Prenom,
                AGE = e.AGE

            }).ToList();

           
        }

    }

    
}
