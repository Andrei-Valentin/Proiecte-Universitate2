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
    public partial class FStart : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string Utilizator; //Pentru a trimite catre fereastra principala numele utilizatorului dupa autentificare
        string Permisiuni;

        public FStart()
        {
            InitializeComponent();
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

        //Getter pentru numele de utilizator
        public string getUtilizator() 
        {
            return Utilizator;
        }

        public string getPermisiuni()
        {
            return Permisiuni;
        }

        //Functia care realizeaza autentificarea
        private Boolean Autentificare_OK()
        {
            if (txt_Utilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txt_Utilizator.Focus();
                return false;
            }

            if (txt_Parola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txt_Parola.Focus();
                return false;
            }

            con = new MySqlConnection("Server=localhost;Database=bazadedate;user=root;Pwd=exemplu;SslMode=Required");
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select id_utilizator, parola, nume_utilizator, nume_angajat, permisiuni from utilizatori u join angajati a on a.id_angajat = u.id_angajat " +
            "where nume_utilizator ='" + txt_Utilizator.Text + "'";
            
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                if (txt_Parola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txt_Parola.Focus();
                    con.Close();
                    return false;
                }
                Utilizator = rdr.GetString(2);
                Permisiuni = rdr.GetString(4);
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Nume utilizator eronat");
                txt_Utilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void btn_Autentificare_Click(object sender, EventArgs e)
        {
            if (Autentificare_OK())
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Autentificare cu succes!");
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

        //Event handler pentru a trece la urmatoarea casuta atunci cand avem selectata casuta utilizator si apasam Enter
        private void txt_Utilizator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Parola.Focus();
            }
        }

        //Event handler pentru a realiza autentificarea atunci cand avem selectata casuta parola si apasam Enter
        private void txt_Parola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Autentificare_Click(sender, e);
            }
        }
    }
}
