using System;
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
    public partial class CreareCont : Form
    {
        public CreareCont()
        {
            InitializeComponent();
        }

        private void CreareCont_Load(object sender, EventArgs e)
        {
            this.angajatiFaraContTableAdapter.Fill(this.bazadedateDataSet.angajatiFaraCont);
            this.txt_IdAngajat.Visible = false;

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

            txt_Nume.DataBindings.Add("Text", angajatiFaraContBindingSource, "nume_angajat");
        }

        private void Refresh_grid(int poz)
        {
            angajatiFaraContTableAdapter.Fill(bazadedateDataSet.angajatiFaraCont);
            angajatiFaraContBindingSource.Position = poz;
        }

        private void Creare_cont()
        {
            string listaCampuri;
            string listaValori;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd;

            con = new MySqlConnection("Server=localhost;Database=bazadedate;user=root;Pwd=exemplu;SslMode=Required");
            cmd = new MySqlCommand();

            cmd.Connection = con;


            listaCampuri = "nume_utilizator, parola, permisiuni, id_angajat";
            listaValori = "'" + txt_Utilizator.Text + "'" +
                          ",'" + txt_Parola.Text + "'" +
                          ",'" + cmbPermisiuni.Text + "'" +
                          "," + txt_IdAngajat.Text;

            cmd.CommandText = "Insert into utilizatori(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show("Contul de utilizator a fost creat cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            //Trimitere pe mail
            //
        }

        //Functia care genereaza automat datele de utilizator
        private void Generare_informatii()
        {
            string Utilizator;
            string Parola = "";
            Random Rnd = new Random();
            string Char_parola = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!?";

            Utilizator = txt_Nume.Text;
            Utilizator = Utilizator.Replace(" ", "");
            Utilizator = Utilizator.ToLower();
            Utilizator = Utilizator + Rnd.Next(100).ToString();
            
            txt_Utilizator.Text = Utilizator;

            for(int i = 0; i<=9; i++)
            {
                Parola = Parola + Char_parola[Rnd.Next(63)];
            }

            txt_Parola.Text = Parola;
        }

        private bool Verificare_duplicate(TextBox txtBox)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con = new MySqlConnection("Server=localhost;Database=bazadedate;user=root;Pwd=exemplu;SslMode=Required");

            cmd.Connection = con;

            cmd.CommandText = "Select COUNT(*) From utilizatori Where nume_utilizator = '" + txtBox.Text + "' ";

            con.Open();

            //Verificam daca numele de utilizator exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Nume utilizator deja existent");
                txt_Utilizator.Focus();
                return false;
            }

            con.Close();

            return true;
        }

        private bool Validare_campuri_obligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Departament, Post, TarifOrar
            if (txt_Utilizator.Text == "")
            {
                MessageBox.Show("Completati numele de utilizator !");
                txt_Utilizator.Focus();
                return false;
            }

            if (txt_Parola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txt_Parola.Focus();
                return false;
            }

            if (cmbPermisiuni.Text == "")
            {
                MessageBox.Show("Selectati permisiunile contului !");
                cmbPermisiuni.Focus();
                return false;
            }

            return true;
        }

        //Butoane
        private void btn_Creare_Click(object sender, EventArgs e)
        {
            if(Verificare_duplicate(txt_Utilizator) && Validare_campuri_obligatorii())
            {
                Creare_cont();
            }    
            Refresh_grid(angajatiFaraContBindingSource.Position);

            this.Close();
        }

        private void btn_Generare_Click(object sender, EventArgs e)
        {
            Generare_informatii();
        }

        private void btn_Renuntare_Click(object sender, EventArgs e)
        {
            const string mesaj = "Renuntati la crearea unui cont?";
            const string titlu = "Renuntare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No)
                return;
            else
                this.Close();
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
    }
}
