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
<<<<<<< HEAD
        public int CodeCours { get; set; }
        public double NoteCours { get; set; }

        public Note(int numeroEtudiant, int codeCours, double noteCours)
=======
        public string CodeCours { get; set; }
        public double NoteCours { get; set; }

        public Note(int numeroEtudiant, string codeCours, double noteCours)
>>>>>>> refs/remotes/origin/main
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.CodeCours = codeCours;
            this.NoteCours = noteCours;
        }
<<<<<<< HEAD


=======
>>>>>>> refs/remotes/origin/main
    }
}
