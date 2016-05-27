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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lblXam = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Clasificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
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
            this.lblAlpha.Location = new System.Drawing.Point(12, 71);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(28, 17);
            this.lblAlpha.TabIndex = 12;
            this.lblAlpha.Text = "α =";
            // 
            // cmbAlpha
            // 
            this.cmbAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlpha.FormattingEnabled = true;
            this.cmbAlpha.Location = new System.Drawing.Point(46, 68);
            this.cmbAlpha.Name = "cmbAlpha";
            this.cmbAlpha.Size = new System.Drawing.Size(100, 24);
            this.cmbAlpha.TabIndex = 11;
            // 
            // btnHacerPrueba
            // 
            this.btnHacerPrueba.Enabled = false;
            this.btnHacerPrueba.Location = new System.Drawing.Point(152, 68);
            this.btnHacerPrueba.Name = "btnHacerPrueba";
            this.btnHacerPrueba.Size = new System.Drawing.Size(88, 47);
            this.btnHacerPrueba.TabIndex = 13;
            this.btnHacerPrueba.Text = "Hacer prueba";
            this.btnHacerPrueba.UseVisualStyleBackColor = true;
            this.btnHacerPrueba.Click += new System.EventHandler(this.btnHacerPrueba_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clasificación,
            this.FO,
            this.FE,
            this.X2});
            this.dgvTabla.Location = new System.Drawing.Point(246, 68);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(652, 258);
            this.dgvTabla.TabIndex = 14;
            // 
            // lblXam
            // 
            this.lblXam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXam.AutoSize = true;
            this.lblXam.Location = new System.Drawing.Point(904, 102);
            this.lblXam.Name = "lblXam";
            this.lblXam.Size = new System.Drawing.Size(64, 17);
            this.lblXam.TabIndex = 21;
            this.lblXam.Text = "X(α, n-1)";
            // 
            // lblX2
            // 
            this.lblX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(904, 85);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(25, 17);
            this.lblX2.TabIndex = 20;
            this.lblX2.Text = "X2";
            // 
            // lblN
            // 
            this.lblN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(904, 68);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(16, 17);
            this.lblN.TabIndex = 22;
            this.lblN.Text = "n";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.Location = new System.Drawing.Point(904, 167);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(181, 101);
            this.lblResultado.TabIndex = 23;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Clasificación
            // 
            this.Clasificación.HeaderText = "Clasificación";
            this.Clasificación.Name = "Clasificación";
            // 
            // FO
            // 
            this.FO.HeaderText = "FO";
            this.FO.Name = "FO";
            // 
            // FE
            // 
            this.FE.HeaderText = "FE";
            this.FE.Name = "FE";
            // 
            // X2
            // 
            this.X2.FillWeight = 120F;
            this.X2.HeaderText = "((FO - FE)^2) / FE";
            this.X2.Name = "X2";
            this.X2.Width = 120;
            // 
            // formPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 338);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblXam);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnHacerPrueba);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.cmbAlpha);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Name = "formPoker";
            this.Text = "Prueba de independencia de Póker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lblXam;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
    }
}