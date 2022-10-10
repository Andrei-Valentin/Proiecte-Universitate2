using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AplicatieGestiune
{
    public partial class IstoricServicii : Form
    {
        public IstoricServicii()
        {
            InitializeComponent();
        }

        
        private void IstoricServicii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadedateDataSet.clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.bazadedateDataSet.clienti);
            this.istoricTableAdapter.Fill(this.bazadedateDataSet.istoric);

            this.txt_IdIstoric.Visible = false;

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

        //Functia pentru configurarea ferestrei
        private void Configurare_fereastra()
        {
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            Configurare2();
        }

        private void Configurare2()
        {
            //Çonfigurare(butoane)
            Configurare_butoane(true);

            //Protectie componente Panel
            Toggle_protectie(true);

            //Legare controale
            Legare_controale(true);
        }

        //Functia pentru configurarea butoanelor
        private void Configurare_butoane(bool val)
        {
            btn_Stergere.Enabled = val;
        }

        //Functia care activeaza/dezactiveaza protectia textbox-urilor
        private void Legare_controale(bool val)
        {
            if (val)
            {
                txt_Denumire.DataBindings.Add("Text", istoricBindingSource, "denumire_serviciu");
                txt_Detalii.DataBindings.Add("Text", istoricBindingSource, "detalii");
                txt_Client.DataBindings.Add("Text", istoricBindingSource, "nume_client");
            }
            else
            {
                txt_Denumire.DataBindings.Clear();
                txt_Detalii.DataBindings.Clear();
                txt_Client.DataBindings.Clear();
            }
        }

        //Functia care leaga sau dezactiveaza legatura controalelor
        private void Toggle_protectie(bool val)
        {
            txt_Denumire.ReadOnly = val;
            txt_Detalii.ReadOnly = val;
            txt_Client.ReadOnly = val;
        }

        private void Golire_campuri()
        {
            txt_Denumire.Text = "";
            txt_Detalii.Text = "";
            txt_Client.Text = "";
        }

        private bool Validare_campuri_obligatorii()
        {
            if (txt_Denumire.Text == "")
            {
                MessageBox.Show("Completati denumirea serviciului !");
                txt_Denumire.Focus();
                return false;
            }

            if (txt_Client.Text == "")
            {
                MessageBox.Show("Alegeti clientul !");
                txt_Client.Focus();
                return false;
            }

            return true;
        }



        private void Refresh_grid(int poz)
        {
            istoricTableAdapter.Fill(bazadedateDataSet.istoric);
            istoricBindingSource.Position = poz;
        }

        

        private void Stergere_inregistrare()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = istoricTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From istoric Where id_istoric = " + txt_IdIstoric.Text;

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Informatiile serviciului au fost sterse cu succes");


            con.Close();

            Refresh_grid(istoricBindingSource.Position);

        }

        private void Modificare()
        {
            //Configurare butoane
            Configurare_butoane(false);

            //Dezlegare controale Panel
            Legare_controale(false);

            //Ridicare protectie controale Panel
            Toggle_protectie(false);

            //Pozitionare cursor pe primul camp
            txt_Denumire.Focus();
        }


        //Bara de titlu si butoanele de pe aceasta



        //Event handle-uri pentru butoane
        private void btn_Stergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea?";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No)
                return;

            Stergere_inregistrare();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

