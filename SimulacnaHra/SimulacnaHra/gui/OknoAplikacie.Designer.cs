namespace SimulacnaHra.gui
{
    partial class OknoAplikacie
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
            this.components = new System.ComponentModel.Container();
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // casovac
            // 
            this.casovac.Interval = 50;
            this.casovac.Tick += new System.EventHandler(this.casovac_Tick);
            // 
            // OknoAplikacie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OknoAplikacie";
            this.Text = "Simulačná hra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OknoAplikacie_FormClosing);
            this.Load += new System.EventHandler(this.casovac_Tick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OknoAplikacie_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OknoAplikacie_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer casovac;
    }
}

