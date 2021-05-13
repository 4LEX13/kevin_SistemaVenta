
namespace AppVenta.VISTA
{
    partial class frmDocumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombreDocumento = new System.Windows.Forms.Label();
            this.txtIdDocumento = new System.Windows.Forms.TextBox();
            this.txtNombreDocumento = new System.Windows.Forms.TextBox();
            this.dgtDocumento = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(131, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblNombreDocumento
            // 
            this.lblNombreDocumento.AutoSize = true;
            this.lblNombreDocumento.Location = new System.Drawing.Point(43, 94);
            this.lblNombreDocumento.Name = "lblNombreDocumento";
            this.lblNombreDocumento.Size = new System.Drawing.Size(117, 13);
            this.lblNombreDocumento.TabIndex = 1;
            this.lblNombreDocumento.Text = "Nombre del documento";
            // 
            // txtIdDocumento
            // 
            this.txtIdDocumento.Location = new System.Drawing.Point(166, 42);
            this.txtIdDocumento.Name = "txtIdDocumento";
            this.txtIdDocumento.Size = new System.Drawing.Size(191, 20);
            this.txtIdDocumento.TabIndex = 2;
            // 
            // txtNombreDocumento
            // 
            this.txtNombreDocumento.Location = new System.Drawing.Point(166, 91);
            this.txtNombreDocumento.Name = "txtNombreDocumento";
            this.txtNombreDocumento.Size = new System.Drawing.Size(191, 20);
            this.txtNombreDocumento.TabIndex = 3;
            // 
            // dgtDocumento
            // 
            this.dgtDocumento.AllowUserToAddRows = false;
            this.dgtDocumento.AllowUserToDeleteRows = false;
            this.dgtDocumento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgtDocumento.Location = new System.Drawing.Point(46, 169);
            this.dgtDocumento.Name = "dgtDocumento";
            this.dgtDocumento.ReadOnly = true;
            this.dgtDocumento.Size = new System.Drawing.Size(400, 157);
            this.dgtDocumento.TabIndex = 4;
            this.dgtDocumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDocumento_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(371, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(371, 114);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(371, 62);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Documento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 359);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgtDocumento);
            this.Controls.Add(this.txtNombreDocumento);
            this.Controls.Add(this.txtIdDocumento);
            this.Controls.Add(this.lblNombreDocumento);
            this.Controls.Add(this.lblId);
            this.Name = "frmDocumentos";
            this.Text = "frmDocumentos";
            this.Load += new System.EventHandler(this.frmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombreDocumento;
        private System.Windows.Forms.TextBox txtIdDocumento;
        private System.Windows.Forms.TextBox txtNombreDocumento;
        private System.Windows.Forms.DataGridView dgtDocumento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}