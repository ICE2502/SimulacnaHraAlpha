namespace SimulacnaHra.gui
{
    partial class ZoskupenieForm
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
            this.aLabelZoskupenieHlavny = new System.Windows.Forms.Label();
            this.aListBoxZoskupenieCaka = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aListBoxZoskupeniePripojene = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aListBoxZoskupenieStanice = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aLabelZoskupeniePrijma = new System.Windows.Forms.Label();
            this.aLabelZoskupeniePoskytuje = new System.Windows.Forms.Label();
            this.aCasovacInfoZoskupenie = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aLabelZoskupenieHlavny
            // 
            this.aLabelZoskupenieHlavny.AutoSize = true;
            this.aLabelZoskupenieHlavny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelZoskupenieHlavny.Location = new System.Drawing.Point(13, 13);
            this.aLabelZoskupenieHlavny.Name = "aLabelZoskupenieHlavny";
            this.aLabelZoskupenieHlavny.Size = new System.Drawing.Size(13, 16);
            this.aLabelZoskupenieHlavny.TabIndex = 0;
            this.aLabelZoskupenieHlavny.Text = "-";
            // 
            // aListBoxZoskupenieCaka
            // 
            this.aListBoxZoskupenieCaka.FormattingEnabled = true;
            this.aListBoxZoskupenieCaka.Location = new System.Drawing.Point(12, 63);
            this.aListBoxZoskupenieCaka.Name = "aListBoxZoskupenieCaka";
            this.aListBoxZoskupenieCaka.Size = new System.Drawing.Size(146, 160);
            this.aListBoxZoskupenieCaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Čaká:";
            // 
            // aListBoxZoskupeniePripojene
            // 
            this.aListBoxZoskupeniePripojene.FormattingEnabled = true;
            this.aListBoxZoskupeniePripojene.Location = new System.Drawing.Point(164, 63);
            this.aListBoxZoskupeniePripojene.Name = "aListBoxZoskupeniePripojene";
            this.aListBoxZoskupeniePripojene.Size = new System.Drawing.Size(146, 160);
            this.aListBoxZoskupeniePripojene.TabIndex = 3;
            this.aListBoxZoskupeniePripojene.SelectedIndexChanged += new System.EventHandler(this.aListBoxZoskupeniePripojene_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pripojené:";
            // 
            // aListBoxZoskupenieStanice
            // 
            this.aListBoxZoskupenieStanice.FormattingEnabled = true;
            this.aListBoxZoskupenieStanice.Location = new System.Drawing.Point(316, 63);
            this.aListBoxZoskupenieStanice.Name = "aListBoxZoskupenieStanice";
            this.aListBoxZoskupenieStanice.Size = new System.Drawing.Size(146, 160);
            this.aListBoxZoskupenieStanice.TabIndex = 5;
            this.aListBoxZoskupenieStanice.SelectedIndexChanged += new System.EventHandler(this.aListBoxZoskupenieStanice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skladá sa z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prijma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Poskytuje:";
            // 
            // aLabelZoskupeniePrijma
            // 
            this.aLabelZoskupeniePrijma.AutoSize = true;
            this.aLabelZoskupeniePrijma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelZoskupeniePrijma.Location = new System.Drawing.Point(113, 240);
            this.aLabelZoskupeniePrijma.Name = "aLabelZoskupeniePrijma";
            this.aLabelZoskupeniePrijma.Size = new System.Drawing.Size(12, 16);
            this.aLabelZoskupeniePrijma.TabIndex = 9;
            this.aLabelZoskupeniePrijma.Text = "-";
            // 
            // aLabelZoskupeniePoskytuje
            // 
            this.aLabelZoskupeniePoskytuje.AutoSize = true;
            this.aLabelZoskupeniePoskytuje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelZoskupeniePoskytuje.Location = new System.Drawing.Point(113, 265);
            this.aLabelZoskupeniePoskytuje.Name = "aLabelZoskupeniePoskytuje";
            this.aLabelZoskupeniePoskytuje.Size = new System.Drawing.Size(12, 16);
            this.aLabelZoskupeniePoskytuje.TabIndex = 10;
            this.aLabelZoskupeniePoskytuje.Text = "-";
            // 
            // aCasovacInfoZoskupenie
            // 
            this.aCasovacInfoZoskupenie.Interval = 1000;
            this.aCasovacInfoZoskupenie.Tick += new System.EventHandler(this.aCasovacInfoZoskupenie_Tick);
            // 
            // ZoskupenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 293);
            this.Controls.Add(this.aLabelZoskupeniePoskytuje);
            this.Controls.Add(this.aLabelZoskupeniePrijma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aListBoxZoskupenieStanice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aListBoxZoskupeniePripojene);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aListBoxZoskupenieCaka);
            this.Controls.Add(this.aLabelZoskupenieHlavny);
            this.Name = "ZoskupenieForm";
            this.Text = "ZoskupenieForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZoskupenieForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabelZoskupenieHlavny;
        private System.Windows.Forms.ListBox aListBoxZoskupenieCaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox aListBoxZoskupeniePripojene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox aListBoxZoskupenieStanice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aLabelZoskupeniePrijma;
        private System.Windows.Forms.Label aLabelZoskupeniePoskytuje;
        private System.Windows.Forms.Timer aCasovacInfoZoskupenie;
    }
}