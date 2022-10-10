namespace AplicatieGestiune
{
    partial class ServiciiActive
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
            this.denumireserviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_serviciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviciiActiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.serviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_IdServiciu = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Detalii = new System.Windows.Forms.TextBox();
            this.txt_Denumire = new System.Windows.Forms.TextBox();
            this.btn_Renuntare = new System.Windows.Forms.Button();
            this.btn_Confirmare = new System.Windows.Forms.Button();
            this.btn_Stergere = new System.Windows.Forms.Button();
            this.btn_Modificare = new System.Windows.Forms.Button();
            this.btn_Adaugare = new System.Windows.Forms.Button();
            this.serviciiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.serviciiTableAdapter();
            this.clientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviciiActiveTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.ServiciiActiveTableAdapter();
            this.btn_Asignare = new System.Windows.Forms.Button();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.clientiTableAdapter();
            this.cmb_Client = new System.Windows.Forms.ComboBox();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiActiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-3, -5);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1515, 50);
            this.panel_bara_titlu.TabIndex = 66;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(12, 13);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(70, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Servicii";
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
            this.denumireserviciuDataGridViewTextBoxColumn,
            this.id_client,
            this.numeclientDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn,
            this.id_serviciu});
            this.dataGridView1.DataSource = this.serviciiActiveBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(54, 218);
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
            this.dataGridView1.Size = new System.Drawing.Size(764, 266);
            this.dataGridView1.TabIndex = 64;
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
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "id_client";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            this.id_client.Visible = false;
            this.id_client.Width = 125;
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
            // id_serviciu
            // 
            this.id_serviciu.DataPropertyName = "id_serviciu";
            this.id_serviciu.HeaderText = "id_serviciu";
            this.id_serviciu.MinimumWidth = 6;
            this.id_serviciu.Name = "id_serviciu";
            this.id_serviciu.ReadOnly = true;
            this.id_serviciu.Visible = false;
            this.id_serviciu.Width = 125;
            // 
            // serviciiActiveBindingSource
            // 
            this.serviciiActiveBindingSource.DataMember = "ServiciiActive";
            this.serviciiActiveBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviciiBindingSource
            // 
            this.serviciiBindingSource.DataMember = "servicii";
            this.serviciiBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // txt_IdServiciu
            // 
            this.txt_IdServiciu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdServiciu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdServiciu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciiActiveBindingSource, "id_serviciu", true));
            this.txt_IdServiciu.Enabled = false;
            this.txt_IdServiciu.Location = new System.Drawing.Point(1209, 462);
            this.txt_IdServiciu.Name = "txt_IdServiciu";
            this.txt_IdServiciu.ReadOnly = true;
            this.txt_IdServiciu.Size = new System.Drawing.Size(100, 22);
            this.txt_IdServiciu.TabIndex = 63;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.ForeColor = System.Drawing.Color.White;
            this.lblOp.Location = new System.Drawing.Point(1370, 138);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(41, 17);
            this.lblOp.TabIndex = 58;
            this.lblOp.Text = "lblOp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(958, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(958, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Detalii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(958, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Denumire serviciu";
            // 
            // txt_Detalii
            // 
            this.txt_Detalii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Detalii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Detalii.ForeColor = System.Drawing.Color.White;
            this.txt_Detalii.Location = new System.Drawing.Point(1127, 312);
            this.txt_Detalii.Multiline = true;
            this.txt_Detalii.Name = "txt_Detalii";
            this.txt_Detalii.ReadOnly = true;
            this.txt_Detalii.Size = new System.Drawing.Size(284, 101);
            this.txt_Detalii.TabIndex = 52;
            // 
            // txt_Denumire
            // 
            this.txt_Denumire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Denumire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Denumire.ForeColor = System.Drawing.Color.White;
            this.txt_Denumire.Location = new System.Drawing.Point(1127, 238);
            this.txt_Denumire.Name = "txt_Denumire";
            this.txt_Denumire.ReadOnly = true;
            this.txt_Denumire.Size = new System.Drawing.Size(284, 22);
            this.txt_Denumire.TabIndex = 50;
            // 
            // btn_Renuntare
            // 
            this.btn_Renuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Renuntare.FlatAppearance.BorderSize = 0;
            this.btn_Renuntare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Renuntare.Location = new System.Drawing.Point(1174, 128);
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
            this.btn_Confirmare.Location = new System.Drawing.Point(951, 128);
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
            this.btn_Stergere.Location = new System.Drawing.Point(456, 128);
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
            this.btn_Modificare.Location = new System.Drawing.Point(273, 128);
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
            this.btn_Adaugare.Location = new System.Drawing.Point(83, 128);
            this.btn_Adaugare.Name = "btn_Adaugare";
            this.btn_Adaugare.Size = new System.Drawing.Size(125, 36);
            this.btn_Adaugare.TabIndex = 45;
            this.btn_Adaugare.Text = "Adaugare";
            this.btn_Adaugare.UseVisualStyleBackColor = false;
            this.btn_Adaugare.Click += new System.EventHandler(this.btn_Adaugare_Click);
            // 
            // serviciiTableAdapter
            // 
            this.serviciiTableAdapter.ClearBeforeFill = true;
            // 
            // clientiBindingSource1
            // 
            this.clientiBindingSource1.DataMember = "clienti";
            this.clientiBindingSource1.DataSource = this.bazadedateDataSet;
            // 
            // serviciiActiveTableAdapter
            // 
            this.serviciiActiveTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Asignare
            // 
            this.btn_Asignare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Asignare.FlatAppearance.BorderSize = 0;
            this.btn_Asignare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Asignare.Location = new System.Drawing.Point(650, 128);
            this.btn_Asignare.Name = "btn_Asignare";
            this.btn_Asignare.Size = new System.Drawing.Size(125, 36);
            this.btn_Asignare.TabIndex = 68;
            this.btn_Asignare.Text = "Asignare";
            this.btn_Asignare.UseVisualStyleBackColor = false;
            this.btn_Asignare.Click += new System.EventHandler(this.btn_Asignare_Click);
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
            // cmb_Client
            // 
            this.cmb_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmb_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Client.ForeColor = System.Drawing.Color.White;
            this.cmb_Client.FormattingEnabled = true;
            this.cmb_Client.Items.AddRange(new object[] {
            "Angajat",
            "Administrator"});
            this.cmb_Client.Location = new System.Drawing.Point(1127, 270);
            this.cmb_Client.Name = "cmb_Client";
            this.cmb_Client.Size = new System.Drawing.Size(284, 24);
            this.cmb_Client.TabIndex = 101;
            // 
            // ServiciiActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1493, 533);
            this.Controls.Add(this.cmb_Client);
            this.Controls.Add(this.btn_Asignare);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IdServiciu);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Detalii);
            this.Controls.Add(this.txt_Denumire);
            this.Controls.Add(this.btn_Renuntare);
            this.Controls.Add(this.btn_Confirmare);
            this.Controls.Add(this.btn_Stergere);
            this.Controls.Add(this.btn_Modificare);
            this.Controls.Add(this.btn_Adaugare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiciiActive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServiciiActive_Load);
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiActiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox txt_IdServiciu;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Detalii;
        private System.Windows.Forms.TextBox txt_Denumire;
        private System.Windows.Forms.Button btn_Renuntare;
        private System.Windows.Forms.Button btn_Confirmare;
        private System.Windows.Forms.Button btn_Stergere;
        private System.Windows.Forms.Button btn_Modificare;
        private System.Windows.Forms.Button btn_Adaugare;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource serviciiBindingSource;
        private bazadedateDataSetTableAdapters.serviciiTableAdapter serviciiTableAdapter;
        private System.Windows.Forms.BindingSource serviciiActiveBindingSource;
        private bazadedateDataSetTableAdapters.ServiciiActiveTableAdapter serviciiActiveTableAdapter;
        private System.Windows.Forms.Button btn_Asignare;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private bazadedateDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.BindingSource clientiBindingSource1;
        private System.Windows.Forms.ComboBox cmb_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireserviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_serviciu;
    }
}