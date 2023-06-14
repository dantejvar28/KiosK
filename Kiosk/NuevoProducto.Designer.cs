namespace Kiosk
{
    partial class NuevoProducto
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
            this.lbl_nombreProducto = new System.Windows.Forms.Label();
            this.txb_nombreProducto = new System.Windows.Forms.TextBox();
            this.txb_categoriaProducto = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_unidadDeMedida = new System.Windows.Forms.Label();
            this.cmb_unidadDeMedida = new System.Windows.Forms.ComboBox();
            this.txb_costoProducto = new System.Windows.Forms.TextBox();
            this.lbl_costoProducto = new System.Windows.Forms.Label();
            this.txb_precioProducto = new System.Windows.Forms.TextBox();
            this.lbl_precioProducto = new System.Windows.Forms.Label();
            this.cbx_seVendePorPeso = new System.Windows.Forms.CheckBox();
            this.btn_crearProducto = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txb_codigoProducto = new System.Windows.Forms.TextBox();
            this.lbl_codigoProducto = new System.Windows.Forms.Label();
            this.txb_stockProducto = new System.Windows.Forms.TextBox();
            this.lbl_stockProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombreProducto
            // 
            this.lbl_nombreProducto.AutoSize = true;
            this.lbl_nombreProducto.Location = new System.Drawing.Point(13, 63);
            this.lbl_nombreProducto.Name = "lbl_nombreProducto";
            this.lbl_nombreProducto.Size = new System.Drawing.Size(144, 17);
            this.lbl_nombreProducto.TabIndex = 0;
            this.lbl_nombreProducto.Text = "Nombre de Producto*";
            // 
            // txb_nombreProducto
            // 
            this.txb_nombreProducto.Location = new System.Drawing.Point(16, 83);
            this.txb_nombreProducto.Name = "txb_nombreProducto";
            this.txb_nombreProducto.Size = new System.Drawing.Size(181, 22);
            this.txb_nombreProducto.TabIndex = 1;
            // 
            // txb_categoriaProducto
            // 
            this.txb_categoriaProducto.Location = new System.Drawing.Point(16, 141);
            this.txb_categoriaProducto.Name = "txb_categoriaProducto";
            this.txb_categoriaProducto.Size = new System.Drawing.Size(181, 22);
            this.txb_categoriaProducto.TabIndex = 3;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(13, 120);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(69, 17);
            this.lbl_categoria.TabIndex = 2;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_unidadDeMedida
            // 
            this.lbl_unidadDeMedida.AutoSize = true;
            this.lbl_unidadDeMedida.Location = new System.Drawing.Point(13, 221);
            this.lbl_unidadDeMedida.Name = "lbl_unidadDeMedida";
            this.lbl_unidadDeMedida.Size = new System.Drawing.Size(128, 17);
            this.lbl_unidadDeMedida.TabIndex = 4;
            this.lbl_unidadDeMedida.Text = "Unidad de Medida*";
            // 
            // cmb_unidadDeMedida
            // 
            this.cmb_unidadDeMedida.FormattingEnabled = true;
            this.cmb_unidadDeMedida.Location = new System.Drawing.Point(16, 242);
            this.cmb_unidadDeMedida.Name = "cmb_unidadDeMedida";
            this.cmb_unidadDeMedida.Size = new System.Drawing.Size(66, 24);
            this.cmb_unidadDeMedida.TabIndex = 5;
            this.cmb_unidadDeMedida.SelectedIndexChanged += new System.EventHandler(this.cmb_unidadDeMedida_SelectedIndexChanged);
            // 
            // txb_costoProducto
            // 
            this.txb_costoProducto.Location = new System.Drawing.Point(248, 83);
            this.txb_costoProducto.Name = "txb_costoProducto";
            this.txb_costoProducto.Size = new System.Drawing.Size(181, 22);
            this.txb_costoProducto.TabIndex = 7;
            this.txb_costoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_costoProducto_KeyPress);
            // 
            // lbl_costoProducto
            // 
            this.lbl_costoProducto.AutoSize = true;
            this.lbl_costoProducto.Location = new System.Drawing.Point(245, 63);
            this.lbl_costoProducto.Name = "lbl_costoProducto";
            this.lbl_costoProducto.Size = new System.Drawing.Size(130, 17);
            this.lbl_costoProducto.TabIndex = 6;
            this.lbl_costoProducto.Text = "Costo de Producto*";
            // 
            // txb_precioProducto
            // 
            this.txb_precioProducto.Location = new System.Drawing.Point(248, 141);
            this.txb_precioProducto.Name = "txb_precioProducto";
            this.txb_precioProducto.Size = new System.Drawing.Size(181, 22);
            this.txb_precioProducto.TabIndex = 9;
            this.txb_precioProducto.TextChanged += new System.EventHandler(this.txb_precioProducto_TextChanged);
            this.txb_precioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_precioProducto_KeyPress);
            // 
            // lbl_precioProducto
            // 
            this.lbl_precioProducto.AutoSize = true;
            this.lbl_precioProducto.Location = new System.Drawing.Point(245, 120);
            this.lbl_precioProducto.Name = "lbl_precioProducto";
            this.lbl_precioProducto.Size = new System.Drawing.Size(134, 17);
            this.lbl_precioProducto.TabIndex = 8;
            this.lbl_precioProducto.Text = "Precio de Producto*";
            // 
            // cbx_seVendePorPeso
            // 
            this.cbx_seVendePorPeso.AutoSize = true;
            this.cbx_seVendePorPeso.Location = new System.Drawing.Point(248, 242);
            this.cbx_seVendePorPeso.Name = "cbx_seVendePorPeso";
            this.cbx_seVendePorPeso.Size = new System.Drawing.Size(169, 21);
            this.cbx_seVendePorPeso.TabIndex = 11;
            this.cbx_seVendePorPeso.Text = "¿Se Vende por Peso?";
            this.cbx_seVendePorPeso.UseVisualStyleBackColor = true;
            // 
            // btn_crearProducto
            // 
            this.btn_crearProducto.Location = new System.Drawing.Point(16, 279);
            this.btn_crearProducto.Name = "btn_crearProducto";
            this.btn_crearProducto.Size = new System.Drawing.Size(181, 79);
            this.btn_crearProducto.TabIndex = 12;
            this.btn_crearProducto.Text = "Crear";
            this.btn_crearProducto.UseVisualStyleBackColor = true;
            this.btn_crearProducto.Click += new System.EventHandler(this.btn_crearProducto_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(248, 279);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(181, 79);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txb_codigoProducto
            // 
            this.txb_codigoProducto.Location = new System.Drawing.Point(16, 32);
            this.txb_codigoProducto.MaxLength = 30;
            this.txb_codigoProducto.Name = "txb_codigoProducto";
            this.txb_codigoProducto.Size = new System.Drawing.Size(413, 22);
            this.txb_codigoProducto.TabIndex = 15;
            // 
            // lbl_codigoProducto
            // 
            this.lbl_codigoProducto.AutoSize = true;
            this.lbl_codigoProducto.Location = new System.Drawing.Point(13, 11);
            this.lbl_codigoProducto.Name = "lbl_codigoProducto";
            this.lbl_codigoProducto.Size = new System.Drawing.Size(138, 17);
            this.lbl_codigoProducto.TabIndex = 14;
            this.lbl_codigoProducto.Text = "Código de Producto*";
            // 
            // txb_stockProducto
            // 
            this.txb_stockProducto.Location = new System.Drawing.Point(248, 198);
            this.txb_stockProducto.Name = "txb_stockProducto";
            this.txb_stockProducto.Size = new System.Drawing.Size(181, 22);
            this.txb_stockProducto.TabIndex = 17;
            this.txb_stockProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_stockProducto_KeyPress);
            // 
            // lbl_stockProducto
            // 
            this.lbl_stockProducto.AutoSize = true;
            this.lbl_stockProducto.Location = new System.Drawing.Point(245, 178);
            this.lbl_stockProducto.Name = "lbl_stockProducto";
            this.lbl_stockProducto.Size = new System.Drawing.Size(48, 17);
            this.lbl_stockProducto.TabIndex = 16;
            this.lbl_stockProducto.Text = "Stock*";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 383);
            this.Controls.Add(this.txb_stockProducto);
            this.Controls.Add(this.lbl_stockProducto);
            this.Controls.Add(this.txb_codigoProducto);
            this.Controls.Add(this.lbl_codigoProducto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_crearProducto);
            this.Controls.Add(this.cbx_seVendePorPeso);
            this.Controls.Add(this.txb_precioProducto);
            this.Controls.Add(this.lbl_precioProducto);
            this.Controls.Add(this.txb_costoProducto);
            this.Controls.Add(this.lbl_costoProducto);
            this.Controls.Add(this.cmb_unidadDeMedida);
            this.Controls.Add(this.lbl_unidadDeMedida);
            this.Controls.Add(this.txb_categoriaProducto);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txb_nombreProducto);
            this.Controls.Add(this.lbl_nombreProducto);
            this.MaximizeBox = false;
            this.Name = "NuevoProducto";
            this.Text = "NuevoProducto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreProducto;
        private System.Windows.Forms.TextBox txb_nombreProducto;
        private System.Windows.Forms.TextBox txb_categoriaProducto;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_unidadDeMedida;
        private System.Windows.Forms.ComboBox cmb_unidadDeMedida;
        private System.Windows.Forms.TextBox txb_costoProducto;
        private System.Windows.Forms.Label lbl_costoProducto;
        private System.Windows.Forms.TextBox txb_precioProducto;
        private System.Windows.Forms.Label lbl_precioProducto;
        private System.Windows.Forms.CheckBox cbx_seVendePorPeso;
        private System.Windows.Forms.Button btn_crearProducto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txb_codigoProducto;
        private System.Windows.Forms.Label lbl_codigoProducto;
        private System.Windows.Forms.TextBox txb_stockProducto;
        private System.Windows.Forms.Label lbl_stockProducto;
    }
}