using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
    public class Note
    {
        public int NumeroEtudiant { get; set; }
        public string CodeCours { get; set; }
        public double NoteCours { get; set; }

       
        public Note(int numeroEtudiant, string codeCours, double noteCours)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.CodeCours = codeCours;
            this.NoteCours = noteCours;
        }

        // Méthode ToString permettant de convertir l'objet cours vers une chaîne de caractère

        public override string ToString()
        {
            return "Numéro Etudiant : " + this.NumeroEtudiant + "\n" +
                    "Code Cours : " + this.CodeCours + "\n" +
                   "Note Cours : " + this.NoteCours;
        }


        // Méthode ToString permettant de comparer deux Notes
        public override bool Equals(object obj)
        {
            if (!(obj is Note)) return false;

            Note note = (Note)obj;
            return note.NumeroEtudiant == this.NumeroEtudiant &&
                note.CodeCours == this.CodeCours &&
               note.NoteCours == this.NoteCours;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
