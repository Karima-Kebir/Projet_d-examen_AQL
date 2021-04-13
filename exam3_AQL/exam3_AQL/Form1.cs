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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Bouton Ajouter cours
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               Note note = new Note(int.Parse(textNumEtudiant.Text), textCodeCours.Text, double.Parse(textNoteCoursEtudaint.Text));
                Cours cours = new Cours(int.Parse(textNumCours.Text), textCodeCours.Text, textTitreCours.Text, note);
                Cours.ListeDeCours.Add(cours);
           
                dataGridView.Rows.Add(cours.NumeroCours , cours.CodeCours , cours.TitreCours , cours.LaNote.NoteCours);

                textNumCours.Text = "";
                textCodeCours.Text = "";
                textTitreCours.Text = "";
                textNoteCoursEtudaint.Text = "";
            }
            catch (FormatException )
            {
                string message = "Des nombres sont requis au nivreau des champs : 'Numéro d'étudiant' , 'Numéro de cours' et 'Note'";
                MessageBox.Show(message);
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

        }
    }
}
