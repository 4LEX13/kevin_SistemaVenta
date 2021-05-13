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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();

            clear();
            Carga();
        }

        void clear()
        {

            txtId.Clear();
            txtEmail.Clear();
            txtPass.Clear();

        }

        void Carga()
        {

            dgtUsuario.Rows.Clear();
            using (sistema_ventasEntities3 db = new sistema_ventasEntities3())
            {
                var Lista = db.tb_usuario.ToList();

                foreach (var iteracion in Lista)
                {
                    dgtUsuario.Rows.Add(iteracion.iDUsuario, iteracion.email, iteracion.contrasena);
                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClsUsuario user = new ClsUsuario();
            user.deleteUser(Convert.ToInt32(txtId.Text));

            Carga();
            clear();
        }

        private void dgtUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsUsuario clsDUserList = new ClsUsuario();
            tb_usuario userList = new tb_usuario();
            userList.email = txtEmail.Text;
            userList.contrasena = txtPass.Text;

            clsDUserList.SaveDatosUser(userList);

            Carga();
            clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsUsuario clsDUserList = new ClsUsuario();

            tb_usuario userList = new tb_usuario();
            userList.iDUsuario = Convert.ToInt32(txtId.Text);
            userList.email = txtEmail.Text;
            userList.contrasena = txtPass.Text;

            clsDUserList.updateUser(userList);

            Carga();
            clear();
        }
    }
}
