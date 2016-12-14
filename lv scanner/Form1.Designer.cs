namespace lv_scanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWindowTitle = new System.Windows.Forms.TextBox();
            this.textBoxListViewCls = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTryHook = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Window Title";
            // 
            // textBoxWindowTitle
            // 
            this.textBoxWindowTitle.Location = new System.Drawing.Point(111, 32);
            this.textBoxWindowTitle.Name = "textBoxWindowTitle";
            this.textBoxWindowTitle.Size = new System.Drawing.Size(349, 20);
            this.textBoxWindowTitle.TabIndex = 1;
            // 
            // textBoxListViewCls
            // 
            this.textBoxListViewCls.Location = new System.Drawing.Point(111, 58);
            this.textBoxListViewCls.Name = "textBoxListViewCls";
            this.textBoxListViewCls.Size = new System.Drawing.Size(349, 20);
            this.textBoxListViewCls.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ListView class name";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(111, 84);
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInterval.TabIndex = 4;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval (secs)";
            // 
            // buttonTryHook
            // 
            this.buttonTryHook.Location = new System.Drawing.Point(485, 35);
            this.buttonTryHook.Name = "buttonTryHook";
            this.buttonTryHook.Size = new System.Drawing.Size(75, 23);
            this.buttonTryHook.TabIndex = 6;
            this.buttonTryHook.Text = "Try Hook";
            this.buttonTryHook.UseVisualStyleBackColor = true;
            this.buttonTryHook.Click += new System.EventHandler(this.buttonTryHook_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(527, 397);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTryHook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.textBoxListViewCls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWindowTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "test";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWindowTitle;
        private System.Windows.Forms.TextBox textBoxListViewCls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTryHook;
        private System.Windows.Forms.TextBox textBox1;
    }
}

