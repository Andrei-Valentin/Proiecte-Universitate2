namespace AplicatieGestiune
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUtilizator = new System.Windows.Forms.PictureBox();
            this.lbl_NumeUtilizator = new System.Windows.Forms.Label();
            this.panel_selectare = new System.Windows.Forms.Panel();
            this.btn_Utilizatori = new System.Windows.Forms.Button();
            this.btn_Istoric = new System.Windows.Forms.Button();
            this.btn_Servicii = new System.Windows.Forms.Button();
            this.btn_Clienti = new System.Windows.Forms.Button();
            this.btn_Angajati = new System.Windows.Forms.Button();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_linie = new System.Windows.Forms.Panel();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btn_Gestionare = new System.Windows.Forms.Button();
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.utilizatori1TableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.utilizatori1TableAdapter();
            this.utilizatori1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizator)).BeginInit();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatori1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.pictureBoxUtilizator);
            this.panel1.Controls.Add(this.lbl_NumeUtilizator);
            this.panel1.Controls.Add(this.panel_selectare);
            this.panel1.Controls.Add(this.btn_Utilizatori);
            this.panel1.Controls.Add(this.btn_Istoric);
            this.panel1.Controls.Add(this.btn_Servicii);
            this.panel1.Controls.Add(this.btn_Clienti);
            this.panel1.Controls.Add(this.btn_Angajati);
            this.panel1.Location = new System.Drawing.Point(1066, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 691);
            this.panel1.TabIndex = 16;
            // 
            // pictureBoxUtilizator
            // 
            this.pictureBoxUtilizator.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtilizator.ErrorImage")));
            this.pictureBoxUtilizator.Location = new System.Drawing.Point(83, 25);
            this.pictureBoxUtilizator.Name = "pictureBoxUtilizator";
            this.pictureBoxUtilizator.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxUtilizator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUtilizator.TabIndex = 29;
            this.pictureBoxUtilizator.TabStop = false;
            // 
            // lbl_NumeUtilizator
            // 
            this.lbl_NumeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeUtilizator.ForeColor = System.Drawing.Color.White;
            this.lbl_NumeUtilizator.Location = new System.Drawing.Point(65, 138);
            this.lbl_NumeUtilizator.Name = "lbl_NumeUtilizator";
            this.lbl_NumeUtilizator.Size = new System.Drawing.Size(149, 25);
            this.lbl_NumeUtilizator.TabIndex = 6;
            this.lbl_NumeUtilizator.Text = "Nume_Utilizator";
            this.lbl_NumeUtilizator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_selectare
            // 
            this.panel_selectare.BackColor = System.Drawing.Color.Salmon;
            this.panel_selectare.Location = new System.Drawing.Point(266, 208);
            this.panel_selectare.Name = "panel_selectare";
            this.panel_selectare.Size = new System.Drawing.Size(10, 47);
            this.panel_selectare.TabIndex = 5;
            this.panel_selectare.Visible = false;
            // 
            // btn_Utilizatori
            // 
            this.btn_Utilizatori.FlatAppearance.BorderSize = 0;
            this.btn_Utilizatori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Utilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Utilizatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Utilizatori.ForeColor = System.Drawing.Color.White;
            this.btn_Utilizatori.Location = new System.Drawing.Point(0, 420);
            this.btn_Utilizatori.Name = "btn_Utilizatori";
            this.btn_Utilizatori.Size = new System.Drawing.Size(275, 47);
            this.btn_Utilizatori.TabIndex = 4;
            this.btn_Utilizatori.Text = "Utilizatori";
            this.btn_Utilizatori.UseVisualStyleBackColor = true;
            this.btn_Utilizatori.Visible = false;
            this.btn_Utilizatori.Click += new System.EventHandler(this.btn_Utilizatori_Click);
            // 
            // btn_Istoric
            // 
            this.btn_Istoric.FlatAppearance.BorderSize = 0;
            this.btn_Istoric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Istoric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Istoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Istoric.ForeColor = System.Drawing.Color.White;
            this.btn_Istoric.Location = new System.Drawing.Point(0, 311);
            this.btn_Istoric.Name = "btn_Istoric";
            this.btn_Istoric.Size = new System.Drawing.Size(275, 47);
            this.btn_Istoric.TabIndex = 3;
            this.btn_Istoric.Text = "Istoric Servicii";
            this.btn_Istoric.UseVisualStyleBackColor = true;
            this.btn_Istoric.Click += new System.EventHandler(this.btn_Istoric_Click);
            // 
            // btn_Servicii
            // 
            this.btn_Servicii.FlatAppearance.BorderSize = 0;
            this.btn_Servicii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Servicii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Servicii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Servicii.ForeColor = System.Drawing.Color.White;
            this.btn_Servicii.Location = new System.Drawing.Point(0, 258);
            this.btn_Servicii.Name = "btn_Servicii";
            this.btn_Servicii.Size = new System.Drawing.Size(275, 47);
            this.btn_Servicii.TabIndex = 2;
            this.btn_Servicii.Text = "Servicii active";
            this.btn_Servicii.UseVisualStyleBackColor = true;
            this.btn_Servicii.Click += new System.EventHandler(this.btn_Servicii_Click);
            // 
            // btn_Clienti
            // 
            this.btn_Clienti.FlatAppearance.BorderSize = 0;
            this.btn_Clienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clienti.ForeColor = System.Drawing.Color.White;
            this.btn_Clienti.Location = new System.Drawing.Point(0, 205);
            this.btn_Clienti.Name = "btn_Clienti";
            this.btn_Clienti.Size = new System.Drawing.Size(275, 47);
            this.btn_Clienti.TabIndex = 1;
            this.btn_Clienti.Text = "Clienti";
            this.btn_Clienti.UseVisualStyleBackColor = true;
            this.btn_Clienti.Click += new System.EventHandler(this.btn_Clienti_Click);
            // 
            // btn_Angajati
            // 
            this.btn_Angajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Angajati.FlatAppearance.BorderSize = 0;
            this.btn_Angajati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Angajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Angajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Angajati.ForeColor = System.Drawing.Color.White;
            this.btn_Angajati.Location = new System.Drawing.Point(1, 473);
            this.btn_Angajati.Name = "btn_Angajati";
            this.btn_Angajati.Size = new System.Drawing.Size(275, 47);
            this.btn_Angajati.TabIndex = 0;
            this.btn_Angajati.Text = "Angajati";
            this.btn_Angajati.UseVisualStyleBackColor = false;
            this.btn_Angajati.Visible = false;
            this.btn_Angajati.Click += new System.EventHandler(this.btn_Angajati_Click);
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-1, 0);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1343, 53);
            this.panel_bara_titlu.TabIndex = 17;
            this.panel_bara_titlu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_bara_titlu_MouseDown);
            // 
            // btn_minimizare
            // 
            this.btn_minimizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.btn_minimizare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimizare.FlatAppearance.BorderSize = 0;
            this.btn_minimizare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_minimizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizare.ForeColor = System.Drawing.Color.White;
            this.btn_minimizare.Location = new System.Drawing.Point(1193, 3);
            this.btn_minimizare.Name = "btn_minimizare";
            this.btn_minimizare.Size = new System.Drawing.Size(72, 46);
            this.btn_minimizare.TabIndex = 1;
            this.btn_minimizare.TabStop = false;
            this.btn_minimizare.Text = "-";
            this.btn_minimizare.UseVisualStyleBackColor = false;
            this.btn_minimizare.Click += new System.EventHandler(this.btn_minimizare_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(1271, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 47);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel_linie
            // 
            this.panel_linie.BackColor = System.Drawing.Color.IndianRed;
            this.panel_linie.Location = new System.Drawing.Point(1066, 224);
            this.panel_linie.Name = "panel_linie";
            this.panel_linie.Size = new System.Drawing.Size(276, 10);
            this.panel_linie.TabIndex = 5;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(385, 128);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(350, 36);
            this.lblTitlu.TabIndex = 9;
            this.lblTitlu.Text = "Bun venit, Vasile Andrei !";
            this.lblTitlu.Click += new System.EventHandler(this.lblTitlu_Click);
            // 
            // btn_Gestionare
            // 
            this.btn_Gestionare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Gestionare.FlatAppearance.BorderSize = 0;
            this.btn_Gestionare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gestionare.Location = new System.Drawing.Point(490, 476);
            this.btn_Gestionare.Name = "btn_Gestionare";
            this.btn_Gestionare.Size = new System.Drawing.Size(125, 36);
            this.btn_Gestionare.TabIndex = 23;
            this.btn_Gestionare.Text = "Gestionare date";
            this.btn_Gestionare.UseVisualStyleBackColor = false;
            this.btn_Gestionare.Visible = false;
            this.btn_Gestionare.Click += new System.EventHandler(this.btn_Gestionare_Click);
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatori1TableAdapter
            // 
            this.utilizatori1TableAdapter.ClearBeforeFill = true;
            // 
            // utilizatori1BindingSource
            // 
            this.utilizatori1BindingSource.DataMember = "utilizatori1";
            this.utilizatori1BindingSource.DataSource = this.bazadedateDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Selecteaza o optiune pentru gestionarea datelor";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gestionare);
            this.Controls.Add(this.panel_linie);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizator)).EndInit();
            this.panel_bara_titlu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatori1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Istoric;
        private System.Windows.Forms.Button btn_Servicii;
        private System.Windows.Forms.Button btn_Clienti;
        private System.Windows.Forms.Button btn_Angajati;
        private System.Windows.Forms.Button btn_Utilizatori;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Panel panel_linie;
        private System.Windows.Forms.Panel panel_selectare;
        private System.Windows.Forms.Label lblTitlu;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.Button btn_Gestionare;
        private System.Windows.Forms.Label lbl_NumeUtilizator;
        private System.Windows.Forms.PictureBox pictureBoxUtilizator;
        private bazadedateDataSetTableAdapters.utilizatori1TableAdapter utilizatori1TableAdapter;
        private System.Windows.Forms.BindingSource utilizatori1BindingSource;
        private System.Windows.Forms.Label label1;
    }
}

