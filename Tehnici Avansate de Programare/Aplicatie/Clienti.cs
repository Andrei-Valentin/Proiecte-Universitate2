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
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            this.clientiTableAdapter.Fill(this.bazadedateDataSet.clienti);
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
            //Initializare lblOp
            lblOp.Text = "";

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
            btn_Renuntare.Visible = !val;
            btn_Confirmare.Visible = !val;

            btn_Adaugare.Enabled = val;
            btn_Modificare.Enabled = val;
            btn_Stergere.Enabled = val;
        }

        //Functia care activeaza/dezactiveaza protectia textbox-urilor
        private void Legare_controale(bool val)
        {
            if (val)
            {
                txt_Nume.DataBindings.Add("Text", clientiBindingSource, "nume_client");
                txt_CNP.DataBindings.Add("Text", clientiBindingSource, "cnp_client");
                txt_Telefon.DataBindings.Add("Text", clientiBindingSource, "telefon_client");
                txt_Email.DataBindings.Add("Text", clientiBindingSource, "email_client");
            }
            else
            {
                txt_Nume.DataBindings.Clear();
                txt_CNP.DataBindings.Clear();
                txt_Telefon.DataBindings.Clear();
                txt_Email.DataBindings.Clear();
            }
        }

        //Functia care leaga sau dezactiveaza legatura controalelor
        private void Toggle_protectie(bool val)
        {
            txt_Nume.ReadOnly = val;
            txt_CNP.ReadOnly = val;
            txt_Telefon.ReadOnly = val;
            txt_Email.ReadOnly = val;
        }

        private void Golire_campuri()
        {
            txt_Nume.Text = "";
            txt_CNP.Text = "";
            txt_Telefon.Text = "";
            txt_Email.Text = "";
        }

        private bool Validare_campuri_obligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Departament, Post, TarifOrar
            if (txt_Nume.Text == "")
            {
                MessageBox.Show("Completati Nume !");
                txt_Nume.Focus();
                return false;
            }

            if (txt_CNP.Text == "")
            {
                MessageBox.Show("Completati CNP !");
                txt_CNP.Focus();
                return false;
            }

            if (txt_Telefon.Text == "")
            {
                MessageBox.Show("Completati adresa numarul de telefon !");
                txt_Telefon.Focus();
                return false;
            }

            if (txt_Email.Text == "")
            {
                MessageBox.Show("Completati adresa e-mail !");
                txt_Email.Focus();
                return false;
            }

            return true;
        }

        private void Actualizare()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!Validare_campuri_obligatorii()) return;

                if (!Verificare_duplicat_adaugare(txt_CNP, txt_Email, txt_Telefon)) return;


                Adaugare_inregistrare();

                Golire_campuri();

                //Pune cursor pe primul camp
                txt_Nume.Focus();
                Refresh_grid(clientiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!Validare_campuri_obligatorii()) return;

                if (!Verificare_duplicat_modificare(txt_CNP, txt_Email, txt_Telefon, txt_IdClient)) return;

                Modificare_inregistrare();
                Refresh_grid(clientiBindingSource.Position);
                Configurare2();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void Refresh_grid(int poz)
        {
            clientiTableAdapter.Fill(bazadedateDataSet.clienti);
            clientiBindingSource.Position = poz;
        }

        private void Adaugare_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd;

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd = new MySqlCommand();

            cmd.Connection = con;


            listaCampuri = "nume_client, cnp_client, telefon_client, email_client";
            listaValori = "'" + txt_Nume.Text + "'" +
                          "," + txt_CNP.Text +
                          "," + txt_Telefon.Text +
                          ",'" + txt_Email.Text + "'";

            cmd.CommandText = "Insert into clienti(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show("Clientul a fost adaugat cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Modificare_inregistrare()
        {
            string listaSet;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;


            listaSet = "nume_client = '" + txt_Nume.Text + "'," +
                       "cnp_client = " + txt_CNP.Text + "," +
                       "telefon_client = " + txt_Telefon.Text + "," +
                       "email_client = '" + txt_Email.Text + "'";

            cmd.CommandText = "Update clienti Set " + listaSet + " Where id_client = " + txt_IdClient.Text;

            MessageBox.Show("Modificare realizata cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Stergere_inregistrare()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From clienti Where id_client = " + txt_IdClient.Text;

            MessageBox.Show("Informatiile clientului au fost sterse cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            Refresh_grid(clientiBindingSource.Position);

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
            txt_Nume.Focus();
        }

        //Validari
        private bool Verificare_duplicat_adaugare(TextBox txtBox, TextBox txtBox2, TextBox txtBox3)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select COUNT(*) From clienti Where cnp_client = '" + txtBox.Text + "' ";

            con.Open();

            //Verificam daca CNP-ul exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("CNP deja existent");
                txt_CNP.Focus();
                return false;
            }


            cmd.CommandText = "Select COUNT(*) From clienti Where email_client = '" + txtBox2.Text + "' ";
            //Verificam daca adresa e-mail exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Adresa e-mail deja existenta");
                txt_Email.Focus();
                return false;
            }

            cmd.CommandText = "Select COUNT(*) From clienti Where telefon_client = '" + txtBox3.Text + "' ";
            //Verificam daca numar de telefon exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Numar de telefon deja existent");
                txt_Email.Focus();
                return false;
            }

            con.Close();

            return true;
        }

        private bool Verificare_duplicat_modificare(TextBox txtBox, TextBox txtBox2, TextBox txtBox3, TextBox txtBox4)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select COUNT(*) From clienti Where cnp_client = '" + txtBox.Text + "' And id_client <> " + txtBox4.Text;

            con.Open();

            //Verificam daca CNP-ul exista deja in baza de date la un alt client decat cel caruia ii modificam datele
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("CNP deja existent");
                txt_CNP.Focus();
                return false;
            }


            cmd.CommandText = "Select COUNT(*) From clienti Where email_client = '" + txtBox2.Text + "' And id_client <> " + txtBox4.Text;
            //Verificam daca adresa e-mail exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Adresa e-mail deja existenta");
                txt_Email.Focus();
                return false;
            }

            cmd.CommandText = "Select COUNT(*) From clienti Where telefon_client = '" + txtBox3.Text + "' And id_client <> " + txtBox4.Text;
            //Verificam daca numarul de telefon exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Numar de telefon deja existent");
                txt_Telefon.Focus();
                return false;
            }


            con.Close();

            return true;
        }

        //Functia pentru verificarea formatului
        //Daca valoarea introdusa nu este un numar afiseaza un mesaj de eroare
        private void Validare_numeric(TextBox txtBox)
        {
            decimal p;

            if (txtBox.Text == "") return;
            try
            {
                p = Convert.ToDecimal(txtBox.Text);
            }
            catch
            {
                MessageBox.Show("Format eronat");
                txtBox.Text = "";
                txtBox.Focus();
            }
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

        //Event handle-uri

        private void txt_CNP_Leave(object sender, EventArgs e)
        {
            Validare_numeric(txt_CNP);
        }

        private void txt_Telefon_Leave(object sender, EventArgs e)
        {
            Validare_numeric(txt_Telefon);
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
            const string mesaj = "Confirmati stergerea";
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
            /*
            const string mesaj = "Confirmati anularea";
            const string titlu = "Renuntare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No)
                return;
             */
            Configurare2();
        }
        
        //Event handle-uri pentru apasarea tastei Enter la introducerea datelor
        private void txt_Nume_KeyDown(object sender, KeyEventArgs e)
        {
            if(lblOp.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_CNP.Focus();
                }
            } 
        }

        private void txt_CNP_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblOp.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_Telefon.Focus();
                }
            }
        }

        private void txt_Telefon_KeyDown(object sender, KeyEventArgs e)
        {
            if (lblOp.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txt_Email.Focus();
                }
            }
        }

        private void txt_Email_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
