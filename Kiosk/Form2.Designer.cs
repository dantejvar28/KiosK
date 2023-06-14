namespace Kiosk
{
    partial class frm_buscarProducto
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
            this.txb_buscarProductoBuscador = new System.Windows.Forms.TextBox();
            this.dgv_listadoBusquedaProducto = new System.Windows.Forms.DataGridView();
            this.cm_codigoProductoBuscador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_nombreProductoBuscador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_seleccionarProductoBuscador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_nombreDeProductoBuscador = new System.Windows.Forms.Label();
            this.btn_buscarBuscador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoBusquedaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_buscarProductoBuscador
            // 
            this.txb_buscarProductoBuscador.Location = new System.Drawing.Point(42, 43);
            this.txb_buscarProductoBuscador.Name = "txb_buscarProductoBuscador";
            this.txb_buscarProductoBuscador.Size = new System.Drawing.Size(355, 22);
            this.txb_buscarProductoBuscador.TabIndex = 0;
            this.txb_buscarProductoBuscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_buscarProductoBuscador_KeyDown);
            // 
            // dgv_listadoBusquedaProducto
            // 
            this.dgv_listadoBusquedaProducto.AllowUserToAddRows = false;
            this.dgv_listadoBusquedaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listadoBusquedaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoBusquedaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cm_codigoProductoBuscador,
            this.cm_nombreProductoBuscador,
            this.clm_precio,
            this.cm_seleccionarProductoBuscador});
            this.dgv_listadoBusquedaProducto.Location = new System.Drawing.Point(42, 85);
            this.dgv_listadoBusquedaProducto.Name = "dgv_listadoBusquedaProducto";
            this.dgv_listadoBusquedaProducto.RowHeadersVisible = false;
            this.dgv_listadoBusquedaProducto.RowTemplate.Height = 24;
            this.dgv_listadoBusquedaProducto.Size = new System.Drawing.Size(667, 150);
            this.dgv_listadoBusquedaProducto.TabIndex = 1;
            this.dgv_listadoBusquedaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listadoBusquedaProducto_CellClick);
            // 
            // cm_codigoProductoBuscador
            // 
            this.cm_codigoProductoBuscador.HeaderText = "Código";
            this.cm_codigoProductoBuscador.Name = "cm_codigoProductoBuscador";
            this.cm_codigoProductoBuscador.ReadOnly = true;
            // 
            // cm_nombreProductoBuscador
            // 
            this.cm_nombreProductoBuscador.HeaderText = "Nombre Producto";
            this.cm_nombreProductoBuscador.Name = "cm_nombreProductoBuscador";
            this.cm_nombreProductoBuscador.ReadOnly = true;
            // 
            // clm_precio
            // 
            this.clm_precio.HeaderText = "Precio";
            this.clm_precio.Name = "clm_precio";
            this.clm_precio.ReadOnly = true;
            // 
            // cm_seleccionarProductoBuscador
            // 
            this.cm_seleccionarProductoBuscador.HeaderText = "Acción";
            this.cm_seleccionarProductoBuscador.Name = "cm_seleccionarProductoBuscador";
            this.cm_seleccionarProductoBuscador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cm_seleccionarProductoBuscador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbl_nombreDeProductoBuscador
            // 
            this.lbl_nombreDeProductoBuscador.AutoSize = true;
            this.lbl_nombreDeProductoBuscador.Location = new System.Drawing.Point(42, 20);
            this.lbl_nombreDeProductoBuscador.Name = "lbl_nombreDeProductoBuscador";
            this.lbl_nombreDeProductoBuscador.Size = new System.Drawing.Size(139, 17);
            this.lbl_nombreDeProductoBuscador.TabIndex = 2;
            this.lbl_nombreDeProductoBuscador.Text = "Nombre de Producto";
            // 
            // btn_buscarBuscador
            // 
            this.btn_buscarBuscador.Location = new System.Drawing.Point(591, 36);
            this.btn_buscarBuscador.Name = "btn_buscarBuscador";
            this.btn_buscarBuscador.Size = new System.Drawing.Size(118, 36);
            this.btn_buscarBuscador.TabIndex = 3;
            this.btn_buscarBuscador.Text = "Buscar";
            this.btn_buscarBuscador.UseVisualStyleBackColor = true;
            this.btn_buscarBuscador.Click += new System.EventHandler(this.btn_buscarBuscador_Click);
            // 
            // frm_buscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 283);
            this.Controls.Add(this.btn_buscarBuscador);
            this.Controls.Add(this.lbl_nombreDeProductoBuscador);
            this.Controls.Add(this.dgv_listadoBusquedaProducto);
            this.Controls.Add(this.txb_buscarProductoBuscador);
            this.MaximizeBox = false;
            this.Name = "frm_buscarProducto";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.frm_buscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoBusquedaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_buscarProductoBuscador;
        private System.Windows.Forms.DataGridView dgv_listadoBusquedaProducto;
        private System.Windows.Forms.Label lbl_nombreDeProductoBuscador;
        private System.Windows.Forms.Button btn_buscarBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_codigoProductoBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_nombreProductoBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_precio;
        private System.Windows.Forms.DataGridViewButtonColumn cm_seleccionarProductoBuscador;
    }
}