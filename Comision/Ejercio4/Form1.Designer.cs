namespace Ejercio3
{
    partial class Form1
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
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.Reporte = new System.Windows.Forms.ListBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnMostarReporte = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa para calcular el salario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diguita tus ventas:";
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(149, 76);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(421, 22);
            this.txtVentas.TabIndex = 2;
            // 
            // Reporte
            // 
            this.Reporte.FormattingEnabled = true;
            this.Reporte.ItemHeight = 16;
            this.Reporte.Location = new System.Drawing.Point(110, 166);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(460, 180);
            this.Reporte.TabIndex = 5;
            this.Reporte.SelectedIndexChanged += new System.EventHandler(this.lbResultados_SelectedIndexChanged);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnReiniciar.Image = global::Ejercio3.Properties.Resources.reiniciar;
            this.btnReiniciar.Location = new System.Drawing.Point(576, 343);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 69);
            this.btnReiniciar.TabIndex = 0;
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnMostarReporte
            // 
            this.btnMostarReporte.Image = global::Ejercio3.Properties.Resources.lista_de_deseos__1_;
            this.btnMostarReporte.Location = new System.Drawing.Point(585, 149);
            this.btnMostarReporte.Name = "btnMostarReporte";
            this.btnMostarReporte.Size = new System.Drawing.Size(64, 61);
            this.btnMostarReporte.TabIndex = 4;
            this.btnMostarReporte.UseVisualStyleBackColor = true;
            this.btnMostarReporte.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Image = global::Ejercio3.Properties.Resources.comercio_electronico;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(579, 61);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(106, 52);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.btnMostarReporte);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnMostarReporte;
        private System.Windows.Forms.ListBox Reporte;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

