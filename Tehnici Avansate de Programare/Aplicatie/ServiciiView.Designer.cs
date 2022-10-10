namespace AplicatieGestiune
{
    partial class ServiciiView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_minimizare = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_bara_titlu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazadedateDataSet = new AplicatieGestiune.bazadedateDataSet();
            this.serviciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciiTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.serviciiTableAdapter();
            this.serviciiActiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciiActiveTableAdapter = new AplicatieGestiune.bazadedateDataSetTableAdapters.ServiciiActiveTableAdapter();
            this.denumireserviciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Detalii = new System.Windows.Forms.TextBox();
            this.txt_Denumire = new System.Windows.Forms.TextBox();
            this.panel_bara_titlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiActiveBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btn_minimizare.Location = new System.Drawing.Point(1144, 3);
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
            this.btn_Exit.Location = new System.Drawing.Point(1222, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(72, 47);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel_bara_titlu
            // 
            this.panel_bara_titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.panel_bara_titlu.Controls.Add(this.btn_minimizare);
            this.panel_bara_titlu.Controls.Add(this.btn_Exit);
            this.panel_bara_titlu.Location = new System.Drawing.Point(-9, -3);
            this.panel_bara_titlu.Name = "panel_bara_titlu";
            this.panel_bara_titlu.Size = new System.Drawing.Size(1353, 48);
            this.panel_bara_titlu.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireserviciuDataGridViewTextBoxColumn,
            this.numeclientDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviciiActiveBindingSource;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.Location = new System.Drawing.Point(37, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 266);
            this.dataGridView1.TabIndex = 65;
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
            // serviciiTableAdapter
            // 
            this.serviciiTableAdapter.ClearBeforeFill = true;
            // 
            // serviciiActiveBindingSource
            // 
            this.serviciiActiveBindingSource.DataMember = "ServiciiActive";
            this.serviciiActiveBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // serviciiActiveTableAdapter
            // 
            this.serviciiActiveTableAdapter.ClearBeforeFill = true;
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
            // txt_Client
            // 
            this.txt_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Client.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciiActiveBindingSource, "nume_client", true));
            this.txt_Client.ForeColor = System.Drawing.Color.White;
            this.txt_Client.Location = new System.Drawing.Point(993, 203);
            this.txt_Client.Name = "txt_Client";
            this.txt_Client.ReadOnly = true;
            this.txt_Client.Size = new System.Drawing.Size(284, 22);
            this.txt_Client.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(823, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 123;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(823, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "Detalii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(823, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Denumire serviciu";
            // 
            // txt_Detalii
            // 
            this.txt_Detalii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Detalii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Detalii.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciiActiveBindingSource, "detalii", true));
            this.txt_Detalii.ForeColor = System.Drawing.Color.White;
            this.txt_Detalii.Location = new System.Drawing.Point(992, 243);
            this.txt_Detalii.Multiline = true;
            this.txt_Detalii.Name = "txt_Detalii";
            this.txt_Detalii.ReadOnly = true;
            this.txt_Detalii.Size = new System.Drawing.Size(284, 101);
            this.txt_Detalii.TabIndex = 120;
            // 
            // txt_Denumire
            // 
            this.txt_Denumire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.txt_Denumire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Denumire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciiActiveBindingSource, "denumire_serviciu", true));
            this.txt_Denumire.ForeColor = System.Drawing.Color.White;
            this.txt_Denumire.Location = new System.Drawing.Point(992, 169);
            this.txt_Denumire.Name = "txt_Denumire";
            this.txt_Denumire.ReadOnly = true;
            this.txt_Denumire.Size = new System.Drawing.Size(284, 22);
            this.txt_Denumire.TabIndex = 119;
            // 
            // ServiciiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1288, 500);
            this.Controls.Add(this.txt_Client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Detalii);
            this.Controls.Add(this.txt_Denumire);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_bara_titlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiciiView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ServiciiView_Load);
            this.panel_bara_titlu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciiActiveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_minimizare;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel_bara_titlu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource serviciiBindingSource;
        private bazadedateDataSetTableAdapters.serviciiTableAdapter serviciiTableAdapter;
        private System.Windows.Forms.BindingSource serviciiActiveBindingSource;
        private bazadedateDataSetTableAdapters.ServiciiActiveTableAdapter serviciiActiveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireserviciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Detalii;
        private System.Windows.Forms.TextBox txt_Denumire;
    }
}