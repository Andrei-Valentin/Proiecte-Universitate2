using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieGestiune
{
    public partial class Asignari : Form
    {
        public Asignari()
        {
            InitializeComponent();
        }

        private void Asignari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadedateDataSet.angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.bazadedateDataSet.angajati);

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
