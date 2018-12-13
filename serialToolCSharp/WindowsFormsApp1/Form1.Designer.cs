namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.ccbDb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ccbEO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.cbbbaut = new System.Windows.Forms.ComboBox();
            this.cbbStp = new System.Windows.Forms.ComboBox();
            this.cbbComList = new System.Windows.Forms.ComboBox();
            this.lblmhz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSnd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ComDevice = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblSts = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rb2);
            this.tabPage1.Controls.Add(this.rb1);
            this.tabPage1.Controls.Add(this.lblSts);
            this.tabPage1.Controls.Add(this.txtT);
            this.tabPage1.Controls.Add(this.txtR);
            this.tabPage1.Controls.Add(this.ccbDb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ccbEO);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnClr);
            this.tabPage1.Controls.Add(this.cbbbaut);
            this.tabPage1.Controls.Add(this.cbbStp);
            this.tabPage1.Controls.Add(this.cbbComList);
            this.tabPage1.Controls.Add(this.lblmhz);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.btnSnd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(236, 346);
            this.txtT.Multiline = true;
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(218, 32);
            this.txtT.TabIndex = 126;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(242, 37);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(302, 212);
            this.txtR.TabIndex = 125;
            // 
            // ccbDb
            // 
            this.ccbDb.FormattingEnabled = true;
            this.ccbDb.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.ccbDb.Location = new System.Drawing.Point(106, 119);
            this.ccbDb.Name = "ccbDb";
            this.ccbDb.Size = new System.Drawing.Size(52, 20);
            this.ccbDb.TabIndex = 124;
            this.ccbDb.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 123;
            this.label2.Text = "数据位";
            // 
            // ccbEO
            // 
            this.ccbEO.FormattingEnabled = true;
            this.ccbEO.Items.AddRange(new object[] {
            "无",
            "奇",
            "偶",
            "0",
            "1"});
            this.ccbEO.Location = new System.Drawing.Point(104, 93);
            this.ccbEO.Name = "ccbEO";
            this.ccbEO.Size = new System.Drawing.Size(54, 20);
            this.ccbEO.TabIndex = 122;
            this.ccbEO.Text = "无";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 121;
            this.label3.Text = "奇偶校验";
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(469, 269);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 39);
            this.btnClr.TabIndex = 111;
            this.btnClr.Text = "清空接收";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // cbbbaut
            // 
            this.cbbbaut.FormattingEnabled = true;
            this.cbbbaut.Items.AddRange(new object[] {
            "9600",
            "100000",
            "115200",
            "921600",
            "自定义"});
            this.cbbbaut.Location = new System.Drawing.Point(104, 40);
            this.cbbbaut.Name = "cbbbaut";
            this.cbbbaut.Size = new System.Drawing.Size(77, 20);
            this.cbbbaut.TabIndex = 80;
            this.cbbbaut.Text = "115200";
            // 
            // cbbStp
            // 
            this.cbbStp.FormattingEnabled = true;
            this.cbbStp.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "无"});
            this.cbbStp.Location = new System.Drawing.Point(104, 60);
            this.cbbStp.Name = "cbbStp";
            this.cbbStp.Size = new System.Drawing.Size(54, 20);
            this.cbbStp.TabIndex = 66;
            this.cbbStp.Text = "1";
            // 
            // cbbComList
            // 
            this.cbbComList.FormattingEnabled = true;
            this.cbbComList.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3"});
            this.cbbComList.Location = new System.Drawing.Point(106, 20);
            this.cbbComList.Name = "cbbComList";
            this.cbbComList.Size = new System.Drawing.Size(75, 20);
            this.cbbComList.TabIndex = 63;
            this.cbbComList.Text = "COM0";
            this.cbbComList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbComList_MouseClick_1);
            // 
            // lblmhz
            // 
            this.lblmhz.AutoSize = true;
            this.lblmhz.Location = new System.Drawing.Point(14, 68);
            this.lblmhz.Name = "lblmhz";
            this.lblmhz.Size = new System.Drawing.Size(41, 12);
            this.lblmhz.TabIndex = 60;
            this.lblmhz.Text = "停止位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "波特率";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 56;
            this.btnOpen.Text = "打开端口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnSnd
            // 
            this.btnSnd.Enabled = false;
            this.btnSnd.Location = new System.Drawing.Point(482, 346);
            this.btnSnd.Name = "btnSnd";
            this.btnSnd.Size = new System.Drawing.Size(62, 32);
            this.btnSnd.TabIndex = 54;
            this.btnSnd.Text = "发送16进制";
            this.btnSnd.UseVisualStyleBackColor = true;
            this.btnSnd.Click += new System.EventHandler(this.btnSnd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // ComDevice
            // 
            this.ComDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ComDevice_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblSts
            // 
            this.lblSts.AutoSize = true;
            this.lblSts.Location = new System.Drawing.Point(37, 457);
            this.lblSts.Name = "lblSts";
            this.lblSts.Size = new System.Drawing.Size(41, 12);
            this.lblSts.TabIndex = 127;
            this.lblSts.Text = "数据位";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(63, 202);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(137, 16);
            this.rb1.TabIndex = 128;
            this.rb1.Text = "接收格式 0x4f, 0x98";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Location = new System.Drawing.Point(63, 233);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(113, 16);
            this.rb2.TabIndex = 129;
            this.rb2.TabStop = true;
            this.rb2.Text = "接收格式 4f  98";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 130;
            this.label4.Text = "可输入自定义波特率";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 529);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "串口工具";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbbbaut;
        private System.Windows.Forms.ComboBox cbbComList;
        private System.Windows.Forms.Label lblmhz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSnd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.IO.Ports.SerialPort ComDevice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.ComboBox cbbStp;
        private System.Windows.Forms.ComboBox ccbDb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ccbEO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label lblSts;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label4;
    }
}

