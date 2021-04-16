using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3_AQL
{
    public class Donnees
    {
        public Etudiant UnEtudiant { get; set; }
        public Cours UnCours { get; set; }
        public Note UneNote { get; set; }


        public Donnees(Etudiant etudiant, Cours cours, Note note)
        {
            this.UnEtudiant = etudiant;
            this.UnCours = cours;
            this.UneNote = note;
        }

        public override string ToString()
        {
            return this.UnEtudiant.ToString() + "\n" +
                   this.UnCours.TitreCours + " : " + this.UneNote.NoteCours + "\n" +
                   "_________________________________" + "\n";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Donnees)) return false;

            Donnees d = (Donnees)obj;
            return d.UnCours == this.UnCours &&
                   d.UneNote == this.UneNote &&
                   d.UnEtudiant == this.UnEtudiant;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //ajouter une ligne de donnees (etudiant+cours+note) dans un registre(liste)
        public List<Donnees> ajouterDansRegistre(Donnees donnees)
        {
            List<Donnees> listDonnees = new List<Donnees>();
            if (donnees != null)
            {
                listDonnees.Add(donnees);
            }
            return listDonnees;
        }

        //chercher les donnees d'un etudiant dans un registre : tout les lignes cours + note 
        public List<Donnees> rechercherDonneesEtudiant(List<Donnees> listDonnees, int NumEtudiant)
        {
            List<Donnees> donneesTrouve = new List<Donnees>();
            foreach (Donnees d in listDonnees)
            {
                if (d.UnEtudiant.NumeroEtudiant == NumEtudiant)
                {
                    donneesTrouve.Add(d);
                }
            }
            return donneesTrouve;
        }

        public double rechercherNoteduCours()
        {
            double note = 0;

            if (this.UnCours.CodeCours == this.UneNote.CodeCours)
                note = this.UneNote.NoteCours;

            return note;
        }
    }
}
