namespace Kiosk
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_kioskMain = new System.Windows.Forms.TabControl();
            this.tb_facturacion = new System.Windows.Forms.TabPage();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.dgv_FacturaFinal = new System.Windows.Forms.DataGridView();
            this.clm_codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_facturacionAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_codigoProducto = new System.Windows.Forms.Label();
            this.txb_codigoProducto = new System.Windows.Forms.TextBox();
            this.tb_clientes = new System.Windows.Forms.TabPage();
            this.lbl_buscarNombre = new System.Windows.Forms.Label();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.txb_nombreClienteBuscar = new System.Windows.Forms.TextBox();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.cm_codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_dniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_editarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_productos = new System.Windows.Forms.TabPage();
            this.lbl_buscarProducto = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.cm_codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_categoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_costoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_seVendePorPesoProducto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clm_stockProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_editarProductosAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_exportarListaProductos = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.txb_tituloProductosBuscar = new System.Windows.Forms.TextBox();
            this.btn_nuevoProducto = new System.Windows.Forms.Button();
            this.tb_totalVentas = new System.Windows.Forms.TabPage();
            this.lbl_filtrarNumeroFactura = new System.Windows.Forms.Label();
            this.lbl_filtrarFacturaNombreCliente = new System.Windows.Forms.Label();
            this.lbl_fechaFacturaHasta = new System.Windows.Forms.Label();
            this.lbl_fechaFacturaDesde = new System.Windows.Forms.Label();
            this.btn_quitarFiltrosFacturas = new System.Windows.Forms.Button();
            this.btn_filtrarFacturas = new System.Windows.Forms.Button();
            this.txb_numeroFactura = new System.Windows.Forms.TextBox();
            this.txb_nombreCliente = new System.Windows.Forms.TextBox();
            this.txb_fechaFacturaHasta = new System.Windows.Forms.TextBox();
            this.dgv_Facturas = new System.Windows.Forms.DataGridView();
            this.txb_fechaFacturaDesde = new System.Windows.Forms.TextBox();
            this.tb_mercadoPago = new System.Windows.Forms.TabPage();
            this.lbl_totalGestionMercadoPago = new System.Windows.Forms.Label();
            this.btn_limpiarFiltros = new System.Windows.Forms.Button();
            this.btn_filtrarMercadoPago = new System.Windows.Forms.Button();
            this.chbx_pendientes = new System.Windows.Forms.CheckBox();
            this.txb_fechaHastaMP = new System.Windows.Forms.TextBox();
            this.lbl_fechaHastaMP = new System.Windows.Forms.Label();
            this.txb_fechaDesdeMP = new System.Windows.Forms.TextBox();
            this.lbl_fechaDesdeMP = new System.Windows.Forms.Label();
            this.dgv_ventasMercadoPagoGeneral = new System.Windows.Forms.DataGridView();
            this.clm_fechaMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_codFacturaMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_codigoClienteMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_nombreClienteMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_montoFacturaMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_numOperacionMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_rendirMP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_cierreDeCaja = new System.Windows.Forms.TabPage();
            this.btn_cerrarCaja = new System.Windows.Forms.Button();
            this.lbl_resultadoCierreCaja = new System.Windows.Forms.Label();
            this.lbl_operacionesCierredeCaja = new System.Windows.Forms.Label();
            this.txb_totalMercadoPago = new System.Windows.Forms.TextBox();
            this.lbl_totalMercadoPago = new System.Windows.Forms.Label();
            this.lbl_totalEfectivo = new System.Windows.Forms.Label();
            this.txb_totalEfectivo = new System.Windows.Forms.TextBox();
            this.dgv_totalVentas = new System.Windows.Forms.DataGridView();
            this.cm_cierreCajaNumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_codigoClienteCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_nombreClienteCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_medioPagoCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_montoParcialCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_comprobantesTesoreria = new System.Windows.Forms.TabPage();
            this.pnl_nuevoComprobante = new System.Windows.Forms.Panel();
            this.btn_cancelarCrearComprobante = new System.Windows.Forms.Button();
            this.btn_crearComprobanteTesoreria = new System.Windows.Forms.Button();
            this.lbl_montoComprobanteTesoreria = new System.Windows.Forms.Label();
            this.txb_montoComprobanteTesoreria = new System.Windows.Forms.TextBox();
            this.cbx_MedioPagoNuevoComprobanteTesoreria = new System.Windows.Forms.ComboBox();
            this.rb_IngresoDinero = new System.Windows.Forms.RadioButton();
            this.rb_egresoDinero = new System.Windows.Forms.RadioButton();
            this.btn_nuevoComprobanteTesoreria = new System.Windows.Forms.Button();
            this.pd_imprimirCierre = new System.Drawing.Printing.PrintDocument();
            this.clm_fechaComprobanteVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_codigoFacturaVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_codigoClienteVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_nombreClienteFacturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_medioDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_numeroOperacionMPVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_fechaRendicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_montoFinalFacturaVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_kioskMain.SuspendLayout();
            this.tb_facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FacturaFinal)).BeginInit();
            this.tb_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.tb_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.tb_totalVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).BeginInit();
            this.tb_mercadoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventasMercadoPagoGeneral)).BeginInit();
            this.tb_cierreDeCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_totalVentas)).BeginInit();
            this.tb_comprobantesTesoreria.SuspendLayout();
            this.pnl_nuevoComprobante.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_kioskMain
            // 
            this.tb_kioskMain.Controls.Add(this.tb_facturacion);
            this.tb_kioskMain.Controls.Add(this.tb_clientes);
            this.tb_kioskMain.Controls.Add(this.tb_productos);
            this.tb_kioskMain.Controls.Add(this.tb_totalVentas);
            this.tb_kioskMain.Controls.Add(this.tb_mercadoPago);
            this.tb_kioskMain.Controls.Add(this.tb_cierreDeCaja);
            this.tb_kioskMain.Controls.Add(this.tb_comprobantesTesoreria);
            this.tb_kioskMain.Location = new System.Drawing.Point(12, 13);
            this.tb_kioskMain.Name = "tb_kioskMain";
            this.tb_kioskMain.SelectedIndex = 0;
            this.tb_kioskMain.Size = new System.Drawing.Size(1025, 569);
            this.tb_kioskMain.TabIndex = 0;
            this.tb_kioskMain.SelectedIndexChanged += new System.EventHandler(this.tb_kioskMain_SelectedIndexChanged);
            // 
            // tb_facturacion
            // 
            this.tb_facturacion.Controls.Add(this.lbl_Total);
            this.tb_facturacion.Controls.Add(this.btn_Cancelar);
            this.tb_facturacion.Controls.Add(this.btn_Cobrar);
            this.tb_facturacion.Controls.Add(this.dgv_FacturaFinal);
            this.tb_facturacion.Controls.Add(this.btn_buscar);
            this.tb_facturacion.Controls.Add(this.lbl_codigoProducto);
            this.tb_facturacion.Controls.Add(this.txb_codigoProducto);
            this.tb_facturacion.Location = new System.Drawing.Point(4, 25);
            this.tb_facturacion.Name = "tb_facturacion";
            this.tb_facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tb_facturacion.Size = new System.Drawing.Size(1017, 540);
            this.tb_facturacion.TabIndex = 0;
            this.tb_facturacion.Text = "Facturación";
            this.tb_facturacion.UseVisualStyleBackColor = true;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(18, 479);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(199, 36);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total: $00000";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(752, 482);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(115, 42);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.Location = new System.Drawing.Point(873, 482);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(115, 42);
            this.btn_Cobrar.TabIndex = 4;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.UseVisualStyleBackColor = true;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // dgv_FacturaFinal
            // 
            this.dgv_FacturaFinal.AllowUserToAddRows = false;
            this.dgv_FacturaFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FacturaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FacturaFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_codigoProducto,
            this.clm_nombreProducto,
            this.clm_stock,
            this.clm_precioUnitario,
            this.clm_Cantidad,
            this.clm_subTotal,
            this.clm_facturacionAcciones});
            this.dgv_FacturaFinal.Location = new System.Drawing.Point(26, 114);
            this.dgv_FacturaFinal.Name = "dgv_FacturaFinal";
            this.dgv_FacturaFinal.RowHeadersVisible = false;
            this.dgv_FacturaFinal.RowTemplate.Height = 24;
            this.dgv_FacturaFinal.Size = new System.Drawing.Size(964, 352);
            this.dgv_FacturaFinal.TabIndex = 3;
            this.dgv_FacturaFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacturaFinal_CellClick);
            this.dgv_FacturaFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacturaFinal_CellContentClick);
            this.dgv_FacturaFinal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FacturaFinal_CellEndEdit);
            this.dgv_FacturaFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_FacturaFinal_KeyDown);
            // 
            // clm_codigoProducto
            // 
            this.clm_codigoProducto.HeaderText = "Código";
            this.clm_codigoProducto.Name = "clm_codigoProducto";
            // 
            // clm_nombreProducto
            // 
            this.clm_nombreProducto.HeaderText = "Nombre de Producto";
            this.clm_nombreProducto.Name = "clm_nombreProducto";
            // 
            // clm_stock
            // 
            this.clm_stock.HeaderText = "Stock Disponible";
            this.clm_stock.Name = "clm_stock";
            this.clm_stock.ReadOnly = true;
            // 
            // clm_precioUnitario
            // 
            this.clm_precioUnitario.HeaderText = "Precio Unitario";
            this.clm_precioUnitario.Name = "clm_precioUnitario";
            // 
            // clm_Cantidad
            // 
            this.clm_Cantidad.HeaderText = "Cantidad";
            this.clm_Cantidad.Name = "clm_Cantidad";
            // 
            // clm_subTotal
            // 
            this.clm_subTotal.HeaderText = "Sub Total";
            this.clm_subTotal.Name = "clm_subTotal";
            // 
            // clm_facturacionAcciones
            // 
            this.clm_facturacionAcciones.HeaderText = "Acciones";
            this.clm_facturacionAcciones.Name = "clm_facturacionAcciones";
            this.clm_facturacionAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_facturacionAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clm_facturacionAcciones.Text = "";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(578, 35);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(128, 34);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar...";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_codigoProducto
            // 
            this.lbl_codigoProducto.AutoSize = true;
            this.lbl_codigoProducto.Location = new System.Drawing.Point(21, 21);
            this.lbl_codigoProducto.Name = "lbl_codigoProducto";
            this.lbl_codigoProducto.Size = new System.Drawing.Size(133, 17);
            this.lbl_codigoProducto.TabIndex = 1;
            this.lbl_codigoProducto.Text = "Código de Producto";
            // 
            // txb_codigoProducto
            // 
            this.txb_codigoProducto.Location = new System.Drawing.Point(24, 41);
            this.txb_codigoProducto.Name = "txb_codigoProducto";
            this.txb_codigoProducto.Size = new System.Drawing.Size(521, 22);
            this.txb_codigoProducto.TabIndex = 0;
            this.txb_codigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_codigoProducto_KeyDown);
            // 
            // tb_clientes
            // 
            this.tb_clientes.Controls.Add(this.lbl_buscarNombre);
            this.tb_clientes.Controls.Add(this.btn_buscarCliente);
            this.tb_clientes.Controls.Add(this.txb_nombreClienteBuscar);
            this.tb_clientes.Controls.Add(this.btn_exportar);
            this.tb_clientes.Controls.Add(this.btn_nuevoCliente);
            this.tb_clientes.Controls.Add(this.dgv_Clientes);
            this.tb_clientes.Location = new System.Drawing.Point(4, 25);
            this.tb_clientes.Name = "tb_clientes";
            this.tb_clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tb_clientes.Size = new System.Drawing.Size(1017, 540);
            this.tb_clientes.TabIndex = 1;
            this.tb_clientes.Text = "Clientes";
            this.tb_clientes.UseVisualStyleBackColor = true;
            // 
            // lbl_buscarNombre
            // 
            this.lbl_buscarNombre.AutoSize = true;
            this.lbl_buscarNombre.Location = new System.Drawing.Point(161, 15);
            this.lbl_buscarNombre.Name = "lbl_buscarNombre";
            this.lbl_buscarNombre.Size = new System.Drawing.Size(124, 17);
            this.lbl_buscarNombre.TabIndex = 5;
            this.lbl_buscarNombre.Text = "Nombre o Apellido";
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Location = new System.Drawing.Point(366, 15);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(112, 43);
            this.btn_buscarCliente.TabIndex = 4;
            this.btn_buscarCliente.Text = "Buscar";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // txb_nombreClienteBuscar
            // 
            this.txb_nombreClienteBuscar.Location = new System.Drawing.Point(164, 35);
            this.txb_nombreClienteBuscar.Name = "txb_nombreClienteBuscar";
            this.txb_nombreClienteBuscar.Size = new System.Drawing.Size(174, 22);
            this.txb_nombreClienteBuscar.TabIndex = 3;
            this.txb_nombreClienteBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_nombreClienteBuscar_KeyDown);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(885, 15);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(112, 43);
            this.btn_exportar.TabIndex = 2;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.Location = new System.Drawing.Point(15, 15);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(112, 43);
            this.btn_nuevoCliente.TabIndex = 1;
            this.btn_nuevoCliente.Text = "Nuevo Cliente";
            this.btn_nuevoCliente.UseVisualStyleBackColor = true;
            this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cm_codigoCliente,
            this.cm_nombreCliente,
            this.cm_apellidoCliente,
            this.cm_dniCliente,
            this.cm_telefonoCliente,
            this.cm_direccionCliente,
            this.cm_editarCliente});
            this.dgv_Clientes.Location = new System.Drawing.Point(15, 88);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.RowHeadersVisible = false;
            this.dgv_Clientes.RowTemplate.Height = 24;
            this.dgv_Clientes.Size = new System.Drawing.Size(982, 431);
            this.dgv_Clientes.TabIndex = 0;
            this.dgv_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clientes_CellClick);
            // 
            // cm_codigoCliente
            // 
            this.cm_codigoCliente.HeaderText = "Código Cliente";
            this.cm_codigoCliente.Name = "cm_codigoCliente";
            // 
            // cm_nombreCliente
            // 
            this.cm_nombreCliente.HeaderText = "Nombre Cliente";
            this.cm_nombreCliente.Name = "cm_nombreCliente";
            // 
            // cm_apellidoCliente
            // 
            this.cm_apellidoCliente.HeaderText = "Apellido";
            this.cm_apellidoCliente.Name = "cm_apellidoCliente";
            // 
            // cm_dniCliente
            // 
            this.cm_dniCliente.HeaderText = "DNI";
            this.cm_dniCliente.Name = "cm_dniCliente";
            // 
            // cm_telefonoCliente
            // 
            this.cm_telefonoCliente.HeaderText = "Teléfono";
            this.cm_telefonoCliente.Name = "cm_telefonoCliente";
            // 
            // cm_direccionCliente
            // 
            this.cm_direccionCliente.HeaderText = "Dirección";
            this.cm_direccionCliente.Name = "cm_direccionCliente";
            // 
            // cm_editarCliente
            // 
            this.cm_editarCliente.HeaderText = "Editar";
            this.cm_editarCliente.Name = "cm_editarCliente";
            this.cm_editarCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cm_editarCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tb_productos
            // 
            this.tb_productos.Controls.Add(this.lbl_buscarProducto);
            this.tb_productos.Controls.Add(this.dgv_Productos);
            this.tb_productos.Controls.Add(this.btn_exportarListaProductos);
            this.tb_productos.Controls.Add(this.btn_buscarProducto);
            this.tb_productos.Controls.Add(this.txb_tituloProductosBuscar);
            this.tb_productos.Controls.Add(this.btn_nuevoProducto);
            this.tb_productos.Location = new System.Drawing.Point(4, 25);
            this.tb_productos.Name = "tb_productos";
            this.tb_productos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_productos.Size = new System.Drawing.Size(1017, 540);
            this.tb_productos.TabIndex = 2;
            this.tb_productos.Text = "Productos";
            this.tb_productos.UseVisualStyleBackColor = true;
            // 
            // lbl_buscarProducto
            // 
            this.lbl_buscarProducto.AutoSize = true;
            this.lbl_buscarProducto.Location = new System.Drawing.Point(160, 10);
            this.lbl_buscarProducto.Name = "lbl_buscarProducto";
            this.lbl_buscarProducto.Size = new System.Drawing.Size(146, 17);
            this.lbl_buscarProducto.TabIndex = 5;
            this.lbl_buscarProducto.Text = "Nombre del Producto:";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AllowUserToAddRows = false;
            this.dgv_Productos.AllowUserToDeleteRows = false;
            this.dgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cm_codigoProducto,
            this.cm_nombreProducto,
            this.cm_categoriaProducto,
            this.cm_unidadMedida,
            this.cm_costoProducto,
            this.cm_precioProducto,
            this.cm_seVendePorPesoProducto,
            this.clm_stockProductos,
            this.clm_editarProductosAcciones});
            this.dgv_Productos.Location = new System.Drawing.Point(17, 86);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.RowHeadersVisible = false;
            this.dgv_Productos.RowTemplate.Height = 24;
            this.dgv_Productos.Size = new System.Drawing.Size(979, 435);
            this.dgv_Productos.TabIndex = 4;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // cm_codigoProducto
            // 
            this.cm_codigoProducto.HeaderText = "Código";
            this.cm_codigoProducto.Name = "cm_codigoProducto";
            this.cm_codigoProducto.ReadOnly = true;
            // 
            // cm_nombreProducto
            // 
            this.cm_nombreProducto.HeaderText = "Nombre";
            this.cm_nombreProducto.Name = "cm_nombreProducto";
            this.cm_nombreProducto.ReadOnly = true;
            // 
            // cm_categoriaProducto
            // 
            this.cm_categoriaProducto.HeaderText = "Categoría";
            this.cm_categoriaProducto.Name = "cm_categoriaProducto";
            this.cm_categoriaProducto.ReadOnly = true;
            // 
            // cm_unidadMedida
            // 
            this.cm_unidadMedida.HeaderText = "Unidad de Medida";
            this.cm_unidadMedida.Name = "cm_unidadMedida";
            this.cm_unidadMedida.ReadOnly = true;
            // 
            // cm_costoProducto
            // 
            this.cm_costoProducto.HeaderText = "Costo";
            this.cm_costoProducto.Name = "cm_costoProducto";
            this.cm_costoProducto.ReadOnly = true;
            // 
            // cm_precioProducto
            // 
            this.cm_precioProducto.HeaderText = "Precio";
            this.cm_precioProducto.Name = "cm_precioProducto";
            this.cm_precioProducto.ReadOnly = true;
            // 
            // cm_seVendePorPesoProducto
            // 
            this.cm_seVendePorPesoProducto.HeaderText = "Se Vende Por Peso";
            this.cm_seVendePorPesoProducto.Name = "cm_seVendePorPesoProducto";
            this.cm_seVendePorPesoProducto.ReadOnly = true;
            this.cm_seVendePorPesoProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cm_seVendePorPesoProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clm_stockProductos
            // 
            this.clm_stockProductos.HeaderText = "Stock";
            this.clm_stockProductos.Name = "clm_stockProductos";
            this.clm_stockProductos.ReadOnly = true;
            // 
            // clm_editarProductosAcciones
            // 
            this.clm_editarProductosAcciones.HeaderText = "Acciones";
            this.clm_editarProductosAcciones.Name = "clm_editarProductosAcciones";
            this.clm_editarProductosAcciones.ReadOnly = true;
            this.clm_editarProductosAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_editarProductosAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_exportarListaProductos
            // 
            this.btn_exportarListaProductos.Location = new System.Drawing.Point(899, 16);
            this.btn_exportarListaProductos.Name = "btn_exportarListaProductos";
            this.btn_exportarListaProductos.Size = new System.Drawing.Size(97, 39);
            this.btn_exportarListaProductos.TabIndex = 3;
            this.btn_exportarListaProductos.Text = "Exportar";
            this.btn_exportarListaProductos.UseVisualStyleBackColor = true;
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Location = new System.Drawing.Point(370, 16);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(97, 39);
            this.btn_buscarProducto.TabIndex = 2;
            this.btn_buscarProducto.Text = "Buscar";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // txb_tituloProductosBuscar
            // 
            this.txb_tituloProductosBuscar.Location = new System.Drawing.Point(160, 33);
            this.txb_tituloProductosBuscar.Name = "txb_tituloProductosBuscar";
            this.txb_tituloProductosBuscar.Size = new System.Drawing.Size(177, 22);
            this.txb_tituloProductosBuscar.TabIndex = 1;
            this.txb_tituloProductosBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_tituloProductosBuscar_KeyDown);
            // 
            // btn_nuevoProducto
            // 
            this.btn_nuevoProducto.Location = new System.Drawing.Point(17, 17);
            this.btn_nuevoProducto.Name = "btn_nuevoProducto";
            this.btn_nuevoProducto.Size = new System.Drawing.Size(97, 39);
            this.btn_nuevoProducto.TabIndex = 0;
            this.btn_nuevoProducto.Text = "Nuevo";
            this.btn_nuevoProducto.UseVisualStyleBackColor = true;
            this.btn_nuevoProducto.Click += new System.EventHandler(this.btn_nuevoProducto_Click);
            // 
            // tb_totalVentas
            // 
            this.tb_totalVentas.Controls.Add(this.lbl_filtrarNumeroFactura);
            this.tb_totalVentas.Controls.Add(this.lbl_filtrarFacturaNombreCliente);
            this.tb_totalVentas.Controls.Add(this.lbl_fechaFacturaHasta);
            this.tb_totalVentas.Controls.Add(this.lbl_fechaFacturaDesde);
            this.tb_totalVentas.Controls.Add(this.btn_quitarFiltrosFacturas);
            this.tb_totalVentas.Controls.Add(this.btn_filtrarFacturas);
            this.tb_totalVentas.Controls.Add(this.txb_numeroFactura);
            this.tb_totalVentas.Controls.Add(this.txb_nombreCliente);
            this.tb_totalVentas.Controls.Add(this.txb_fechaFacturaHasta);
            this.tb_totalVentas.Controls.Add(this.dgv_Facturas);
            this.tb_totalVentas.Controls.Add(this.txb_fechaFacturaDesde);
            this.tb_totalVentas.Location = new System.Drawing.Point(4, 25);
            this.tb_totalVentas.Name = "tb_totalVentas";
            this.tb_totalVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_totalVentas.Size = new System.Drawing.Size(1017, 540);
            this.tb_totalVentas.TabIndex = 3;
            this.tb_totalVentas.Text = "Ventas";
            this.tb_totalVentas.UseVisualStyleBackColor = true;
            // 
            // lbl_filtrarNumeroFactura
            // 
            this.lbl_filtrarNumeroFactura.AutoSize = true;
            this.lbl_filtrarNumeroFactura.Location = new System.Drawing.Point(186, 79);
            this.lbl_filtrarNumeroFactura.Name = "lbl_filtrarNumeroFactura";
            this.lbl_filtrarNumeroFactura.Size = new System.Drawing.Size(123, 17);
            this.lbl_filtrarNumeroFactura.TabIndex = 10;
            this.lbl_filtrarNumeroFactura.Text = "Numero de Venta:";
            // 
            // lbl_filtrarFacturaNombreCliente
            // 
            this.lbl_filtrarFacturaNombreCliente.AutoSize = true;
            this.lbl_filtrarFacturaNombreCliente.Location = new System.Drawing.Point(186, 25);
            this.lbl_filtrarFacturaNombreCliente.Name = "lbl_filtrarFacturaNombreCliente";
            this.lbl_filtrarFacturaNombreCliente.Size = new System.Drawing.Size(129, 17);
            this.lbl_filtrarFacturaNombreCliente.TabIndex = 9;
            this.lbl_filtrarFacturaNombreCliente.Text = "Nombre de Cliente:";
            // 
            // lbl_fechaFacturaHasta
            // 
            this.lbl_fechaFacturaHasta.AutoSize = true;
            this.lbl_fechaFacturaHasta.Location = new System.Drawing.Point(22, 79);
            this.lbl_fechaFacturaHasta.Name = "lbl_fechaFacturaHasta";
            this.lbl_fechaFacturaHasta.Size = new System.Drawing.Size(92, 17);
            this.lbl_fechaFacturaHasta.TabIndex = 8;
            this.lbl_fechaFacturaHasta.Text = "Fecha Hasta:";
            // 
            // lbl_fechaFacturaDesde
            // 
            this.lbl_fechaFacturaDesde.AutoSize = true;
            this.lbl_fechaFacturaDesde.Location = new System.Drawing.Point(20, 25);
            this.lbl_fechaFacturaDesde.Name = "lbl_fechaFacturaDesde";
            this.lbl_fechaFacturaDesde.Size = new System.Drawing.Size(94, 17);
            this.lbl_fechaFacturaDesde.TabIndex = 7;
            this.lbl_fechaFacturaDesde.Text = "Fecha desde:";
            // 
            // btn_quitarFiltrosFacturas
            // 
            this.btn_quitarFiltrosFacturas.Location = new System.Drawing.Point(703, 25);
            this.btn_quitarFiltrosFacturas.Name = "btn_quitarFiltrosFacturas";
            this.btn_quitarFiltrosFacturas.Size = new System.Drawing.Size(167, 96);
            this.btn_quitarFiltrosFacturas.TabIndex = 6;
            this.btn_quitarFiltrosFacturas.Text = "Limpiar Filtros";
            this.btn_quitarFiltrosFacturas.UseVisualStyleBackColor = true;
            this.btn_quitarFiltrosFacturas.Click += new System.EventHandler(this.btn_quitarFiltrosFacturas_Click);
            // 
            // btn_filtrarFacturas
            // 
            this.btn_filtrarFacturas.Location = new System.Drawing.Point(489, 25);
            this.btn_filtrarFacturas.Name = "btn_filtrarFacturas";
            this.btn_filtrarFacturas.Size = new System.Drawing.Size(183, 96);
            this.btn_filtrarFacturas.TabIndex = 5;
            this.btn_filtrarFacturas.Text = "Filtrar";
            this.btn_filtrarFacturas.UseVisualStyleBackColor = true;
            this.btn_filtrarFacturas.Click += new System.EventHandler(this.btn_filtrarFacturas_Click);
            // 
            // txb_numeroFactura
            // 
            this.txb_numeroFactura.Location = new System.Drawing.Point(186, 99);
            this.txb_numeroFactura.Name = "txb_numeroFactura";
            this.txb_numeroFactura.Size = new System.Drawing.Size(250, 22);
            this.txb_numeroFactura.TabIndex = 4;
            // 
            // txb_nombreCliente
            // 
            this.txb_nombreCliente.Location = new System.Drawing.Point(186, 45);
            this.txb_nombreCliente.Name = "txb_nombreCliente";
            this.txb_nombreCliente.Size = new System.Drawing.Size(250, 22);
            this.txb_nombreCliente.TabIndex = 3;
            // 
            // txb_fechaFacturaHasta
            // 
            this.txb_fechaFacturaHasta.Location = new System.Drawing.Point(23, 99);
            this.txb_fechaFacturaHasta.Name = "txb_fechaFacturaHasta";
            this.txb_fechaFacturaHasta.Size = new System.Drawing.Size(100, 22);
            this.txb_fechaFacturaHasta.TabIndex = 2;
            this.txb_fechaFacturaHasta.Text = "25/05/2010";
            // 
            // dgv_Facturas
            // 
            this.dgv_Facturas.AllowUserToAddRows = false;
            this.dgv_Facturas.AllowUserToDeleteRows = false;
            this.dgv_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_fechaComprobanteVentas,
            this.cm_codigoFacturaVentas,
            this.cm_codigoClienteVentas,
            this.clm_nombreClienteFacturas,
            this.cm_medioDePago,
            this.cm_numeroOperacionMPVentas,
            this.cm_fechaRendicion,
            this.clm_montoFinalFacturaVer});
            this.dgv_Facturas.Location = new System.Drawing.Point(23, 139);
            this.dgv_Facturas.Name = "dgv_Facturas";
            this.dgv_Facturas.ReadOnly = true;
            this.dgv_Facturas.RowHeadersVisible = false;
            this.dgv_Facturas.RowTemplate.Height = 24;
            this.dgv_Facturas.Size = new System.Drawing.Size(970, 380);
            this.dgv_Facturas.TabIndex = 1;
            // 
            // txb_fechaFacturaDesde
            // 
            this.txb_fechaFacturaDesde.Location = new System.Drawing.Point(23, 45);
            this.txb_fechaFacturaDesde.Name = "txb_fechaFacturaDesde";
            this.txb_fechaFacturaDesde.Size = new System.Drawing.Size(100, 22);
            this.txb_fechaFacturaDesde.TabIndex = 0;
            this.txb_fechaFacturaDesde.Text = "25/05/2010";
            // 
            // tb_mercadoPago
            // 
            this.tb_mercadoPago.Controls.Add(this.lbl_totalGestionMercadoPago);
            this.tb_mercadoPago.Controls.Add(this.btn_limpiarFiltros);
            this.tb_mercadoPago.Controls.Add(this.btn_filtrarMercadoPago);
            this.tb_mercadoPago.Controls.Add(this.chbx_pendientes);
            this.tb_mercadoPago.Controls.Add(this.txb_fechaHastaMP);
            this.tb_mercadoPago.Controls.Add(this.lbl_fechaHastaMP);
            this.tb_mercadoPago.Controls.Add(this.txb_fechaDesdeMP);
            this.tb_mercadoPago.Controls.Add(this.lbl_fechaDesdeMP);
            this.tb_mercadoPago.Controls.Add(this.dgv_ventasMercadoPagoGeneral);
            this.tb_mercadoPago.Location = new System.Drawing.Point(4, 25);
            this.tb_mercadoPago.Name = "tb_mercadoPago";
            this.tb_mercadoPago.Padding = new System.Windows.Forms.Padding(3);
            this.tb_mercadoPago.Size = new System.Drawing.Size(1017, 540);
            this.tb_mercadoPago.TabIndex = 4;
            this.tb_mercadoPago.Text = "Gestión Mercado Pago";
            this.tb_mercadoPago.UseVisualStyleBackColor = true;
            // 
            // lbl_totalGestionMercadoPago
            // 
            this.lbl_totalGestionMercadoPago.AutoSize = true;
            this.lbl_totalGestionMercadoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalGestionMercadoPago.Location = new System.Drawing.Point(16, 484);
            this.lbl_totalGestionMercadoPago.Name = "lbl_totalGestionMercadoPago";
            this.lbl_totalGestionMercadoPago.Size = new System.Drawing.Size(199, 36);
            this.lbl_totalGestionMercadoPago.TabIndex = 16;
            this.lbl_totalGestionMercadoPago.Text = "Total: $00000";
            // 
            // btn_limpiarFiltros
            // 
            this.btn_limpiarFiltros.Location = new System.Drawing.Point(447, 41);
            this.btn_limpiarFiltros.Name = "btn_limpiarFiltros";
            this.btn_limpiarFiltros.Size = new System.Drawing.Size(160, 67);
            this.btn_limpiarFiltros.TabIndex = 14;
            this.btn_limpiarFiltros.Text = "Limpiar Filtros";
            this.btn_limpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // btn_filtrarMercadoPago
            // 
            this.btn_filtrarMercadoPago.Location = new System.Drawing.Point(281, 41);
            this.btn_filtrarMercadoPago.Name = "btn_filtrarMercadoPago";
            this.btn_filtrarMercadoPago.Size = new System.Drawing.Size(160, 67);
            this.btn_filtrarMercadoPago.TabIndex = 13;
            this.btn_filtrarMercadoPago.Text = "Filtrar";
            this.btn_filtrarMercadoPago.UseVisualStyleBackColor = true;
            // 
            // chbx_pendientes
            // 
            this.chbx_pendientes.AutoSize = true;
            this.chbx_pendientes.Location = new System.Drawing.Point(164, 41);
            this.chbx_pendientes.Name = "chbx_pendientes";
            this.chbx_pendientes.Size = new System.Drawing.Size(101, 21);
            this.chbx_pendientes.TabIndex = 12;
            this.chbx_pendientes.Text = "Pendientes";
            this.chbx_pendientes.UseVisualStyleBackColor = true;
            // 
            // txb_fechaHastaMP
            // 
            this.txb_fechaHastaMP.Location = new System.Drawing.Point(22, 86);
            this.txb_fechaHastaMP.Name = "txb_fechaHastaMP";
            this.txb_fechaHastaMP.Size = new System.Drawing.Size(100, 22);
            this.txb_fechaHastaMP.TabIndex = 11;
            this.txb_fechaHastaMP.Text = "25/05/2010";
            // 
            // lbl_fechaHastaMP
            // 
            this.lbl_fechaHastaMP.AutoSize = true;
            this.lbl_fechaHastaMP.Location = new System.Drawing.Point(19, 66);
            this.lbl_fechaHastaMP.Name = "lbl_fechaHastaMP";
            this.lbl_fechaHastaMP.Size = new System.Drawing.Size(92, 17);
            this.lbl_fechaHastaMP.TabIndex = 10;
            this.lbl_fechaHastaMP.Text = "Fecha Hasta:";
            // 
            // txb_fechaDesdeMP
            // 
            this.txb_fechaDesdeMP.Location = new System.Drawing.Point(22, 41);
            this.txb_fechaDesdeMP.Name = "txb_fechaDesdeMP";
            this.txb_fechaDesdeMP.Size = new System.Drawing.Size(100, 22);
            this.txb_fechaDesdeMP.TabIndex = 9;
            this.txb_fechaDesdeMP.Text = "25/05/2010";
            // 
            // lbl_fechaDesdeMP
            // 
            this.lbl_fechaDesdeMP.AutoSize = true;
            this.lbl_fechaDesdeMP.Location = new System.Drawing.Point(19, 21);
            this.lbl_fechaDesdeMP.Name = "lbl_fechaDesdeMP";
            this.lbl_fechaDesdeMP.Size = new System.Drawing.Size(94, 17);
            this.lbl_fechaDesdeMP.TabIndex = 8;
            this.lbl_fechaDesdeMP.Text = "Fecha desde:";
            // 
            // dgv_ventasMercadoPagoGeneral
            // 
            this.dgv_ventasMercadoPagoGeneral.AllowUserToAddRows = false;
            this.dgv_ventasMercadoPagoGeneral.AllowUserToDeleteRows = false;
            this.dgv_ventasMercadoPagoGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ventasMercadoPagoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventasMercadoPagoGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_fechaMP,
            this.cm_codFacturaMP,
            this.cm_codigoClienteMP,
            this.cm_nombreClienteMP,
            this.cm_montoFacturaMP,
            this.clm_numOperacionMP,
            this.clm_rendirMP});
            this.dgv_ventasMercadoPagoGeneral.Location = new System.Drawing.Point(22, 135);
            this.dgv_ventasMercadoPagoGeneral.Name = "dgv_ventasMercadoPagoGeneral";
            this.dgv_ventasMercadoPagoGeneral.ReadOnly = true;
            this.dgv_ventasMercadoPagoGeneral.RowHeadersVisible = false;
            this.dgv_ventasMercadoPagoGeneral.RowTemplate.Height = 24;
            this.dgv_ventasMercadoPagoGeneral.Size = new System.Drawing.Size(976, 316);
            this.dgv_ventasMercadoPagoGeneral.TabIndex = 0;
            this.dgv_ventasMercadoPagoGeneral.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventasMercadoPagoGeneral_CellClick);
            // 
            // clm_fechaMP
            // 
            this.clm_fechaMP.HeaderText = "Fecha";
            this.clm_fechaMP.Name = "clm_fechaMP";
            this.clm_fechaMP.ReadOnly = true;
            // 
            // cm_codFacturaMP
            // 
            this.cm_codFacturaMP.HeaderText = "Código";
            this.cm_codFacturaMP.Name = "cm_codFacturaMP";
            this.cm_codFacturaMP.ReadOnly = true;
            // 
            // cm_codigoClienteMP
            // 
            this.cm_codigoClienteMP.HeaderText = "Código Cliente";
            this.cm_codigoClienteMP.Name = "cm_codigoClienteMP";
            this.cm_codigoClienteMP.ReadOnly = true;
            // 
            // cm_nombreClienteMP
            // 
            this.cm_nombreClienteMP.HeaderText = "Nombre Cliente";
            this.cm_nombreClienteMP.Name = "cm_nombreClienteMP";
            this.cm_nombreClienteMP.ReadOnly = true;
            // 
            // cm_montoFacturaMP
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cm_montoFacturaMP.DefaultCellStyle = dataGridViewCellStyle3;
            this.cm_montoFacturaMP.HeaderText = "Monto Total";
            this.cm_montoFacturaMP.Name = "cm_montoFacturaMP";
            this.cm_montoFacturaMP.ReadOnly = true;
            // 
            // clm_numOperacionMP
            // 
            this.clm_numOperacionMP.HeaderText = "Numero Operacion MP";
            this.clm_numOperacionMP.Name = "clm_numOperacionMP";
            this.clm_numOperacionMP.ReadOnly = true;
            // 
            // clm_rendirMP
            // 
            this.clm_rendirMP.HeaderText = "Rendir Mercado Pago";
            this.clm_rendirMP.Name = "clm_rendirMP";
            this.clm_rendirMP.ReadOnly = true;
            this.clm_rendirMP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_rendirMP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tb_cierreDeCaja
            // 
            this.tb_cierreDeCaja.Controls.Add(this.btn_cerrarCaja);
            this.tb_cierreDeCaja.Controls.Add(this.lbl_resultadoCierreCaja);
            this.tb_cierreDeCaja.Controls.Add(this.lbl_operacionesCierredeCaja);
            this.tb_cierreDeCaja.Controls.Add(this.txb_totalMercadoPago);
            this.tb_cierreDeCaja.Controls.Add(this.lbl_totalMercadoPago);
            this.tb_cierreDeCaja.Controls.Add(this.lbl_totalEfectivo);
            this.tb_cierreDeCaja.Controls.Add(this.txb_totalEfectivo);
            this.tb_cierreDeCaja.Controls.Add(this.dgv_totalVentas);
            this.tb_cierreDeCaja.Location = new System.Drawing.Point(4, 25);
            this.tb_cierreDeCaja.Name = "tb_cierreDeCaja";
            this.tb_cierreDeCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tb_cierreDeCaja.Size = new System.Drawing.Size(1017, 540);
            this.tb_cierreDeCaja.TabIndex = 6;
            this.tb_cierreDeCaja.Text = "Cierre de Caja";
            this.tb_cierreDeCaja.UseVisualStyleBackColor = true;
            // 
            // btn_cerrarCaja
            // 
            this.btn_cerrarCaja.Location = new System.Drawing.Point(572, 238);
            this.btn_cerrarCaja.Name = "btn_cerrarCaja";
            this.btn_cerrarCaja.Size = new System.Drawing.Size(186, 65);
            this.btn_cerrarCaja.TabIndex = 10;
            this.btn_cerrarCaja.Text = "Cerrar Caja";
            this.btn_cerrarCaja.UseVisualStyleBackColor = true;
            this.btn_cerrarCaja.Click += new System.EventHandler(this.btn_cerrarCaja_Click);
            // 
            // lbl_resultadoCierreCaja
            // 
            this.lbl_resultadoCierreCaja.AutoSize = true;
            this.lbl_resultadoCierreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadoCierreCaja.Location = new System.Drawing.Point(567, 191);
            this.lbl_resultadoCierreCaja.Name = "lbl_resultadoCierreCaja";
            this.lbl_resultadoCierreCaja.Size = new System.Drawing.Size(215, 29);
            this.lbl_resultadoCierreCaja.TabIndex = 9;
            this.lbl_resultadoCierreCaja.Text = "Resultado: $0000";
            // 
            // lbl_operacionesCierredeCaja
            // 
            this.lbl_operacionesCierredeCaja.AutoSize = true;
            this.lbl_operacionesCierredeCaja.Location = new System.Drawing.Point(39, 49);
            this.lbl_operacionesCierredeCaja.Name = "lbl_operacionesCierredeCaja";
            this.lbl_operacionesCierredeCaja.Size = new System.Drawing.Size(104, 17);
            this.lbl_operacionesCierredeCaja.TabIndex = 8;
            this.lbl_operacionesCierredeCaja.Text = "Comprobantes:";
            // 
            // txb_totalMercadoPago
            // 
            this.txb_totalMercadoPago.Location = new System.Drawing.Point(572, 157);
            this.txb_totalMercadoPago.Name = "txb_totalMercadoPago";
            this.txb_totalMercadoPago.Size = new System.Drawing.Size(186, 22);
            this.txb_totalMercadoPago.TabIndex = 6;
            // 
            // lbl_totalMercadoPago
            // 
            this.lbl_totalMercadoPago.AutoSize = true;
            this.lbl_totalMercadoPago.Location = new System.Drawing.Point(569, 137);
            this.lbl_totalMercadoPago.Name = "lbl_totalMercadoPago";
            this.lbl_totalMercadoPago.Size = new System.Drawing.Size(140, 17);
            this.lbl_totalMercadoPago.TabIndex = 5;
            this.lbl_totalMercadoPago.Text = "Total Mercado Pago:";
            // 
            // lbl_totalEfectivo
            // 
            this.lbl_totalEfectivo.AutoSize = true;
            this.lbl_totalEfectivo.Location = new System.Drawing.Point(569, 80);
            this.lbl_totalEfectivo.Name = "lbl_totalEfectivo";
            this.lbl_totalEfectivo.Size = new System.Drawing.Size(98, 17);
            this.lbl_totalEfectivo.TabIndex = 3;
            this.lbl_totalEfectivo.Text = "Total Efectivo:";
            // 
            // txb_totalEfectivo
            // 
            this.txb_totalEfectivo.Location = new System.Drawing.Point(572, 105);
            this.txb_totalEfectivo.Name = "txb_totalEfectivo";
            this.txb_totalEfectivo.Size = new System.Drawing.Size(186, 22);
            this.txb_totalEfectivo.TabIndex = 2;
            // 
            // dgv_totalVentas
            // 
            this.dgv_totalVentas.AllowUserToAddRows = false;
            this.dgv_totalVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_totalVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_totalVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cm_cierreCajaNumFactura,
            this.cm_codigoClienteCierreCaja,
            this.cm_nombreClienteCierreCaja,
            this.clm_medioPagoCierreCaja,
            this.cm_montoParcialCierreCaja});
            this.dgv_totalVentas.Location = new System.Drawing.Point(39, 80);
            this.dgv_totalVentas.Name = "dgv_totalVentas";
            this.dgv_totalVentas.RowHeadersVisible = false;
            this.dgv_totalVentas.RowTemplate.Height = 24;
            this.dgv_totalVentas.Size = new System.Drawing.Size(509, 401);
            this.dgv_totalVentas.TabIndex = 1;
            // 
            // cm_cierreCajaNumFactura
            // 
            this.cm_cierreCajaNumFactura.HeaderText = "Codigo Comprobante";
            this.cm_cierreCajaNumFactura.Name = "cm_cierreCajaNumFactura";
            this.cm_cierreCajaNumFactura.ReadOnly = true;
            // 
            // cm_codigoClienteCierreCaja
            // 
            this.cm_codigoClienteCierreCaja.HeaderText = "Código de Cliente";
            this.cm_codigoClienteCierreCaja.Name = "cm_codigoClienteCierreCaja";
            this.cm_codigoClienteCierreCaja.ReadOnly = true;
            // 
            // cm_nombreClienteCierreCaja
            // 
            this.cm_nombreClienteCierreCaja.HeaderText = "Nombre Cliente";
            this.cm_nombreClienteCierreCaja.Name = "cm_nombreClienteCierreCaja";
            this.cm_nombreClienteCierreCaja.ReadOnly = true;
            // 
            // clm_medioPagoCierreCaja
            // 
            this.clm_medioPagoCierreCaja.HeaderText = "Medio de Pago";
            this.clm_medioPagoCierreCaja.Name = "clm_medioPagoCierreCaja";
            this.clm_medioPagoCierreCaja.ReadOnly = true;
            // 
            // cm_montoParcialCierreCaja
            // 
            this.cm_montoParcialCierreCaja.HeaderText = "Monto";
            this.cm_montoParcialCierreCaja.Name = "cm_montoParcialCierreCaja";
            this.cm_montoParcialCierreCaja.ReadOnly = true;
            // 
            // tb_comprobantesTesoreria
            // 
            this.tb_comprobantesTesoreria.Controls.Add(this.pnl_nuevoComprobante);
            this.tb_comprobantesTesoreria.Controls.Add(this.btn_nuevoComprobanteTesoreria);
            this.tb_comprobantesTesoreria.Location = new System.Drawing.Point(4, 25);
            this.tb_comprobantesTesoreria.Name = "tb_comprobantesTesoreria";
            this.tb_comprobantesTesoreria.Padding = new System.Windows.Forms.Padding(3);
            this.tb_comprobantesTesoreria.Size = new System.Drawing.Size(1017, 540);
            this.tb_comprobantesTesoreria.TabIndex = 7;
            this.tb_comprobantesTesoreria.Text = "Comprobantes de Tesorería";
            this.tb_comprobantesTesoreria.UseVisualStyleBackColor = true;
            // 
            // pnl_nuevoComprobante
            // 
            this.pnl_nuevoComprobante.Controls.Add(this.btn_cancelarCrearComprobante);
            this.pnl_nuevoComprobante.Controls.Add(this.btn_crearComprobanteTesoreria);
            this.pnl_nuevoComprobante.Controls.Add(this.lbl_montoComprobanteTesoreria);
            this.pnl_nuevoComprobante.Controls.Add(this.txb_montoComprobanteTesoreria);
            this.pnl_nuevoComprobante.Controls.Add(this.cbx_MedioPagoNuevoComprobanteTesoreria);
            this.pnl_nuevoComprobante.Controls.Add(this.rb_IngresoDinero);
            this.pnl_nuevoComprobante.Controls.Add(this.rb_egresoDinero);
            this.pnl_nuevoComprobante.Location = new System.Drawing.Point(25, 136);
            this.pnl_nuevoComprobante.Name = "pnl_nuevoComprobante";
            this.pnl_nuevoComprobante.Size = new System.Drawing.Size(422, 278);
            this.pnl_nuevoComprobante.TabIndex = 3;
            this.pnl_nuevoComprobante.Visible = false;
            // 
            // btn_cancelarCrearComprobante
            // 
            this.btn_cancelarCrearComprobante.Location = new System.Drawing.Point(234, 152);
            this.btn_cancelarCrearComprobante.Name = "btn_cancelarCrearComprobante";
            this.btn_cancelarCrearComprobante.Size = new System.Drawing.Size(162, 110);
            this.btn_cancelarCrearComprobante.TabIndex = 9;
            this.btn_cancelarCrearComprobante.Text = "Cancelar";
            this.btn_cancelarCrearComprobante.UseVisualStyleBackColor = true;
            this.btn_cancelarCrearComprobante.Click += new System.EventHandler(this.btn_cancelarCrearComprobante_Click);
            // 
            // btn_crearComprobanteTesoreria
            // 
            this.btn_crearComprobanteTesoreria.Location = new System.Drawing.Point(22, 152);
            this.btn_crearComprobanteTesoreria.Name = "btn_crearComprobanteTesoreria";
            this.btn_crearComprobanteTesoreria.Size = new System.Drawing.Size(162, 110);
            this.btn_crearComprobanteTesoreria.TabIndex = 8;
            this.btn_crearComprobanteTesoreria.Text = "Crear Comprobante";
            this.btn_crearComprobanteTesoreria.UseVisualStyleBackColor = true;
            this.btn_crearComprobanteTesoreria.Click += new System.EventHandler(this.btn_crearComprobanteTesoreria_Click);
            // 
            // lbl_montoComprobanteTesoreria
            // 
            this.lbl_montoComprobanteTesoreria.AutoSize = true;
            this.lbl_montoComprobanteTesoreria.Location = new System.Drawing.Point(20, 89);
            this.lbl_montoComprobanteTesoreria.Name = "lbl_montoComprobanteTesoreria";
            this.lbl_montoComprobanteTesoreria.Size = new System.Drawing.Size(47, 17);
            this.lbl_montoComprobanteTesoreria.TabIndex = 5;
            this.lbl_montoComprobanteTesoreria.Text = "Monto";
            // 
            // txb_montoComprobanteTesoreria
            // 
            this.txb_montoComprobanteTesoreria.Location = new System.Drawing.Point(23, 109);
            this.txb_montoComprobanteTesoreria.Name = "txb_montoComprobanteTesoreria";
            this.txb_montoComprobanteTesoreria.Size = new System.Drawing.Size(100, 22);
            this.txb_montoComprobanteTesoreria.TabIndex = 4;
            // 
            // cbx_MedioPagoNuevoComprobanteTesoreria
            // 
            this.cbx_MedioPagoNuevoComprobanteTesoreria.FormattingEnabled = true;
            this.cbx_MedioPagoNuevoComprobanteTesoreria.Location = new System.Drawing.Point(204, 29);
            this.cbx_MedioPagoNuevoComprobanteTesoreria.Name = "cbx_MedioPagoNuevoComprobanteTesoreria";
            this.cbx_MedioPagoNuevoComprobanteTesoreria.Size = new System.Drawing.Size(121, 24);
            this.cbx_MedioPagoNuevoComprobanteTesoreria.TabIndex = 3;
            this.cbx_MedioPagoNuevoComprobanteTesoreria.SelectedIndexChanged += new System.EventHandler(this.cbx_MedioPagoNuevoComprobanteTesoreria_SelectedIndexChanged);
            // 
            // rb_IngresoDinero
            // 
            this.rb_IngresoDinero.AutoSize = true;
            this.rb_IngresoDinero.Location = new System.Drawing.Point(23, 18);
            this.rb_IngresoDinero.Name = "rb_IngresoDinero";
            this.rb_IngresoDinero.Size = new System.Drawing.Size(122, 21);
            this.rb_IngresoDinero.TabIndex = 1;
            this.rb_IngresoDinero.TabStop = true;
            this.rb_IngresoDinero.Text = "Ingreso Dinero";
            this.rb_IngresoDinero.UseVisualStyleBackColor = true;
            // 
            // rb_egresoDinero
            // 
            this.rb_egresoDinero.AutoSize = true;
            this.rb_egresoDinero.Location = new System.Drawing.Point(23, 45);
            this.rb_egresoDinero.Name = "rb_egresoDinero";
            this.rb_egresoDinero.Size = new System.Drawing.Size(114, 21);
            this.rb_egresoDinero.TabIndex = 2;
            this.rb_egresoDinero.TabStop = true;
            this.rb_egresoDinero.Text = "Salida Dinero";
            this.rb_egresoDinero.UseVisualStyleBackColor = true;
            // 
            // btn_nuevoComprobanteTesoreria
            // 
            this.btn_nuevoComprobanteTesoreria.Location = new System.Drawing.Point(47, 45);
            this.btn_nuevoComprobanteTesoreria.Name = "btn_nuevoComprobanteTesoreria";
            this.btn_nuevoComprobanteTesoreria.Size = new System.Drawing.Size(185, 72);
            this.btn_nuevoComprobanteTesoreria.TabIndex = 0;
            this.btn_nuevoComprobanteTesoreria.Text = "Nuevo Comprobante";
            this.btn_nuevoComprobanteTesoreria.UseVisualStyleBackColor = true;
            this.btn_nuevoComprobanteTesoreria.Click += new System.EventHandler(this.btn_nuevoComprobanteTesoreria_Click);
            // 
            // pd_imprimirCierre
            // 
            this.pd_imprimirCierre.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_imprimirCierre_PrintPage);
            // 
            // clm_fechaComprobanteVentas
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.clm_fechaComprobanteVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.clm_fechaComprobanteVentas.HeaderText = "Fecha";
            this.clm_fechaComprobanteVentas.Name = "clm_fechaComprobanteVentas";
            this.clm_fechaComprobanteVentas.ReadOnly = true;
            // 
            // cm_codigoFacturaVentas
            // 
            this.cm_codigoFacturaVentas.HeaderText = "Codigo";
            this.cm_codigoFacturaVentas.Name = "cm_codigoFacturaVentas";
            this.cm_codigoFacturaVentas.ReadOnly = true;
            // 
            // cm_codigoClienteVentas
            // 
            this.cm_codigoClienteVentas.HeaderText = "Codigo Cliente";
            this.cm_codigoClienteVentas.Name = "cm_codigoClienteVentas";
            this.cm_codigoClienteVentas.ReadOnly = true;
            // 
            // clm_nombreClienteFacturas
            // 
            this.clm_nombreClienteFacturas.HeaderText = "Nombre de Cliente";
            this.clm_nombreClienteFacturas.Name = "clm_nombreClienteFacturas";
            this.clm_nombreClienteFacturas.ReadOnly = true;
            // 
            // cm_medioDePago
            // 
            this.cm_medioDePago.HeaderText = "Medio De Pago";
            this.cm_medioDePago.Name = "cm_medioDePago";
            this.cm_medioDePago.ReadOnly = true;
            // 
            // cm_numeroOperacionMPVentas
            // 
            this.cm_numeroOperacionMPVentas.HeaderText = "Número de Operación";
            this.cm_numeroOperacionMPVentas.Name = "cm_numeroOperacionMPVentas";
            this.cm_numeroOperacionMPVentas.ReadOnly = true;
            // 
            // cm_fechaRendicion
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.cm_fechaRendicion.DefaultCellStyle = dataGridViewCellStyle2;
            this.cm_fechaRendicion.HeaderText = "Fecha de Rendicion";
            this.cm_fechaRendicion.Name = "cm_fechaRendicion";
            this.cm_fechaRendicion.ReadOnly = true;
            // 
            // clm_montoFinalFacturaVer
            // 
            this.clm_montoFinalFacturaVer.HeaderText = "Monto Total";
            this.clm_montoFinalFacturaVer.Name = "clm_montoFinalFacturaVer";
            this.clm_montoFinalFacturaVer.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 594);
            this.Controls.Add(this.tb_kioskMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KiosK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tb_kioskMain.ResumeLayout(false);
            this.tb_facturacion.ResumeLayout(false);
            this.tb_facturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FacturaFinal)).EndInit();
            this.tb_clientes.ResumeLayout(false);
            this.tb_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.tb_productos.ResumeLayout(false);
            this.tb_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.tb_totalVentas.ResumeLayout(false);
            this.tb_totalVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).EndInit();
            this.tb_mercadoPago.ResumeLayout(false);
            this.tb_mercadoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventasMercadoPagoGeneral)).EndInit();
            this.tb_cierreDeCaja.ResumeLayout(false);
            this.tb_cierreDeCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_totalVentas)).EndInit();
            this.tb_comprobantesTesoreria.ResumeLayout(false);
            this.pnl_nuevoComprobante.ResumeLayout(false);
            this.pnl_nuevoComprobante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_kioskMain;
        private System.Windows.Forms.TabPage tb_facturacion;
        private System.Windows.Forms.TabPage tb_clientes;
        private System.Windows.Forms.TabPage tb_productos;
        private System.Windows.Forms.TabPage tb_totalVentas;
        private System.Windows.Forms.TabPage tb_mercadoPago;
        private System.Windows.Forms.TabPage tb_cierreDeCaja;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cobrar;
        private System.Windows.Forms.DataGridView dgv_FacturaFinal;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_codigoProducto;
        private System.Windows.Forms.TextBox txb_codigoProducto;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Label lbl_buscarNombre;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.TextBox txb_nombreClienteBuscar;
        private System.Windows.Forms.Label lbl_buscarProducto;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.Button btn_exportarListaProductos;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.TextBox txb_tituloProductosBuscar;
        private System.Windows.Forms.Button btn_nuevoProducto;
        private System.Windows.Forms.Label lbl_filtrarNumeroFactura;
        private System.Windows.Forms.Label lbl_filtrarFacturaNombreCliente;
        private System.Windows.Forms.Label lbl_fechaFacturaHasta;
        private System.Windows.Forms.Label lbl_fechaFacturaDesde;
        private System.Windows.Forms.Button btn_quitarFiltrosFacturas;
        private System.Windows.Forms.Button btn_filtrarFacturas;
        private System.Windows.Forms.TextBox txb_numeroFactura;
        private System.Windows.Forms.TextBox txb_nombreCliente;
        private System.Windows.Forms.TextBox txb_fechaFacturaHasta;
        private System.Windows.Forms.DataGridView dgv_Facturas;
        private System.Windows.Forms.TextBox txb_fechaFacturaDesde;
        private System.Windows.Forms.DataGridView dgv_ventasMercadoPagoGeneral;
        private System.Windows.Forms.TextBox txb_fechaDesdeMP;
        private System.Windows.Forms.Label lbl_fechaDesdeMP;
        private System.Windows.Forms.Button btn_limpiarFiltros;
        private System.Windows.Forms.Button btn_filtrarMercadoPago;
        private System.Windows.Forms.CheckBox chbx_pendientes;
        private System.Windows.Forms.TextBox txb_fechaHastaMP;
        private System.Windows.Forms.Label lbl_fechaHastaMP;
        private System.Windows.Forms.Label lbl_totalEfectivo;
        private System.Windows.Forms.TextBox txb_totalEfectivo;
        private System.Windows.Forms.DataGridView dgv_totalVentas;
        private System.Windows.Forms.TextBox txb_totalMercadoPago;
        private System.Windows.Forms.Label lbl_totalMercadoPago;
        private System.Windows.Forms.TabPage tb_comprobantesTesoreria;
        private System.Windows.Forms.Panel pnl_nuevoComprobante;
        private System.Windows.Forms.Button btn_crearComprobanteTesoreria;
        private System.Windows.Forms.Label lbl_montoComprobanteTesoreria;
        private System.Windows.Forms.TextBox txb_montoComprobanteTesoreria;
        private System.Windows.Forms.ComboBox cbx_MedioPagoNuevoComprobanteTesoreria;
        private System.Windows.Forms.RadioButton rb_IngresoDinero;
        private System.Windows.Forms.RadioButton rb_egresoDinero;
        private System.Windows.Forms.Button btn_nuevoComprobanteTesoreria;
        private System.Windows.Forms.Label lbl_operacionesCierredeCaja;
        private System.Windows.Forms.Label lbl_totalGestionMercadoPago;
        private System.Windows.Forms.Button btn_cerrarCaja;
        private System.Windows.Forms.Label lbl_resultadoCierreCaja;
        private System.Windows.Forms.Button btn_cancelarCrearComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_apellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_dniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_telefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_direccionCliente;
        private System.Windows.Forms.DataGridViewButtonColumn cm_editarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_subTotal;
        private System.Windows.Forms.DataGridViewButtonColumn clm_facturacionAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_categoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_costoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_precioProducto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cm_seVendePorPesoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_stockProductos;
        private System.Windows.Forms.DataGridViewButtonColumn clm_editarProductosAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_fechaMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codFacturaMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoClienteMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_nombreClienteMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_montoFacturaMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_numOperacionMP;
        private System.Windows.Forms.DataGridViewButtonColumn clm_rendirMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_cierreCajaNumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoClienteCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_nombreClienteCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_medioPagoCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_montoParcialCierreCaja;
        private System.Drawing.Printing.PrintDocument pd_imprimirCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_fechaComprobanteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoFacturaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoClienteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nombreClienteFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_medioDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_numeroOperacionMPVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_fechaRendicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_montoFinalFacturaVer;
    }
}

