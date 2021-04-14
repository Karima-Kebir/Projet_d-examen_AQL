using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3_AQL
{
    public partial class Form1 : Form
    {

        private int incrementCours = 1;
        public List<Cours> CoursList = new List<Cours>();
        public List<Etudiant> ListeEtudiants = new List<Etudiant>();
        public List<Donnees> ListeDonnees = new List<Donnees>();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textNumCours.Text = incrementCours.ToString();
			textNumEtudiant.Text = 1 +"";

        }

        //Bouton Ajouter cours
        private void buttonAjoutCours_Click(object sender, EventArgs e)
        {
           try
            {
                if (textCodeCours.Text != "" && textTitreCours.Text != "")
                {
                    Cours cours = new Cours(int.Parse(textNumCours.Text), textCodeCours.Text, textTitreCours.Text);

                    dataGridView.Rows.Add(cours.NumeroCours, cours.CodeCours, cours.TitreCours);
                    CoursList.Add(cours);
                    incrementCours++;

                    textNumCours.Text = incrementCours.ToString();
                    textCodeCours.Clear();
                    textTitreCours.Clear();

                    if (CoursList.Count() != 0)
                        remplirComboCours(CoursList);
                }
                else
                {
                    MessageBox.Show("Vous devez saisir tous les champs");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre dans le champs : Numéro de cours");
            }

        }

  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjoutEtudiant_Click(object sender, EventArgs e)
        {
            try
            {
             if(textNomEtudiant.Text !="" && textPrenomEtudiant.Text != "")
                {
                    Etudiant etudiant = new Etudiant(textNomEtudiant.Text, textPrenomEtudiant.Text);

                    textNumEtudiant.Text = etudiant.NumeroEtudiant + "";

                    dataGridViewEtudiant.Rows.Add(textNumEtudiant.Text, textNomEtudiant.Text, textPrenomEtudiant.Text);

                    ListeEtudiants.Add(etudiant);

                    int increment = int.Parse(textNumEtudiant.Text);
                    increment++;

                    textNomEtudiant.Clear();
                    textPrenomEtudiant.Clear();
                    textNumEtudiant.Text = increment + "";

                    if (ListeEtudiants.Count() != 0)
                    {
                        remplirComboEtudiant(ListeEtudiants);
                    }
                        
                }
                else
                {
                    MessageBox.Show("Vous devez saisir tous les champs");
                }
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir les types convenables");
            }
        }
        //remplir le comboBox avec les numeros des etudiants deja saisies
        private void remplirComboEtudiant(List<Etudiant> listetudiant)
        {
            comboNumEtudiant.Items.Clear();
            for (int i=0; i < listetudiant.Count(); i++)
            {
                comboNumEtudiant.Items.Add(listetudiant[i].NumeroEtudiant);
            }
            comboNumEtudiant.Text = listetudiant[0].NumeroEtudiant.ToString();

        }
        //remplir le comboBox avec les numeros des etudiants deja saisies
        private void remplirComboCodeEtudiant(List<Etudiant> listetudiant)
        {
            comboCodeEtudiant.Items.Clear();
            for (int i = 0; i < listetudiant.Count(); i++)
            {
                comboCodeEtudiant.Items.Add(listetudiant[i].NumeroEtudiant);
            }
            comboCodeEtudiant.Text = listetudiant[0].NumeroEtudiant.ToString();

        }
        //remplir le comboBox avec les numeros des cours deja saisies
        private void remplirComboCours(List<Cours> listcours)
        {
            comboNumCours.Items.Clear();
            for (int i = 0; i < listcours.Count(); i++)
            {
                comboNumCours.Items.Add(listcours[i].NumeroCours);
            }
            comboNumCours.Text = listcours[0].NumeroCours.ToString();

        }
        //Recherche d'un etudiant dans une liste par son numero
        private Etudiant findEtudiant(int num, List<Etudiant> listetudiant)
        {
            foreach (Etudiant et in listetudiant)
            {
                if (et.NumeroEtudiant == num) return et;

            }
            return null;
        }

        //Recherche d'un cours dans une liste par son numero
        private Cours findCours(int num, List<Cours> listecours)
        {
            foreach (Cours c in listecours)
            {
                if (c.NumeroCours == num) return c;
            }
            return null;
        }

        private void buttonEnregistrerNoteCours_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboNumEtudiant.Text != "" && comboNumCours.Text != "" && textNoteCoursEtudaint.Text != "")
                {
                    Etudiant etudiant = findEtudiant(int.Parse(comboNumEtudiant.Text), ListeEtudiants);
                    Cours cours = findCours(int.Parse(comboNumCours.Text), CoursList);
                    Note note = new Note(int.Parse(comboNumEtudiant.Text), cours.CodeCours, int.Parse(textNoteCoursEtudaint.Text));
                    Donnees donneesEtudiant = new Donnees(etudiant, cours, note);

                    dataGridView2.Rows.Add(etudiant.NumeroEtudiant, etudiant.Nom, etudiant.Prenom, cours.TitreCours, note.NoteCours);
                    
                    ListeDonnees.Add(donneesEtudiant);
                   
                    textNoteCoursEtudaint.Clear();
                    comboCodeEtudiant.Items.Add(etudiant.NumeroEtudiant);
                    comboCodeEtudiant.Text = comboCodeEtudiant.Items[0].ToString();
                }
                else
                {
                    MessageBox.Show("Vous devez saisir tous les champs");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre dans le champs : Numéro de cours");
            }
        }

    }
}
