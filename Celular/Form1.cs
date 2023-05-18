using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celular.Modelo;

namespace Celular
{
    public partial class Form1 : Form
    {
        telefono cel = new telefono();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnApagar.Enabled = false;
            btnLlamar.Enabled = false;
            btnTextear.Enabled = false;
            btnPrender.Enabled = true;
            btnCaerse.Enabled = false;
            cel.setEstado(false);
            cel.setOn_off(false);
        }

        private void Encender()
        {
            btnApagar.Enabled = true;
            btnLlamar.Enabled = true;
            btnTextear.Enabled = true;
            btnPrender.Enabled = false;
            btnCaerse.Enabled = true;
            cel.setEstado(true);               
            cel.setOn_off(true);
        }
        private void Apagar()
        {
            btnApagar.Enabled = false;
            btnLlamar.Enabled = false;
            btnTextear.Enabled = false;
            btnPrender.Enabled = true;
            btnCaerse.Enabled = false;
            cel.setEstado(false);
            cel.setOn_off(false);
        }                      
        private void btnPrender_Click(object sender, EventArgs e)
        {
            Encender(); 
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnCaerse_Click(object sender, EventArgs e)
        {
            btnApagar.Enabled = false;
            btnLlamar.Enabled = false;
            btnTextear.Enabled = false;
            btnPrender.Enabled = false;
            btnCaerse.Enabled = false;
            MessageBox.Show("¡SE DAÑO EL CELULAR!");
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if(cel.getEstado() == true)
            {
                MessageBox.Show("LLAMANDO...");
            }
            else
            {
                MessageBox.Show("Encienda primero el celular");
            }
        }

        private void btnTextear_Click(object sender, EventArgs e)
        {
            if (cel.getEstado() == true)
            {
                MessageBox.Show(" actualize la aplicacion para continuar");
            }
            else
            {
                MessageBox.Show("Encienda primero el celular");
            }
        }
    }
}
