namespace Kiosk
{
    partial class FinalizarCrearFactura
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
            this.btn_crearFacturaInvitado = new System.Windows.Forms.Button();
            this.btn_crearFacturaCliente = new System.Windows.Forms.Button();
            this.pnl_facturaElegirCliente = new System.Windows.Forms.Panel();
            this.lbl_medioPago = new System.Windows.Forms.Label();
            this.cmb_medioPago = new System.Windows.Forms.ComboBox();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.txb_nombreCliente = new System.Windows.Forms.TextBox();
            this.dgv_buscarClienteFactura = new System.Windows.Forms.DataGridView();
            this.clm_codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Elegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pd_imprimirTicket = new System.Drawing.Printing.PrintDocument();
            this.pnl_facturaElegirCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscarClienteFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearFacturaInvitado
            // 
            this.btn_crearFacturaInvitado.Location = new System.Drawing.Point(48, 25);
            this.btn_crearFacturaInvitado.Name = "btn_crearFacturaInvitado";
            this.btn_crearFacturaInvitado.Size = new System.Drawing.Size(206, 56);
            this.btn_crearFacturaInvitado.TabIndex = 0;
            this.btn_crearFacturaInvitado.Text = "Crear Factura Como Invitado";
            this.btn_crearFacturaInvitado.UseVisualStyleBackColor = true;
            this.btn_crearFacturaInvitado.Click += new System.EventHandler(this.btn_crearFacturaInvitado_Click);
            // 
            // btn_crearFacturaCliente
            // 
            this.btn_crearFacturaCliente.Location = new System.Drawing.Point(475, 25);
            this.btn_crearFacturaCliente.Name = "btn_crearFacturaCliente";
            this.btn_crearFacturaCliente.Size = new System.Drawing.Size(206, 56);
            this.btn_crearFacturaCliente.TabIndex = 1;
            this.btn_crearFacturaCliente.Text = "Elegir Cliente";
            this.btn_crearFacturaCliente.UseVisualStyleBackColor = true;
            this.btn_crearFacturaCliente.Click += new System.EventHandler(this.btn_crearFacturaCliente_Click);
            // 
            // pnl_facturaElegirCliente
            // 
            this.pnl_facturaElegirCliente.Controls.Add(this.lbl_medioPago);
            this.pnl_facturaElegirCliente.Controls.Add(this.cmb_medioPago);
            this.pnl_facturaElegirCliente.Controls.Add(this.lbl_NombreCliente);
            this.pnl_facturaElegirCliente.Controls.Add(this.btn_buscarCliente);
            this.pnl_facturaElegirCliente.Controls.Add(this.txb_nombreCliente);
            this.pnl_facturaElegirCliente.Controls.Add(this.dgv_buscarClienteFactura);
            this.pnl_facturaElegirCliente.Location = new System.Drawing.Point(48, 102);
            this.pnl_facturaElegirCliente.Name = "pnl_facturaElegirCliente";
            this.pnl_facturaElegirCliente.Size = new System.Drawing.Size(633, 342);
            this.pnl_facturaElegirCliente.TabIndex = 2;
            // 
            // lbl_medioPago
            // 
            this.lbl_medioPago.AutoSize = true;
            this.lbl_medioPago.Location = new System.Drawing.Point(23, 273);
            this.lbl_medioPago.Name = "lbl_medioPago";
            this.lbl_medioPago.Size = new System.Drawing.Size(103, 17);
            this.lbl_medioPago.TabIndex = 5;
            this.lbl_medioPago.Text = "Medio de Pago";
            // 
            // cmb_medioPago
            // 
            this.cmb_medioPago.FormattingEnabled = true;
            this.cmb_medioPago.Location = new System.Drawing.Point(23, 294);
            this.cmb_medioPago.Name = "cmb_medioPago";
            this.cmb_medioPago.Size = new System.Drawing.Size(121, 24);
            this.cmb_medioPago.TabIndex = 4;
            this.cmb_medioPago.SelectedIndexChanged += new System.EventHandler(this.cmb_medioPago_SelectedIndexChanged);
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(23, 18);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(125, 17);
            this.lbl_NombreCliente.TabIndex = 3;
            this.lbl_NombreCliente.Text = "Nombre de Cliente";
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Location = new System.Drawing.Point(477, 18);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(135, 55);
            this.btn_buscarCliente.TabIndex = 2;
            this.btn_buscarCliente.Text = "Buscar...";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // txb_nombreCliente
            // 
            this.txb_nombreCliente.Location = new System.Drawing.Point(23, 50);
            this.txb_nombreCliente.Name = "txb_nombreCliente";
            this.txb_nombreCliente.Size = new System.Drawing.Size(433, 22);
            this.txb_nombreCliente.TabIndex = 1;
            this.txb_nombreCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_nombreCliente_KeyDown);
            // 
            // dgv_buscarClienteFactura
            // 
            this.dgv_buscarClienteFactura.AllowUserToAddRows = false;
            this.dgv_buscarClienteFactura.AllowUserToDeleteRows = false;
            this.dgv_buscarClienteFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_buscarClienteFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscarClienteFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_codigoCliente,
            this.clm_nombreCliente,
            this.clm_Apellido,
            this.clm_Elegir});
            this.dgv_buscarClienteFactura.Location = new System.Drawing.Point(23, 94);
            this.dgv_buscarClienteFactura.Name = "dgv_buscarClienteFactura";
            this.dgv_buscarClienteFactura.ReadOnly = true;
            this.dgv_buscarClienteFactura.RowHeadersVisible = false;
            this.dgv_buscarClienteFactura.RowTemplate.Height = 24;
            this.dgv_buscarClienteFactura.Size = new System.Drawing.Size(589, 172);
            this.dgv_buscarClienteFactura.TabIndex = 0;
            this.dgv_buscarClienteFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_buscarClienteFactura_CellClick);
            // 
            // clm_codigoCliente
            // 
            this.clm_codigoCliente.HeaderText = "Codigo Cliente";
            this.clm_codigoCliente.Name = "clm_codigoCliente";
            this.clm_codigoCliente.ReadOnly = true;
            // 
            // clm_nombreCliente
            // 
            this.clm_nombreCliente.HeaderText = "Nombre";
            this.clm_nombreCliente.Name = "clm_nombreCliente";
            this.clm_nombreCliente.ReadOnly = true;
            // 
            // clm_Apellido
            // 
            this.clm_Apellido.HeaderText = "Apellido";
            this.clm_Apellido.Name = "clm_Apellido";
            this.clm_Apellido.ReadOnly = true;
            // 
            // clm_Elegir
            // 
            this.clm_Elegir.HeaderText = "Elegir";
            this.clm_Elegir.Name = "clm_Elegir";
            this.clm_Elegir.ReadOnly = true;
            this.clm_Elegir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_Elegir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pd_imprimirTicket
            // 
            this.pd_imprimirTicket.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_imprimirTicket_PrintPage);
            // 
            // FinalizarCrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 472);
            this.Controls.Add(this.pnl_facturaElegirCliente);
            this.Controls.Add(this.btn_crearFacturaCliente);
            this.Controls.Add(this.btn_crearFacturaInvitado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalizarCrearFactura";
            this.Text = "FinalizarCrearFactura";
            this.Load += new System.EventHandler(this.FinalizarCrearFactura_Load);
            this.pnl_facturaElegirCliente.ResumeLayout(false);
            this.pnl_facturaElegirCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscarClienteFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crearFacturaInvitado;
        private System.Windows.Forms.Button btn_crearFacturaCliente;
        private System.Windows.Forms.Panel pnl_facturaElegirCliente;
        private System.Windows.Forms.DataGridView dgv_buscarClienteFactura;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.TextBox txb_nombreCliente;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Apellido;
        private System.Windows.Forms.DataGridViewButtonColumn clm_Elegir;
        private System.Windows.Forms.Label lbl_medioPago;
        private System.Windows.Forms.ComboBox cmb_medioPago;
        private System.Drawing.Printing.PrintDocument pd_imprimirTicket;
    }
}