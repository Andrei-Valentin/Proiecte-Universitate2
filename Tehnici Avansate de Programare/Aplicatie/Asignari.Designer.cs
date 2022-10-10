namespace AplicatieGestiune
{
    partial class Asignari
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
            this.txt_IdAngajat = new System.Windows.Forms.TextBox();
            this.btn_Renuntare = new System.Windows.Forms.Button();
            this.btn_Creare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.angajatiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.angajatiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            this.panel_bara_titlu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IdAngajat
            // 
            this.txt_IdAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdAngajat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdAngajat.Enabled = false;
            this.txt_IdAngajat.Location = new System.Drawing.Point(13, 54);
            this.txt_IdAngajat.Name = "txt_IdAngajat";
            this.txt_IdAngajat.ReadOnly = true;
            this.txt_IdAngajat.Size = new System.Drawing.Size(100, 22);
            this.txt_IdAngajat.TabIndex = 106;
            this.txt_IdAngajat.Visible = false;
            // 
            // btn_Renuntare
            // 
            this.btn_Renuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Renuntare.FlatAppearance.BorderSize = 0;
            this.btn_Renuntare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Renuntare.Location = new System.Drawing.Point(657, 474);
            this.btn_Renuntare.Name = "btn_Renuntare";
            this.btn_Renuntare.Size = new System.Drawing.Size(125, 36);
            this.btn_Renuntare.TabIndex = 105;
            this.btn_Renuntare.Text = "Renuntare";
            this.btn_Renuntare.UseVisualStyleBackColor = false;
            // 
            // btn_Creare
            // 
            this.btn_Creare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Creare.FlatAppearance.BorderSize = 0;
            this.btn_Creare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creare.Location = new System.Drawing.Point(281, 474);
            this.btn_Creare.Name = "btn_Creare";
            this.btn_Creare.Size = new System.Drawing.Size(125, 36);
            this.btn_Creare.TabIndex = 104;
            this.btn_Creare.Text = "Asignare";
            this.btn_Creare.UseVisualStyleBackColor = false;
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
            this.numeangajatDataGridViewTextBoxColumn,
            this.cnpangajatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(110, 94);
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
            this.dataGridView1.Size = new System.Drawing.Size(837, 356);
            this.dataGridView1.TabIndex = 103;
            // 
            // numeangajatDataGridViewTextBoxColumn
            // 
            this.numeangajatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeangajatDataGridViewTextBoxColumn.DataPropertyName = "nume_angajat";
            this.numeangajatDataGridViewTextBoxColumn.HeaderText = "nume_angajat";
            this.numeangajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeangajatDataGridViewTextBoxColumn.Name = "numeangajatDataGridViewTextBoxColumn";
            this.numeangajatDataGridViewTextBoxColumn.ReadOnly = true;
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
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "angajati";
            this.angajatiBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-3, 1);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1065, 47);
            this.panel_bara_titlu.TabIndex = 102;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(12, 13);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(78, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Asignari";
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
            this.btn_minimizare.Location = new System.Drawing.Point(912, -3);
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
            this.btn_Exit.Location = new System.Drawing.Point(990, -3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 50);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // Asignari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1059, 568);
            this.Controls.Add(this.txt_IdAngajat);
            this.Controls.Add(this.btn_Renuntare);
            this.Controls.Add(this.btn_Creare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_bara_titlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asignari";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Asignari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_IdAngajat;
        private System.Windows.Forms.Button btn_Renuntare;
        private System.Windows.Forms.Button btn_Creare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Label label_Titlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private bazadedateDataSetTableAdapters.angajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpangajatDataGridViewTextBoxColumn;
    }
}