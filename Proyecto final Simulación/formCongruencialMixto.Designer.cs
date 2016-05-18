namespace Proyecto_final_Simulación
{
    partial class formCongruencialMixto
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
            this.btnExpNums = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnXn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnXn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.numX0 = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExpNums
            // 
            this.btnExpNums.Location = new System.Drawing.Point(719, 13);
            this.btnExpNums.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpNums.Name = "btnExpNums";
            this.btnExpNums.Size = new System.Drawing.Size(100, 120);
            this.btnExpNums.TabIndex = 6;
            this.btnExpNums.Text = "Exportar números generados";
            this.btnExpNums.UseVisualStyleBackColor = true;
            this.btnExpNums.Click += new System.EventHandler(this.btnExpNums_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(643, 108);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(67, 22);
            this.txtPeriodo.TabIndex = 7;
            this.txtPeriodo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Periodo:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(25, 111);
            this.lblM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(31, 17);
            this.lblM.TabIndex = 23;
            this.lblM.Text = "m =";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(18, 79);
            this.lblX0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(37, 17);
            this.lblX0.TabIndex = 22;
            this.lblX0.Text = "X0 =";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(27, 47);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(27, 17);
            this.lblC.TabIndex = 21;
            this.lblC.Text = "c =";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(27, 15);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 17);
            this.lblA.TabIndex = 20;
            this.lblA.Text = "a =";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnN,
            this.ColumnXn,
            this.ColumnF,
            this.ColumnXn1,
            this.Columnri});
            this.dataGridView1.Location = new System.Drawing.Point(14, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 279);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.TabStop = false;
            // 
            // ColumnN
            // 
            this.ColumnN.HeaderText = "n";
            this.ColumnN.Name = "ColumnN";
            // 
            // ColumnXn
            // 
            this.ColumnXn.HeaderText = "Xn";
            this.ColumnXn.Name = "ColumnXn";
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "((a)(Xn)+c) mod m";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.Width = 120;
            // 
            // ColumnXn1
            // 
            this.ColumnXn1.HeaderText = "Xn+1";
            this.ColumnXn1.Name = "ColumnXn1";
            // 
            // Columnri
            // 
            this.Columnri.HeaderText = "r";
            this.Columnri.Name = "Columnri";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(158, 105);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numM
            // 
            this.numM.Location = new System.Drawing.Point(65, 109);
            this.numM.Margin = new System.Windows.Forms.Padding(4);
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(85, 22);
            this.numM.TabIndex = 3;
            this.numM.Enter += new System.EventHandler(this.numM_Enter);
            // 
            // numX0
            // 
            this.numX0.Location = new System.Drawing.Point(65, 77);
            this.numX0.Margin = new System.Windows.Forms.Padding(4);
            this.numX0.Name = "numX0";
            this.numX0.Size = new System.Drawing.Size(85, 22);
            this.numX0.TabIndex = 2;
            this.numX0.Enter += new System.EventHandler(this.numX0_Enter);
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(65, 45);
            this.numC.Margin = new System.Windows.Forms.Padding(4);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(85, 22);
            this.numC.TabIndex = 1;
            this.numC.Enter += new System.EventHandler(this.numC_Enter);
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(65, 13);
            this.numA.Margin = new System.Windows.Forms.Padding(4);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(85, 22);
            this.numA.TabIndex = 0;
            this.numA.Enter += new System.EventHandler(this.numA_Enter);
            // 
            // formCongruencialMixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 432);
            this.Controls.Add(this.btnExpNums);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.numM);
            this.Controls.Add(this.numX0);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.numA);
            this.Name = "formCongruencialMixto";
            this.Text = "Generar - Método congruencial mixto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpNums;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnXn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnXn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnri;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.NumericUpDown numX0;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numA;
    }
}