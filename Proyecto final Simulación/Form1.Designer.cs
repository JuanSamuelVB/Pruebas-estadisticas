namespace Proyecto_final_Simulación
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoCongruencialMixtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasEstadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolmogorovSmirnovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolmogorovSmirnovToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.pruebasEstadísticasToolStripMenuItem,
            this.tablasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.métodoCongruencialMixtoToolStripMenuItem});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.generarToolStripMenuItem.Text = "Generación";
            // 
            // métodoCongruencialMixtoToolStripMenuItem
            // 
            this.métodoCongruencialMixtoToolStripMenuItem.Name = "métodoCongruencialMixtoToolStripMenuItem";
            this.métodoCongruencialMixtoToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.métodoCongruencialMixtoToolStripMenuItem.Text = "Método congruencial mixto";
            this.métodoCongruencialMixtoToolStripMenuItem.Click += new System.EventHandler(this.métodoCongruencialMixtoToolStripMenuItem_Click);
            // 
            // pruebasEstadísticasToolStripMenuItem
            // 
            this.pruebasEstadísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolmogorovSmirnovToolStripMenuItem});
            this.pruebasEstadísticasToolStripMenuItem.Name = "pruebasEstadísticasToolStripMenuItem";
            this.pruebasEstadísticasToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.pruebasEstadísticasToolStripMenuItem.Text = "Pruebas estadísticas";
            // 
            // kolmogorovSmirnovToolStripMenuItem
            // 
            this.kolmogorovSmirnovToolStripMenuItem.Name = "kolmogorovSmirnovToolStripMenuItem";
            this.kolmogorovSmirnovToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.kolmogorovSmirnovToolStripMenuItem.Text = "Kolmogorov-Smirnov";
            this.kolmogorovSmirnovToolStripMenuItem.Click += new System.EventHandler(this.kolmogorovSmirnovToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolmogorovSmirnovToolStripMenuItem1});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // kolmogorovSmirnovToolStripMenuItem1
            // 
            this.kolmogorovSmirnovToolStripMenuItem1.Name = "kolmogorovSmirnovToolStripMenuItem1";
            this.kolmogorovSmirnovToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.kolmogorovSmirnovToolStripMenuItem1.Text = "Kolmogorov-Smirnov";
            this.kolmogorovSmirnovToolStripMenuItem1.Click += new System.EventHandler(this.kolmogorovSmirnovToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 29);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Números pseudoaleatorios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoCongruencialMixtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebasEstadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolmogorovSmirnovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolmogorovSmirnovToolStripMenuItem1;
    }
}

