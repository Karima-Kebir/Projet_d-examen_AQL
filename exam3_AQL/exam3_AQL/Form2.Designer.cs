
namespace Exam3_AQL
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.afficherNumEtudiant = new System.Windows.Forms.Label();
            this.afficherNom = new System.Windows.Forms.Label();
            this.afficherPrenom = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afficherNumero = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonExportReleveEtudiant = new System.Windows.Forms.Button();
            this.AfficherMoyenne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro d\'étudiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "RELEVE DE NOTES";
            // 
            // afficherNumEtudiant
            // 
            this.afficherNumEtudiant.AutoSize = true;
            this.afficherNumEtudiant.Location = new System.Drawing.Point(165, 118);
            this.afficherNumEtudiant.Name = "afficherNumEtudiant";
            this.afficherNumEtudiant.Size = new System.Drawing.Size(0, 17);
            this.afficherNumEtudiant.TabIndex = 8;
            // 
            // afficherNom
            // 
            this.afficherNom.AutoSize = true;
            this.afficherNom.Location = new System.Drawing.Point(91, 162);
            this.afficherNom.Name = "afficherNom";
            this.afficherNom.Size = new System.Drawing.Size(35, 17);
            this.afficherNom.TabIndex = 9;
            this.afficherNom.Text = "nom";
            // 
            // afficherPrenom
            // 
            this.afficherPrenom.AutoSize = true;
            this.afficherPrenom.Location = new System.Drawing.Point(91, 206);
            this.afficherPrenom.Name = "afficherPrenom";
            this.afficherPrenom.Size = new System.Drawing.Size(56, 17);
            this.afficherPrenom.TabIndex = 10;
            this.afficherPrenom.Text = "prenom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(285, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 319);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numéro cours";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code cours";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Titre cours";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Note";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // afficherNumero
            // 
            this.afficherNumero.AutoSize = true;
            this.afficherNumero.Location = new System.Drawing.Point(161, 118);
            this.afficherNumero.Name = "afficherNumero";
            this.afficherNumero.Size = new System.Drawing.Size(114, 17);
            this.afficherNumero.TabIndex = 12;
            this.afficherNumero.Text = "Numero Etudiant";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(844, 487);
            this.buttonFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(141, 37);
            this.buttonFermer.TabIndex = 13;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonExportReleveEtudiant
            // 
            this.buttonExportReleveEtudiant.Location = new System.Drawing.Point(609, 487);
            this.buttonExportReleveEtudiant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportReleveEtudiant.Name = "buttonExportReleveEtudiant";
            this.buttonExportReleveEtudiant.Size = new System.Drawing.Size(212, 36);
            this.buttonExportReleveEtudiant.TabIndex = 14;
            this.buttonExportReleveEtudiant.Text = "Exporter Revelé Etudiant";
            this.buttonExportReleveEtudiant.UseVisualStyleBackColor = true;
            this.buttonExportReleveEtudiant.Click += new System.EventHandler(this.buttonExportReleveEtudiant_Click);
            // 
            // AfficherMoyenne
            // 
            this.AfficherMoyenne.AutoSize = true;
            this.AfficherMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficherMoyenne.Location = new System.Drawing.Point(155, 417);
            this.AfficherMoyenne.Name = "AfficherMoyenne";
            this.AfficherMoyenne.Size = new System.Drawing.Size(0, 20);
            this.AfficherMoyenne.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Moyenne :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "____________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "____________________________";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AfficherMoyenne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExportReleveEtudiant);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.afficherNumero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.afficherPrenom);
            this.Controls.Add(this.afficherNom);
            this.Controls.Add(this.afficherNumEtudiant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label afficherNumEtudiant;
        private System.Windows.Forms.Label afficherNom;
        private System.Windows.Forms.Label afficherPrenom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label afficherNumero;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonExportReleveEtudiant;
        private System.Windows.Forms.Label AfficherMoyenne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}