using EpsiDTO;
using KeDalle;
using KeDalle.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EtudiantsServices
{
    public interface IEtudiantServices
    {
        List<Etudiant> GetEtudiants();
        Etudiant GetEtudiant(int id);
        Etudiant AjoutEtudiants(Etudiant etu);
        Etudiant UpdateEtudiant(Etudiant etu);
        void DeleteEtudiant(int id);
    }

    public class EtudiantsServicess : IEtudiantServices
    {
        private IEpsiContext _context;
        public EtudiantsServicess(IEpsiContext ctx)
        {
            _context = ctx;
        }

        public Etudiant GetEtudiant(int id)
        {
            var etudiant = _context.etudiants.SingleOrDefault(e => e.ID == id);
            if(etudiant == null)
            {
                throw new InvalidOperationException("L'etudiant avec l'id" + id + " existe pas");
            }
            return etudiant;
        }
        public List<Etudiant> Getetudiants()
        {
            var etudiantDal = _context.etudiants.ToList();

            return etudiantDal;
        }
        
       
        public void DeleteEtudiant(int id)
        {
            var etudiant = GetEtudiant(id);
            _context.etudiants.Remove(etudiant);

        }
      
        public List<Etudiant> GetEtudiants()
        {
            var etudiantDal = _context.etudiants.ToList();

            return etudiantDal.Select(e => new Etudiant
            {
                ID = e.ID,
                Nom = e.Nom,
                Prenom = e.Prenom,
                AGE = e.AGE

            }).ToList();

           
        }

      
        public Etudiant UpdateEtudiant(Etudiant etu)
        {
            var etudiantaupdate = GetEtudiant(etu.ID);
            etudiantaupdate.Nom = etu.Nom;
            etudiantaupdate.Prenom = etu.Prenom;
            etudiantaupdate.AGE = etu.AGE;
            return etu;
        }
        

        public Etudiant AjoutEtudiants(Etudiant etu)
        {
            if (etu.ID > 0)
            {
                throw new InvalidOperationException(" il existe deja !");
            }

            _context.etudiants.Add(etu);
            return etu;
        }
    }

    
}
