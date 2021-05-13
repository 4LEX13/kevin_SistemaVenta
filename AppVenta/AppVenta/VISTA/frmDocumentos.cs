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
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();

        }

        void clear()
        {
            txtIdDocumento.Clear();
            txtNombreDocumento.Clear();

        }

        void Carga()
        {

            dgtDocumento.Rows.Clear();
            using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
            {
                var Lista = db.tb_documento.ToList();

                foreach (var iteracion in Lista)
                {
                    dgtDocumento.Rows.Add(iteracion.iDDocumento, iteracion.nombreDocumento);
                }
            }

        }
        private void frmDocumentos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsDocumento clsUserList = new ClsDocumento();
            tb_documento userList = new tb_documento();
            userList.nombreDocumento = txtNombreDocumento.Text;


            clsUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDocumento user = new ClsDocumento();
            user.deleteUser(Convert.ToInt32(txtIdDocumento.Text));

            Carga();
            clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsDocumento clsDUserList = new ClsDocumento();

            tb_documento userList = new tb_documento();
            userList.iDDocumento = Convert.ToInt32(txtIdDocumento.Text);
            userList.nombreDocumento = txtNombreDocumento.Text;

            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }

        private void dgtDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String idDocumento = dgtDocumento.CurrentRow.Cells[0].Value.ToString();
            String nombreDocumento = dgtDocumento.CurrentRow.Cells[1].Value.ToString();



            txtIdDocumento.Text = idDocumento;
            txtNombreDocumento.Text = nombreDocumento;

        }
    }
}
