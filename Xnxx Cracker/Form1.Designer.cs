
namespace Xnxx_Cracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBad = new System.Windows.Forms.Label();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btnCombo);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thread:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(127, 184);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(18, 97);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(161, 54);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.Text = "Load Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.lblBad);
            this.groupBox2.Controls.Add(this.lblGood);
            this.groupBox2.Controls.Add(this.lblPremium);
            this.groupBox2.Controls.Add(this.lblRemain);
            this.groupBox2.Controls.Add(this.lblCheck);
            this.groupBox2.Location = new System.Drawing.Point(216, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // lblBad
            // 
            this.lblBad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBad.Location = new System.Drawing.Point(16, 205);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(211, 23);
            this.lblBad.TabIndex = 4;
            this.lblBad.Text = "Bad: 0";
            // 
            // lblGood
            // 
            this.lblGood.ForeColor = System.Drawing.Color.Lime;
            this.lblGood.Location = new System.Drawing.Point(16, 156);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(211, 23);
            this.lblGood.TabIndex = 3;
            this.lblGood.Text = "Good: 0";
            // 
            // lblPremium
            // 
            this.lblPremium.ForeColor = System.Drawing.Color.Blue;
            this.lblPremium.Location = new System.Drawing.Point(16, 107);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(211, 23);
            this.lblPremium.TabIndex = 2;
            this.lblPremium.Text = "Premium: 0";
            // 
            // lblRemain
            // 
            this.lblRemain.Location = new System.Drawing.Point(16, 62);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(211, 23);
            this.lblRemain.TabIndex = 1;
            this.lblRemain.Text = "Remain: 0";
            // 
            // lblCheck
            // 
            this.lblCheck.Location = new System.Drawing.Point(16, 31);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(211, 23);
            this.lblCheck.TabIndex = 0;
            this.lblCheck.Text = "Check: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(482, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "xnxx Cracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label lblCheck;
    }
}

