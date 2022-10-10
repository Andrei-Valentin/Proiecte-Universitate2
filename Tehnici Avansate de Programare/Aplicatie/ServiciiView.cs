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
    public partial class ServiciiView : Form
    {
        public ServiciiView()
        {
            InitializeComponent();
        }

        private void ServiciiView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadedateDataSet.ServiciiActive' table. You can move, or remove it, as needed.
            this.serviciiActiveTableAdapter.Fill(this.bazadedateDataSet.ServiciiActive);
            // TODO: This line of code loads data into the 'bazadedateDataSet.servicii' table. You can move, or remove it, as needed.
            this.serviciiTableAdapter.Fill(this.bazadedateDataSet.servicii);

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
