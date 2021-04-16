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

        //Bouton Ajouter cours
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
                    MessageBox.Show("Vous devez saisir tous les champs");
                }
        }


        //remplir le comboBox avec les numeros des etudiants deja saisies
        private void remplirComboEtudiant(List<Etudiant> listetudiant)
        {
            comboNumEtudiant.Items.Clear();
            for (int i = 0; i < listetudiant.Count(); i++)
            {
                comboNumEtudiant.Items.Add(listetudiant[i].NumeroEtudiant);
            }
            comboNumEtudiant.Text = listetudiant[0].NumeroEtudiant.ToString();

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
        private bool verifieDoublant(List<Donnees> listedonnee, Etudiant etudiant, Cours cours)
        {
            bool test = false;
            foreach (Donnees d in listedonnee)
            {
                if (d.UnEtudiant.Equals(etudiant) && d.UnCours.Equals(cours))
                    test= true; 
            }
            return test;
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
                    if (verifieDoublant(ListeDonnees,etudiant,cours)==false)
                    {
                        if(int.Parse(textNoteCoursEtudaint.Text) >=0 && int.Parse(textNoteCoursEtudaint.Text) <= 100)
                        {
                            ListeDonnees.Add(donneesEtudiant);
                            dataGridView2.Rows.Add(etudiant.NumeroEtudiant, etudiant.Nom, etudiant.Prenom, cours.TitreCours, note.NoteCours);
                            textNoteCoursEtudaint.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Saisissez une note ente 0 et 100");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cet etudiant a deja une note pour ce cours");
                    }
                    

                    if (!comboCodeEtudiant.Items.Contains(etudiant.NumeroEtudiant)) //tester si le combo contient deja ce code ou non
                    {
                        comboCodeEtudiant.Items.Add(etudiant.NumeroEtudiant);
                        comboCodeEtudiant.Text = comboCodeEtudiant.Items[0].ToString();
                    }           
                }
                else
                {
                    MessageBox.Show("Vous devez saisir tous les champs");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre dans le champs : Note");
            }
        }


        private void buttonAfficherReleve_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.comboCodeEtudiant.Text != "")
                {
                    int NumEtudiant = int.Parse(this.comboCodeEtudiant.Text);
                    if (RechercherDonneesEtudiant(this.ListeDonnees, NumEtudiant).Count()!=0)
                    {
                        Form2 form = new Form2();
                        form.DonneesEtudiant = RechercherDonneesEtudiant(this.ListeDonnees, NumEtudiant);
                        form.Show();
                    }
                    else MessageBox.Show("Cet etudiant n'existe pas ou n'a pas encore des notes");
                }
                else MessageBox.Show("Le champ Numero Etudiant est vide");

            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre ");
            }


        }

        private void buttonExpotTxt_Click(object sender, EventArgs e)
        {
            
            string str = "";
           
                if (ListeDonnees.Count()!=0)
                {
                foreach(Etudiant etud in ListeEtudiants)
                {
                    List<Donnees> donnesEtudiant = RechercherDonneesEtudiant(this.ListeDonnees, etud.NumeroEtudiant);
                    if (donnesEtudiant.Count() != 0)
                    {
                        foreach (Donnees d in donnesEtudiant)
                        {
                            str += d.ToString();
                        }
                    }
                }
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "WAP Files (*.txt)|*.txt";
                    sfd.OverwritePrompt = true;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter write = new StreamWriter(File.Create(sfd.FileName));
                        write.WriteLine(str);

                        write.Close();
                        write.Dispose();
                    }
                }
                else MessageBox.Show("Pas de donnees a Exporter !");
            
            
        }
    }
}
