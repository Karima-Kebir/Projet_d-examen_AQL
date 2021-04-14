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
        

        public List<Etudiant> ListeEtudiants = new List<Etudiant>();

        public Form1()
        {
            InitializeComponent();
            textNumEtudiant.Text = 1 +"";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Bouton Ajouter cours
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textNumCours_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjoutEtudiant_Click(object sender, EventArgs e)
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
