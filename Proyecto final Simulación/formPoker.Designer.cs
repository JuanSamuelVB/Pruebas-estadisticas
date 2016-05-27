namespace Proyecto_final_Simulación
{
    partial class formPoker
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
            this.lblAlpha = new System.Windows.Forms.Label();
            this.cmbAlpha = new System.Windows.Forms.ComboBox();
            this.btnHacerPrueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(338, 10);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(88, 27);
            this.btnExplorar.TabIndex = 2;
            this.btnExplorar.Text = "Explorar...";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(163, 12);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(169, 22);
            this.txtArchivo.TabIndex = 1;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(12, 15);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(145, 17);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo con números:";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(23, 71);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(28, 17);
            this.lblAlpha.TabIndex = 12;
            this.lblAlpha.Text = "α =";
            // 
            // cmbAlpha
            // 
            this.cmbAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlpha.FormattingEnabled = true;
            this.cmbAlpha.Location = new System.Drawing.Point(57, 68);
            this.cmbAlpha.Name = "cmbAlpha";
            this.cmbAlpha.Size = new System.Drawing.Size(100, 24);
            this.cmbAlpha.TabIndex = 11;
            // 
            // btnHacerPrueba
            // 
            this.btnHacerPrueba.Enabled = false;
            this.btnHacerPrueba.Location = new System.Drawing.Point(163, 68);
            this.btnHacerPrueba.Name = "btnHacerPrueba";
            this.btnHacerPrueba.Size = new System.Drawing.Size(88, 47);
            this.btnHacerPrueba.TabIndex = 13;
            this.btnHacerPrueba.Text = "Hacer prueba";
            this.btnHacerPrueba.UseVisualStyleBackColor = true;
            // 
            // formPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 338);
            this.Controls.Add(this.btnHacerPrueba);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.cmbAlpha);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Name = "formPoker";
            this.Text = "Prueba de independencia de Póker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.ComboBox cmbAlpha;
        private System.Windows.Forms.Button btnHacerPrueba;
    }
}