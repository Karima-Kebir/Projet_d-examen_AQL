using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
   public class Cours

    {
    //Test!
        /// <summary>
        /// Proprités de la classe cours
        /// </summary>

        public int NumeroCours { get; set; }
        public string CodeCours { get; set; }
        public string TitreCours { get; set; }


        /// <summary>
        /// Constructeur initialisant tous les attributs de la classe cours
        /// </summary>
        public Cours(int numeroCours, string codeCours, string titreCours)
        {
            this.NumeroCours = numeroCours;
            this.CodeCours = codeCours;
            this.TitreCours = titreCours;
        }


        /// <summary>
        /// Méthode ToString permetant de convertir l'objet cours vers une chaîne de caractère
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "\n" +
                 "Numéro de cours : " + this.NumeroCours + "\n" +
                 "Code : " + this.CodeCours + "\n" +
                 "Titre : " + this.TitreCours;
        }

    }

















}
