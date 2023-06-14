namespace Kiosk
{
    partial class NuevoCliente
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
            this.txb_nombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.lbl_apellidoCliente = new System.Windows.Forms.Label();
            this.txb_apellidoCliente = new System.Windows.Forms.TextBox();
            this.lbl_dniCliente = new System.Windows.Forms.Label();
            this.txb_dniCliente = new System.Windows.Forms.TextBox();
            this.lbl_telefonoCliente = new System.Windows.Forms.Label();
            this.txb_telefonoCliente = new System.Windows.Forms.TextBox();
            this.lbl_direccionCliente = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_nombreCliente
            // 
            this.txb_nombreCliente.Location = new System.Drawing.Point(42, 44);
            this.txb_nombreCliente.Name = "txb_nombreCliente";
            this.txb_nombreCliente.Size = new System.Drawing.Size(173, 22);
            this.txb_nombreCliente.TabIndex = 0;
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(39, 24);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(134, 17);
            this.lbl_nombreCliente.TabIndex = 1;
            this.lbl_nombreCliente.Text = "Nombre de Cliente *";
            // 
            // lbl_apellidoCliente
            // 
            this.lbl_apellidoCliente.AutoSize = true;
            this.lbl_apellidoCliente.Location = new System.Drawing.Point(39, 87);
            this.lbl_apellidoCliente.Name = "lbl_apellidoCliente";
            this.lbl_apellidoCliente.Size = new System.Drawing.Size(125, 17);
            this.lbl_apellidoCliente.TabIndex = 3;
            this.lbl_apellidoCliente.Text = "Apellido de Cliente";
            // 
            // txb_apellidoCliente
            // 
            this.txb_apellidoCliente.Location = new System.Drawing.Point(42, 107);
            this.txb_apellidoCliente.Name = "txb_apellidoCliente";
            this.txb_apellidoCliente.Size = new System.Drawing.Size(173, 22);
            this.txb_apellidoCliente.TabIndex = 2;
            // 
            // lbl_dniCliente
            // 
            this.lbl_dniCliente.AutoSize = true;
            this.lbl_dniCliente.Location = new System.Drawing.Point(253, 24);
            this.lbl_dniCliente.Name = "lbl_dniCliente";
            this.lbl_dniCliente.Size = new System.Drawing.Size(36, 17);
            this.lbl_dniCliente.TabIndex = 5;
            this.lbl_dniCliente.Text = "DNI*";
            // 
            // txb_dniCliente
            // 
            this.txb_dniCliente.Location = new System.Drawing.Point(256, 44);
            this.txb_dniCliente.MaxLength = 8;
            this.txb_dniCliente.Name = "txb_dniCliente";
            this.txb_dniCliente.Size = new System.Drawing.Size(173, 22);
            this.txb_dniCliente.TabIndex = 4;
            this.txb_dniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_dniCliente_KeyPress);
            // 
            // lbl_telefonoCliente
            // 
            this.lbl_telefonoCliente.AutoSize = true;
            this.lbl_telefonoCliente.Location = new System.Drawing.Point(253, 87);
            this.lbl_telefonoCliente.Name = "lbl_telefonoCliente";
            this.lbl_telefonoCliente.Size = new System.Drawing.Size(64, 17);
            this.lbl_telefonoCliente.TabIndex = 7;
            this.lbl_telefonoCliente.Text = "Teléfono";
            // 
            // txb_telefonoCliente
            // 
            this.txb_telefonoCliente.Location = new System.Drawing.Point(256, 107);
            this.txb_telefonoCliente.Name = "txb_telefonoCliente";
            this.txb_telefonoCliente.Size = new System.Drawing.Size(173, 22);
            this.txb_telefonoCliente.TabIndex = 6;
            this.txb_telefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_telefonoCliente_KeyPress);
            // 
            // lbl_direccionCliente
            // 
            this.lbl_direccionCliente.AutoSize = true;
            this.lbl_direccionCliente.Location = new System.Drawing.Point(39, 152);
            this.lbl_direccionCliente.Name = "lbl_direccionCliente";
            this.lbl_direccionCliente.Size = new System.Drawing.Size(67, 17);
            this.lbl_direccionCliente.TabIndex = 9;
            this.lbl_direccionCliente.Text = "Dirección";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(42, 172);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(387, 22);
            this.txb_direccion.TabIndex = 8;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(42, 226);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(173, 79);
            this.btn_crear.TabIndex = 10;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(256, 226);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(173, 79);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 317);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_direccionCliente);
            this.Controls.Add(this.txb_direccion);
            this.Controls.Add(this.lbl_telefonoCliente);
            this.Controls.Add(this.txb_telefonoCliente);
            this.Controls.Add(this.lbl_dniCliente);
            this.Controls.Add(this.txb_dniCliente);
            this.Controls.Add(this.lbl_apellidoCliente);
            this.Controls.Add(this.txb_apellidoCliente);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.txb_nombreCliente);
            this.MaximizeBox = false;
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nombreCliente;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label lbl_apellidoCliente;
        private System.Windows.Forms.TextBox txb_apellidoCliente;
        private System.Windows.Forms.Label lbl_dniCliente;
        private System.Windows.Forms.TextBox txb_dniCliente;
        private System.Windows.Forms.Label lbl_telefonoCliente;
        private System.Windows.Forms.TextBox txb_telefonoCliente;
        private System.Windows.Forms.Label lbl_direccionCliente;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_cancelar;

    }
}