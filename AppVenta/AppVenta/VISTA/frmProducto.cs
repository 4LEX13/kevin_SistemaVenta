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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            Carga();
            clear();
        }

        void clear()
        {
          
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtEstado.Clear();

        }
        void Carga()
        {
            var ClsProducto = new ClsProducto();
            dgtProducto.Rows.Clear();
           

                foreach (var ListarDatos in ClsProducto.cargarProductoFiltro(txtNombreProducto.Text))
                {
                    dgtProducto.Rows.Add(ListarDatos.idProducto,ListarDatos.nombreProducto,ListarDatos.precioProducto);
                }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsProducto clsUserList = new ClsProducto();
            tb_producto userList = new tb_producto();
            userList.nombreProducto = txtNombreProducto.Text;
            userList.precioProducto = txtPrecio.Text;
            userList.estadoProducto = txtEstado.Text;

            clsUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsProducto user = new ClsProducto();
            user.deleteUser(Convert.ToInt32(txtIdProducto.Text));

            Carga();
            clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsProducto clsDUserList = new ClsProducto();

            tb_producto userList = new tb_producto();
            userList.idProducto = Convert.ToInt32(txtIdProducto.Text);
            userList.nombreProducto = txtNombreProducto.Text;
            userList.precioProducto = txtPrecio.Text;
            userList.estadoProducto = txtEstado.Text;


            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dgtProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idProducto = dgtProducto.CurrentRow.Cells[0].Value.ToString();
            String nombreProducto = dgtProducto.CurrentRow.Cells[1].Value.ToString();
            String precioProducto = dgtProducto.CurrentRow.Cells[2].Value.ToString();
            String estadoProducto = dgtProducto.CurrentRow.Cells[3].Value.ToString();

            txtIdProducto.Text = idProducto;
            txtNombreProducto.Text = nombreProducto;
            txtPrecio.Text = precioProducto;
            txtEstado.Text = estadoProducto;
        }

        private void dgtProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dgtProducto.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgtProducto.CurrentRow.Cells[1].Value.ToString();
            String Precio = dgtProducto.CurrentRow.Cells[2].Value.ToString();

            frmVenta frmVenta = new frmVenta();
            frmVenta.txtId.Text = Id;
            frmVenta.txtNombreProducto.Text = Nombre;
            frmVenta.txtPrecio.Text = Precio;
        }
    }
    
    
}
