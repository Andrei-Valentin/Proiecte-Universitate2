namespace AplicatieGestiune
{
    partial class Utilizatori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nume_angajat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeutilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisiuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizatori1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_IdClient = new System.Windows.Forms.TextBox();
            this.btn_Creare = new System.Windows.Forms.Button();
            this.utilizatoriTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.utilizatoriTableAdapter();
            this.utilizatori1TableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.utilizatori1TableAdapter();
            this.txt_Permisiuni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.txt_Utilizator = new System.Windows.Forms.TextBox();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.btn_Afisare = new System.Windows.Forms.Button();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatori1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-1, -10);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1513, 51);
            this.panel_bara_titlu.TabIndex = 83;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(13, 19);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(83, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Utilizatori";
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
            this.btn_minimizare.Location = new System.Drawing.Point(1360, 3);
            this.btn_minimizare.Name = "btn_minimizare";
            this.btn_minimizare.Size = new System.Drawing.Size(72, 48);
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
            this.btn_Exit.Location = new System.Drawing.Point(1438, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 48);
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume_angajat,
            this.numeutilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.permisiuniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilizatori1BindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.Location = new System.Drawing.Point(76, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 356);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            // numeutilizatorDataGridViewTextBoxColumn
            // 
            this.numeutilizatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeutilizatorDataGridViewTextBoxColumn.DataPropertyName = "nume_utilizator";
            this.numeutilizatorDataGridViewTextBoxColumn.HeaderText = "nume_utilizator";
            this.numeutilizatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeutilizatorDataGridViewTextBoxColumn.Name = "numeutilizatorDataGridViewTextBoxColumn";
            this.numeutilizatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permisiuniDataGridViewTextBoxColumn
            // 
            this.permisiuniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.permisiuniDataGridViewTextBoxColumn.DataPropertyName = "permisiuni";
            this.permisiuniDataGridViewTextBoxColumn.HeaderText = "permisiuni";
            this.permisiuniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permisiuniDataGridViewTextBoxColumn.Name = "permisiuniDataGridViewTextBoxColumn";
            this.permisiuniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilizatori1BindingSource
            // 
            this.utilizatori1BindingSource.DataMember = "utilizatori1";
            this.utilizatori1BindingSource.DataSource = this.bazadedateDataSet;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "utilizatori";
            this.utilizatoriBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // txt_IdClient
            // 
            this.txt_IdClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdClient.Enabled = false;
            this.txt_IdClient.Location = new System.Drawing.Point(1101, 377);
            this.txt_IdClient.Name = "txt_IdClient";
            this.txt_IdClient.ReadOnly = true;
            this.txt_IdClient.Size = new System.Drawing.Size(100, 22);
            this.txt_IdClient.TabIndex = 80;
            // 
            // btn_Creare
            // 
            this.btn_Creare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Creare.FlatAppearance.BorderSize = 0;
            this.btn_Creare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creare.Location = new System.Drawing.Point(1242, 127);
            this.btn_Creare.Name = "btn_Creare";
            this.btn_Creare.Size = new System.Drawing.Size(125, 36);
            this.btn_Creare.TabIndex = 67;
            this.btn_Creare.Text = "Creare cont nou";
            this.btn_Creare.UseVisualStyleBackColor = false;
            this.btn_Creare.Click += new System.EventHandler(this.btn_Creare_Click);
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatori1TableAdapter
            // 
            this.utilizatori1TableAdapter.ClearBeforeFill = true;
            // 
            // txt_Permisiuni
            // 
            this.txt_Permisiuni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Permisiuni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Permisiuni.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Permisiuni.ForeColor = System.Drawing.Color.White;
            this.txt_Permisiuni.Location = new System.Drawing.Point(1101, 340);
            this.txt_Permisiuni.Name = "txt_Permisiuni";
            this.txt_Permisiuni.ReadOnly = true;
            this.txt_Permisiuni.Size = new System.Drawing.Size(182, 22);
            this.txt_Permisiuni.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(988, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(988, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Permisiuni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(988, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Utilizator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(988, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Nume";
            // 
            // txt_Parola
            // 
            this.txt_Parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Parola.ForeColor = System.Drawing.Color.White;
            this.txt_Parola.Location = new System.Drawing.Point(1101, 303);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.PasswordChar = '*';
            this.txt_Parola.ReadOnly = true;
            this.txt_Parola.Size = new System.Drawing.Size(182, 22);
            this.txt_Parola.TabIndex = 86;
            this.txt_Parola.TextChanged += new System.EventHandler(this.txt_Parola_TextChanged);
            // 
            // txt_Utilizator
            // 
            this.txt_Utilizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Utilizator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Utilizator.ForeColor = System.Drawing.Color.White;
            this.txt_Utilizator.Location = new System.Drawing.Point(1101, 268);
            this.txt_Utilizator.Name = "txt_Utilizator";
            this.txt_Utilizator.ReadOnly = true;
            this.txt_Utilizator.Size = new System.Drawing.Size(182, 22);
            this.txt_Utilizator.TabIndex = 85;
            // 
            // txt_Nume
            // 
            this.txt_Nume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Nume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nume.ForeColor = System.Drawing.Color.White;
            this.txt_Nume.Location = new System.Drawing.Point(1101, 230);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.ReadOnly = true;
            this.txt_Nume.Size = new System.Drawing.Size(182, 22);
            this.txt_Nume.TabIndex = 84;
            // 
            // btn_Afisare
            // 
            this.btn_Afisare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Afisare.FlatAppearance.BorderSize = 0;
            this.btn_Afisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Afisare.Location = new System.Drawing.Point(1013, 127);
            this.btn_Afisare.Name = "btn_Afisare";
            this.btn_Afisare.Size = new System.Drawing.Size(125, 36);
            this.btn_Afisare.TabIndex = 92;
            this.btn_Afisare.Text = "Afisare parola";
            this.btn_Afisare.UseVisualStyleBackColor = false;
            this.btn_Afisare.Click += new System.EventHandler(this.btn_Afisare_Click);
            // 
            // Utilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1511, 580);
            this.Controls.Add(this.btn_Afisare);
            this.Controls.Add(this.txt_Permisiuni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_Utilizator);
            this.Controls.Add(this.txt_Nume);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IdClient);
            this.Controls.Add(this.btn_Creare);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Utilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizatori";
            this.Load += new System.EventHandler(this.Utilizatori_Load);
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatori1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Label label_Titlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_IdClient;
        private System.Windows.Forms.Button btn_Creare;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private bazadedateDataSetTableAdapters.utilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource utilizatori1BindingSource;
        private bazadedateDataSetTableAdapters.utilizatori1TableAdapter utilizatori1TableAdapter;
        private System.Windows.Forms.TextBox txt_Permisiuni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_Utilizator;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.Button btn_Afisare;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume_angajat;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeutilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisiuniDataGridViewTextBoxColumn;
    }
}