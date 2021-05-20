using AppVenta.DAO;
using AppVenta.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVenta.VISTA
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            ClsCliente clsCliente = new ClsCliente();
            
                


                comboBox2.DataSource = clsCliente.cargarComboCliente();
                comboBox2.DisplayMember = "nombreCliente";
                comboBox2.ValueMember = "iDCliente";

            ClsDocumento clsDocumento = new ClsDocumento();

                comboBox1.DataSource = clsDocumento.cargarComboDocumento();
                comboBox1.DisplayMember = "nombreDocumento";
                comboBox1.ValueMember = "iDDocumento";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProducto buscar = new frmProducto();
            buscar.Show();
        }
    }
}
