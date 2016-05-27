namespace Proyecto_final_Simulación
{
    partial class formDistancia
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
            this.lblLI = new System.Windows.Forms.Label();
            this.lblLS = new System.Windows.Forms.Label();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.cmbAlpha = new System.Windows.Forms.ComboBox();
            this.lblTheta = new System.Windows.Forms.Label();
            this.btnHacerPrueba = new System.Windows.Forms.Button();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.nudLS = new System.Windows.Forms.NumericUpDown();
            this.nudLI = new System.Windows.Forms.NumericUpDown();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblSumaFO = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblXam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLI
            // 
            this.lblLI.AutoSize = true;
            this.lblLI.Location = new System.Drawing.Point(20, 71);
            this.lblLI.Name = "lblLI";
            this.lblLI.Size = new System.Drawing.Size(105, 17);
            this.lblLI.TabIndex = 5;
            this.lblLI.Text = "Límite inferior =";
            // 
            // lblLS
            // 
            this.lblLS.AutoSize = true;
            this.lblLS.Location = new System.Drawing.Point(12, 99);
            this.lblLS.Name = "lblLS";
            this.lblLS.Size = new System.Drawing.Size(113, 17);
            this.lblLS.TabIndex = 6;
            this.lblLS.Text = "Límite superior =";
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
            this.txtArchivo.TabIndex = 0;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(12, 15);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(145, 17);
            this.lblArchivo.TabIndex = 1;
            this.lblArchivo.Text = "Archivo con números:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(97, 127);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(28, 17);
            this.lblN.TabIndex = 8;
            this.lblN.Text = "n =";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(97, 155);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(28, 17);
            this.lblAlpha.TabIndex = 10;
            this.lblAlpha.Text = "α =";
            // 
            // cmbAlpha
            // 
            this.cmbAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlpha.FormattingEnabled = true;
            this.cmbAlpha.Location = new System.Drawing.Point(131, 152);
            this.cmbAlpha.Name = "cmbAlpha";
            this.cmbAlpha.Size = new System.Drawing.Size(100, 24);
            this.cmbAlpha.TabIndex = 9;
            // 
            // lblTheta
            // 
            this.lblTheta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(1005, 69);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(16, 17);
            this.lblTheta.TabIndex = 11;
            this.lblTheta.Text = "θ";
            // 
            // btnHacerPrueba
            // 
            this.btnHacerPrueba.Enabled = false;
            this.btnHacerPrueba.Location = new System.Drawing.Point(237, 97);
            this.btnHacerPrueba.Name = "btnHacerPrueba";
            this.btnHacerPrueba.Size = new System.Drawing.Size(88, 47);
            this.btnHacerPrueba.TabIndex = 12;
            this.btnHacerPrueba.Text = "Hacer prueba";
            this.btnHacerPrueba.UseVisualStyleBackColor = true;
            this.btnHacerPrueba.Click += new System.EventHandler(this.btnHacerPrueba_Click);
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(131, 125);
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(100, 22);
            this.nudN.TabIndex = 13;
            this.nudN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudLS
            // 
            this.nudLS.DecimalPlaces = 2;
            this.nudLS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLS.Location = new System.Drawing.Point(131, 97);
            this.nudLS.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLS.Name = "nudLS";
            this.nudLS.Size = new System.Drawing.Size(100, 22);
            this.nudLS.TabIndex = 4;
            this.nudLS.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            // 
            // nudLI
            // 
            this.nudLI.DecimalPlaces = 2;
            this.nudLI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLI.Location = new System.Drawing.Point(131, 69);
            this.nudLI.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLI.Name = "nudLI";
            this.nudLI.Size = new System.Drawing.Size(100, 22);
            this.nudLI.TabIndex = 3;
            this.nudLI.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // dgvTabla
            // 
            this.dgvTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Pi,
            this.FO,
            this.FE,
            this.X2i});
            this.dgvTabla.Location = new System.Drawing.Point(331, 69);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowTemplate.Height = 24;
            this.dgvTabla.Size = new System.Drawing.Size(668, 245);
            this.dgvTabla.TabIndex = 14;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // Pi
            // 
            this.Pi.HeaderText = "Pi";
            this.Pi.Name = "Pi";
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
            // X2i
            // 
            this.X2i.FillWeight = 120F;
            this.X2i.HeaderText = "((FO - FE)^2) / FE";
            this.X2i.Name = "X2i";
            this.X2i.Width = 120;
            // 
            // lblMarcas
            // 
            this.lblMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(332, 319);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(0, 17);
            this.lblMarcas.TabIndex = 15;
            // 
            // lblSumaFO
            // 
            this.lblSumaFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumaFO.AutoSize = true;
            this.lblSumaFO.Location = new System.Drawing.Point(1005, 86);
            this.lblSumaFO.Name = "lblSumaFO";
            this.lblSumaFO.Size = new System.Drawing.Size(36, 17);
            this.lblSumaFO.TabIndex = 16;
            this.lblSumaFO.Text = "ΣFO";
            // 
            // lblX2
            // 
            this.lblX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(1005, 103);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(25, 17);
            this.lblX2.TabIndex = 17;
            this.lblX2.Text = "X2";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.Location = new System.Drawing.Point(1008, 194);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(181, 101);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblXam
            // 
            this.lblXam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXam.AutoSize = true;
            this.lblXam.Location = new System.Drawing.Point(1005, 120);
            this.lblXam.Name = "lblXam";
            this.lblXam.Size = new System.Drawing.Size(54, 17);
            this.lblXam.TabIndex = 19;
            this.lblXam.Text = "X(α, m)";
            // 
            // formDistancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 345);
            this.Controls.Add(this.lblXam);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblSumaFO);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.nudLI);
            this.Controls.Add(this.nudLS);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.btnHacerPrueba);
            this.Controls.Add(this.lblTheta);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.cmbAlpha);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.lblLS);
            this.Controls.Add(this.lblLI);
            this.Name = "formDistancia";
            this.Text = "Prueba de independencia de distancia";
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLI;
        private System.Windows.Forms.Label lblLS;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.ComboBox cmbAlpha;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.Button btnHacerPrueba;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.NumericUpDown nudLS;
        private System.Windows.Forms.NumericUpDown nudLI;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblSumaFO;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2i;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblXam;
    }
}