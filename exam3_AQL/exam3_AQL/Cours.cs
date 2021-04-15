using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
   public class Cours
    {  

        public int NumeroCours { get; set; }
        public string CodeCours { get; set; }
        public string TitreCours { get; set; }
        

        public Cours(int numeroCours, string codeCours, string titreCours)
        {
            this.NumeroCours = numeroCours;
            this.CodeCours = codeCours;
            this.TitreCours = titreCours;           
        }

        // Méthode ToString permettant de convertir l'objet cours vers une chaîne de caractère
        public override string ToString()
        {
            return  "Numéro de cours : " + this.NumeroCours + "\n" +
                    "Code : " + this.CodeCours + "\n" +
                    "Titre : " + this.TitreCours;
        }

        // Méthode ToString permettant de comparer deux cours
        public override bool Equals(object obj)
        {
            if (!(obj is Cours)) return false;

            Cours cours = (Cours)obj;
            return cours.NumeroCours == this.NumeroCours &&
                cours.TitreCours == this.TitreCours &&
                cours.CodeCours == this.CodeCours;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
