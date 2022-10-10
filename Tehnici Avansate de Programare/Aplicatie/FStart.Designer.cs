namespace AplicatieGestiune
{
    partial class FStart
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
            this.btn_Autentificare = new System.Windows.Forms.Button();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.txt_Utilizator = new System.Windows.Forms.TextBox();
            this.lbl_Parola = new System.Windows.Forms.Label();
            this.lbl_Utilizator = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bun venit, pentru inceput introduceti datele";
            // 
            // btn_Autentificare
            // 
            this.btn_Autentificare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Autentificare.FlatAppearance.BorderSize = 0;
            this.btn_Autentificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Autentificare.Location = new System.Drawing.Point(513, 370);
            this.btn_Autentificare.Name = "btn_Autentificare";
            this.btn_Autentificare.Size = new System.Drawing.Size(143, 28);
            this.btn_Autentificare.TabIndex = 24;
            this.btn_Autentificare.Text = "Autentificare";
            this.btn_Autentificare.UseVisualStyleBackColor = false;
            this.btn_Autentificare.Click += new System.EventHandler(this.btn_Autentificare_Click);
            // 
            // txt_Parola
            // 
            this.txt_Parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Parola.ForeColor = System.Drawing.Color.White;
            this.txt_Parola.Location = new System.Drawing.Point(513, 317);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.PasswordChar = '*';
            this.txt_Parola.Size = new System.Drawing.Size(143, 22);
            this.txt_Parola.TabIndex = 23;
            this.txt_Parola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Parola_KeyDown);
            // 
            // txt_Utilizator
            // 
            this.txt_Utilizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Utilizator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Utilizator.ForeColor = System.Drawing.Color.White;
            this.txt_Utilizator.Location = new System.Drawing.Point(513, 261);
            this.txt_Utilizator.Name = "txt_Utilizator";
            this.txt_Utilizator.Size = new System.Drawing.Size(143, 22);
            this.txt_Utilizator.TabIndex = 22;
            this.txt_Utilizator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Utilizator_KeyDown);
            // 
            // lbl_Parola
            // 
            this.lbl_Parola.AutoSize = true;
            this.lbl_Parola.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Parola.ForeColor = System.Drawing.Color.White;
            this.lbl_Parola.Location = new System.Drawing.Point(419, 322);
            this.lbl_Parola.Name = "lbl_Parola";
            this.lbl_Parola.Size = new System.Drawing.Size(49, 17);
            this.lbl_Parola.TabIndex = 21;
            this.lbl_Parola.Text = "Parola";
            // 
            // lbl_Utilizator
            // 
            this.lbl_Utilizator.AutoSize = true;
            this.lbl_Utilizator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Utilizator.ForeColor = System.Drawing.Color.White;
            this.lbl_Utilizator.Location = new System.Drawing.Point(419, 266);
            this.lbl_Utilizator.Name = "lbl_Utilizator";
            this.lbl_Utilizator.Size = new System.Drawing.Size(63, 17);
            this.lbl_Utilizator.TabIndex = 20;
            this.lbl_Utilizator.Text = "Utilizator";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(120, 112);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(827, 36);
            this.lblTitlu.TabIndex = 19;
            this.lblTitlu.Text = "Aplicatie de gestiune a serviciilor unei firme de proiectare";
            this.lblTitlu.Visible = false;
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
            this.btn_minimizare.Location = new System.Drawing.Point(913, 3);
            this.btn_minimizare.Name = "btn_minimizare";
            this.btn_minimizare.Size = new System.Drawing.Size(72, 39);
            this.btn_minimizare.TabIndex = 27;
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
            this.btn_Exit.Location = new System.Drawing.Point(991, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 40);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_minimizare);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 42);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Autentificare";
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Autentificare);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_Utilizator);
            this.Controls.Add(this.lbl_Parola);
            this.Controls.Add(this.lbl_Utilizator);
            this.Controls.Add(this.lblTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Autentificare;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_Utilizator;
        private System.Windows.Forms.Label lbl_Parola;
        private System.Windows.Forms.Label lbl_Utilizator;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}