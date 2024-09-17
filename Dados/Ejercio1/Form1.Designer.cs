namespace Ejercio1
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
            this.indice = new System.Windows.Forms.Label();
            this.lbDado1 = new System.Windows.Forms.Label();
            this.lbDado2 = new System.Windows.Forms.Label();
            this.lbSuma = new System.Windows.Forms.Label();
            this.lbHistorial = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLanzarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // indice
            // 
            this.indice.AutoSize = true;
            this.indice.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indice.Location = new System.Drawing.Point(232, 9);
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(260, 31);
            this.indice.TabIndex = 0;
            this.indice.Text = "Simulacion de dados:";
            // 
            // lbDado1
            // 
            this.lbDado1.AutoSize = true;
            this.lbDado1.Location = new System.Drawing.Point(259, 120);
            this.lbDado1.Name = "lbDado1";
            this.lbDado1.Size = new System.Drawing.Size(51, 16);
            this.lbDado1.TabIndex = 3;
            this.lbDado1.Text = "Dado1:";
            this.lbDado1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDado2
            // 
            this.lbDado2.AutoSize = true;
            this.lbDado2.Location = new System.Drawing.Point(551, 120);
            this.lbDado2.Name = "lbDado2";
            this.lbDado2.Size = new System.Drawing.Size(51, 16);
            this.lbDado2.TabIndex = 5;
            this.lbDado2.Text = "Dado2:";
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuma.Location = new System.Drawing.Point(206, 356);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(86, 31);
            this.lbSuma.TabIndex = 6;
            this.lbSuma.Text = "Suma:";
            // 
            // lbHistorial
            // 
            this.lbHistorial.FormattingEnabled = true;
            this.lbHistorial.ItemHeight = 16;
            this.lbHistorial.Location = new System.Drawing.Point(212, 194);
            this.lbHistorial.Name = "lbHistorial";
            this.lbHistorial.Size = new System.Drawing.Size(314, 116);
            this.lbHistorial.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ejercio1.Properties.Resources.esquema_de_cubo_de_dados;
            this.pictureBox2.Location = new System.Drawing.Point(437, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 63);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercio1.Properties.Resources.esquema_de_cubo_de_dados;
            this.pictureBox1.Location = new System.Drawing.Point(143, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 66);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLanzarDados
            // 
            this.btnLanzarDados.Image = global::Ejercio1.Properties.Resources.juego_de_dados;
            this.btnLanzarDados.Location = new System.Drawing.Point(554, 241);
            this.btnLanzarDados.Name = "btnLanzarDados";
            this.btnLanzarDados.Size = new System.Drawing.Size(92, 69);
            this.btnLanzarDados.TabIndex = 1;
            this.btnLanzarDados.UseVisualStyleBackColor = true;
            this.btnLanzarDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbHistorial);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.lbDado2);
            this.Controls.Add(this.lbDado1);
            this.Controls.Add(this.btnLanzarDados);
            this.Controls.Add(this.indice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label indice;
        private System.Windows.Forms.Button btnLanzarDados;
        private System.Windows.Forms.Label lbDado1;
        private System.Windows.Forms.Label lbDado2;
        private System.Windows.Forms.Label lbSuma;
        private System.Windows.Forms.ListBox lbHistorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

