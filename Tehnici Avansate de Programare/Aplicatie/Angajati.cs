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
    public partial class Angajati : Form
    {
        public Angajati()
        {
            InitializeComponent();
        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            this.angajatiTableAdapter.Fill(this.bazadedateDataSet.angajati);
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

        //Functia pentru configurarea ferestrei
        private void Configurare_fereastra()
        {
            //Configuram picture box-ul
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

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
                txt_Nume.DataBindings.Add("Text", angajatiBindingSource, "nume_angajat");
                txt_CNP.DataBindings.Add("Text", angajatiBindingSource, "cnp_angajat");
                txt_Email.DataBindings.Add("Text", angajatiBindingSource, "email_angajat");
                txt_Post.DataBindings.Add("Text", angajatiBindingSource, "post");
                txt_TarifOrar.DataBindings.Add("Text", angajatiBindingSource, "tarif_orar");
                txt_CaleImagine.DataBindings.Add("Text", angajatiBindingSource, "cale_imagine");
                pictureBox1.DataBindings.Add("ImageLocation", angajatiBindingSource, "cale_imagine");
            }
            else
            {
                txt_Nume.DataBindings.Clear();
                txt_CNP.DataBindings.Clear();
                txt_Email.DataBindings.Clear();
                txt_Post.DataBindings.Clear();
                txt_TarifOrar.DataBindings.Clear();
                txt_CaleImagine.DataBindings.Clear();
                pictureBox1.DataBindings.Clear();
            }
        }

        //Functia care leaga sau dezactiveaza legatura controalelor
        private void Toggle_protectie(bool val)
        {
            txt_Nume.ReadOnly = val;
            txt_CNP.ReadOnly = val;
            txt_Email.ReadOnly = val;
            txt_Post.ReadOnly = val;
            txt_TarifOrar.ReadOnly = val;
            txt_CaleImagine.ReadOnly = val;
        }

        private void Golire_campuri()
        {
            txt_Nume.Text = "";
            txt_CNP.Text = "";
            txt_Email.Text = "";
            txt_Post.Text = "";
            txt_TarifOrar.Text = "";
            txt_CaleImagine.Text = "";
            pictureBox1.ImageLocation = "";
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

            if (txt_Email.Text == "")
            {
                MessageBox.Show("Completati adresa e-mail !");
                txt_Email.Focus();
                return false;
            }

            if(txt_Post.Text == "")
            {
                txt_Post.Text = "N/A";
            }

            if(txt_TarifOrar.Text == "")
            {
                txt_TarifOrar.Text = "0";
            }
            //Daca calea imaginii nu este corecta este inlocuita cu N/A
            if (File.Exists(txt_CaleImagine.Text) == false)
            {
                txt_CaleImagine.Text = "N/A";
            }


            return true;
        }

        private void Actualizare()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!Validare_campuri_obligatorii()) return;

                if (!Verificare_duplicat_adaugare(txt_CNP, txt_Email)) return;


                Adaugare_inregistrare();

                Golire_campuri();

                //Pune cursor pe primul camp
                txt_Nume.Focus();
                Refresh_grid(angajatiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!Validare_campuri_obligatorii()) return;

                if (!Verificare_duplicat_modificare(txt_CNP, txt_Email, txt_IdAngajat)) return;

                Modificare_inregistrare();
                Refresh_grid(angajatiBindingSource.Position);
                Configurare2();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void Refresh_grid(int poz)
        {
            angajatiTableAdapter.Fill(bazadedateDataSet.angajati);
            angajatiBindingSource.Position = poz;
        }

        private void Adaugare_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd;

            con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;
            cmd = new MySqlCommand();

            cmd.Connection = con;

            string Cale;
            if (txt_CaleImagine.Text != "")
            {
                Cale = txt_CaleImagine.Text;
                Cale = Cale.Replace("\\", "\\\\");
            }
            else
            {
                Cale = "N/A";
            }

            listaCampuri = "nume_angajat, cnp_angajat, email_angajat, post, tarif_orar, cale_imagine";
            listaValori = "'" + txt_Nume.Text + "'" +
                          "," + txt_CNP.Text +
                          ",'" + txt_Email.Text + "'" +
                          ",'" + txt_Post.Text + "'" +
                          "," + txt_TarifOrar.Text +
                          ",'" + Cale + "'";

            cmd.CommandText = "Insert into angajati(" + listaCampuri + ") " +
                              "Select " + listaValori;

            MessageBox.Show("Angajatul a fost adaugat cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Modificare_inregistrare()
        {
            string listaSet;

            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;
 
            cmd.Connection = con;

            string Post;
            float Tarif;
            string Cale;

            if (txt_Post.Text != "")
            {
                Post = txt_Post.Text;
            }
            else
            {
                Post = "N/A";
            }

            if (txt_TarifOrar.Text != "")
            {
                Tarif = float.Parse(txt_TarifOrar.Text);
            }
            else
            {
                Tarif = 0;
            }

            if (txt_CaleImagine.Text != "")
            {
                Cale = txt_CaleImagine.Text;
                Cale = Cale.Replace("\\", "\\\\");
            }
            else
            {
                Cale = "N/A";
            }

            listaSet = "nume_angajat = '" + txt_Nume.Text + "'," +
                       "cnp_angajat = " + txt_CNP.Text + "," +
                       "email_angajat = '" + txt_Email.Text + "'," +
                       "post = '" + Post + "'," +
                       "tarif_orar = " + Tarif + "," +
                       "cale_imagine = '" + Cale + "'";

            cmd.CommandText = "Update angajati Set " + listaSet + " Where id_angajat = " + txt_IdAngajat.Text;
            MessageBox.Show("Modificare realizata cu succes");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void Stergere_inregistrare()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From utilizatori Where id_angajat = " + txt_IdAngajat.Text;

            con.Open();

            cmd.ExecuteNonQuery();

            MessageBox.Show("Informatiile angajatului au fost sterse cu succes");

            cmd.CommandText = "Delete From angajati Where id_angajat = " + txt_IdAngajat.Text;

            cmd.ExecuteNonQuery();

            con.Close();

            Refresh_grid(angajatiBindingSource.Position);

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
        private bool Verificare_duplicat_adaugare(TextBox txtBox, TextBox txtBox2)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select COUNT(*) From angajati Where cnp_angajat = '" + txtBox.Text + "' ";

            con.Open();

            //Verificam daca CNP-ul exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("CNP deja existent");
                txt_CNP.Focus();
                return false;
            }

            
            cmd.CommandText = "Select COUNT(*) From angajati Where email_angajat = '" + txtBox2.Text + "' ";
            //Verificam daca adresa e-mail exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Adresa e-mail deja existenta");
                txt_Email.Focus();
                return false;
            }
            

            con.Close();

            return true;
        }

        private bool Verificare_duplicat_modificare(TextBox txtBox, TextBox txtBox2, TextBox txtBox3)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = angajatiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select COUNT(*) From angajati Where cnp_angajat = '" + txtBox.Text + "' And id_angajat <> " + txtBox3.Text;

            con.Open();

            //Verificam daca CNP-ul exista deja in baza de date la un alt angajat decat cel caruia ii modificam datele
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("CNP deja existent");
                txt_CNP.Focus();
                return false;
            }

            
            cmd.CommandText = "Select COUNT(*) From angajati Where email_angajat = '" + txtBox2.Text + "' And id_angajat <> " + txtBox3.Text;
            //Verificam daca adresa e-mail exista deja in baza de date
            if (Convert.ToInt64(cmd.ExecuteScalar()) != Convert.ToInt64(0))
            {
                MessageBox.Show("Adresa e-mail deja existenta");
                txt_Email.Focus();
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
        

        //Functia pentru alegerea unei imagini
        private void Alegere_imagine()
        {
            if (lblOp.Text == "")
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_CaleImagine.Text = openFileDialog.FileName;
                pictureBox1.ImageLocation = txt_CaleImagine.Text;
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

        private void txt_TarifOrar_Leave(object sender, EventArgs e)
        {
            Validare_numeric(txt_TarifOrar);
        }

        private void txt_CaleImagine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Alegere_imagine();
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
            const string mesaj = "Confirmati stergerea? Se va sterge si contul de utilizator al angajatului.";
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
    }
}
