using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
    public class Etudiant
    {
        private static int nombreEtudiants = 0;
        public int NumeroEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        //Constructeur
        public Etudiant(string nom, string prenom)
        {
            this.NumeroEtudiant = ++nombreEtudiants;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                 "Numéro Etudiant : " + this.NumeroEtudiant + "\n" +
                 "Nom : " + this.Nom + "\n" +
                 "Prenom : " + this.Prenom;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Etudiant)) return false;

            Etudiant etudiant = (Etudiant)obj;
            return etudiant.NumeroEtudiant == this.NumeroEtudiant &&
                etudiant.Nom == this.Nom &&
                etudiant.Prenom == this.Prenom;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
