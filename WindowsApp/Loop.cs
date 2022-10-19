using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace WindowsApp
{
    public partial class Loop : Form
    {
        public Loop()
        {
            InitializeComponent();
        }

        private void btnLoop_Click_Click(object sender, EventArgs e)
        {
            int total = 0;
            MessageBox.Show("Ingrese 10 números menor que 100");

            for (int i = 0; i < 4 ; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese número", "Carga de números"));

                while (numero >=100)
                {
                    MessageBox.Show("Ingrese números menores a 100, intente de nuevo.");
                    numero = Convert.ToInt32(Interaction.InputBox("Ingrese número", "Carga de números"));
                }

                total += numero; 

             }
            MessageBox.Show("Total: " + total);
        }
    }
}
