namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton1.Location = new System.Drawing.Point(56, 362);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(204, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "2+2=\r\n\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton2.Location = new System.Drawing.Point(348, 362);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(204, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "2\r\n";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton3.Location = new System.Drawing.Point(56, 409);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(204, 19);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton4.Location = new System.Drawing.Point(348, 411);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(204, 19);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(159, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "2+1=\r\n\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(159, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "2+0=\r\n\r\n\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(159, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "2-1=\r\n\r\n\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton5.Location = new System.Drawing.Point(56, 362);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(204, 19);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.Text = "1";
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.Visible = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton6.Location = new System.Drawing.Point(348, 409);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(204, 19);
            this.radioButton6.TabIndex = 14;
            this.radioButton6.Text = "4";
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.Visible = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.BackColor = System.Drawing.Color.Transparent;
            this.radioButton7.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton7.Location = new System.Drawing.Point(56, 411);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(204, 19);
            this.radioButton7.TabIndex = 15;
            this.radioButton7.Text = "3";
            this.radioButton7.UseVisualStyleBackColor = false;
            this.radioButton7.Visible = false;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.BackColor = System.Drawing.Color.Transparent;
            this.radioButton8.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton8.Location = new System.Drawing.Point(348, 362);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(204, 19);
            this.radioButton8.TabIndex = 16;
            this.radioButton8.Text = "2\r\n";
            this.radioButton8.UseVisualStyleBackColor = false;
            this.radioButton8.Visible = false;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "The end";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(429, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "1000";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(429, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "2000";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(429, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "5000";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(429, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "20000";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._590;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

