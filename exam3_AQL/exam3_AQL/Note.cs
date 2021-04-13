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

    }
}
