using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AplicatieGestiune
{
    public partial class Form1 : Form
    {
        string UtilizatorAutentificat;
        string Selectie;
        public Form1(string Utilizator)
        {
            InitializeComponent();
            UtilizatorAutentificat = Utilizator;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            lbl_NumeUtilizator.Text = GetNume(UtilizatorAutentificat);
            pictureBoxUtilizator.ImageLocation = GetCaleImagine();

            lblTitlu.Text = "Bun venit, " + GetNume(UtilizatorAutentificat);
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

        private string GetNume(string Nume_utilizator)
        {
            string Nume = "";
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            con = new MySqlConnection("Server=localhost;Database=bazadedate;user=root;Pwd=exemplu;SslMode=Required");
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select nume_angajat from angajati " +
            "where id_angajat = (Select id_angajat from utilizatori where nume_utilizator ='" + Nume_utilizator + "')";

            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Nume = rdr.GetString(0);
            }

            con.Close();

            return Nume;
        }

        private string GetCaleImagine()
        {
            string CaleImagine = "";
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader rdr;

            con = new MySqlConnection("Server=localhost;Database=bazadedate;user=root;Pwd=exemplu;SslMode=Required");
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select cale_imagine from angajati " +
            "where id_angajat = (Select id_angajat from utilizatori where nume_utilizator ='" + UtilizatorAutentificat + "')";

            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                CaleImagine = rdr.GetString(0);
            }

            con.Close();

            return CaleImagine;
        }

        //Functie care realizeaza mutarea panoului lateral pe optiunea selectata
        private void Mutare_Selectie(Button buton)
        {
            if (panel_selectare.Visible == false)
            {
                panel_selectare.Visible = true;
            }

            panel_selectare.Top = buton.Top;

            Selectie = buton.Name;
        }

        private void Afisare_butoane()
        {
            if (btn_Gestionare.Visible == false)
                btn_Gestionare.Visible = true;
        }

        private void lblTitlu_Click(object sender, EventArgs e)
        {

        }

        //Bara de titlu si butoanele de pe aceasta
        private void panel_bara_titlu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizare_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Butoane meniu lateral
        private void btn_Angajati_Click(object sender, EventArgs e)
        {
            //Mutam bara laterala care indica optiunea selectata
            Mutare_Selectie(btn_Angajati);

            Afisare_butoane();
        }




        private void btn_Utilizatori_Click(object sender, EventArgs e)
        {
            //Mutam bara laterala care indica optiunea selectata
            Mutare_Selectie(btn_Utilizatori);

            Afisare_butoane();
        }

        //In functie de optiunea selectata se va deschide o fereastra de gestionare
        private void btn_Gestionare_Click(object sender, EventArgs e)
        {
            if (Selectie == btn_Angajati.Name)
            {
                Angajati Fereastra = new Angajati();
                Fereastra.ShowDialog();

                lbl_NumeUtilizator.Text = GetNume(UtilizatorAutentificat);
                pictureBoxUtilizator.ImageLocation = GetCaleImagine();
            }

            if (Selectie == btn_Utilizatori.Name)
            {
                Utilizatori Fereastra = new Utilizatori();
                Fereastra.ShowDialog();
            }
        }
    }
}

