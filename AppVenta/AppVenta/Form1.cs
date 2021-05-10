using AppVenta.DAO;
using AppVenta.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsAcceso acce = new ClsAcceso();

            int valor = acce.Acceso(txtUsuario.Text, txtPass.Text);

            if (valor == 1)
            {
                frmVenta venta = new frmVenta();
                venta.Show();
            }

            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
