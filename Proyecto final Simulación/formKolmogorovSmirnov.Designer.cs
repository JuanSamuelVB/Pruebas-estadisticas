namespace Proyecto_final_Simulación
{
    partial class formKolmogorovSmirnov
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.btnHacerPrueba = new System.Windows.Forms.Button();
            this.lblDm = new System.Windows.Forms.Label();
            this.lblDam = new System.Windows.Forms.Label();
            this.cmbAlpha = new System.Windows.Forms.ComboBox();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo con números: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(168, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(343, 10);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(88, 27);
            this.btnExplorar.TabIndex = 2;
            this.btnExplorar.Text = "Explorar...";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // btnHacerPrueba
            // 
            this.btnHacerPrueba.Enabled = false;
            this.btnHacerPrueba.Location = new System.Drawing.Point(343, 99);
            this.btnHacerPrueba.Name = "btnHacerPrueba";
            this.btnHacerPrueba.Size = new System.Drawing.Size(88, 47);
            this.btnHacerPrueba.TabIndex = 3;
            this.btnHacerPrueba.Text = "Hacer prueba";
            this.btnHacerPrueba.UseVisualStyleBackColor = true;
            this.btnHacerPrueba.Click += new System.EventHandler(this.btnHacerPrueba_Click);
            // 
            // lblDm
            // 
            this.lblDm.AutoSize = true;
            this.lblDm.Location = new System.Drawing.Point(12, 130);
            this.lblDm.Name = "lblDm";
            this.lblDm.Size = new System.Drawing.Size(29, 17);
            this.lblDm.TabIndex = 4;
            this.lblDm.Text = "Dm";
            // 
            // lblDam
            // 
            this.lblDam.AutoSize = true;
            this.lblDam.Location = new System.Drawing.Point(12, 160);
            this.lblDam.Name = "lblDam";
            this.lblDam.Size = new System.Drawing.Size(53, 17);
            this.lblDam.TabIndex = 5;
            this.lblDam.Text = "d(α, m)";
            // 
            // cmbAlpha
            // 
            this.cmbAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlpha.FormattingEnabled = true;
            this.cmbAlpha.Location = new System.Drawing.Point(46, 64);
            this.cmbAlpha.Name = "cmbAlpha";
            this.cmbAlpha.Size = new System.Drawing.Size(121, 24);
            this.cmbAlpha.TabIndex = 6;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(12, 67);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(28, 17);
            this.lblAlpha.TabIndex = 7;
            this.lblAlpha.Text = "α =";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(12, 99);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(19, 17);
            this.lblM.TabIndex = 8;
            this.lblM.Text = "m";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 196);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 9;
            // 
            // formKolmogorovSmirnov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 237);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.cmbAlpha);
            this.Controls.Add(this.lblDam);
            this.Controls.Add(this.lblDm);
            this.Controls.Add(this.btnHacerPrueba);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "formKolmogorovSmirnov";
            this.Text = "Prueba de uniformidad Kolmogorov-Smirnov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.Button btnHacerPrueba;
        private System.Windows.Forms.Label lblDm;
        private System.Windows.Forms.Label lblDam;
        private System.Windows.Forms.ComboBox cmbAlpha;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblResultado;
    }
}