namespace SimulacnaHra.gui
{
    partial class ZoznamVyrobyForm
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
            this.aListBoxZoznamVyroby = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // aListBoxZoznamVyroby
            // 
            this.aListBoxZoznamVyroby.FormattingEnabled = true;
            this.aListBoxZoznamVyroby.Location = new System.Drawing.Point(12, 12);
            this.aListBoxZoznamVyroby.Name = "aListBoxZoznamVyroby";
            this.aListBoxZoznamVyroby.Size = new System.Drawing.Size(283, 264);
            this.aListBoxZoznamVyroby.TabIndex = 0;
            this.aListBoxZoznamVyroby.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.aListBoxVyroba_MouseDoubleClick);
            // 
            // ZoznamVyrobyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 289);
            this.Controls.Add(this.aListBoxZoznamVyroby);
            this.Name = "ZoznamVyrobyForm";
            this.Text = "Zoznam výroby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoznamVyrobyForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox aListBoxZoznamVyroby;
    }
}