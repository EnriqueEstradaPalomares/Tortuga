namespace GraficoTortuga
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
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.btnPlumaAbajo = new System.Windows.Forms.Button();
            this.btnGirarIzquierda = new System.Windows.Forms.Button();
            this.btnGirarDerecha = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.Location = new System.Drawing.Point(36, 12);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(94, 32);
            this.btnPlumaArriba.TabIndex = 0;
            this.btnPlumaArriba.Text = "Pluma Arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(36, 98);
            this.txtPiso.Multiline = true;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(427, 264);
            this.txtPiso.TabIndex = 1;
            // 
            // btnPlumaAbajo
            // 
            this.btnPlumaAbajo.Location = new System.Drawing.Point(142, 12);
            this.btnPlumaAbajo.Name = "btnPlumaAbajo";
            this.btnPlumaAbajo.Size = new System.Drawing.Size(92, 32);
            this.btnPlumaAbajo.TabIndex = 2;
            this.btnPlumaAbajo.Text = "Pluma abajo";
            this.btnPlumaAbajo.UseVisualStyleBackColor = true;
            this.btnPlumaAbajo.Click += new System.EventHandler(this.btnPlumaAbajo_Click);
            // 
            // btnGirarIzquierda
            // 
            this.btnGirarIzquierda.Location = new System.Drawing.Point(249, 12);
            this.btnGirarIzquierda.Name = "btnGirarIzquierda";
            this.btnGirarIzquierda.Size = new System.Drawing.Size(100, 32);
            this.btnGirarIzquierda.TabIndex = 3;
            this.btnGirarIzquierda.Text = "Girar izquierda";
            this.btnGirarIzquierda.UseVisualStyleBackColor = true;
            this.btnGirarIzquierda.Click += new System.EventHandler(this.btnGirarIzquierda_Click);
            // 
            // btnGirarDerecha
            // 
            this.btnGirarDerecha.Location = new System.Drawing.Point(364, 12);
            this.btnGirarDerecha.Name = "btnGirarDerecha";
            this.btnGirarDerecha.Size = new System.Drawing.Size(99, 32);
            this.btnGirarDerecha.TabIndex = 4;
            this.btnGirarDerecha.Text = "Girar derecha";
            this.btnGirarDerecha.UseVisualStyleBackColor = true;
            this.btnGirarDerecha.Click += new System.EventHandler(this.btnGirarDerecha_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(142, 61);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(87, 31);
            this.btnAvanzar.TabIndex = 5;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(249, 61);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 31);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprime";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(350, 61);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(85, 31);
            this.btnFin.TabIndex = 7;
            this.btnFin.Text = "Fin de datos";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(50, 72);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(60, 20);
            this.txtPasos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 374);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnGirarDerecha);
            this.Controls.Add(this.btnGirarIzquierda);
            this.Controls.Add(this.btnPlumaAbajo);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.btnPlumaArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Button btnPlumaAbajo;
        private System.Windows.Forms.Button btnGirarIzquierda;
        private System.Windows.Forms.Button btnGirarDerecha;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtPasos;
    }
}

