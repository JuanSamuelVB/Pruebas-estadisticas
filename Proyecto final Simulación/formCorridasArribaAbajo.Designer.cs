namespace Proyecto_final_Simulación
{
    partial class formCorridasArribaAbajo
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
            this.btnExplorar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnHacerPrueba = new System.Windows.Forms.Button();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(339, 10);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(88, 27);
            this.btnExplorar.TabIndex = 5;
            this.btnExplorar.Text = "Explorar...";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(164, 12);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(169, 22);
            this.txtArchivo.TabIndex = 4;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(13, 15);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(145, 17);
            this.lblArchivo.TabIndex = 3;
            this.lblArchivo.Text = "Archivo con números:";
            // 
            // btnHacerPrueba
            // 
            this.btnHacerPrueba.Enabled = false;
            this.btnHacerPrueba.Location = new System.Drawing.Point(16, 61);
            this.btnHacerPrueba.Name = "btnHacerPrueba";
            this.btnHacerPrueba.Size = new System.Drawing.Size(88, 47);
            this.btnHacerPrueba.TabIndex = 14;
            this.btnHacerPrueba.Text = "Hacer prueba";
            this.btnHacerPrueba.UseVisualStyleBackColor = true;
            this.btnHacerPrueba.Click += new System.EventHandler(this.btnHacerPrueba_Click);
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(110, 78);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(26, 17);
            this.lblN1.TabIndex = 15;
            this.lblN1.Text = "N1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(110, 95);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(26, 17);
            this.lblN2.TabIndex = 16;
            this.lblN2.Text = "N2";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(110, 112);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(46, 17);
            this.lblMedia.TabIndex = 17;
            this.lblMedia.Text = "Media";
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Location = new System.Drawing.Point(110, 129);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(77, 17);
            this.lblDesviacion.TabIndex = 18;
            this.lblDesviacion.Text = "Desviación";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(110, 146);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(18, 17);
            this.lblH.TabIndex = 19;
            this.lblH.Text = "H";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(110, 163);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(25, 17);
            this.lblZ.TabIndex = 20;
            this.lblZ.Text = "Z0";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.Location = new System.Drawing.Point(336, 61);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(181, 101);
            this.lblResultado.TabIndex = 24;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(110, 61);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 17);
            this.lblR.TabIndex = 25;
            this.lblR.Text = "R";
            // 
            // formCorridasArribaAbajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 192);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblDesviacion);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.btnHacerPrueba);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Name = "formCorridasArribaAbajo";
            this.Text = "Prueba de aleatoriedad de corridas por arriba y debajo de la media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnHacerPrueba;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblR;
    }
}