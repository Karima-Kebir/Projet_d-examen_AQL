﻿
namespace Exam3_AQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textNumEtudiant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrenomEtudiant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumCours = new System.Windows.Forms.TextBox();
            this.textCodeCours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNoteCoursEtudaint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTitreCours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAjoutCours = new System.Windows.Forms.Button();
            this.buttonEnregistrerNoteCours = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCodeEtudiant = new System.Windows.Forms.ComboBox();
            this.buttonAfficherReleve = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textNomEtudiant = new System.Windows.Forms.TextBox();
            this.buttonAjoutEtudiant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboNumEtudiant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboNumCours = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonExpotTxt = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro d\'étudiant";
            // 
            // textNumEtudiant
            // 
            this.textNumEtudiant.Location = new System.Drawing.Point(148, 41);
            this.textNumEtudiant.Name = "textNumEtudiant";
            this.textNumEtudiant.Size = new System.Drawing.Size(139, 22);
            this.textNumEtudiant.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom";
            // 
            // textPrenomEtudiant
            // 
            this.textPrenomEtudiant.Location = new System.Drawing.Point(148, 96);
            this.textPrenomEtudiant.Name = "textPrenomEtudiant";
            this.textPrenomEtudiant.Size = new System.Drawing.Size(139, 22);
            this.textPrenomEtudiant.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero de cours";
            // 
            // textNumCours
            // 
            this.textNumCours.Location = new System.Drawing.Point(129, 33);
            this.textNumCours.Name = "textNumCours";
            this.textNumCours.Size = new System.Drawing.Size(127, 22);
            this.textNumCours.TabIndex = 7;
            this.textNumCours.TextChanged += new System.EventHandler(this.textNumCours_TextChanged);
            // 
            // textCodeCours
            // 
            this.textCodeCours.Location = new System.Drawing.Point(129, 65);
            this.textCodeCours.Name = "textCodeCours";
            this.textCodeCours.Size = new System.Drawing.Size(127, 22);
            this.textCodeCours.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code du cours";
            // 
            // textNoteCoursEtudaint
            // 
            this.textNoteCoursEtudaint.Location = new System.Drawing.Point(678, 54);
            this.textNoteCoursEtudaint.Name = "textNoteCoursEtudaint";
            this.textNoteCoursEtudaint.Size = new System.Drawing.Size(94, 22);
            this.textNoteCoursEtudaint.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Note";
            // 
            // textTitreCours
            // 
            this.textTitreCours.Location = new System.Drawing.Point(129, 96);
            this.textTitreCours.Name = "textTitreCours";
            this.textTitreCours.Size = new System.Drawing.Size(127, 22);
            this.textTitreCours.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Titre de cours";
            // 
            // buttonAjoutCours
            // 
            this.buttonAjoutCours.Location = new System.Drawing.Point(337, 84);
            this.buttonAjoutCours.Name = "buttonAjoutCours";
            this.buttonAjoutCours.Size = new System.Drawing.Size(129, 29);
            this.buttonAjoutCours.TabIndex = 14;
            this.buttonAjoutCours.Text = "Ajouter un cours";
            this.buttonAjoutCours.UseVisualStyleBackColor = true;
            this.buttonAjoutCours.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEnregistrerNoteCours
            // 
            this.buttonEnregistrerNoteCours.Location = new System.Drawing.Point(832, 54);
            this.buttonEnregistrerNoteCours.Name = "buttonEnregistrerNoteCours";
            this.buttonEnregistrerNoteCours.Size = new System.Drawing.Size(150, 25);
            this.buttonEnregistrerNoteCours.TabIndex = 16;
            this.buttonEnregistrerNoteCours.Text = "Enregistrer";
            this.buttonEnregistrerNoteCours.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(928, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "_________________________________________________________________________________" +
    "__________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Relevé de notes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Entrer Numero étudiant";
            // 
            // comboCodeEtudiant
            // 
            this.comboCodeEtudiant.FormattingEnabled = true;
            this.comboCodeEtudiant.Location = new System.Drawing.Point(176, 76);
            this.comboCodeEtudiant.Name = "comboCodeEtudiant";
            this.comboCodeEtudiant.Size = new System.Drawing.Size(177, 24);
            this.comboCodeEtudiant.TabIndex = 20;
            // 
            // buttonAfficherReleve
            // 
            this.buttonAfficherReleve.Location = new System.Drawing.Point(619, 76);
            this.buttonAfficherReleve.Name = "buttonAfficherReleve";
            this.buttonAfficherReleve.Size = new System.Drawing.Size(129, 24);
            this.buttonAfficherReleve.TabIndex = 21;
            this.buttonAfficherReleve.Text = "Afficher relevé";
            this.buttonAfficherReleve.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(13, 128);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(453, 170);
            this.dataGridView.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(9, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 170);
            this.dataGridView1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nom";
            // 
            // textNomEtudiant
            // 
            this.textNomEtudiant.Location = new System.Drawing.Point(148, 69);
            this.textNomEtudiant.Name = "textNomEtudiant";
            this.textNomEtudiant.Size = new System.Drawing.Size(139, 22);
            this.textNomEtudiant.TabIndex = 3;
            // 
            // buttonAjoutEtudiant
            // 
            this.buttonAjoutEtudiant.Location = new System.Drawing.Point(357, 87);
            this.buttonAjoutEtudiant.Name = "buttonAjoutEtudiant";
            this.buttonAjoutEtudiant.Size = new System.Drawing.Size(140, 29);
            this.buttonAjoutEtudiant.TabIndex = 25;
            this.buttonAjoutEtudiant.Text = "Ajouter un Etudiant";
            this.buttonAjoutEtudiant.UseVisualStyleBackColor = true;
            this.buttonAjoutEtudiant.Click += new System.EventHandler(this.buttonAjoutEtudiant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNumCours);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textCodeCours);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textTitreCours);
            this.groupBox1.Controls.Add(this.buttonAjoutCours);
            this.groupBox1.Location = new System.Drawing.Point(540, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 312);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout Nouveau Cours";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNomEtudiant);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.buttonAjoutEtudiant);
            this.groupBox2.Controls.Add(this.textNumEtudiant);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textPrenomEtudiant);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 312);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajout Nouveau Etudiant";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.comboNumCours);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboNumEtudiant);
            this.groupBox3.Controls.Add(this.textNoteCoursEtudaint);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonEnregistrerNoteCours);
            this.groupBox3.Location = new System.Drawing.Point(12, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1008, 264);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout Note pour un etudiant";
            // 
            // comboNumEtudiant
            // 
            this.comboNumEtudiant.FormattingEnabled = true;
            this.comboNumEtudiant.Location = new System.Drawing.Point(135, 55);
            this.comboNumEtudiant.Name = "comboNumEtudiant";
            this.comboNumEtudiant.Size = new System.Drawing.Size(152, 24);
            this.comboNumEtudiant.TabIndex = 21;
            this.comboNumEtudiant.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Numero étudiant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Numero Cours";
            // 
            // comboNumCours
            // 
            this.comboNumCours.FormattingEnabled = true;
            this.comboNumCours.Location = new System.Drawing.Point(421, 55);
            this.comboNumCours.Name = "comboNumCours";
            this.comboNumCours.Size = new System.Drawing.Size(152, 24);
            this.comboNumCours.TabIndex = 31;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonExpotTxt);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.comboCodeEtudiant);
            this.groupBox4.Controls.Add(this.buttonAfficherReleve);
            this.groupBox4.Location = new System.Drawing.Point(12, 601);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1005, 155);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relevé de Notes d\'un Etudiant";
            // 
            // buttonExpotTxt
            // 
            this.buttonExpotTxt.Location = new System.Drawing.Point(619, 117);
            this.buttonExpotTxt.Name = "buttonExpotTxt";
            this.buttonExpotTxt.Size = new System.Drawing.Size(237, 24);
            this.buttonExpotTxt.TabIndex = 22;
            this.buttonExpotTxt.Text = "Exporter tout les Etudiants en txt";
            this.buttonExpotTxt.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numéro cours";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code cours";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Titre cours";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(12, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(772, 146);
            this.dataGridView2.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro Etudiant";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Numéro Etudiant";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TitreCours";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Note";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 768);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Details Etudiants Et Notes des Cours";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumEtudiant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrenomEtudiant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumCours;
        private System.Windows.Forms.TextBox textCodeCours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNoteCoursEtudaint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTitreCours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAjoutCours;
        private System.Windows.Forms.Button buttonEnregistrerNoteCours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboCodeEtudiant;
        private System.Windows.Forms.Button buttonAfficherReleve;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textNomEtudiant;
        private System.Windows.Forms.Button buttonAjoutEtudiant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNumEtudiant;
        private System.Windows.Forms.ComboBox comboNumCours;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonExpotTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

