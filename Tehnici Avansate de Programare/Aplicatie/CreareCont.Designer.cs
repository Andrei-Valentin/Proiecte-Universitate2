namespace AplicatieGestiune
{
    partial class CreareCont
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nume_angajat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_angajat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiFaraContBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.angajatiFaraContTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.angajatiFaraContTableAdapter();
            this.btn_Creare = new System.Windows.Forms.Button();
            this.btn_Renuntare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.txt_Utilizator = new System.Windows.Forms.TextBox();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.txt_IdAngajat = new System.Windows.Forms.TextBox();
            this.cmbPermisiuni = new System.Windows.Forms.ComboBox();
            this.btn_Generare = new System.Windows.Forms.Button();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiFaraContBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-1, -3);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(956, 50);
            this.panel_bara_titlu.TabIndex = 84;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(12, 13);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(146, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Creare cont nou";
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
            this.btn_minimizare.Location = new System.Drawing.Point(803, 0);
            this.btn_minimizare.Name = "btn_minimizare";
            this.btn_minimizare.Size = new System.Drawing.Size(72, 50);
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
            this.btn_Exit.Location = new System.Drawing.Point(881, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 50);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume_angajat,
            this.cnpangajatDataGridViewTextBoxColumn,
            this.emailangajatDataGridViewTextBoxColumn,
            this.id_angajat});
            this.dataGridView1.DataSource = this.angajatiFaraContBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.Location = new System.Drawing.Point(24, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 356);
            this.dataGridView1.TabIndex = 85;
            // 
            // nume_angajat
            // 
            this.nume_angajat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nume_angajat.DataPropertyName = "nume_angajat";
            this.nume_angajat.HeaderText = "nume_angajat";
            this.nume_angajat.MinimumWidth = 6;
            this.nume_angajat.Name = "nume_angajat";
            this.nume_angajat.ReadOnly = true;
            // 
            // cnpangajatDataGridViewTextBoxColumn
            // 
            this.cnpangajatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnpangajatDataGridViewTextBoxColumn.DataPropertyName = "cnp_angajat";
            this.cnpangajatDataGridViewTextBoxColumn.HeaderText = "cnp_angajat";
            this.cnpangajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnpangajatDataGridViewTextBoxColumn.Name = "cnpangajatDataGridViewTextBoxColumn";
            this.cnpangajatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailangajatDataGridViewTextBoxColumn
            // 
            this.emailangajatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailangajatDataGridViewTextBoxColumn.DataPropertyName = "email_angajat";
            this.emailangajatDataGridViewTextBoxColumn.HeaderText = "email_angajat";
            this.emailangajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailangajatDataGridViewTextBoxColumn.Name = "emailangajatDataGridViewTextBoxColumn";
            this.emailangajatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_angajat
            // 
            this.id_angajat.DataPropertyName = "id_angajat";
            this.id_angajat.HeaderText = "id_angajat";
            this.id_angajat.MinimumWidth = 6;
            this.id_angajat.Name = "id_angajat";
            this.id_angajat.ReadOnly = true;
            this.id_angajat.Visible = false;
            this.id_angajat.Width = 125;
            // 
            // angajatiFaraContBindingSource
            // 
            this.angajatiFaraContBindingSource.DataMember = "angajatiFaraCont";
            this.angajatiFaraContBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiFaraContTableAdapter
            // 
            this.angajatiFaraContTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Creare
            // 
            this.btn_Creare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Creare.FlatAppearance.BorderSize = 0;
            this.btn_Creare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creare.Location = new System.Drawing.Point(662, 356);
            this.btn_Creare.Name = "btn_Creare";
            this.btn_Creare.Size = new System.Drawing.Size(125, 36);
            this.btn_Creare.TabIndex = 86;
            this.btn_Creare.Text = "Creare cont";
            this.btn_Creare.UseVisualStyleBackColor = false;
            this.btn_Creare.Click += new System.EventHandler(this.btn_Creare_Click);
            // 
            // btn_Renuntare
            // 
            this.btn_Renuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Renuntare.FlatAppearance.BorderSize = 0;
            this.btn_Renuntare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Renuntare.Location = new System.Drawing.Point(736, 414);
            this.btn_Renuntare.Name = "btn_Renuntare";
            this.btn_Renuntare.Size = new System.Drawing.Size(125, 36);
            this.btn_Renuntare.TabIndex = 87;
            this.btn_Renuntare.Text = "Renuntare";
            this.btn_Renuntare.UseVisualStyleBackColor = false;
            this.btn_Renuntare.Click += new System.EventHandler(this.btn_Renuntare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(659, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(659, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "Permisiuni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(659, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Utilizator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(659, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Nume";
            // 
            // txt_Parola
            // 
            this.txt_Parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Parola.ForeColor = System.Drawing.Color.White;
            this.txt_Parola.Location = new System.Drawing.Point(755, 238);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(182, 22);
            this.txt_Parola.TabIndex = 95;
            // 
            // txt_Utilizator
            // 
            this.txt_Utilizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Utilizator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Utilizator.ForeColor = System.Drawing.Color.White;
            this.txt_Utilizator.Location = new System.Drawing.Point(755, 203);
            this.txt_Utilizator.Name = "txt_Utilizator";
            this.txt_Utilizator.Size = new System.Drawing.Size(182, 22);
            this.txt_Utilizator.TabIndex = 94;
            // 
            // txt_Nume
            // 
            this.txt_Nume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Nume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nume.ForeColor = System.Drawing.Color.White;
            this.txt_Nume.Location = new System.Drawing.Point(755, 165);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.ReadOnly = true;
            this.txt_Nume.Size = new System.Drawing.Size(182, 22);
            this.txt_Nume.TabIndex = 93;
            // 
            // txt_IdAngajat
            // 
            this.txt_IdAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdAngajat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdAngajat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiFaraContBindingSource, "id_angajat", true));
            this.txt_IdAngajat.Enabled = false;
            this.txt_IdAngajat.Location = new System.Drawing.Point(270, 466);
            this.txt_IdAngajat.Name = "txt_IdAngajat";
            this.txt_IdAngajat.ReadOnly = true;
            this.txt_IdAngajat.Size = new System.Drawing.Size(100, 22);
            this.txt_IdAngajat.TabIndex = 92;
            // 
            // cmbPermisiuni
            // 
            this.cmbPermisiuni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbPermisiuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPermisiuni.ForeColor = System.Drawing.Color.White;
            this.cmbPermisiuni.FormattingEnabled = true;
            this.cmbPermisiuni.Items.AddRange(new object[] {
            "Angajat",
            "Administrator",
            "Proiectant"});
            this.cmbPermisiuni.Location = new System.Drawing.Point(755, 275);
            this.cmbPermisiuni.Name = "cmbPermisiuni";
            this.cmbPermisiuni.Size = new System.Drawing.Size(182, 24);
            this.cmbPermisiuni.TabIndex = 100;
            // 
            // btn_Generare
            // 
            this.btn_Generare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Generare.FlatAppearance.BorderSize = 0;
            this.btn_Generare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generare.Location = new System.Drawing.Point(812, 356);
            this.btn_Generare.Name = "btn_Generare";
            this.btn_Generare.Size = new System.Drawing.Size(125, 36);
            this.btn_Generare.TabIndex = 101;
            this.btn_Generare.Text = "Generare";
            this.btn_Generare.UseVisualStyleBackColor = false;
            this.btn_Generare.Click += new System.EventHandler(this.btn_Generare_Click);
            // 
            // CreareCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(949, 514);
            this.Controls.Add(this.btn_Generare);
            this.Controls.Add(this.cmbPermisiuni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_Utilizator);
            this.Controls.Add(this.txt_Nume);
            this.Controls.Add(this.txt_IdAngajat);
            this.Controls.Add(this.btn_Renuntare);
            this.Controls.Add(this.btn_Creare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_bara_titlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreareCont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreareCont";
            this.Load += new System.EventHandler(this.CreareCont_Load);
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiFaraContBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Label label_Titlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource angajatiFaraContBindingSource;
        private bazadedateDataSetTableAdapters.angajatiFaraContTableAdapter angajatiFaraContTableAdapter;
        private System.Windows.Forms.Button btn_Creare;
        private System.Windows.Forms.Button btn_Renuntare;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume_angajat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_angajat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_Utilizator;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.TextBox txt_IdAngajat;
        private System.Windows.Forms.ComboBox cmbPermisiuni;
        private System.Windows.Forms.Button btn_Generare;
    }
}