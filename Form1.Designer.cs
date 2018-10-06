namespace ppsinh
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnHethuc = new System.Windows.Forms.Button();
            this.txtHethuc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtF0 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDayke = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Sinhtohop = new System.Windows.Forms.Button();
            this.txtSinhtohop = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDaytohop = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnDaynhiphan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnHethuc);
            this.tabPage4.Controls.Add(this.txtHethuc);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtF1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtF0);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtC2);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtC1);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(419, 170);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Giải HT truy hồi";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // btnHethuc
            // 
            this.btnHethuc.Location = new System.Drawing.Point(158, 131);
            this.btnHethuc.Name = "btnHethuc";
            this.btnHethuc.Size = new System.Drawing.Size(107, 32);
            this.btnHethuc.TabIndex = 7;
            this.btnHethuc.Text = "&Kết quả";
            this.btnHethuc.UseVisualStyleBackColor = true;
            this.btnHethuc.Click += new System.EventHandler(this.btnHethuc_Click);
            // 
            // txtHethuc
            // 
            this.txtHethuc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHethuc.Location = new System.Drawing.Point(101, 98);
            this.txtHethuc.Name = "txtHethuc";
            this.txtHethuc.ReadOnly = true;
            this.txtHethuc.Size = new System.Drawing.Size(263, 26);
            this.txtHethuc.TabIndex = 6;
            this.txtHethuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "F(n) = ";
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(277, 53);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(63, 26);
            this.txtF1.TabIndex = 5;
            this.txtF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtF1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "F(1) = ";
            // 
            // txtF0
            // 
            this.txtF0.Location = new System.Drawing.Point(108, 53);
            this.txtF0.Name = "txtF0";
            this.txtF0.Size = new System.Drawing.Size(63, 26);
            this.txtF0.TabIndex = 4;
            this.txtF0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtF0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "F(0) = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "F(n-2)  ";
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(249, 12);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(63, 26);
            this.txtC2.TabIndex = 2;
            this.txtC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "F(n-1)  + ";
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(101, 12);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(63, 26);
            this.txtC1.TabIndex = 0;
            this.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "F(n) = ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 203);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtDayke);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtDay);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 170);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Sinh Hoán vị - Nhị phân";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sinh hoán vị";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnHoanvi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sinh nhị phân";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDaynhiphan_Click);
            // 
            // txtDayke
            // 
            this.txtDayke.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDayke.Location = new System.Drawing.Point(122, 50);
            this.txtDayke.Name = "txtDayke";
            this.txtDayke.ReadOnly = true;
            this.txtDayke.Size = new System.Drawing.Size(252, 26);
            this.txtDayke.TabIndex = 5;
            this.txtDayke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Dãy kế tiếp:";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(122, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(252, 26);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Chưa mần";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Dãy trước:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(122, 18);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(252, 26);
            this.txtDay.TabIndex = 1;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhập dãy:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Sinhtohop);
            this.tabPage2.Controls.Add(this.txtSinhtohop);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtDaytohop);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtN);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 170);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Sinh Tập con";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // Sinhtohop
            // 
            this.Sinhtohop.Location = new System.Drawing.Point(135, 127);
            this.Sinhtohop.Name = "Sinhtohop";
            this.Sinhtohop.Size = new System.Drawing.Size(129, 34);
            this.Sinhtohop.TabIndex = 7;
            this.Sinhtohop.Text = "Sinh tập con";
            this.Sinhtohop.UseVisualStyleBackColor = true;
            this.Sinhtohop.Click += new System.EventHandler(this.Sinhtohop_Click);
            // 
            // txtSinhtohop
            // 
            this.txtSinhtohop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSinhtohop.Location = new System.Drawing.Point(146, 95);
            this.txtSinhtohop.Name = "txtSinhtohop";
            this.txtSinhtohop.ReadOnly = true;
            this.txtSinhtohop.Size = new System.Drawing.Size(208, 26);
            this.txtSinhtohop.TabIndex = 6;
            this.txtSinhtohop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Dãy kế tiếp:";
            // 
            // txtDaytohop
            // 
            this.txtDaytohop.Location = new System.Drawing.Point(146, 63);
            this.txtDaytohop.Name = "txtDaytohop";
            this.txtDaytohop.Size = new System.Drawing.Size(208, 26);
            this.txtDaytohop.TabIndex = 4;
            this.txtDaytohop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDaytohop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nhập dãy:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(146, 31);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 2;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nhập n:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(314, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Khuyến cáo: Đây chỉ xét tập hợp từ 1 đến n.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập dãy:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dãy kế tiếp:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dãy trước:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(119, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Chưa mần";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDaynhiphan
            // 
            this.btnDaynhiphan.Location = new System.Drawing.Point(46, 125);
            this.btnDaynhiphan.Name = "btnDaynhiphan";
            this.btnDaynhiphan.Size = new System.Drawing.Size(130, 37);
            this.btnDaynhiphan.TabIndex = 12;
            this.btnDaynhiphan.Text = "Sinh &nhị phân";
            this.btnDaynhiphan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sinh &hoán vị";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 203);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phương pháp sinh";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnHethuc;
        private System.Windows.Forms.TextBox txtHethuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtF0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnDaynhiphan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDayke;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Sinhtohop;
        private System.Windows.Forms.TextBox txtSinhtohop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDaytohop;
        private System.Windows.Forms.Label label15;


    }
}

