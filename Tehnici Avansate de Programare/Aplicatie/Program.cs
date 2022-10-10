using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AplicatieGestiune
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1("Ionescu Marcel"));

            
            FStart Autentificare = new FStart();
            if (Autentificare.ShowDialog() == DialogResult.OK)
            {
                string Permisiuni = Autentificare.getPermisiuni();
                string Utilizator = Autentificare.getUtilizator();
                Autentificare.Close();
                if(Permisiuni == "Administrator")
                {
                    Application.Run(new Form1(Utilizator));
                }
                else if (Permisiuni == "Angajat")
                {
                    Application.Run(new FMain(Utilizator));
                }
                else if (Permisiuni == "Proiectant")
                {
                    Application.Run(new Form2(Utilizator));
                }
            } 
        }
    }
}
