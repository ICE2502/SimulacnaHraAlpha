namespace SimulacnaHra.gui
{
    partial class Uvod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aNumericUpDownRiadky = new System.Windows.Forms.NumericUpDown();
            this.aNumericUpDownStlpce = new System.Windows.Forms.NumericUpDown();
            this.aButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDownRiadky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDownStlpce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transport Simulation Game - Dobroslav Grygar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(623, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nová hra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Počet riadkov:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Počet stĺpcov:";
            // 
            // aNumericUpDownRiadky
            // 
            this.aNumericUpDownRiadky.Location = new System.Drawing.Point(626, 155);
            this.aNumericUpDownRiadky.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.aNumericUpDownRiadky.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.aNumericUpDownRiadky.Name = "aNumericUpDownRiadky";
            this.aNumericUpDownRiadky.Size = new System.Drawing.Size(120, 20);
            this.aNumericUpDownRiadky.TabIndex = 5;
            this.aNumericUpDownRiadky.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.aNumericUpDownRiadky.ValueChanged += new System.EventHandler(this.aNumericUpDownRiadky_ValueChanged);
            // 
            // aNumericUpDownStlpce
            // 
            this.aNumericUpDownStlpce.Location = new System.Drawing.Point(626, 214);
            this.aNumericUpDownStlpce.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.aNumericUpDownStlpce.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.aNumericUpDownStlpce.Name = "aNumericUpDownStlpce";
            this.aNumericUpDownStlpce.Size = new System.Drawing.Size(120, 20);
            this.aNumericUpDownStlpce.TabIndex = 6;
            this.aNumericUpDownStlpce.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // aButton1
            // 
            this.aButton1.Location = new System.Drawing.Point(626, 317);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(161, 44);
            this.aButton1.TabIndex = 7;
            this.aButton1.Text = "Generuj hernú plochu";
            this.aButton1.UseVisualStyleBackColor = true;
            this.aButton1.Click += new System.EventHandler(this.aButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Generovanie mapy môže ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "trvať 1 až 30 sekúnd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimulacnaHra.Properties.Resources.Uvod;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 481);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Uvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 545);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aNumericUpDownStlpce);
            this.Controls.Add(this.aNumericUpDownRiadky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Uvod";
            this.Text = "Uvod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Uvod_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDownRiadky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDownStlpce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown aNumericUpDownRiadky;
        private System.Windows.Forms.NumericUpDown aNumericUpDownStlpce;
        private System.Windows.Forms.Button aButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}