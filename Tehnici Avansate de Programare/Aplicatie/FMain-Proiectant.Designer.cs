namespace AplicatieGestiune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Gestionare = new System.Windows.Forms.Button();
            this.panel_linie = new System.Windows.Forms.Panel();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUtilizator = new System.Windows.Forms.PictureBox();
            this.lbl_NumeUtilizator = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btn_Cont = new System.Windows.Forms.Button();
            this.panel_selectare = new System.Windows.Forms.Panel();
            this.btn_Utilizatori = new System.Windows.Forms.Button();
            this.panel_bara_titlu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizator)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Selecteaza o optiune pentru gestionarea datelor";
            // 
            // btn_Gestionare
            // 
            this.btn_Gestionare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Gestionare.FlatAppearance.BorderSize = 0;
            this.btn_Gestionare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gestionare.Location = new System.Drawing.Point(453, 477);
            this.btn_Gestionare.Name = "btn_Gestionare";
            this.btn_Gestionare.Size = new System.Drawing.Size(125, 36);
            this.btn_Gestionare.TabIndex = 35;
            this.btn_Gestionare.Text = "Vizualizare";
            this.btn_Gestionare.UseVisualStyleBackColor = false;
            this.btn_Gestionare.Visible = false;
            this.btn_Gestionare.Click += new System.EventHandler(this.btn_Gestionare_Click);
            // 
            // panel_linie
            // 
            this.panel_linie.BackColor = System.Drawing.Color.IndianRed;
            this.panel_linie.Location = new System.Drawing.Point(1029, 225);
            this.panel_linie.Name = "panel_linie";
            this.panel_linie.Size = new System.Drawing.Size(276, 10);
            this.panel_linie.TabIndex = 31;
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-38, 1);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1343, 53);
            this.panel_bara_titlu.TabIndex = 34;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.pictureBoxUtilizator);
            this.panel1.Controls.Add(this.lbl_NumeUtilizator);
            this.panel1.Controls.Add(this.panel_selectare);
            this.panel1.Controls.Add(this.btn_Utilizatori);
            this.panel1.Controls.Add(this.btn_Cont);
            this.panel1.Location = new System.Drawing.Point(1029, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 691);
            this.panel1.TabIndex = 33;
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
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(348, 129);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(350, 36);
            this.lblTitlu.TabIndex = 32;
            this.lblTitlu.Text = "Bun venit, Vasile Andrei !";
            // 
            // btn_Cont
            // 
            this.btn_Cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Cont.FlatAppearance.BorderSize = 0;
            this.btn_Cont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cont.ForeColor = System.Drawing.Color.White;
            this.btn_Cont.Location = new System.Drawing.Point(-1, 261);
            this.btn_Cont.Name = "btn_Cont";
            this.btn_Cont.Size = new System.Drawing.Size(275, 47);
            this.btn_Cont.TabIndex = 0;
            this.btn_Cont.Text = "Vizualizare Cont";
            this.btn_Cont.UseVisualStyleBackColor = false;
            this.btn_Cont.Click += new System.EventHandler(this.btn_Cont_Click);
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
            this.btn_Utilizatori.Location = new System.Drawing.Point(-2, 208);
            this.btn_Utilizatori.Name = "btn_Utilizatori";
            this.btn_Utilizatori.Size = new System.Drawing.Size(275, 47);
            this.btn_Utilizatori.TabIndex = 4;
            this.btn_Utilizatori.Text = "Servicii Asignate";
            this.btn_Utilizatori.UseVisualStyleBackColor = true;
            this.btn_Utilizatori.Click += new System.EventHandler(this.btn_Utilizatori_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1306, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gestionare);
            this.Controls.Add(this.panel_linie);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Gestionare;
        private System.Windows.Forms.Panel panel_linie;
        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxUtilizator;
        private System.Windows.Forms.Label lbl_NumeUtilizator;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Panel panel_selectare;
        private System.Windows.Forms.Button btn_Utilizatori;
        private System.Windows.Forms.Button btn_Cont;
    }
}