using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            textNumEtudiant.Text = 1 + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textNumCours.Text = incrementCours.ToString();
        }

        private void buttonAjoutCours_Click(object sender, EventArgs e)
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
                MessageBox.Show("Vous devez saisir tous les champs !");
            }
        }

        private void buttonAjoutEtudiant_Click(object sender, EventArgs e)
        {
            if (textNomEtudiant.Text != "" && textPrenomEtudiant.Text != "")
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
                MessageBox.Show("Vous devez saisir tous les champs !");
            }

        }


        // Remplir le comboBox avec les numéros des étudiants deja saisis
        private void remplirComboEtudiant(List<Etudiant> listEtudiant)
        {
            comboNumEtudiant.Items.Clear();
            for (int i = 0; i < listEtudiant.Count(); i++)
            {
                comboNumEtudiant.Items.Add(listEtudiant[i].NumeroEtudiant);
            }
            comboNumEtudiant.Text = listEtudiant[0].NumeroEtudiant.ToString();

        }

        //remplir le comboBox avec les numeros des cours deja saisis
        private void remplirComboCours(List<Cours> listCours)
        {
            comboNumCours.Items.Clear();
            for (int i = 0; i < listCours.Count(); i++)
            {
                comboNumCours.Items.Add(listCours[i].NumeroCours);
            }
            comboNumCours.Text = listCours[0].NumeroCours.ToString();

        }
        //Recherche d'un etudiant dans une liste par son numero
        private Etudiant trouverEtudiant(int numeroDetudiant, List<Etudiant> listEtudiant)
        {
            foreach (Etudiant etudiant in listEtudiant)
            {
                if (etudiant.NumeroEtudiant == numeroDetudiant) return etudiant;
            }
            return null;
        }

        //Recherche d'un cours dans une liste par son numero
        private Cours trouverCours(int numeroDeCours, List<Cours> listeCours)
        {
            foreach (Cours cours in listeCours)
            {
                if (cours.NumeroCours == numeroDeCours) return cours;
            }
            return null;
        }

        //chercher les donnees d'un etudiant dans un registre : tout les lignes cours + note 
        public List<Donnees> RechercherDonneesEtudiant(List<Donnees> listDonnees, int NumEtudiant)
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

        //Verifie si la liste contient la meme ligne pour le meme etudiant et le meme cours
        private bool verifierDoublon(List<Donnees> listedonnee, Etudiant etudiant, Cours cours)
        {
            bool doublon = false;
            foreach (Donnees d in listedonnee)
            {
                if (d.UnEtudiant.Equals(etudiant) && d.UnCours.Equals(cours))
                    doublon = true;
            }
            return doublon;
        }

        private void buttonEnregistrerNoteCours_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboNumEtudiant.Text != "" && comboNumCours.Text != "" && textNoteCoursEtudaint.Text != "")
                {
                    Etudiant etudiant = trouverEtudiant(int.Parse(comboNumEtudiant.Text), ListeEtudiants);
                    Cours cours = trouverCours(int.Parse(comboNumCours.Text), CoursList);
                    Note note = null;

                    if (cours != null)
                    {
                        note = new Note(int.Parse(comboNumEtudiant.Text), cours.CodeCours, int.Parse(textNoteCoursEtudaint.Text));
                    }
                    Donnees donneesEtudiant = new Donnees(etudiant, cours, note);

                    if (verifierDoublon(ListeDonnees, etudiant, cours) == false)
                    {
                        verifierNoteEtudiant(etudiant, donneesEtudiant, cours, note);
                    }
                    else
                    {
                        MessageBox.Show("Cet étudiant a déjà une note pour ce cours.");
                    }

                    verifierSiComboBoxContientCode (etudiant);
                }
                else
                {
                    MessageBox.Show("Vous devez saisir tous les champs !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre dans le champs : Note");
            }
        }

        // Vérifier la note de l'etudiant 
        private void verifierNoteEtudiant(Etudiant etudiant ,Donnees donneesEtudiant , Cours cours , Note note)
        {
            if (int.Parse(textNoteCoursEtudaint.Text) >= 0 && int.Parse(textNoteCoursEtudaint.Text) <= 100)
            {
                if (etudiant == null)
                {
                    MessageBox.Show("Cet étudiant n'existe pas !");
                }
                else if (cours == null)
                {
                    MessageBox.Show("Ce cours n'existe pas !");
                }
                else
                {
                    ListeDonnees.Add(donneesEtudiant);
                    dataGridView2.Rows.Add(etudiant.NumeroEtudiant, etudiant.Nom, etudiant.Prenom, cours.TitreCours, note.NoteCours);
                    textNoteCoursEtudaint.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir une note ente 0 et 100.");
            }
        }

        //tester si le combo contient deja ce code ou non
        private void verifierSiComboBoxContientCode(Etudiant etudiant)
        {
            if (etudiant != null)
            {
                if (!comboCodeEtudiant.Items.Contains(etudiant.NumeroEtudiant))
                {
                    comboCodeEtudiant.Items.Add(etudiant.NumeroEtudiant);
                    comboCodeEtudiant.Text = comboCodeEtudiant.Items[0].ToString();
                }
            }
        }

        private void buttonAfficherReleve_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboCodeEtudiant.Text != "")
                {
                    int NumEtudiant = int.Parse(this.comboCodeEtudiant.Text);
                    if (trouverDonneesEtudiant(this.ListeDonnees, NumEtudiant).Count() != 0)
                    {
                        Form2 form = new Form2();
                        form.DonneesEtudiant = trouverDonneesEtudiant(this.ListeDonnees, NumEtudiant);
                        form.Show();
                    }
                    else MessageBox.Show("Cet etudiant n'existe pas ou n'a pas encore des notes.");
                }
                else MessageBox.Show("Le champ Numero Etudiant est vide.");

            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre.");
            }
        }

        private void buttonExpotTxt_Click(object sender, EventArgs e)
        {
            string donnee = "";

            if (ListeDonnees.Count() != 0)
            {
                foreach (Etudiant etud in ListeEtudiants)
                {
                    List<Donnees> donnesEtudiant = trouverDonneesEtudiant(this.ListeDonnees, etud.NumeroEtudiant);
                    if (donnesEtudiant.Count() != 0)
                    {
                        foreach (Donnees d in donnesEtudiant)
                        {
                            donnee += d.ToString();
                        }
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "WAP Files (*.txt)|*.txt";
                saveFileDialog.OverwritePrompt = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(File.Create(saveFileDialog.FileName));
                    write.WriteLine(donnee);
                    write.Close();
                    write.Dispose();
                }
            }
            else MessageBox.Show("Pas de données à exporter !");


        }
    }
}
