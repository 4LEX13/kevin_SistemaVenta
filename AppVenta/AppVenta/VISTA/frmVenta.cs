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
            using (sistema_ventasEntities3 bd = new sistema_ventasEntities3())
            {
                var consultacliente = bd.tb_cliente.ToList();


                comboBox2.DataSource = consultacliente;
                comboBox2.DisplayMember = "nombreCliente";
                comboBox2.ValueMember = "iDCliente";

                var consultadocumento = bd.tb_documento.ToList();

                comboBox1.DataSource = consultadocumento;
                comboBox1.DisplayMember = "nombreDocumento";
                comboBox1.ValueMember = "iDDocumento";
            }

        }
    }
}
