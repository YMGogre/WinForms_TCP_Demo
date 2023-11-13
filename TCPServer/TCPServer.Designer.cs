﻿namespace TCPServer
{
    partial class TCPServer
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
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.SplitContainer splitContainer2;
            System.Windows.Forms.SplitContainer splitContainer3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPServer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_logBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox_msgBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox_msgEditBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_broadcastMsg = new System.Windows.Forms.Button();
            this.btn_clearMsg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_quickMsg = new System.Windows.Forms.ComboBox();
            this.btn_addQuickMsg = new System.Windows.Forms.Label();
            this.btn_openCurrDir = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipAddrInputer_hostIP = new WindowsFormsControlLibraryMadeByXJY.IPAddrInputer();
            this.btn_startListen = new System.Windows.Forms.Button();
            this.maskedTextBox_hostPort = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolTip_addQuickMsg = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_scrollToCaret = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_clearEditBoxAfterSend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_saveServerConfig = new System.Windows.Forms.ToolStripMenuItem();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer3)).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.groupBox5);
            splitContainer1.Size = new System.Drawing.Size(675, 369);
            splitContainer1.SplitterDistance = 223;
            splitContainer1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_logBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 369);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志栏";
            // 
            // richTextBox_logBox
            // 
            this.richTextBox_logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_logBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_logBox.Location = new System.Drawing.Point(3, 25);
            this.richTextBox_logBox.Name = "richTextBox_logBox";
            this.richTextBox_logBox.Size = new System.Drawing.Size(217, 341);
            this.richTextBox_logBox.TabIndex = 1;
            this.richTextBox_logBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox_msgBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 369);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "消息栏";
            // 
            // richTextBox_msgBox
            // 
            this.richTextBox_msgBox.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_msgBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox_msgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_msgBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_msgBox.Location = new System.Drawing.Point(3, 25);
            this.richTextBox_msgBox.Name = "richTextBox_msgBox";
            this.richTextBox_msgBox.ReadOnly = true;
            this.richTextBox_msgBox.Size = new System.Drawing.Size(442, 341);
            this.richTextBox_msgBox.TabIndex = 1;
            this.richTextBox_msgBox.Text = "";
            this.richTextBox_msgBox.TextChanged += new System.EventHandler(this.richTextBox_msgBox_TextChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_cut,
            this.ToolStripMenuItem_copy,
            this.ToolStripMenuItem_paste});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 70);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // ToolStripMenuItem_cut
            // 
            this.ToolStripMenuItem_cut.Enabled = false;
            this.ToolStripMenuItem_cut.Name = "ToolStripMenuItem_cut";
            this.ToolStripMenuItem_cut.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_cut.Text = "剪切";
            this.ToolStripMenuItem_cut.Click += new System.EventHandler(this.ToolStripMenuItem_cut_Click);
            // 
            // ToolStripMenuItem_copy
            // 
            this.ToolStripMenuItem_copy.Enabled = false;
            this.ToolStripMenuItem_copy.Name = "ToolStripMenuItem_copy";
            this.ToolStripMenuItem_copy.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_copy.Text = "复制";
            this.ToolStripMenuItem_copy.Click += new System.EventHandler(this.ToolStripMenuItem_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Enabled = false;
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_paste.Text = "粘贴";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.ToolStripMenuItem_paste_Click);
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(this.panel1);
            splitContainer2.Size = new System.Drawing.Size(943, 477);
            splitContainer2.SplitterDistance = 675;
            splitContainer2.TabIndex = 10;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(this.groupBox4);
            splitContainer3.Size = new System.Drawing.Size(675, 477);
            splitContainer3.SplitterDistance = 369;
            splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox_msgEditBox);
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 104);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "编辑栏";
            // 
            // richTextBox_msgEditBox
            // 
            this.richTextBox_msgEditBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox_msgEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_msgEditBox.Location = new System.Drawing.Point(3, 25);
            this.richTextBox_msgEditBox.Name = "richTextBox_msgEditBox";
            this.richTextBox_msgEditBox.Size = new System.Drawing.Size(536, 76);
            this.richTextBox_msgEditBox.TabIndex = 1;
            this.richTextBox_msgEditBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_broadcastMsg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clearMsg, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(539, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_broadcastMsg
            // 
            this.btn_broadcastMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_broadcastMsg.Location = new System.Drawing.Point(3, 3);
            this.btn_broadcastMsg.Name = "btn_broadcastMsg";
            this.btn_broadcastMsg.Size = new System.Drawing.Size(127, 32);
            this.btn_broadcastMsg.TabIndex = 0;
            this.btn_broadcastMsg.Text = "广播发送";
            this.btn_broadcastMsg.UseVisualStyleBackColor = true;
            this.btn_broadcastMsg.Click += new System.EventHandler(this.btn_broadcastMsg_Click);
            // 
            // btn_clearMsg
            // 
            this.btn_clearMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearMsg.Location = new System.Drawing.Point(3, 41);
            this.btn_clearMsg.Name = "btn_clearMsg";
            this.btn_clearMsg.Size = new System.Drawing.Size(127, 32);
            this.btn_clearMsg.TabIndex = 1;
            this.btn_clearMsg.Text = "清空消息栏";
            this.btn_clearMsg.UseVisualStyleBackColor = true;
            this.btn_clearMsg.Click += new System.EventHandler(this.btn_clearMsg_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 477);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_clients);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 250);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "客户端列表";
            // 
            // listBox_clients
            // 
            this.listBox_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_clients.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.ItemHeight = 17;
            this.listBox_clients.Location = new System.Drawing.Point(3, 25);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(258, 222);
            this.listBox_clients.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.comboBox_quickMsg);
            this.groupBox6.Controls.Add(this.btn_addQuickMsg);
            this.groupBox6.Controls.Add(this.btn_openCurrDir);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(0, 419);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(264, 58);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "快捷消息";
            // 
            // comboBox_quickMsg
            // 
            this.comboBox_quickMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_quickMsg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_quickMsg.FormattingEnabled = true;
            this.comboBox_quickMsg.Location = new System.Drawing.Point(3, 25);
            this.comboBox_quickMsg.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_quickMsg.Name = "comboBox_quickMsg";
            this.comboBox_quickMsg.Size = new System.Drawing.Size(198, 29);
            this.comboBox_quickMsg.TabIndex = 1;
            this.comboBox_quickMsg.SelectionChangeCommitted += new System.EventHandler(this.comboBox_quickMsg_SelectionChangeCommitted);
            // 
            // btn_addQuickMsg
            // 
            this.btn_addQuickMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_addQuickMsg.Image = global::TCPServer.Properties.Resources._3_Add;
            this.btn_addQuickMsg.Location = new System.Drawing.Point(201, 25);
            this.btn_addQuickMsg.Name = "btn_addQuickMsg";
            this.btn_addQuickMsg.Size = new System.Drawing.Size(30, 30);
            this.btn_addQuickMsg.TabIndex = 0;
            this.toolTip_addQuickMsg.SetToolTip(this.btn_addQuickMsg, "添加快捷消息");
            this.btn_addQuickMsg.Click += new System.EventHandler(this.btn_addQuickMsg_Click);
            this.btn_addQuickMsg.MouseEnter += new System.EventHandler(this.btn_addQuickMsg_MouseEnter);
            this.btn_addQuickMsg.MouseLeave += new System.EventHandler(this.btn_addQuickMsg_MouseLeave);
            // 
            // btn_openCurrDir
            // 
            this.btn_openCurrDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_openCurrDir.Image = global::TCPServer.Properties.Resources._4_folder;
            this.btn_openCurrDir.Location = new System.Drawing.Point(231, 25);
            this.btn_openCurrDir.Name = "btn_openCurrDir";
            this.btn_openCurrDir.Size = new System.Drawing.Size(30, 30);
            this.btn_openCurrDir.TabIndex = 2;
            this.toolTip_addQuickMsg.SetToolTip(this.btn_openCurrDir, "浏览当前工作目录");
            this.btn_openCurrDir.Click += new System.EventHandler(this.btn_openCurrDir_Click);
            this.btn_openCurrDir.MouseEnter += new System.EventHandler(this.btn_openCurrDir_MouseEnter);
            this.btn_openCurrDir.MouseLeave += new System.EventHandler(this.btn_openCurrDir_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipAddrInputer_hostIP);
            this.groupBox1.Controls.Add(this.btn_startListen);
            this.groupBox1.Controls.Add(this.maskedTextBox_hostPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务端配置";
            // 
            // ipAddrInputer_hostIP
            // 
            this.ipAddrInputer_hostIP.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddrInputer_hostIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipAddrInputer_hostIP.EnableLoopbackAddr = true;
            this.ipAddrInputer_hostIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipAddrInputer_hostIP.Location = new System.Drawing.Point(99, 76);
            this.ipAddrInputer_hostIP.Margin = new System.Windows.Forms.Padding(0);
            this.ipAddrInputer_hostIP.Name = "ipAddrInputer_hostIP";
            this.ipAddrInputer_hostIP.Size = new System.Drawing.Size(153, 29);
            this.ipAddrInputer_hostIP.TabIndex = 7;
            this.ipAddrInputer_hostIP.Validating += new System.ComponentModel.CancelEventHandler(this.ipAddrInputer_hostIP_Validating);
            // 
            // btn_startListen
            // 
            this.btn_startListen.Location = new System.Drawing.Point(99, 40);
            this.btn_startListen.Name = "btn_startListen";
            this.btn_startListen.Size = new System.Drawing.Size(93, 31);
            this.btn_startListen.TabIndex = 6;
            this.btn_startListen.Text = "开始监听";
            this.btn_startListen.UseVisualStyleBackColor = true;
            this.btn_startListen.Click += new System.EventHandler(this.btn_startListen_Click);
            // 
            // maskedTextBox_hostPort
            // 
            this.maskedTextBox_hostPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskedTextBox_hostPort.Location = new System.Drawing.Point(99, 112);
            this.maskedTextBox_hostPort.Mask = "00000";
            this.maskedTextBox_hostPort.Name = "maskedTextBox_hostPort";
            this.maskedTextBox_hostPort.PromptChar = ' ';
            this.maskedTextBox_hostPort.Size = new System.Drawing.Size(153, 29);
            this.maskedTextBox_hostPort.TabIndex = 3;
            this.maskedTextBox_hostPort.Text = "54600";
            this.maskedTextBox_hostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_hostPort.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_port_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP 地址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(957, 517);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_scrollToCaret,
            this.tsmi_clearEditBoxAfterSend,
            this.tsmi_saveServerConfig});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "选项";
            // 
            // tsmi_scrollToCaret
            // 
            this.tsmi_scrollToCaret.CheckOnClick = true;
            this.tsmi_scrollToCaret.Name = "tsmi_scrollToCaret";
            this.tsmi_scrollToCaret.Size = new System.Drawing.Size(220, 22);
            this.tsmi_scrollToCaret.Text = "消息栏总是定位到最新一行";
            this.tsmi_scrollToCaret.CheckedChanged += new System.EventHandler(this.tsmi_scrollToCaret_CheckedChanged);
            // 
            // tsmi_clearEditBoxAfterSend
            // 
            this.tsmi_clearEditBoxAfterSend.Checked = true;
            this.tsmi_clearEditBoxAfterSend.CheckOnClick = true;
            this.tsmi_clearEditBoxAfterSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_clearEditBoxAfterSend.Name = "tsmi_clearEditBoxAfterSend";
            this.tsmi_clearEditBoxAfterSend.Size = new System.Drawing.Size(220, 22);
            this.tsmi_clearEditBoxAfterSend.Text = "发送消息后清空编辑栏";
            this.tsmi_clearEditBoxAfterSend.CheckedChanged += new System.EventHandler(this.tsmi_clearEditBoxAfterSend_CheckedChanged);
            // 
            // tsmi_saveServerConfig
            // 
            this.tsmi_saveServerConfig.Checked = true;
            this.tsmi_saveServerConfig.CheckOnClick = true;
            this.tsmi_saveServerConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_saveServerConfig.Name = "tsmi_saveServerConfig";
            this.tsmi_saveServerConfig.Size = new System.Drawing.Size(220, 22);
            this.tsmi_saveServerConfig.Text = "保存服务端配置";
            this.tsmi_saveServerConfig.ToolTipText = "在应用程序关闭时保存服务端 IP 地址和端口号";
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 542);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TCPServer";
            this.Text = "TCP 服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TCPServer_FormClosing);
            this.Load += new System.EventHandler(this.TCPServer_Load);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer3)).EndInit();
            splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_hostPort;
        private System.Windows.Forms.Button btn_startListen;
        private System.Windows.Forms.RichTextBox richTextBox_logBox;
        private System.Windows.Forms.ListBox listBox_clients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_broadcastMsg;
        private System.Windows.Forms.Button btn_clearMsg;
        private System.Windows.Forms.RichTextBox richTextBox_msgEditBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox_msgBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label btn_addQuickMsg;
        private System.Windows.Forms.ComboBox comboBox_quickMsg;
        private System.Windows.Forms.ToolTip toolTip_addQuickMsg;
        private System.Windows.Forms.Label btn_openCurrDir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_scrollToCaret;
        private System.Windows.Forms.ToolStripMenuItem tsmi_clearEditBoxAfterSend;
        private System.Windows.Forms.ToolStripMenuItem tsmi_saveServerConfig;
        private WindowsFormsControlLibraryMadeByXJY.IPAddrInputer ipAddrInputer_hostIP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
    }
}

