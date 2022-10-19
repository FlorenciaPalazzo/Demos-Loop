using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FormNotas : Form
    {
        public FormNotas()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int Nota1 = Convert.ToInt32(txtNota1.Text);
            int Nota2 = Convert.ToInt32(txtNota2.Text);
            int Nota3 = Convert.ToInt32(txtNota3.Text);
            int Nota4 = Convert.ToInt32(txtNota4.Text);


            int suma = Nota1 + Nota2 + Nota3 + Nota4;
            int[] notas = { Nota1, Nota2, Nota3, Nota4 };
            int notaMayor = notas.Max();
            int promedio = suma / 4;


            if (promedio >= 9)
            {
                MessageBox.Show("Su nota mayor es: " + notaMayor + " El promedio es: " + promedio + " Excelente");
            }
            else if (promedio < 9 && promedio >= 7)
            {
                MessageBox.Show("Su nota mayor es: " + notaMayor + " El promedio es: " + promedio + " Muy bien");
            }
            else if (promedio < 7 && promedio >= 4)
            {
                MessageBox.Show("Su nota mayor es: " + notaMayor + " El promedio es: " + promedio + " Regular");
            }
            else
            {
                MessageBox.Show("Su nota mayor es: " + notaMayor + " El promedio es: " + promedio + " En proceso de aprendizaje");
            }
        }
    }
}
