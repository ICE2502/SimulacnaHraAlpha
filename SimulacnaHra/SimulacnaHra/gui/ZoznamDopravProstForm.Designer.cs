namespace SimulacnaHra.gui
{
    partial class ZoznamDopravProstForm
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
            this.aListBoxZozDoPr = new System.Windows.Forms.ListBox();
            this.aTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aListBoxZozDoPr
            // 
            this.aListBoxZozDoPr.FormattingEnabled = true;
            this.aListBoxZozDoPr.Location = new System.Drawing.Point(13, 13);
            this.aListBoxZozDoPr.Name = "aListBoxZozDoPr";
            this.aListBoxZozDoPr.Size = new System.Drawing.Size(259, 238);
            this.aListBoxZozDoPr.TabIndex = 0;
            this.aListBoxZozDoPr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.aListBoxZozDoPr_MouseDoubleClick);
            // 
            // aTimer1
            // 
            this.aTimer1.Interval = 500;
            this.aTimer1.Tick += new System.EventHandler(this.aTimer1_Tick);
            // 
            // ZoznamDopravProstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.aListBoxZozDoPr);
            this.Name = "ZoznamDopravProstForm";
            this.Text = "Zoznam dopravných prostriedkov";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoznamDopravProstForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox aListBoxZozDoPr;
        private System.Windows.Forms.Timer aTimer1;
    }
}