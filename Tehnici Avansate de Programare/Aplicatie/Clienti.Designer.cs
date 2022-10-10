namespace AplicatieGestiune
{
    partial class Clienti
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.txt_IdClient = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_CNP = new System.Windows.Forms.TextBox();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.btn_Renuntare = new System.Windows.Forms.Button();
            this.btn_Confirmare = new System.Windows.Forms.Button();
            this.btn_Stergere = new System.Windows.Forms.Button();
            this.btn_Modificare = new System.Windows.Forms.Button();
            this.btn_Adaugare = new System.Windows.Forms.Button();
            this.clientiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.clientiTableAdapter();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(1, -3);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1511, 50);
            this.panel_bara_titlu.TabIndex = 66;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(12, 13);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(61, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Clienti";
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
            this.btn_minimizare.Location = new System.Drawing.Point(1358, 0);
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
            this.btn_Exit.Location = new System.Drawing.Point(1436, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 50);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Email.ForeColor = System.Drawing.Color.White;
            this.txt_Email.Location = new System.Drawing.Point(1065, 386);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(245, 22);
            this.txt_Email.TabIndex = 65;
            this.txt_Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Email_KeyDown);
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
            this.numeclientDataGridViewTextBoxColumn,
            this.cnpclientDataGridViewTextBoxColumn,
            this.telefonclientDataGridViewTextBoxColumn,
            this.emailclientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientiBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(55, 216);
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
            this.dataGridView1.Size = new System.Drawing.Size(806, 266);
            this.dataGridView1.TabIndex = 64;
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
            // cnpclientDataGridViewTextBoxColumn
            // 
            this.cnpclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnpclientDataGridViewTextBoxColumn.DataPropertyName = "cnp_client";
            this.cnpclientDataGridViewTextBoxColumn.HeaderText = "cnp_client";
            this.cnpclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnpclientDataGridViewTextBoxColumn.Name = "cnpclientDataGridViewTextBoxColumn";
            this.cnpclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonclientDataGridViewTextBoxColumn
            // 
            this.telefonclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonclientDataGridViewTextBoxColumn.DataPropertyName = "telefon_client";
            this.telefonclientDataGridViewTextBoxColumn.HeaderText = "telefon_client";
            this.telefonclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonclientDataGridViewTextBoxColumn.Name = "telefonclientDataGridViewTextBoxColumn";
            this.telefonclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailclientDataGridViewTextBoxColumn
            // 
            this.emailclientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailclientDataGridViewTextBoxColumn.DataPropertyName = "email_client";
            this.emailclientDataGridViewTextBoxColumn.HeaderText = "email_client";
            this.emailclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailclientDataGridViewTextBoxColumn.Name = "emailclientDataGridViewTextBoxColumn";
            this.emailclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "clienti";
            this.clientiBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_IdClient
            // 
            this.txt_IdClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "id_client", true));
            this.txt_IdClient.Enabled = false;
            this.txt_IdClient.Location = new System.Drawing.Point(1065, 425);
            this.txt_IdClient.Name = "txt_IdClient";
            this.txt_IdClient.ReadOnly = true;
            this.txt_IdClient.Size = new System.Drawing.Size(100, 22);
            this.txt_IdClient.TabIndex = 63;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.ForeColor = System.Drawing.Color.White;
            this.lblOp.Location = new System.Drawing.Point(1371, 136);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(41, 17);
            this.lblOp.TabIndex = 58;
            this.lblOp.Text = "lblOp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(952, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(952, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(952, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(952, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nume";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefon.ForeColor = System.Drawing.Color.White;
            this.txt_Telefon.Location = new System.Drawing.Point(1065, 349);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.ReadOnly = true;
            this.txt_Telefon.Size = new System.Drawing.Size(245, 22);
            this.txt_Telefon.TabIndex = 53;
            this.txt_Telefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Telefon_KeyDown);
            this.txt_Telefon.Leave += new System.EventHandler(this.txt_Telefon_Leave);
            // 
            // txt_CNP
            // 
            this.txt_CNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_CNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CNP.ForeColor = System.Drawing.Color.White;
            this.txt_CNP.Location = new System.Drawing.Point(1065, 314);
            this.txt_CNP.Name = "txt_CNP";
            this.txt_CNP.ReadOnly = true;
            this.txt_CNP.Size = new System.Drawing.Size(245, 22);
            this.txt_CNP.TabIndex = 52;
            this.txt_CNP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CNP_KeyDown);
            this.txt_CNP.Leave += new System.EventHandler(this.txt_CNP_Leave);
            // 
            // txt_Nume
            // 
            this.txt_Nume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Nume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nume.ForeColor = System.Drawing.Color.White;
            this.txt_Nume.Location = new System.Drawing.Point(1065, 271);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.ReadOnly = true;
            this.txt_Nume.Size = new System.Drawing.Size(245, 22);
            this.txt_Nume.TabIndex = 50;
            this.txt_Nume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nume_KeyDown);
            // 
            // btn_Renuntare
            // 
            this.btn_Renuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Renuntare.FlatAppearance.BorderSize = 0;
            this.btn_Renuntare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Renuntare.Location = new System.Drawing.Point(1175, 126);
            this.btn_Renuntare.Name = "btn_Renuntare";
            this.btn_Renuntare.Size = new System.Drawing.Size(135, 36);
            this.btn_Renuntare.TabIndex = 49;
            this.btn_Renuntare.Text = "Renuntare";
            this.btn_Renuntare.UseVisualStyleBackColor = false;
            this.btn_Renuntare.Click += new System.EventHandler(this.btn_Renuntare_Click);
            // 
            // btn_Confirmare
            // 
            this.btn_Confirmare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Confirmare.FlatAppearance.BorderSize = 0;
            this.btn_Confirmare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmare.Location = new System.Drawing.Point(952, 126);
            this.btn_Confirmare.Name = "btn_Confirmare";
            this.btn_Confirmare.Size = new System.Drawing.Size(135, 36);
            this.btn_Confirmare.TabIndex = 48;
            this.btn_Confirmare.Text = "Confirmare";
            this.btn_Confirmare.UseVisualStyleBackColor = false;
            this.btn_Confirmare.Click += new System.EventHandler(this.btn_Confirmare_Click);
            // 
            // btn_Stergere
            // 
            this.btn_Stergere.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Stergere.FlatAppearance.BorderSize = 0;
            this.btn_Stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stergere.Location = new System.Drawing.Point(577, 126);
            this.btn_Stergere.Name = "btn_Stergere";
            this.btn_Stergere.Size = new System.Drawing.Size(125, 36);
            this.btn_Stergere.TabIndex = 47;
            this.btn_Stergere.Text = "Stergere";
            this.btn_Stergere.UseVisualStyleBackColor = false;
            this.btn_Stergere.Click += new System.EventHandler(this.btn_Stergere_Click);
            // 
            // btn_Modificare
            // 
            this.btn_Modificare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Modificare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Modificare.FlatAppearance.BorderSize = 0;
            this.btn_Modificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificare.Location = new System.Drawing.Point(383, 126);
            this.btn_Modificare.Name = "btn_Modificare";
            this.btn_Modificare.Size = new System.Drawing.Size(125, 36);
            this.btn_Modificare.TabIndex = 46;
            this.btn_Modificare.Text = "Modificare";
            this.btn_Modificare.UseVisualStyleBackColor = false;
            this.btn_Modificare.Click += new System.EventHandler(this.btn_Modificare_Click);
            // 
            // btn_Adaugare
            // 
            this.btn_Adaugare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Adaugare.FlatAppearance.BorderSize = 0;
            this.btn_Adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adaugare.Location = new System.Drawing.Point(183, 126);
            this.btn_Adaugare.Name = "btn_Adaugare";
            this.btn_Adaugare.Size = new System.Drawing.Size(125, 36);
            this.btn_Adaugare.TabIndex = 45;
            this.btn_Adaugare.Text = "Adaugare";
            this.btn_Adaugare.UseVisualStyleBackColor = false;
            this.btn_Adaugare.Click += new System.EventHandler(this.btn_Adaugare_Click);
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1511, 580);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IdClient);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.txt_CNP);
            this.Controls.Add(this.txt_Nume);
            this.Controls.Add(this.btn_Renuntare);
            this.Controls.Add(this.btn_Confirmare);
            this.Controls.Add(this.btn_Stergere);
            this.Controls.Add(this.btn_Modificare);
            this.Controls.Add(this.btn_Adaugare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Clienti_Load);
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.Label label_Titlu;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_IdClient;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_CNP;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.Button btn_Renuntare;
        private System.Windows.Forms.Button btn_Confirmare;
        private System.Windows.Forms.Button btn_Stergere;
        private System.Windows.Forms.Button btn_Modificare;
        private System.Windows.Forms.Button btn_Adaugare;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private bazadedateDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclientDataGridViewTextBoxColumn;
    }
}