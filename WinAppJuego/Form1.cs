using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppJuego
{
    public partial class FormJuego : Form
    {
        public FormJuego()
        {
            InitializeComponent();
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            buttonJugar.Focus();
            pictureBoxGanador.Visible = false;
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            Random numeros = new Random();
            labelNumero1.Text = numeros.Next(1, 7).ToString();
            labelNumero2.Text = numeros.Next(1, 7).ToString();
            labelNumero3.Text = numeros.Next(1, 7).ToString();

            if (labelNumero1.Text == labelNumero2.Text && labelNumero1.Text == labelNumero3.Text)
            {
                pictureBoxGanador.Visible = true;
                labelTitulo.Text = "GANADOR";
            }
        }

        
    }
}
