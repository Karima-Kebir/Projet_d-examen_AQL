using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
   public class Cours

    {
        // Proprités de la classe cours
        public int NumeroCours { get; set; }
        public string CodeCours { get; set; }
        public string TitreCours { get; set; }
        public Note LaNote { get; set; }
        public static List<Cours> ListeDeCours { get; set; } = new List<Cours>();

        // Constructeur initialisant tous les attributs de la classe cours
        public Cours(int numeroCours, string codeCours, string titreCours, Note note)
        {
            this.NumeroCours = numeroCours;
            this.CodeCours = codeCours;
            this.TitreCours = titreCours;
            this.LaNote = note;
        }

        // Méthode ToString permettant de convertir l'objet cours vers une chaîne de caractère
        public override string ToString()
        {
            return base.ToString() + "\n" +
                 "Numéro de cours : " + this.NumeroCours + "\n" +
                 "Code : " + this.CodeCours + "\n" +
                 "Titre : " + this.TitreCours;
        }

    }

















}
