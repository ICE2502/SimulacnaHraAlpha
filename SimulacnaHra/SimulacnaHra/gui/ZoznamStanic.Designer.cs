namespace SimulacnaHra.gui
{
    partial class ZoznamStanic
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
            this.aListBoxZoznamStanic = new System.Windows.Forms.ListBox();
            this.aTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aListBoxZoznamStanic
            // 
            this.aListBoxZoznamStanic.FormattingEnabled = true;
            this.aListBoxZoznamStanic.Location = new System.Drawing.Point(13, 13);
            this.aListBoxZoznamStanic.Name = "aListBoxZoznamStanic";
            this.aListBoxZoznamStanic.Size = new System.Drawing.Size(432, 264);
            this.aListBoxZoznamStanic.TabIndex = 0;
            this.aListBoxZoznamStanic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.aListBox_MouseDoubleClick);
            // 
            // aTimer1
            // 
            this.aTimer1.Interval = 500;
            this.aTimer1.Tick += new System.EventHandler(this.aTimer1_Tick);
            // 
            // ZoznamStanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 287);
            this.Controls.Add(this.aListBoxZoznamStanic);
            this.Name = "ZoznamStanic";
            this.Text = "Zoznam Staníc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoznamStanic_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox aListBoxZoznamStanic;
        private System.Windows.Forms.Timer aTimer1;
    }
}