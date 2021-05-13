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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            Carga();
            clear();
        }

        void clear()
        {

            txtId.Clear();
            txtNombreCliente.Clear();
            txtDireccion.Clear();
            txtDui.Clear();
        }

        void Carga()
        {

            txtId.Clear();
            txtNombreCliente.Clear();
            txtDireccion.Clear();
            txtDui.Clear();
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsCliente clsDUserList = new ClsCliente();
            tb_cliente userList = new tb_cliente();
            userList.nombreCliente = txtNombreCliente.Text;
            userList.direccionCliente = txtDireccion.Text;
            userList.duiCliente = txtDui.Text;

            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsCliente user = new ClsCliente();
            user.deleteUser(Convert.ToInt32(txtId.Text));

            Carga();
            clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsCliente clsDUserList = new ClsCliente();

            tb_cliente userList = new tb_cliente();
            userList.iDCliente = Convert.ToInt32(txtId.Text);
            userList.nombreCliente = txtNombreCliente.Text;
            userList.direccionCliente = txtDireccion.Text;
            userList.duiCliente = txtDui.Text;
            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dgtClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String idCliente = dgtClientes.CurrentRow.Cells[0].Value.ToString();
            String nombreCliente = dgtClientes.CurrentRow.Cells[1].Value.ToString();
            String DireccionCliente = dgtClientes.CurrentRow.Cells[2].Value.ToString();
            String dui = dgtClientes.CurrentRow.Cells[3].Value.ToString();


            txtId.Text = idCliente;
            txtNombreCliente.Text = nombreCliente;
            txtDireccion.Text = DireccionCliente;
            txtDui.Text = dui;
        }
    }
}
