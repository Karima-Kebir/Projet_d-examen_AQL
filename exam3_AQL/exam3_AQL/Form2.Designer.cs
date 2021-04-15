
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro d\'étudiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "RELEVE DE NOTES";
            // 
            // afficherNumEtudiant
            // 
            this.afficherNumEtudiant.AutoSize = true;
            this.afficherNumEtudiant.Location = new System.Drawing.Point(124, 96);
            this.afficherNumEtudiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afficherNumEtudiant.Name = "afficherNumEtudiant";
            this.afficherNumEtudiant.Size = new System.Drawing.Size(0, 13);
            this.afficherNumEtudiant.TabIndex = 8;
            // 
            // afficherNom
            // 
            this.afficherNom.AutoSize = true;
            this.afficherNom.Location = new System.Drawing.Point(68, 132);
            this.afficherNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afficherNom.Name = "afficherNom";
            this.afficherNom.Size = new System.Drawing.Size(27, 13);
            this.afficherNom.TabIndex = 9;
            this.afficherNom.Text = "nom";
            // 
            // afficherPrenom
            // 
            this.afficherPrenom.AutoSize = true;
            this.afficherPrenom.Location = new System.Drawing.Point(68, 167);
            this.afficherPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afficherPrenom.Name = "afficherPrenom";
            this.afficherPrenom.Size = new System.Drawing.Size(42, 13);
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
            this.dataGridView1.Location = new System.Drawing.Point(214, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 259);
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
            this.afficherNumero.Location = new System.Drawing.Point(121, 96);
            this.afficherNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afficherNumero.Name = "afficherNumero";
            this.afficherNumero.Size = new System.Drawing.Size(86, 13);
            this.afficherNumero.TabIndex = 12;
            this.afficherNumero.Text = "Numero Etudiant";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(633, 396);
            this.buttonFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(106, 30);
            this.buttonFermer.TabIndex = 13;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonExportReleveEtudiant
            // 
            this.buttonExportReleveEtudiant.Location = new System.Drawing.Point(457, 396);
            this.buttonExportReleveEtudiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExportReleveEtudiant.Name = "buttonExportReleveEtudiant";
            this.buttonExportReleveEtudiant.Size = new System.Drawing.Size(159, 29);
            this.buttonExportReleveEtudiant.TabIndex = 14;
            this.buttonExportReleveEtudiant.Text = "Exporter Revelé Etudiant";
            this.buttonExportReleveEtudiant.UseVisualStyleBackColor = true;
            this.buttonExportReleveEtudiant.Click += new System.EventHandler(this.buttonExportReleveEtudiant_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 474);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}