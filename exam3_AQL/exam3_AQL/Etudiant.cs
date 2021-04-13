using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
    class Etudiant
    {
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        //Constructeur
        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
        }
    }
}
