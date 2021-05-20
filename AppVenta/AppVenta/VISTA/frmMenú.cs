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
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();
        }


        public static frmVenta frm = new frmVenta();


        private void liataDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocumentos frm = new frmDocumentos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frm.Show();
        }
    }
}
