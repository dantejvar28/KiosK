namespace Kiosk
{
    partial class RendirMercadoPago
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
            this.lbl_numeroOperacion = new System.Windows.Forms.Label();
            this.txb_numeroOperacion = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_rendir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_numeroOperacion
            // 
            this.lbl_numeroOperacion.AutoSize = true;
            this.lbl_numeroOperacion.Location = new System.Drawing.Point(29, 27);
            this.lbl_numeroOperacion.Name = "lbl_numeroOperacion";
            this.lbl_numeroOperacion.Size = new System.Drawing.Size(148, 17);
            this.lbl_numeroOperacion.TabIndex = 0;
            this.lbl_numeroOperacion.Text = "Numero de Operación";
            // 
            // txb_numeroOperacion
            // 
            this.txb_numeroOperacion.Location = new System.Drawing.Point(32, 48);
            this.txb_numeroOperacion.Name = "txb_numeroOperacion";
            this.txb_numeroOperacion.Size = new System.Drawing.Size(195, 22);
            this.txb_numeroOperacion.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(32, 76);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(195, 45);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_rendir
            // 
            this.btn_rendir.Location = new System.Drawing.Point(32, 127);
            this.btn_rendir.Name = "btn_rendir";
            this.btn_rendir.Size = new System.Drawing.Size(195, 45);
            this.btn_rendir.TabIndex = 3;
            this.btn_rendir.Text = "Rendir";
            this.btn_rendir.UseVisualStyleBackColor = true;
            this.btn_rendir.Click += new System.EventHandler(this.btn_rendir_Click);
            // 
            // RendirMercadoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 199);
            this.Controls.Add(this.btn_rendir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txb_numeroOperacion);
            this.Controls.Add(this.lbl_numeroOperacion);
            this.MaximizeBox = false;
            this.Name = "RendirMercadoPago";
            this.Text = "RendirMercadoPago";
            this.Load += new System.EventHandler(this.RendirMercadoPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numeroOperacion;
        private System.Windows.Forms.TextBox txb_numeroOperacion;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_rendir;
    }
}