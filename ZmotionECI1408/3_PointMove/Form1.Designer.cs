namespace PointMove
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_U = new System.Windows.Forms.RadioButton();
            this.rad_Z = new System.Windows.Forms.RadioButton();
            this.rad_Y = new System.Windows.Forms.RadioButton();
            this.rad_X = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtAccel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sramp = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeccl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Lspeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LED = new System.Windows.Forms.Panel();
            this.Btn_Init = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_ScanIP = new System.Windows.Forms.Button();
            this.cmbIps = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rad_Rev = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rad_Relative = new System.Windows.Forms.RadioButton();
            this.txt_Distance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Zero = new System.Windows.Forms.Button();
            this.Btn_PMove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_U);
            this.groupBox3.Controls.Add(this.rad_Z);
            this.groupBox3.Controls.Add(this.rad_Y);
            this.groupBox3.Controls.Add(this.rad_X);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "规划轴选择";
            // 
            // rad_U
            // 
            this.rad_U.AutoSize = true;
            this.rad_U.Location = new System.Drawing.Point(624, 26);
            this.rad_U.Name = "rad_U";
            this.rad_U.Size = new System.Drawing.Size(56, 24);
            this.rad_U.TabIndex = 0;
            this.rad_U.Text = "U轴";
            this.rad_U.UseVisualStyleBackColor = true;
            // 
            // rad_Z
            // 
            this.rad_Z.AutoSize = true;
            this.rad_Z.Location = new System.Drawing.Point(408, 26);
            this.rad_Z.Name = "rad_Z";
            this.rad_Z.Size = new System.Drawing.Size(54, 24);
            this.rad_Z.TabIndex = 0;
            this.rad_Z.Text = "Z轴";
            this.rad_Z.UseVisualStyleBackColor = true;
            // 
            // rad_Y
            // 
            this.rad_Y.AutoSize = true;
            this.rad_Y.Location = new System.Drawing.Point(226, 26);
            this.rad_Y.Name = "rad_Y";
            this.rad_Y.Size = new System.Drawing.Size(54, 24);
            this.rad_Y.TabIndex = 0;
            this.rad_Y.Text = "Y轴";
            this.rad_Y.UseVisualStyleBackColor = true;
            // 
            // rad_X
            // 
            this.rad_X.AutoSize = true;
            this.rad_X.Checked = true;
            this.rad_X.Location = new System.Drawing.Point(36, 29);
            this.rad_X.Name = "rad_X";
            this.rad_X.Size = new System.Drawing.Size(55, 24);
            this.rad_X.TabIndex = 0;
            this.rad_X.TabStop = true;
            this.rad_X.Text = "X轴";
            this.rad_X.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnits);
            this.groupBox2.Controls.Add(this.txtAccel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Sramp);
            this.groupBox2.Controls.Add(this.txtSpeed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDeccl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Lspeed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动参数设置";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(624, 86);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(125, 27);
            this.txtUnits.TabIndex = 1;
            this.txtUnits.Text = "20";
            // 
            // txtAccel
            // 
            this.txtAccel.Location = new System.Drawing.Point(624, 37);
            this.txtAccel.Name = "txtAccel";
            this.txtAccel.Size = new System.Drawing.Size(125, 27);
            this.txtAccel.TabIndex = 1;
            this.txtAccel.Text = "500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "脉冲当量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "加速度：";
            // 
            // txt_Sramp
            // 
            this.txt_Sramp.Location = new System.Drawing.Point(390, 86);
            this.txt_Sramp.Name = "txt_Sramp";
            this.txt_Sramp.Size = new System.Drawing.Size(125, 27);
            this.txt_Sramp.TabIndex = 1;
            this.txt_Sramp.Text = "200";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(390, 37);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(125, 27);
            this.txtSpeed.TabIndex = 1;
            this.txtSpeed.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "S曲线：";
            // 
            // txtDeccl
            // 
            this.txtDeccl.Location = new System.Drawing.Point(101, 86);
            this.txtDeccl.Name = "txtDeccl";
            this.txtDeccl.Size = new System.Drawing.Size(125, 27);
            this.txtDeccl.TabIndex = 1;
            this.txtDeccl.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "运行速度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "减速度：";
            // 
            // txt_Lspeed
            // 
            this.txt_Lspeed.Location = new System.Drawing.Point(101, 37);
            this.txt_Lspeed.Name = "txt_Lspeed";
            this.txt_Lspeed.Size = new System.Drawing.Size(125, 27);
            this.txt_Lspeed.TabIndex = 1;
            this.txt_Lspeed.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始速度：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LED);
            this.groupBox1.Controls.Add(this.Btn_Init);
            this.groupBox1.Controls.Add(this.Btn_Connect);
            this.groupBox1.Controls.Add(this.Btn_ScanIP);
            this.groupBox1.Controls.Add(this.cmbIps);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轴卡连接";
            // 
            // LED
            // 
            this.LED.BackColor = System.Drawing.Color.Gray;
            this.LED.Location = new System.Drawing.Point(339, 29);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(55, 27);
            this.LED.TabIndex = 2;
            // 
            // Btn_Init
            // 
            this.Btn_Init.Location = new System.Drawing.Point(495, 29);
            this.Btn_Init.Name = "Btn_Init";
            this.Btn_Init.Size = new System.Drawing.Size(145, 29);
            this.Btn_Init.TabIndex = 1;
            this.Btn_Init.Text = "初始化控制器";
            this.Btn_Init.UseVisualStyleBackColor = true;
            this.Btn_Init.Click += new System.EventHandler(this.Btn_Init_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(408, 29);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(69, 29);
            this.Btn_Connect.TabIndex = 1;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_ScanIP
            // 
            this.Btn_ScanIP.Location = new System.Drawing.Point(253, 29);
            this.Btn_ScanIP.Name = "Btn_ScanIP";
            this.Btn_ScanIP.Size = new System.Drawing.Size(69, 29);
            this.Btn_ScanIP.TabIndex = 1;
            this.Btn_ScanIP.Text = "扫描IP";
            this.Btn_ScanIP.UseVisualStyleBackColor = true;
            this.Btn_ScanIP.Click += new System.EventHandler(this.Btn_ScanIP_Click);
            // 
            // cmbIps
            // 
            this.cmbIps.FormattingEnabled = true;
            this.cmbIps.Location = new System.Drawing.Point(85, 30);
            this.cmbIps.Name = "cmbIps";
            this.cmbIps.Size = new System.Drawing.Size(151, 28);
            this.cmbIps.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP地址：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txt_Distance);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btn_Stop);
            this.groupBox4.Controls.Add(this.Btn_Zero);
            this.groupBox4.Controls.Add(this.Btn_PMove);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 113);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "寸动控制";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Controls.Add(this.rad_Rev);
            this.groupBox6.Location = new System.Drawing.Point(215, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 79);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "运动方向";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(98, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "正向";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rad_Rev
            // 
            this.rad_Rev.AutoSize = true;
            this.rad_Rev.Checked = true;
            this.rad_Rev.Location = new System.Drawing.Point(18, 34);
            this.rad_Rev.Name = "rad_Rev";
            this.rad_Rev.Size = new System.Drawing.Size(60, 24);
            this.rad_Rev.TabIndex = 0;
            this.rad_Rev.TabStop = true;
            this.rad_Rev.Text = "负向";
            this.rad_Rev.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.rad_Relative);
            this.groupBox5.Location = new System.Drawing.Point(21, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 79);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "运动模式";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 24);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "绝对";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rad_Relative
            // 
            this.rad_Relative.AutoSize = true;
            this.rad_Relative.Checked = true;
            this.rad_Relative.Location = new System.Drawing.Point(18, 35);
            this.rad_Relative.Name = "rad_Relative";
            this.rad_Relative.Size = new System.Drawing.Size(60, 24);
            this.rad_Relative.TabIndex = 0;
            this.rad_Relative.TabStop = true;
            this.rad_Relative.Text = "相对";
            this.rad_Relative.UseVisualStyleBackColor = true;
            // 
            // txt_Distance
            // 
            this.txt_Distance.Location = new System.Drawing.Point(567, 20);
            this.txt_Distance.Name = "txt_Distance";
            this.txt_Distance.Size = new System.Drawing.Size(46, 27);
            this.txt_Distance.TabIndex = 1;
            this.txt_Distance.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(616, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "mm";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(666, 59);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(102, 40);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "停止运动";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Btn_Zero
            // 
            this.Btn_Zero.Location = new System.Drawing.Point(544, 59);
            this.Btn_Zero.Name = "Btn_Zero";
            this.Btn_Zero.Size = new System.Drawing.Size(102, 40);
            this.Btn_Zero.TabIndex = 1;
            this.Btn_Zero.Text = "位置清零";
            this.Btn_Zero.UseVisualStyleBackColor = true;
            this.Btn_Zero.Click += new System.EventHandler(this.Btn_Zero_Click);
            // 
            // Btn_PMove
            // 
            this.Btn_PMove.Location = new System.Drawing.Point(410, 59);
            this.Btn_PMove.Name = "Btn_PMove";
            this.Btn_PMove.Size = new System.Drawing.Size(102, 40);
            this.Btn_PMove.TabIndex = 1;
            this.Btn_PMove.Text = "执行寸动";
            this.Btn_PMove.UseVisualStyleBackColor = true;
            this.Btn_PMove.Click += new System.EventHandler(this.Btn_PMove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "寸动距离：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zmotion的寸动案例";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private RadioButton rad_U;
        private RadioButton rad_Z;
        private RadioButton rad_Y;
        private RadioButton rad_X;
        private GroupBox groupBox2;
        private TextBox txtUnits;
        private TextBox txtAccel;
        private Label label6;
        private Label label3;
        private TextBox txt_Sramp;
        private TextBox txtSpeed;
        private Label label5;
        private TextBox txtDeccl;
        private Label label2;
        private Label label4;
        private TextBox txt_Lspeed;
        private Label label1;
        private GroupBox groupBox1;
        private Panel LED;
        private Button Btn_Init;
        private Button Btn_Connect;
        private Button Btn_ScanIP;
        private ComboBox cmbIps;
        private Label label7;
        private GroupBox groupBox4;
        private TextBox txt_Distance;
        private Label label9;
        private Label label8;
        private Button btn_Stop;
        private Button Btn_Zero;
        private Button Btn_PMove;
        private GroupBox groupBox6;
        private RadioButton radioButton3;
        private RadioButton rad_Rev;
        private GroupBox groupBox5;
        private RadioButton radioButton2;
        private RadioButton rad_Relative;
    }
}