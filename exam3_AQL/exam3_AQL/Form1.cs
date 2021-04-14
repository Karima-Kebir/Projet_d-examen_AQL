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

                Cours cours = new Cours(int.Parse(textNumCours.Text), textCodeCours.Text, textTitreCours.Text);

                dataGridView.Rows.Add(cours.NumeroCours, cours.CodeCours, cours.TitreCours);
                CoursList.Add(cours);
                incrementCours++;

                textNumCours.Text = incrementCours.ToString();
                textCodeCours.Clear();
                textTitreCours.Clear();

            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir un nombre dans le champs : Numéro de cours");
            }

        }

        private void textNumCours_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjoutEtudiant_Click(object sender, EventArgs e)
        {
            try
            {
            Etudiant etudiant = new Etudiant (textNomEtudiant.Text, textPrenomEtudiant.Text);

            textNumEtudiant.Text = etudiant.NumeroEtudiant + "";

            dataGridViewEtudiant.Rows.Add(textNumEtudiant.Text , textNomEtudiant.Text, textPrenomEtudiant.Text);
            
            ListeEtudiants.Add(etudiant);

            int increment = int.Parse(textNumEtudiant.Text);
            increment++;


            textNomEtudiant.Clear();
            textPrenomEtudiant.Clear();
            textNumEtudiant.Text = increment + "";

            }
            catch (FormatException)
            {
                MessageBox.Show("Vous devez saisir les types convenables");
            }
        } 

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textNumEtudiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumEtudiant_Click(object sender, EventArgs e)
        {

        }

  
    }
}
