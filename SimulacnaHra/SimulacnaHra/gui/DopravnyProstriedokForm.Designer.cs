namespace SimulacnaHra.gui
{
    partial class DopravnyProstriedokForm
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
            this.aLabelNadpis = new System.Windows.Forms.Label();
            this.aTextBoxPodrobneInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aListBoxZoznamCielov = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aButtonProdajCiel = new System.Windows.Forms.Button();
            this.aButtonVymazCiele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aListBoxNaklad = new System.Windows.Forms.ListBox();
            this.aButtonStart = new System.Windows.Forms.Button();
            this.aButtonStop = new System.Windows.Forms.Button();
            this.aButtonChodDoDepa = new System.Windows.Forms.Button();
            this.aTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aLabelNadpis
            // 
            this.aLabelNadpis.AutoSize = true;
            this.aLabelNadpis.Location = new System.Drawing.Point(13, 13);
            this.aLabelNadpis.Name = "aLabelNadpis";
            this.aLabelNadpis.Size = new System.Drawing.Size(10, 13);
            this.aLabelNadpis.TabIndex = 0;
            this.aLabelNadpis.Text = "-";
            // 
            // aTextBoxPodrobneInfo
            // 
            this.aTextBoxPodrobneInfo.Location = new System.Drawing.Point(12, 53);
            this.aTextBoxPodrobneInfo.Multiline = true;
            this.aTextBoxPodrobneInfo.Name = "aTextBoxPodrobneInfo";
            this.aTextBoxPodrobneInfo.Size = new System.Drawing.Size(193, 106);
            this.aTextBoxPodrobneInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informácie:";
            // 
            // aListBoxZoznamCielov
            // 
            this.aListBoxZoznamCielov.FormattingEnabled = true;
            this.aListBoxZoznamCielov.Location = new System.Drawing.Point(212, 56);
            this.aListBoxZoznamCielov.Name = "aListBoxZoznamCielov";
            this.aListBoxZoznamCielov.Size = new System.Drawing.Size(248, 160);
            this.aListBoxZoznamCielov.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoznam cielov:";
            // 
            // aButtonProdajCiel
            // 
            this.aButtonProdajCiel.Location = new System.Drawing.Point(212, 223);
            this.aButtonProdajCiel.Name = "aButtonProdajCiel";
            this.aButtonProdajCiel.Size = new System.Drawing.Size(157, 23);
            this.aButtonProdajCiel.TabIndex = 5;
            this.aButtonProdajCiel.Text = "Pridávanie cieľov";
            this.aButtonProdajCiel.UseVisualStyleBackColor = true;
            this.aButtonProdajCiel.Click += new System.EventHandler(this.aButtonProdajCiel_Click);
            // 
            // aButtonVymazCiele
            // 
            this.aButtonVymazCiele.Location = new System.Drawing.Point(376, 222);
            this.aButtonVymazCiele.Name = "aButtonVymazCiele";
            this.aButtonVymazCiele.Size = new System.Drawing.Size(84, 23);
            this.aButtonVymazCiele.TabIndex = 6;
            this.aButtonVymazCiele.Text = "Vymaž ciele";
            this.aButtonVymazCiele.UseVisualStyleBackColor = true;
            this.aButtonVymazCiele.Click += new System.EventHandler(this.aButtonVymazCiele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Náklad";
            // 
            // aListBoxNaklad
            // 
            this.aListBoxNaklad.FormattingEnabled = true;
            this.aListBoxNaklad.Location = new System.Drawing.Point(12, 183);
            this.aListBoxNaklad.Name = "aListBoxNaklad";
            this.aListBoxNaklad.Size = new System.Drawing.Size(193, 95);
            this.aListBoxNaklad.TabIndex = 8;
            // 
            // aButtonStart
            // 
            this.aButtonStart.Location = new System.Drawing.Point(212, 253);
            this.aButtonStart.Name = "aButtonStart";
            this.aButtonStart.Size = new System.Drawing.Size(75, 23);
            this.aButtonStart.TabIndex = 9;
            this.aButtonStart.Text = "Štart";
            this.aButtonStart.UseVisualStyleBackColor = true;
            this.aButtonStart.Click += new System.EventHandler(this.aButtonStart_Click);
            // 
            // aButtonStop
            // 
            this.aButtonStop.Location = new System.Drawing.Point(294, 253);
            this.aButtonStop.Name = "aButtonStop";
            this.aButtonStop.Size = new System.Drawing.Size(75, 23);
            this.aButtonStop.TabIndex = 10;
            this.aButtonStop.Text = "Stop";
            this.aButtonStop.UseVisualStyleBackColor = true;
            this.aButtonStop.Click += new System.EventHandler(this.aButtonStop_Click);
            // 
            // aButtonChodDoDepa
            // 
            this.aButtonChodDoDepa.Location = new System.Drawing.Point(376, 253);
            this.aButtonChodDoDepa.Name = "aButtonChodDoDepa";
            this.aButtonChodDoDepa.Size = new System.Drawing.Size(84, 23);
            this.aButtonChodDoDepa.TabIndex = 11;
            this.aButtonChodDoDepa.Text = "Chod do depa";
            this.aButtonChodDoDepa.UseVisualStyleBackColor = true;
            this.aButtonChodDoDepa.Click += new System.EventHandler(this.aButtonChodDoDepa_Click);
            // 
            // aTimer1
            // 
            this.aTimer1.Interval = 500;
            this.aTimer1.Tick += new System.EventHandler(this.aTimer1_Tick);
            // 
            // DopravnyProstriedokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 292);
            this.Controls.Add(this.aButtonChodDoDepa);
            this.Controls.Add(this.aButtonStop);
            this.Controls.Add(this.aButtonStart);
            this.Controls.Add(this.aListBoxNaklad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aButtonVymazCiele);
            this.Controls.Add(this.aButtonProdajCiel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aListBoxZoznamCielov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTextBoxPodrobneInfo);
            this.Controls.Add(this.aLabelNadpis);
            this.Name = "DopravnyProstriedokForm";
            this.Text = "Dopravny prostriedok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DopravnyProstriedokForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabelNadpis;
        private System.Windows.Forms.TextBox aTextBoxPodrobneInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox aListBoxZoznamCielov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aButtonProdajCiel;
        private System.Windows.Forms.Button aButtonVymazCiele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox aListBoxNaklad;
        private System.Windows.Forms.Button aButtonStart;
        private System.Windows.Forms.Button aButtonStop;
        private System.Windows.Forms.Button aButtonChodDoDepa;
        private System.Windows.Forms.Timer aTimer1;
    }
}