namespace _2_JogMove
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LED = new System.Windows.Forms.Panel();
            this.Btn_Init = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_ScanIP = new System.Windows.Forms.Button();
            this.cmbIps = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_U = new System.Windows.Forms.RadioButton();
            this.rad_Z = new System.Windows.Forms.RadioButton();
            this.rad_Y = new System.Windows.Forms.RadioButton();
            this.rad_X = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Right = new System.Windows.Forms.Button();
            this.Btn_Left = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 0;
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
            this.groupBox2.TabIndex = 0;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_U);
            this.groupBox3.Controls.Add(this.rad_Z);
            this.groupBox3.Controls.Add(this.rad_Y);
            this.groupBox3.Controls.Add(this.rad_X);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 73);
            this.groupBox3.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Right);
            this.groupBox4.Controls.Add(this.Btn_Left);
            this.groupBox4.Location = new System.Drawing.Point(12, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 84);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "点动控制";
            // 
            // Btn_Right
            // 
            this.Btn_Right.Location = new System.Drawing.Point(408, 26);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(216, 43);
            this.Btn_Right.TabIndex = 0;
            this.Btn_Right.Text = "向右";
            this.Btn_Right.UseVisualStyleBackColor = true;
            this.Btn_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Right_MouseDown);
            this.Btn_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Left_MouseUp);
            // 
            // Btn_Left
            // 
            this.Btn_Left.Location = new System.Drawing.Point(115, 26);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(200, 43);
            this.Btn_Left.TabIndex = 0;
            this.Btn_Left.Text = "向左";
            this.Btn_Left.UseVisualStyleBackColor = true;
            this.Btn_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Left_MouseDown);
            this.Btn_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Left_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zmotion点动案例";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rad_U;
        private RadioButton rad_Z;
        private RadioButton rad_Y;
        private RadioButton rad_X;
        private GroupBox groupBox4;
        private Button Btn_Right;
        private Button Btn_Left;
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
        private Button Btn_ScanIP;
        private ComboBox cmbIps;
        private Label label7;
        private Panel LED;
        private Button Btn_Connect;
        private Button Btn_Init;
    }
}