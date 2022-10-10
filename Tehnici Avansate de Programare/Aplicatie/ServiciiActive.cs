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
    public partial class ServiciiActive : Form
    {
        public ServiciiActive()
        {
            InitializeComponent();
        }

        private void ServiciiActive_Load(object sender, EventArgs e)
        {
            this.clientiTableAdapter.Fill(this.bazadedateDataSet.clienti);
            this.serviciiActiveTableAdapter.Fill(this.bazadedateDataSet.ServiciiActive);

            this.txt_IdServiciu.Visible = false;

            cmb_Client.DropDownStyle = ComboBoxStyle.Simple;
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

            cmb_Client.DropDownStyle = ComboBoxStyle.Simple;

            Configurare2();
        }

        private void Configurare2()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            Configurare_butoane(true);

            //Protectie componente Panel
            Toggle_protectie(true);

            //Legare controale
            Legare_controale(true);


            //Configurare(ComboBox - Uri)
            cmb_Client.DropDownStyle = ComboBoxStyle.DropDownList;

            //Legare comboBox-uri la sursa de date
            cmb_Client.DataSource = clientiBindingSource1;
            cmb_Client.DisplayMember = "nume_client";
            cmb_Client.ValueMember = "id_client";
        }

        //Functia pentru configurarea butoanelor
        private void Configurare_butoane(bool val)
        {
            btn_Renuntare.Visible = !val;
            btn_Confirmare.Visible = !val;

            btn_Adaugare.Enabled = val;
            btn_Modificare.Enabled = val;
            btn_Stergere.Enabled = val;
            btn_Asignare.Enabled = val;
        }

        //Functia care activeaza/dezactiveaza protectia textbox-urilor
        private void Legare_controale(bool val)
        {
            if (val)
            {
                txt_Denumire.DataBindings.Add("Text", serviciiActiveBindingSource, "denumire_serviciu");
                txt_Detalii.DataBindings.Add("Text", serviciiActiveBindingSource, "detalii");
                cmb_Client.DataBindings.Add("Text", serviciiActiveBindingSource, "nume_client");
            }
            else
            {
                txt_Denumire.DataBindings.Clear();
                txt_Detalii.DataBindings.Clear();
                cmb_Client.DataBindings.Clear();
            }
        }

        //Functia care leaga sau dezactiveaza legatura controalelor
        private void Toggle_protectie(bool val)
        {
            txt_Denumire.ReadOnly = val;
            txt_Detalii.ReadOnly = val;
            cmb_Client.Enabled = !val;
        }

        private void Golire_campuri()
        {
            txt_Denumire.Text = "";
            txt_Detalii.Text = "";
            cmb_Client.SelectedIndex = -1;
        }

        private bool Validare_campuri_obligatorii()
        {
            if (txt_Denumire.Text == "")
            {
                MessageBox.Show("Completati denumirea serviciului !");
                txt_Denumire.Focus();
                return false;
            }

            if (cmb_Client.Text == "")
            {
                MessageBox.Show("Alegeti clientul !");
                cmb_Client.Focus();
                return false;
            }

            return true;
        }

        private void Actualizare()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!Validare_campuri_obligatorii()) return;

                Adaugare_inregistrare();

                Golire_campuri();

                //Pune cursor pe primul camp
                txt_Denumire.Focus();
                Refresh_grid(serviciiActiveBindingSource.Position);
                cmb_Client.DataSource = clientiBindingSource1;
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!Validare_campuri_obligatorii()) return;

                Modificare_inregistrare();
                Refresh_grid(serviciiActiveBindingSource.Position);
                Configurare2();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void Refresh_grid(int poz)
        {
            serviciiActiveTableAdapter.Fill(bazadedateDataSet.ServiciiActive);
            serviciiActiveBindingSource.Position = poz;
        }

        private void Adaugare_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd;

            con.ConnectionString = serviciiActiveTableAdapter.Connection.ConnectionString;
            cmd = new MySqlCommand();

            cmd.Connection = con;

            string detalii;
            if (txt_Detalii.Text == "")
            {
                detalii = "N/A";
            }
            else
            {
                detalii = txt_Detalii.Text;
            }

            listaCampuri = "denumire_serviciu, id_client, detalii";
            listaValori = "'" + txt_Denumire.Text + "'" +
                          "," + cmb_Client.SelectedValue +
                          ",'" + detalii + "'";

            cmd.CommandText = "Insert into servicii(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show("Serviciul a fost adaugat cu succes");
            
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Modificare_inregistrare()
        {
            string listaSet;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = serviciiActiveTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            string detalii;
            if (txt_Detalii.Text == "")
            {
                detalii = "N/A";
            }
            else
            {
                detalii = txt_Detalii.Text;
            }

            listaSet = "denumire_serviciu = '" + txt_Denumire.Text + "'," +
                       "id_client = " + cmb_Client.SelectedValue + "," +
                       "detalii = '" + detalii + "'";

            cmd.CommandText = "Update servicii Set " + listaSet + " Where id_serviciu = " + txt_IdServiciu.Text;
            MessageBox.Show("Modificare realizata cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Stergere_inregistrare()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            string listaCampuri;
            string listaValori;

            con.ConnectionString = serviciiActiveTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "denumire_serviciu, nume_client, detalii, id_serviciu";
            listaValori = "'" + txt_Denumire.Text + "'" +
                          ",'" + cmb_Client.Text + "'" +
                          ",'" + txt_Detalii.Text + "'" +
                          "," + txt_IdServiciu.Text;

            cmd.CommandText = "Insert into istoric(" + listaCampuri + ") " +
                              "Select " + listaValori;

            con.Open();
            
            cmd.ExecuteNonQuery();


            cmd.CommandText = "Delete From servicii Where id_serviciu = " + txt_IdServiciu.Text;


            cmd.ExecuteNonQuery();

            MessageBox.Show("Informatiile serviciului au fost sterse cu succes");


            con.Close();

            Refresh_grid(serviciiActiveBindingSource.Position);

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
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        //Event handle-uri pentru butoane
        private void btn_Adaugare_Click(object sender, EventArgs e)
        {
            Modificare();
            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";
            Golire_campuri();
        }

        private void btn_Modificare_Click(object sender, EventArgs e)
        {
            Modificare();
            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";
        }

        private void btn_Stergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea?";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No)
                return;

            Stergere_inregistrare();
        }

        private void btn_Confirmare_Click(object sender, EventArgs e)
        {
            Actualizare();
        }

        private void btn_Renuntare_Click(object sender, EventArgs e)
        {
            Configurare2();
        }

        private void btn_Asignare_Click(object sender, EventArgs e)
        {
            Asignari Fereastra = new Asignari();
            Fereastra.ShowDialog();
        }
    }
}
