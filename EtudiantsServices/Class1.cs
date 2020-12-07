using EpsiDTO;
using System;
using System.Collections.Generic;


namespace EtudiantsServices
{
    public interface IEtudiantServices
    {
        List<EtudiantDTO> GetEtudiantDTOs();
    }

    public class EtudiantsServicess : IEtudiantServices
    {
        public List<EtudiantDTO> GetEtudiantDTOs()
        {
            List<EtudiantDTO> etudiants = new List<EtudiantDTO>();

            etudiants.Add(new EtudiantDTO { ID = 1, Nom = "Jean", Prenom = "Michel" });
            etudiants.Add(new EtudiantDTO { ID = 1, Nom = "Jack", Prenom = "Valentine" });
            etudiants.Add(new EtudiantDTO { ID = 1, Nom = "Georges", Prenom = "welles" });
            etudiants.Add(new EtudiantDTO { ID = 1, Nom = "Charlie", Prenom = "Heaton" });
            return etudiants;
        }

    }
}
