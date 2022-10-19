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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int password = Convert.ToInt32(txtPassword.Text);

            if (nombre.ToUpper() == "FLOR" && password == 123456)
            {
                MessageBox.Show("Bienvenida" + " " + nombre);
            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }
        }
    }
}
