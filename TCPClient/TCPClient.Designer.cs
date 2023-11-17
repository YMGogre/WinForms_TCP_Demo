namespace TCPClient
{
    partial class TCPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCPClient));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox_msgBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox_msgEditBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sendMsg = new System.Windows.Forms.Button();
            this.btn_clearMsg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_codec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_hostPort = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddrInputer_hostIP = new WindowsFormsControlLibraryMadeByXJY.IPAddrInputer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_quickMsg = new System.Windows.Forms.ComboBox();
            this.btn_addQuickMsg = new System.Windows.Forms.Label();
            this.btn_openCurrDir = new System.Windows.Forms.Label();
            this.toolTip_addQuickMsg = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_scrollToCaret = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_clearEditBoxAfterSend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_saveServerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_all = new System.Windows.Forms.ToolStripMenuItem();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.panel1);
            splitContainer1.Size = new System.Drawing.Size(928, 511);
            splitContainer1.SplitterDistance = 665;
            splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(this.groupBox3);
            splitContainer2.Size = new System.Drawing.Size(665, 511);
            splitContainer2.SplitterDistance = 379;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox_msgBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(665, 379);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "消息栏";
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
            this.richTextBox_msgBox.Size = new System.Drawing.Size(659, 351);
            this.richTextBox_msgBox.TabIndex = 1;
            this.richTextBox_msgBox.Text = "";
            this.richTextBox_msgBox.TextChanged += new System.EventHandler(this.richTextBox_msgBox_TextChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_cancel,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_cut,
            this.ToolStripMenuItem_copy,
            this.ToolStripMenuItem_paste,
            this.ToolStripMenuItem_delete,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_all});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 170);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // ToolStripMenuItem_cancel
            // 
            this.ToolStripMenuItem_cancel.Enabled = false;
            this.ToolStripMenuItem_cancel.Name = "ToolStripMenuItem_cancel";
            this.ToolStripMenuItem_cancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ToolStripMenuItem_cancel.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_cancel.Text = "撤销";
            this.ToolStripMenuItem_cancel.Click += new System.EventHandler(this.ToolStripMenuItem_cancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItem_cut
            // 
            this.ToolStripMenuItem_cut.Enabled = false;
            this.ToolStripMenuItem_cut.Name = "ToolStripMenuItem_cut";
            this.ToolStripMenuItem_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItem_cut.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_cut.Text = "剪切";
            this.ToolStripMenuItem_cut.Click += new System.EventHandler(this.ToolStripMenuItem_cut_Click);
            // 
            // ToolStripMenuItem_copy
            // 
            this.ToolStripMenuItem_copy.Enabled = false;
            this.ToolStripMenuItem_copy.Name = "ToolStripMenuItem_copy";
            this.ToolStripMenuItem_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItem_copy.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_copy.Text = "复制";
            this.ToolStripMenuItem_copy.Click += new System.EventHandler(this.ToolStripMenuItem_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Enabled = false;
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_paste.Text = "粘贴";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.ToolStripMenuItem_paste_Click);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Enabled = false;
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_delete.Text = "删除";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox_msgEditBox);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 128);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "编辑栏";
            // 
            // richTextBox_msgEditBox
            // 
            this.richTextBox_msgEditBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox_msgEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_msgEditBox.Location = new System.Drawing.Point(3, 25);
            this.richTextBox_msgEditBox.Name = "richTextBox_msgEditBox";
            this.richTextBox_msgEditBox.Size = new System.Drawing.Size(526, 100);
            this.richTextBox_msgEditBox.TabIndex = 1;
            this.richTextBox_msgEditBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_sendMsg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clearMsg, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(529, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_sendMsg
            // 
            this.btn_sendMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sendMsg.Location = new System.Drawing.Point(3, 3);
            this.btn_sendMsg.Name = "btn_sendMsg";
            this.btn_sendMsg.Size = new System.Drawing.Size(127, 44);
            this.btn_sendMsg.TabIndex = 0;
            this.btn_sendMsg.Text = "发送";
            this.btn_sendMsg.UseVisualStyleBackColor = true;
            this.btn_sendMsg.Click += new System.EventHandler(this.btn_sendMsg_Click);
            // 
            // btn_clearMsg
            // 
            this.btn_clearMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearMsg.Location = new System.Drawing.Point(3, 53);
            this.btn_clearMsg.Name = "btn_clearMsg";
            this.btn_clearMsg.Size = new System.Drawing.Size(127, 44);
            this.btn_clearMsg.TabIndex = 1;
            this.btn_clearMsg.Text = "清空消息栏";
            this.btn_clearMsg.UseVisualStyleBackColor = true;
            this.btn_clearMsg.Click += new System.EventHandler(this.btn_clearMsg_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 511);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务端配置";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_codec, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBox_hostPort, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ipAddrInputer_hostIP, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(253, 116);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP 地址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_codec
            // 
            this.comboBox_codec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_codec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_codec.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_codec.FormattingEnabled = true;
            this.comboBox_codec.Items.AddRange(new object[] {
            "原数据直接编码(UTF-8)",
            "增加 4 字节包头(UTF-8)"});
            this.comboBox_codec.Location = new System.Drawing.Point(98, 78);
            this.comboBox_codec.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_codec.Name = "comboBox_codec";
            this.comboBox_codec.Size = new System.Drawing.Size(153, 29);
            this.comboBox_codec.TabIndex = 9;
            this.comboBox_codec.SelectionChangeCommitted += new System.EventHandler(this.comboBox_codec_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox_hostPort
            // 
            this.maskedTextBox_hostPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox_hostPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maskedTextBox_hostPort.Location = new System.Drawing.Point(99, 41);
            this.maskedTextBox_hostPort.Mask = "00000";
            this.maskedTextBox_hostPort.Name = "maskedTextBox_hostPort";
            this.maskedTextBox_hostPort.PromptChar = ' ';
            this.maskedTextBox_hostPort.Size = new System.Drawing.Size(151, 29);
            this.maskedTextBox_hostPort.TabIndex = 3;
            this.maskedTextBox_hostPort.Text = "54600";
            this.maskedTextBox_hostPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_hostPort.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_hostPort_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "编解码器：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ipAddrInputer_hostIP
            // 
            this.ipAddrInputer_hostIP.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddrInputer_hostIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipAddrInputer_hostIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipAddrInputer_hostIP.EnableLoopbackAddr = true;
            this.ipAddrInputer_hostIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipAddrInputer_hostIP.Location = new System.Drawing.Point(99, 3);
            this.ipAddrInputer_hostIP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.ipAddrInputer_hostIP.Name = "ipAddrInputer_hostIP";
            this.ipAddrInputer_hostIP.Size = new System.Drawing.Size(151, 31);
            this.ipAddrInputer_hostIP.TabIndex = 0;
            this.ipAddrInputer_hostIP.Validating += new System.ComponentModel.CancelEventHandler(this.ipAddrInputer_hostIP_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_connect);
            this.panel2.Controls.Add(this.btn_disconnect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 58);
            this.panel2.TabIndex = 10;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(10, 9);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(93, 31);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Location = new System.Drawing.Point(153, 9);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(93, 31);
            this.btn_disconnect.TabIndex = 7;
            this.btn_disconnect.Text = "断开连接";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox_quickMsg);
            this.groupBox2.Controls.Add(this.btn_addQuickMsg);
            this.groupBox2.Controls.Add(this.btn_openCurrDir);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快捷消息";
            // 
            // comboBox_quickMsg
            // 
            this.comboBox_quickMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_quickMsg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_quickMsg.FormattingEnabled = true;
            this.comboBox_quickMsg.Location = new System.Drawing.Point(3, 25);
            this.comboBox_quickMsg.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_quickMsg.Name = "comboBox_quickMsg";
            this.comboBox_quickMsg.Size = new System.Drawing.Size(193, 29);
            this.comboBox_quickMsg.TabIndex = 1;
            this.comboBox_quickMsg.SelectionChangeCommitted += new System.EventHandler(this.comboBox_quickMsg_SelectionChangeCommitted);
            // 
            // btn_addQuickMsg
            // 
            this.btn_addQuickMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_addQuickMsg.Image = global::TCPClient.Properties.Resources._3_Add;
            this.btn_addQuickMsg.Location = new System.Drawing.Point(196, 25);
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
            this.btn_openCurrDir.Image = global::TCPClient.Properties.Resources._4_folder;
            this.btn_openCurrDir.Location = new System.Drawing.Point(226, 25);
            this.btn_openCurrDir.Name = "btn_openCurrDir";
            this.btn_openCurrDir.Size = new System.Drawing.Size(30, 30);
            this.btn_openCurrDir.TabIndex = 2;
            this.toolTip_addQuickMsg.SetToolTip(this.btn_openCurrDir, "浏览当前工作目录");
            this.btn_openCurrDir.Click += new System.EventHandler(this.btn_openCurrDir_Click);
            this.btn_openCurrDir.MouseEnter += new System.EventHandler(this.btn_openCurrDir_MouseEnter);
            this.btn_openCurrDir.MouseLeave += new System.EventHandler(this.btn_openCurrDir_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_scrollToCaret,
            this.tsmi_clearEditBoxAfterSend,
            this.tsmi_saveServerConfig});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
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
            // 
            // tsmi_clearEditBoxAfterSend
            // 
            this.tsmi_clearEditBoxAfterSend.Checked = true;
            this.tsmi_clearEditBoxAfterSend.CheckOnClick = true;
            this.tsmi_clearEditBoxAfterSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_clearEditBoxAfterSend.Name = "tsmi_clearEditBoxAfterSend";
            this.tsmi_clearEditBoxAfterSend.Size = new System.Drawing.Size(220, 22);
            this.tsmi_clearEditBoxAfterSend.Text = "发送消息后清空编辑栏";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItem_all
            // 
            this.ToolStripMenuItem_all.Enabled = false;
            this.ToolStripMenuItem_all.Name = "ToolStripMenuItem_all";
            this.ToolStripMenuItem_all.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItem_all.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_all.Text = "全选";
            this.ToolStripMenuItem_all.Click += new System.EventHandler(this.ToolStripMenuItem_all_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 536);
            this.Controls.Add(splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TCPClient";
            this.Text = "TCP 客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TCPClient_FormClosing);
            this.Load += new System.EventHandler(this.TCPClient_Load);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_hostPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_quickMsg;
        private System.Windows.Forms.Label btn_addQuickMsg;
        private System.Windows.Forms.ToolTip toolTip_addQuickMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_msgEditBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_sendMsg;
        private System.Windows.Forms.Button btn_clearMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_codec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox_msgBox;
        private System.Windows.Forms.Label btn_openCurrDir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_scrollToCaret;
        private System.Windows.Forms.ToolStripMenuItem tsmi_clearEditBoxAfterSend;
        private System.Windows.Forms.ToolStripMenuItem tsmi_saveServerConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private WindowsFormsControlLibraryMadeByXJY.IPAddrInputer ipAddrInputer_hostIP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_all;
    }
}

