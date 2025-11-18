
namespace ModbusAddressScanner
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            gbSerialConfig = new GroupBox();
            cboStopBits = new ComboBox();
            label5 = new Label();
            cboParity = new ComboBox();
            label4 = new Label();
            cboDataBits = new ComboBox();
            label3 = new Label();
            cboBaudRate = new ComboBox();
            label2 = new Label();
            cboPort = new ComboBox();
            label1 = new Label();
            gbControl = new GroupBox();
            btnStop = new Button();
            btnStart = new Button();
            gbLog = new GroupBox();
            txtLog = new TextBox();
            label6 = new Label();
            tb_readRegisterStart = new TextBox();
            label7 = new Label();
            tb_readRegisterCount = new TextBox();
            gbSerialConfig.SuspendLayout();
            gbControl.SuspendLayout();
            gbLog.SuspendLayout();
            SuspendLayout();
            // 
            // gbSerialConfig
            // 
            gbSerialConfig.Controls.Add(cboStopBits);
            gbSerialConfig.Controls.Add(label5);
            gbSerialConfig.Controls.Add(cboParity);
            gbSerialConfig.Controls.Add(label4);
            gbSerialConfig.Controls.Add(cboDataBits);
            gbSerialConfig.Controls.Add(label3);
            gbSerialConfig.Controls.Add(cboBaudRate);
            gbSerialConfig.Controls.Add(label2);
            gbSerialConfig.Controls.Add(cboPort);
            gbSerialConfig.Controls.Add(label1);
            gbSerialConfig.Location = new Point(12, 12);
            gbSerialConfig.Name = "gbSerialConfig";
            gbSerialConfig.Size = new Size(711, 100);
            gbSerialConfig.TabIndex = 0;
            gbSerialConfig.TabStop = false;
            gbSerialConfig.Text = "串口配置";
            // 
            // cboStopBits
            // 
            cboStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStopBits.Location = new Point(477, 35);
            cboStopBits.Name = "cboStopBits";
            cboStopBits.Size = new Size(80, 25);
            cboStopBits.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 38);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 8;
            label5.Text = "停止位:";
            // 
            // cboParity
            // 
            cboParity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParity.Location = new Point(338, 35);
            cboParity.Name = "cboParity";
            cboParity.Size = new Size(80, 25);
            cboParity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 38);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 6;
            label4.Text = "校验位:";
            // 
            // cboDataBits
            // 
            cboDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDataBits.Location = new Point(199, 35);
            cboDataBits.Name = "cboDataBits";
            cboDataBits.Size = new Size(80, 25);
            cboDataBits.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 38);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 4;
            label3.Text = "数据位:";
            // 
            // cboBaudRate
            // 
            cboBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBaudRate.Location = new Point(60, 66);
            cboBaudRate.Name = "cboBaudRate";
            cboBaudRate.Size = new Size(110, 25);
            cboBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 69);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 2;
            label2.Text = "波特率:";
            // 
            // cboPort
            // 
            cboPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPort.Location = new Point(60, 35);
            cboPort.Name = "cboPort";
            cboPort.Size = new Size(80, 25);
            cboPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 38);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "端口号:";
            // 
            // gbControl
            // 
            gbControl.Controls.Add(tb_readRegisterCount);
            gbControl.Controls.Add(label7);
            gbControl.Controls.Add(tb_readRegisterStart);
            gbControl.Controls.Add(label6);
            gbControl.Controls.Add(btnStop);
            gbControl.Controls.Add(btnStart);
            gbControl.Location = new Point(12, 118);
            gbControl.Name = "gbControl";
            gbControl.Size = new Size(711, 70);
            gbControl.TabIndex = 1;
            gbControl.TabStop = false;
            gbControl.Text = "扫描控制";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(589, 25);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 30);
            btnStop.TabIndex = 1;
            btnStop.Text = "停止扫描";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(477, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 30);
            btnStart.TabIndex = 0;
            btnStart.Text = "开始扫描";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // gbLog
            // 
            gbLog.Controls.Add(txtLog);
            gbLog.Location = new Point(12, 194);
            gbLog.Name = "gbLog";
            gbLog.Size = new Size(711, 220);
            gbLog.TabIndex = 2;
            gbLog.TabStop = false;
            gbLog.Text = "扫描日志";
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLog.Location = new Point(3, 19);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(705, 198);
            txtLog.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 32);
            label6.Name = "label6";
            label6.Size = new Size(164, 17);
            label6.TabIndex = 2;
            label6.Text = "寄存器起始地址（十进制）：";
            // 
            // tb_readRegisterStart
            // 
            tb_readRegisterStart.Location = new Point(177, 29);
            tb_readRegisterStart.Name = "tb_readRegisterStart";
            tb_readRegisterStart.Size = new Size(100, 23);
            tb_readRegisterStart.TabIndex = 3;
            tb_readRegisterStart.Text = "1004";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 32);
            label7.Name = "label7";
            label7.Size = new Size(104, 17);
            label7.TabIndex = 4;
            label7.Text = "读取寄存器长度：";
            // 
            // tb_readRegisterCount
            // 
            tb_readRegisterCount.Location = new Point(393, 29);
            tb_readRegisterCount.Name = "tb_readRegisterCount";
            tb_readRegisterCount.Size = new Size(66, 23);
            tb_readRegisterCount.TabIndex = 5;
            tb_readRegisterCount.Text = "1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 426);
            Controls.Add(gbLog);
            Controls.Add(gbControl);
            Controls.Add(gbSerialConfig);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modbus地址扫描工具";
            FormClosing += MainForm_FormClosing;
            gbSerialConfig.ResumeLayout(false);
            gbSerialConfig.PerformLayout();
            gbControl.ResumeLayout(false);
            gbControl.PerformLayout();
            gbLog.ResumeLayout(false);
            gbLog.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.GroupBox gbSerialConfig;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private Label label7;
        private TextBox tb_readRegisterStart;
        private Label label6;
        private TextBox tb_readRegisterCount;
    }
}