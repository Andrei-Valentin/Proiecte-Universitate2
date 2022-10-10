using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicatieGestiune
{
    public partial class Utilizatori : Form
    {
        public Utilizatori()
        {
            InitializeComponent();
        }

        private void Utilizatori_Load(object sender, EventArgs e)
        {
            this.utilizatori1TableAdapter.Fill(this.bazadedateDataSet.utilizatori1);
            this.txt_IdClient.Visible = false;

            //Apelam functia pentru configurarea ferestrei
            Configurare_fereastra();
        }

        //Efect "drop shadow" pentru fereastra aplicatiei
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        //Ne permite sa mutam fereastra cu mouse-ul
        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;
        protected override void WndProc(ref Message msg)
        {
            base.WndProc(ref msg);
            if (msg.Msg == WM_NCHITTEST && msg.Result == (IntPtr)HTCLIENT)
            {
                msg.Result = (IntPtr)HTCAPTION;
            }
        }

        private void Configurare_fereastra()
        {
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            txt_Nume.DataBindings.Add("Text", utilizatori1BindingSource, "nume_angajat");
            txt_Utilizator.DataBindings.Add("Text", utilizatori1BindingSource, "nume_utilizator");
            txt_Parola.DataBindings.Add("Text", utilizatori1BindingSource, "parola");
            txt_Permisiuni.DataBindings.Add("Text", utilizatori1BindingSource, "permisiuni");
        }

        private void Refresh_grid(int poz)
        {
            utilizatori1TableAdapter.Fill(bazadedateDataSet.utilizatori1);
            utilizatori1BindingSource.Position = poz;
        }

        //Deschiderea ferestrei de creare cont nou
        private void btn_Creare_Click(object sender, EventArgs e)
        {
            CreareCont Fereastra = new CreareCont();
            Fereastra.ShowDialog();

            Refresh_grid(utilizatori1BindingSource.Position);
        }

        //Event handle-uri pentru afisarea si ascunderea parolei
        private void btn_Afisare_Click(object sender, EventArgs e)
        {
            txt_Parola.PasswordChar = '\0';
        }

        private void txt_Parola_TextChanged(object sender, EventArgs e)
        {
            txt_Parola.PasswordChar = '*';
        }


        //Bara de titlu si butoanele de pe aceasta
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Ascunderea parolei in dataGridView
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
                e.Value = new string('*', e.Value.ToString().Length);
        }
    }
}
