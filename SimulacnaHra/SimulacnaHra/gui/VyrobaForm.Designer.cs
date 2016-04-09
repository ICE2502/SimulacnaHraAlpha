namespace SimulacnaHra.gui
{
    partial class VyrobaForm
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
            this.aLabelDruh = new System.Windows.Forms.Label();
            this.aLabelFlekDruhVyroby = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aLabelFlekVyrobaPrijma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aLabelFlekVyrobaProdukuje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aLabelDruh
            // 
            this.aLabelDruh.AutoSize = true;
            this.aLabelDruh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelDruh.Location = new System.Drawing.Point(17, 13);
            this.aLabelDruh.Name = "aLabelDruh";
            this.aLabelDruh.Size = new System.Drawing.Size(53, 20);
            this.aLabelDruh.TabIndex = 0;
            this.aLabelDruh.Text = "Druh:";
            // 
            // aLabelFlekDruhVyroby
            // 
            this.aLabelFlekDruhVyroby.AutoSize = true;
            this.aLabelFlekDruhVyroby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelFlekDruhVyroby.Location = new System.Drawing.Point(121, 13);
            this.aLabelFlekDruhVyroby.Name = "aLabelFlekDruhVyroby";
            this.aLabelFlekDruhVyroby.Size = new System.Drawing.Size(15, 20);
            this.aLabelFlekDruhVyroby.TabIndex = 1;
            this.aLabelFlekDruhVyroby.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Príjma:";
            // 
            // aLabelFlekVyrobaPrijma
            // 
            this.aLabelFlekVyrobaPrijma.AutoSize = true;
            this.aLabelFlekVyrobaPrijma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelFlekVyrobaPrijma.Location = new System.Drawing.Point(121, 53);
            this.aLabelFlekVyrobaPrijma.Name = "aLabelFlekVyrobaPrijma";
            this.aLabelFlekVyrobaPrijma.Size = new System.Drawing.Size(15, 20);
            this.aLabelFlekVyrobaPrijma.TabIndex = 3;
            this.aLabelFlekVyrobaPrijma.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produkuje:";
            // 
            // aLabelFlekVyrobaProdukuje
            // 
            this.aLabelFlekVyrobaProdukuje.AutoSize = true;
            this.aLabelFlekVyrobaProdukuje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelFlekVyrobaProdukuje.Location = new System.Drawing.Point(121, 87);
            this.aLabelFlekVyrobaProdukuje.Name = "aLabelFlekVyrobaProdukuje";
            this.aLabelFlekVyrobaProdukuje.Size = new System.Drawing.Size(15, 20);
            this.aLabelFlekVyrobaProdukuje.TabIndex = 5;
            this.aLabelFlekVyrobaProdukuje.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zobrazí pripojené zoskupenie staníc:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zobraz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VyrobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aLabelFlekVyrobaProdukuje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aLabelFlekVyrobaPrijma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aLabelFlekDruhVyroby);
            this.Controls.Add(this.aLabelDruh);
            this.Name = "VyrobaForm";
            this.Text = "Informácie o výrobe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VyrobaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabelDruh;
        private System.Windows.Forms.Label aLabelFlekDruhVyroby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aLabelFlekVyrobaPrijma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aLabelFlekVyrobaProdukuje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}