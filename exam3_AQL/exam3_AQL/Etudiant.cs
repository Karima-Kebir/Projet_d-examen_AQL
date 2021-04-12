using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam3_AQL
{
    public class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Cours> ListeDeCours { get; set; }


        //Constructeur
        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
            this.ListeDeCours = new List<Cours>();
        }
    }
}
