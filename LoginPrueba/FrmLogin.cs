using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPrueba
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtclave.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "player1" && txtclave.Text == "admin123+")
            {
                Frminicio frminicio = new Frminicio();
                frminicio.FormClosed += (s, args) => this.Show();
                frminicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos. Inténtalo de nuevo.");
                txtusuario.Clear();
                txtclave.Clear();
                txtusuario.Focus();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
