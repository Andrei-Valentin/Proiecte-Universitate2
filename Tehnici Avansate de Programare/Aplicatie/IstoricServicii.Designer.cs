namespace AplicatieGestiune
{
    partial class IstoricServicii
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
            this.denumireserviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istoricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.txt_IdIstoric = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Detalii = new System.Windows.Forms.TextBox();
            this.txt_Denumire = new System.Windows.Forms.TextBox();
            this.btn_Stergere = new System.Windows.Forms.Button();
            this.istoricTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.istoricTableAdapter();
            this.txt_Client = new System.Windows.Forms.TextBox();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.clientiTableAdapter();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-5, 0);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1498, 48);
            this.panel_bara_titlu.TabIndex = 115;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(12, 13);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(123, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Istoric Servicii";
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
            this.btn_minimizare.Location = new System.Drawing.Point(1348, 0);
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
            this.btn_Exit.Location = new System.Drawing.Point(1426, 0);
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
            this.denumireserviciuDataGridViewTextBoxColumn,
            this.numeclientDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.istoricBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(57, 223);
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
            this.dataGridView1.Size = new System.Drawing.Size(764, 266);
            this.dataGridView1.TabIndex = 114;
            // 
            // denumireserviciuDataGridViewTextBoxColumn
            // 
            this.denumireserviciuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.denumireserviciuDataGridViewTextBoxColumn.DataPropertyName = "denumire_serviciu";
            this.denumireserviciuDataGridViewTextBoxColumn.HeaderText = "denumire_serviciu";
            this.denumireserviciuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireserviciuDataGridViewTextBoxColumn.Name = "denumireserviciuDataGridViewTextBoxColumn";
            this.denumireserviciuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeclientDataGridViewTextBoxColumn
            // 
            this.numeclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeclientDataGridViewTextBoxColumn.DataPropertyName = "nume_client";
            this.numeclientDataGridViewTextBoxColumn.HeaderText = "nume_client";
            this.numeclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeclientDataGridViewTextBoxColumn.Name = "numeclientDataGridViewTextBoxColumn";
            this.numeclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "detalii";
            this.detaliiDataGridViewTextBoxColumn.HeaderText = "detalii";
            this.detaliiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            this.detaliiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // istoricBindingSource
            // 
            this.istoricBindingSource.DataMember = "istoric";
            this.istoricBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_IdIstoric
            // 
            this.txt_IdIstoric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdIstoric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdIstoric.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istoricBindingSource, "id_istoric", true));
            this.txt_IdIstoric.Enabled = false;
            this.txt_IdIstoric.Location = new System.Drawing.Point(1212, 467);
            this.txt_IdIstoric.Name = "txt_IdIstoric";
            this.txt_IdIstoric.ReadOnly = true;
            this.txt_IdIstoric.Size = new System.Drawing.Size(100, 22);
            this.txt_IdIstoric.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(961, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(961, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Detalii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(961, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "Denumire serviciu";
            // 
            // txt_Detalii
            // 
            this.txt_Detalii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Detalii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Detalii.ForeColor = System.Drawing.Color.White;
            this.txt_Detalii.Location = new System.Drawing.Point(1130, 317);
            this.txt_Detalii.Multiline = true;
            this.txt_Detalii.Name = "txt_Detalii";
            this.txt_Detalii.ReadOnly = true;
            this.txt_Detalii.Size = new System.Drawing.Size(284, 101);
            this.txt_Detalii.TabIndex = 108;
            // 
            // txt_Denumire
            // 
            this.txt_Denumire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Denumire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Denumire.ForeColor = System.Drawing.Color.White;
            this.txt_Denumire.Location = new System.Drawing.Point(1130, 243);
            this.txt_Denumire.Name = "txt_Denumire";
            this.txt_Denumire.ReadOnly = true;
            this.txt_Denumire.Size = new System.Drawing.Size(284, 22);
            this.txt_Denumire.TabIndex = 107;
            // 
            // btn_Stergere
            // 
            this.btn_Stergere.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Stergere.FlatAppearance.BorderSize = 0;
            this.btn_Stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stergere.Location = new System.Drawing.Point(320, 133);
            this.btn_Stergere.Name = "btn_Stergere";
            this.btn_Stergere.Size = new System.Drawing.Size(125, 36);
            this.btn_Stergere.TabIndex = 104;
            this.btn_Stergere.Text = "Stergere";
            this.btn_Stergere.UseVisualStyleBackColor = false;
            this.btn_Stergere.Click += new System.EventHandler(this.btn_Stergere_Click);
            // 
            // istoricTableAdapter
            // 
            this.istoricTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Client
            // 
            this.txt_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Client.ForeColor = System.Drawing.Color.White;
            this.txt_Client.Location = new System.Drawing.Point(1131, 277);
            this.txt_Client.Name = "txt_Client";
            this.txt_Client.ReadOnly = true;
            this.txt_Client.Size = new System.Drawing.Size(284, 22);
            this.txt_Client.TabIndex = 118;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "clienti";
            this.clientiBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // IstoricServicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1493, 533);
            this.Controls.Add(this.txt_Client);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IdIstoric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Detalii);
            this.Controls.Add(this.txt_Denumire);
            this.Controls.Add(this.btn_Stergere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IstoricServicii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IstoricServicii_Load);
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Label label_Titlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_IdIstoric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Detalii;
        private System.Windows.Forms.TextBox txt_Denumire;
        private System.Windows.Forms.Button btn_Stergere;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource istoricBindingSource;
        private bazadedateDataSetTableAdapters.istoricTableAdapter istoricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireserviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Client;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private bazadedateDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
    }
}