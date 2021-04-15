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
    public partial class Form2 : Form
    {
        public List<Donnees> DonneesEtudiant { get; set; }
        public List<Note> NoteEtudiant = new List<Note>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(DonneesEtudiant.Count() != 0)
            {
                afficherNumero.Text = DonneesEtudiant[0].UnEtudiant.NumeroEtudiant.ToString();
                afficherPrenom.Text = DonneesEtudiant[0].UnEtudiant.Prenom;
                afficherNom.Text = DonneesEtudiant[0].UnEtudiant.Nom;
                afficherNumEtudiant.Text = DonneesEtudiant[0].UnEtudiant.NumeroEtudiant.ToString();
                foreach (Donnees d in DonneesEtudiant)
                {
                    NoteEtudiant.Add(d.UneNote);
                    dataGridView1.Rows.Add(d.UnCours.NumeroCours,d.UnCours.CodeCours,d.UnCours.TitreCours,d.noteduCours());
                }
                double moyenneEtudiant = calculerMoyenne(NoteEtudiant);
                AfficherMoyenne.Text = moyenneEtudiant.ToString();
            }
         
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExportReleveEtudiant_Click(object sender, EventArgs e)
        {
            
            string str = "";

            if (DonneesEtudiant.Count() != 0)
            {
                str += DonneesEtudiant[0].UnEtudiant.ToString();
                str += "\n==============================================================================\n";
                foreach (Donnees d in DonneesEtudiant)
                {
                    str += "Numero Cours : " + d.UnCours.NumeroCours + " | " + "Code Cours : " + d.UnCours.CodeCours + " | " +
                           "Titre Cours : " + d.UnCours.TitreCours + " | " + "Note : " + d.noteduCours() +
                        "\n_____________________________________________________________________________\n";
                       
                }
                str += "\n==============================================================================" +
                    "\nMoyenne = " + calculerMoyenne(NoteEtudiant).ToString();

            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "WAP Files (*.txt)|*.txt";
            saveFileDialog.OverwritePrompt = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(File.Create(saveFileDialog.FileName));
                    write.WriteLine(str);

                    write.Close();
                    write.Dispose();
                }
            }

        private double calculerMoyenne(List<Note> listeNotes )
        {
            double resultat = 0;
            if (listeNotes.Count() != 0)
            {
                
                foreach (Note note in listeNotes)
                {
                    resultat += note.NoteCours;
                }                
            }
            return resultat / listeNotes.Count();
        }
           
        }
    }

