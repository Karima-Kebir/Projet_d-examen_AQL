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
    }
}
