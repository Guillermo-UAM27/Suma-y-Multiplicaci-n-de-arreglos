namespace ejercio3
{
    partial class FormularioDeVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdVendedor = new System.Windows.Forms.TextBox();
            this.tbMontoVenta = new System.Windows.Forms.TextBox();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.lbReporte = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAgregarVentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID EMPLEADO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PRODUCTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTO DE VENTA:";
            // 
            // tbIdVendedor
            // 
            this.tbIdVendedor.Location = new System.Drawing.Point(217, 78);
            this.tbIdVendedor.Name = "tbIdVendedor";
            this.tbIdVendedor.Size = new System.Drawing.Size(260, 22);
            this.tbIdVendedor.TabIndex = 3;
            // 
            // tbMontoVenta
            // 
            this.tbMontoVenta.Location = new System.Drawing.Point(217, 181);
            this.tbMontoVenta.Name = "tbMontoVenta";
            this.tbMontoVenta.Size = new System.Drawing.Size(260, 22);
            this.tbMontoVenta.TabIndex = 4;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(217, 122);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(260, 22);
            this.tbIdProducto.TabIndex = 5;
            // 
            // lbReporte
            // 
            this.lbReporte.FormattingEnabled = true;
            this.lbReporte.ItemHeight = 16;
            this.lbReporte.Location = new System.Drawing.Point(182, 252);
            this.lbReporte.Name = "lbReporte";
            this.lbReporte.Size = new System.Drawing.Size(335, 164);
            this.lbReporte.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "SISTEMA DE GESTION DE VENTAS:";
            // 
            // btAgregarVentas
            // 
            this.btAgregarVentas.ForeColor = System.Drawing.Color.Coral;
            this.btAgregarVentas.Image = global::ejercio3.Properties.Resources.comercio_electronico;
            this.btAgregarVentas.Location = new System.Drawing.Point(531, 100);
            this.btAgregarVentas.Name = "btAgregarVentas";
            this.btAgregarVentas.Size = new System.Drawing.Size(67, 84);
            this.btAgregarVentas.TabIndex = 9;
            this.btAgregarVentas.UseVisualStyleBackColor = true;
            this.btAgregarVentas.Click += new System.EventHandler(this.btAgregarVentas_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ejercio3.Properties.Resources.lista_de_deseos__1_;
            this.button1.Location = new System.Drawing.Point(558, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 83);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAgregarVentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbReporte);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.tbMontoVenta);
            this.Controls.Add(this.tbIdVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioDeVenta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdVendedor;
        private System.Windows.Forms.TextBox tbMontoVenta;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.ListBox lbReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAgregarVentas;
        private System.Windows.Forms.Label label4;
    }
}

