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
                    dataGridView1.Rows.Add(d.UnCours.NumeroCours,d.UnCours.CodeCours,d.UnCours.TitreCours,d.noteduCours());
                }
                
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
                    str += "Numero Cours : " + d.UnCours.NumeroCours +" | " + "Code Cours : "+ d.UnCours.CodeCours+ " | "+
                           "Titre Cours : " + d.UnCours.TitreCours + " | " + "Note : " + d.noteduCours() +
                        "\n_____________________________________________________________________________\n";
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
           
        }
    }

