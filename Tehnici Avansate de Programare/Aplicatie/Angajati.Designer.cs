namespace AplicatieGestiune
{
    partial class Angajati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angajati));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_IdAngajat = new System.Windows.Forms.TextBox();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.lblOp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CaleImagine = new System.Windows.Forms.TextBox();
            this.txt_TarifOrar = new System.Windows.Forms.TextBox();
            this.txt_Post = new System.Windows.Forms.TextBox();
            this.txt_CNP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.btn_Renuntare = new System.Windows.Forms.Button();
            this.btn_Confirmare = new System.Windows.Forms.Button();
            this.btn_Stergere = new System.Windows.Forms.Button();
            this.btn_Modificare = new System.Windows.Forms.Button();
            this.btn_Adaugare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.angajatiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.angajatiTableAdapter();
            this.numeangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariforarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caleimagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_bara_titlu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_IdAngajat
            // 
            this.txt_IdAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_IdAngajat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdAngajat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "id_angajat", true));
            this.txt_IdAngajat.Enabled = false;
            this.txt_IdAngajat.Location = new System.Drawing.Point(1035, 455);
            this.txt_IdAngajat.Name = "txt_IdAngajat";
            this.txt_IdAngajat.ReadOnly = true;
            this.txt_IdAngajat.Size = new System.Drawing.Size(100, 22);
            this.txt_IdAngajat.TabIndex = 41;
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
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.ForeColor = System.Drawing.Color.White;
            this.lblOp.Location = new System.Drawing.Point(1370, 131);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(41, 17);
            this.lblOp.TabIndex = 36;
            this.lblOp.Text = "lblOp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(887, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cale Imagine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(887, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tarif Orar (€)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(887, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Post";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(887, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(887, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(887, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nume";
            // 
            // txt_CaleImagine
            // 
            this.txt_CaleImagine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_CaleImagine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CaleImagine.ForeColor = System.Drawing.Color.White;
            this.txt_CaleImagine.Location = new System.Drawing.Point(1000, 413);
            this.txt_CaleImagine.Name = "txt_CaleImagine";
            this.txt_CaleImagine.ReadOnly = true;
            this.txt_CaleImagine.Size = new System.Drawing.Size(182, 22);
            this.txt_CaleImagine.TabIndex = 32;
            this.txt_CaleImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_CaleImagine_MouseDoubleClick);
            // 
            // txt_TarifOrar
            // 
            this.txt_TarifOrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_TarifOrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TarifOrar.ForeColor = System.Drawing.Color.White;
            this.txt_TarifOrar.Location = new System.Drawing.Point(1000, 376);
            this.txt_TarifOrar.Name = "txt_TarifOrar";
            this.txt_TarifOrar.ReadOnly = true;
            this.txt_TarifOrar.Size = new System.Drawing.Size(182, 22);
            this.txt_TarifOrar.TabIndex = 31;
            this.txt_TarifOrar.Leave += new System.EventHandler(this.txt_TarifOrar_Leave);
            // 
            // txt_Post
            // 
            this.txt_Post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Post.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Post.ForeColor = System.Drawing.Color.White;
            this.txt_Post.Location = new System.Drawing.Point(1000, 334);
            this.txt_Post.Name = "txt_Post";
            this.txt_Post.ReadOnly = true;
            this.txt_Post.Size = new System.Drawing.Size(182, 22);
            this.txt_Post.TabIndex = 30;
            // 
            // txt_CNP
            // 
            this.txt_CNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_CNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CNP.ForeColor = System.Drawing.Color.White;
            this.txt_CNP.Location = new System.Drawing.Point(1000, 254);
            this.txt_CNP.Name = "txt_CNP";
            this.txt_CNP.ReadOnly = true;
            this.txt_CNP.Size = new System.Drawing.Size(182, 22);
            this.txt_CNP.TabIndex = 29;
            this.txt_CNP.Leave += new System.EventHandler(this.txt_CNP_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1252, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Nume
            // 
            this.txt_Nume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Nume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nume.ForeColor = System.Drawing.Color.White;
            this.txt_Nume.Location = new System.Drawing.Point(1000, 211);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.ReadOnly = true;
            this.txt_Nume.Size = new System.Drawing.Size(182, 22);
            this.txt_Nume.TabIndex = 27;
            // 
            // btn_Renuntare
            // 
            this.btn_Renuntare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Renuntare.FlatAppearance.BorderSize = 0;
            this.btn_Renuntare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Renuntare.Location = new System.Drawing.Point(1174, 121);
            this.btn_Renuntare.Name = "btn_Renuntare";
            this.btn_Renuntare.Size = new System.Drawing.Size(135, 36);
            this.btn_Renuntare.TabIndex = 26;
            this.btn_Renuntare.Text = "Renuntare";
            this.btn_Renuntare.UseVisualStyleBackColor = false;
            this.btn_Renuntare.Click += new System.EventHandler(this.btn_Renuntare_Click);
            // 
            // btn_Confirmare
            // 
            this.btn_Confirmare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Confirmare.FlatAppearance.BorderSize = 0;
            this.btn_Confirmare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmare.Location = new System.Drawing.Point(951, 121);
            this.btn_Confirmare.Name = "btn_Confirmare";
            this.btn_Confirmare.Size = new System.Drawing.Size(135, 36);
            this.btn_Confirmare.TabIndex = 25;
            this.btn_Confirmare.Text = "Confirmare";
            this.btn_Confirmare.UseVisualStyleBackColor = false;
            this.btn_Confirmare.Click += new System.EventHandler(this.btn_Confirmare_Click);
            // 
            // btn_Stergere
            // 
            this.btn_Stergere.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Stergere.FlatAppearance.BorderSize = 0;
            this.btn_Stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stergere.Location = new System.Drawing.Point(575, 121);
            this.btn_Stergere.Name = "btn_Stergere";
            this.btn_Stergere.Size = new System.Drawing.Size(125, 36);
            this.btn_Stergere.TabIndex = 24;
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
            this.btn_Modificare.Location = new System.Drawing.Point(381, 121);
            this.btn_Modificare.Name = "btn_Modificare";
            this.btn_Modificare.Size = new System.Drawing.Size(125, 36);
            this.btn_Modificare.TabIndex = 23;
            this.btn_Modificare.Text = "Modificare";
            this.btn_Modificare.UseVisualStyleBackColor = false;
            this.btn_Modificare.Click += new System.EventHandler(this.btn_Modificare_Click);
            // 
            // btn_Adaugare
            // 
            this.btn_Adaugare.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Adaugare.FlatAppearance.BorderSize = 0;
            this.btn_Adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adaugare.Location = new System.Drawing.Point(181, 121);
            this.btn_Adaugare.Name = "btn_Adaugare";
            this.btn_Adaugare.Size = new System.Drawing.Size(125, 36);
            this.btn_Adaugare.TabIndex = 22;
            this.btn_Adaugare.Text = "Adaugare";
            this.btn_Adaugare.UseVisualStyleBackColor = false;
            this.btn_Adaugare.Click += new System.EventHandler(this.btn_Adaugare_Click);
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
            this.numeangajatDataGridViewTextBoxColumn,
            this.cnpangajatDataGridViewTextBoxColumn,
            this.emailangajatDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.tariforarDataGridViewTextBoxColumn,
            this.caleimagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(54, 211);
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
            this.dataGridView1.TabIndex = 42;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Email.ForeColor = System.Drawing.Color.White;
            this.txt_Email.Location = new System.Drawing.Point(1000, 294);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(182, 22);
            this.txt_Email.TabIndex = 43;
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
            this.btn_minimizare.Size = new System.Drawing.Size(72, 51);
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
            this.btn_Exit.Size = new System.Drawing.Size(72, 51);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.label_Titlu);
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(0, -4);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1511, 51);
            this.panel_bara_titlu.TabIndex = 44;
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titlu.ForeColor = System.Drawing.Color.White;
            this.label_Titlu.Location = new System.Drawing.Point(12, 13);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(77, 24);
            this.label_Titlu.TabIndex = 2;
            this.label_Titlu.Text = "Angajati";
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
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
            // emailangajatDataGridViewTextBoxColumn
            // 
            this.emailangajatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailangajatDataGridViewTextBoxColumn.DataPropertyName = "email_angajat";
            this.emailangajatDataGridViewTextBoxColumn.HeaderText = "email_angajat";
            this.emailangajatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailangajatDataGridViewTextBoxColumn.Name = "emailangajatDataGridViewTextBoxColumn";
            this.emailangajatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "post";
            this.postDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tariforarDataGridViewTextBoxColumn
            // 
            this.tariforarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tariforarDataGridViewTextBoxColumn.DataPropertyName = "tarif_orar";
            this.tariforarDataGridViewTextBoxColumn.HeaderText = "tarif_orar";
            this.tariforarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariforarDataGridViewTextBoxColumn.Name = "tariforarDataGridViewTextBoxColumn";
            this.tariforarDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariforarDataGridViewTextBoxColumn.Width = 94;
            // 
            // caleimagineDataGridViewTextBoxColumn
            // 
            this.caleimagineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caleimagineDataGridViewTextBoxColumn.DataPropertyName = "cale_imagine";
            this.caleimagineDataGridViewTextBoxColumn.HeaderText = "cale_imagine";
            this.caleimagineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caleimagineDataGridViewTextBoxColumn.Name = "caleimagineDataGridViewTextBoxColumn";
            this.caleimagineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1511, 580);
            this.Controls.Add(this.panel_bara_titlu);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IdAngajat);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CaleImagine);
            this.Controls.Add(this.txt_TarifOrar);
            this.Controls.Add(this.txt_Post);
            this.Controls.Add(this.txt_CNP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Nume);
            this.Controls.Add(this.btn_Renuntare);
            this.Controls.Add(this.btn_Confirmare);
            this.Controls.Add(this.btn_Stergere);
            this.Controls.Add(this.btn_Modificare);
            this.Controls.Add(this.btn_Adaugare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Angajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angajati";
            this.Load += new System.EventHandler(this.Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_bara_titlu.ResumeLayout(false);
            this.panel_bara_titlu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdAngajat;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CaleImagine;
        private System.Windows.Forms.TextBox txt_TarifOrar;
        private System.Windows.Forms.TextBox txt_Post;
        private System.Windows.Forms.TextBox txt_CNP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.Button btn_Renuntare;
        private System.Windows.Forms.Button btn_Confirmare;
        private System.Windows.Forms.Button btn_Stergere;
        private System.Windows.Forms.Button btn_Modificare;
        private System.Windows.Forms.Button btn_Adaugare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel_bara_titlu;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private bazadedateDataSetTableAdapters.angajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.Label label_Titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariforarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caleimagineDataGridViewTextBoxColumn;
    }
}