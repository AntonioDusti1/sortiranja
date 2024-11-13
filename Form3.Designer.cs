namespace sortiranjaj
{
    partial class Form1
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
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.lstVozila = new System.Windows.Forms.ListBox();
            this.txtSortiraniVozila = new System.Windows.Forms.TextBox();
            this.cmbSortirajPo = new System.Windows.Forms.ComboBox();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(84, 315);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(102, 41);
            this.btnDodajVozilo.TabIndex = 0;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(237, 315);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(94, 41);
            this.btnSortiraj.TabIndex = 1;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "GodinaProizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kilometraza";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(175, 84);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(156, 26);
            this.txtMarka.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(175, 139);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(156, 26);
            this.txtModel.TabIndex = 7;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(175, 199);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(156, 26);
            this.txtGodinaProizvodnje.TabIndex = 8;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(175, 252);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(156, 26);
            this.txtKilometraza.TabIndex = 9;
            // 
            // lstVozila
            // 
            this.lstVozila.FormattingEnabled = true;
            this.lstVozila.ItemHeight = 20;
            this.lstVozila.Location = new System.Drawing.Point(502, 41);
            this.lstVozila.Name = "lstVozila";
            this.lstVozila.Size = new System.Drawing.Size(230, 124);
            this.lstVozila.TabIndex = 10;
            // 
            // txtSortiraniVozila
            // 
            this.txtSortiraniVozila.Location = new System.Drawing.Point(536, 295);
            this.txtSortiraniVozila.Multiline = true;
            this.txtSortiraniVozila.Name = "txtSortiraniVozila";
            this.txtSortiraniVozila.Size = new System.Drawing.Size(196, 113);
            this.txtSortiraniVozila.TabIndex = 11;
            // 
            // cmbSortirajPo
            // 
            this.cmbSortirajPo.FormattingEnabled = true;
            this.cmbSortirajPo.Location = new System.Drawing.Point(511, 226);
            this.cmbSortirajPo.Name = "cmbSortirajPo";
            this.cmbSortirajPo.Size = new System.Drawing.Size(221, 28);
            this.cmbSortirajPo.TabIndex = 12;
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(373, 315);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(107, 60);
            this.btnObrisiVozilo.TabIndex = 13;
            this.btnObrisiVozilo.Text = "Za brisanje";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.cmbSortirajPo);
            this.Controls.Add(this.txtSortiraniVozila);
            this.Controls.Add(this.lstVozila);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodajVozilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.ListBox lstVozila;
        private System.Windows.Forms.TextBox txtSortiraniVozila;
        private System.Windows.Forms.ComboBox cmbSortirajPo;
        private System.Windows.Forms.Button btnObrisiVozilo;
    }
}

