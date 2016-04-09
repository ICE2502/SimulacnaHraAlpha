namespace SimulacnaHra.gui
{
    partial class StanicaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelTyp = new System.Windows.Forms.Label();
            this.aListBoxAktualne = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aButtonPredaj = new System.Windows.Forms.Button();
            this.aButtonNakup = new System.Windows.Forms.Button();
            this.aComboBoxMozne = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aTextBoxInfo = new System.Windows.Forms.TextBox();
            this.aTimer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typ: ";
            // 
            // aLabelTyp
            // 
            this.aLabelTyp.AutoSize = true;
            this.aLabelTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabelTyp.Location = new System.Drawing.Point(66, 13);
            this.aLabelTyp.Name = "aLabelTyp";
            this.aLabelTyp.Size = new System.Drawing.Size(15, 20);
            this.aLabelTyp.TabIndex = 1;
            this.aLabelTyp.Text = "-";
            // 
            // aListBoxAktualne
            // 
            this.aListBoxAktualne.FormattingEnabled = true;
            this.aListBoxAktualne.Location = new System.Drawing.Point(17, 76);
            this.aListBoxAktualne.Name = "aListBoxAktualne";
            this.aListBoxAktualne.Size = new System.Drawing.Size(263, 199);
            this.aListBoxAktualne.TabIndex = 2;
            this.aListBoxAktualne.SelectedIndexChanged += new System.EventHandler(this.aListBoxAktualne_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktuálne v depe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(283, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nákup:";
            // 
            // aButtonPredaj
            // 
            this.aButtonPredaj.Location = new System.Drawing.Point(16, 307);
            this.aButtonPredaj.Name = "aButtonPredaj";
            this.aButtonPredaj.Size = new System.Drawing.Size(150, 34);
            this.aButtonPredaj.TabIndex = 6;
            this.aButtonPredaj.Text = "Predaj";
            this.aButtonPredaj.UseVisualStyleBackColor = true;
            this.aButtonPredaj.Click += new System.EventHandler(this.ButtonPredaj_Click);
            // 
            // aButtonNakup
            // 
            this.aButtonNakup.Location = new System.Drawing.Point(286, 307);
            this.aButtonNakup.Name = "aButtonNakup";
            this.aButtonNakup.Size = new System.Drawing.Size(111, 34);
            this.aButtonNakup.TabIndex = 7;
            this.aButtonNakup.Text = "Nákup";
            this.aButtonNakup.UseVisualStyleBackColor = true;
            this.aButtonNakup.Click += new System.EventHandler(this.ButtonNakup_Click);
            // 
            // aComboBoxMozne
            // 
            this.aComboBoxMozne.FormattingEnabled = true;
            this.aComboBoxMozne.Location = new System.Drawing.Point(286, 95);
            this.aComboBoxMozne.Name = "aComboBoxMozne";
            this.aComboBoxMozne.Size = new System.Drawing.Size(263, 21);
            this.aComboBoxMozne.TabIndex = 8;
            this.aComboBoxMozne.SelectedIndexChanged += new System.EventHandler(this.aComboBoxMozne_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dostupné stroje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Informácie:";
            // 
            // aTextBoxInfo
            // 
            this.aTextBoxInfo.Location = new System.Drawing.Point(289, 151);
            this.aTextBoxInfo.Multiline = true;
            this.aTextBoxInfo.Name = "aTextBoxInfo";
            this.aTextBoxInfo.Size = new System.Drawing.Size(263, 124);
            this.aTextBoxInfo.TabIndex = 11;
            // 
            // aTimer1
            // 
            this.aTimer1.Interval = 500;
            this.aTimer1.Tick += new System.EventHandler(this.aTimer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kúpiť vybraný dopravný prostriedok:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Predať vybraný dopravný prostriedok:";
            // 
            // StanicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 355);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aTextBoxInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aComboBoxMozne);
            this.Controls.Add(this.aButtonNakup);
            this.Controls.Add(this.aButtonPredaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aListBoxAktualne);
            this.Controls.Add(this.aLabelTyp);
            this.Controls.Add(this.label1);
            this.Name = "StanicaForm";
            this.Text = "Stanica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StanicaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelTyp;
        private System.Windows.Forms.ListBox aListBoxAktualne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aButtonPredaj;
        private System.Windows.Forms.Button aButtonNakup;
        private System.Windows.Forms.ComboBox aComboBoxMozne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aTextBoxInfo;
        private System.Windows.Forms.Timer aTimer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}