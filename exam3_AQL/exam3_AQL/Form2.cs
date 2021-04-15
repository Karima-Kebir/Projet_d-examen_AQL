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
        List<Donnees> donneesEtudiant = Form1.donnees;
        public Form2()
        {
            InitializeComponent();
            afficherPrenom.Text = donneesEtudiant[0].UnEtudiant.Prenom;
            afficherNom.Text = donneesEtudiant[0].UnEtudiant.Nom;
            afficherNumEtudiant.Text = donneesEtudiant[0].UnEtudiant.NumeroEtudiant.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void afficherNumEtudiant_Click(object sender, EventArgs e)
        {            
        }

        private void afficherNom_Click(object sender, EventArgs e)
        {
        }

        private void afficherPrenom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
