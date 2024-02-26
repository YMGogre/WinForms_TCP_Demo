namespace TCPServer
{
    partial class ClientPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            this.richTextBox_msgBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_all = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer_edit = new System.Windows.Forms.SplitContainer();
            this.richTextBox_msgEditBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sendMsg = new System.Windows.Forms.Button();
            this.btn_clearMsg = new System.Windows.Forms.Button();
            this.chkBox_TimedContinuousTransmission = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerInterval = new System.Windows.Forms.NumericUpDown();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_clientPort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_clientIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_clientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_quickMsg = new System.Windows.Forms.ComboBox();
            this.transmissionTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_edit)).BeginInit();
            this.splitContainer_edit.Panel1.SuspendLayout();
            this.splitContainer_edit.Panel2.SuspendLayout();
            this.splitContainer_edit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Right;
            label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label4.Location = new System.Drawing.Point(76, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(25, 17);
            label4.TabIndex = 1;
            label4.Text = "ms";
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
            this.richTextBox_msgBox.Size = new System.Drawing.Size(595, 272);
            this.richTextBox_msgBox.TabIndex = 0;
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
            this.contextMenuStrip.Size = new System.Drawing.Size(146, 148);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // ToolStripMenuItem_cancel
            // 
            this.ToolStripMenuItem_cancel.Enabled = false;
            this.ToolStripMenuItem_cancel.Name = "ToolStripMenuItem_cancel";
            this.ToolStripMenuItem_cancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ToolStripMenuItem_cancel.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_cancel.Text = "撤销";
            this.ToolStripMenuItem_cancel.Click += new System.EventHandler(this.ToolStripMenuItem_cancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // ToolStripMenuItem_cut
            // 
            this.ToolStripMenuItem_cut.Enabled = false;
            this.ToolStripMenuItem_cut.Name = "ToolStripMenuItem_cut";
            this.ToolStripMenuItem_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItem_cut.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_cut.Text = "剪切";
            this.ToolStripMenuItem_cut.Click += new System.EventHandler(this.ToolStripMenuItem_cut_Click);
            // 
            // ToolStripMenuItem_copy
            // 
            this.ToolStripMenuItem_copy.Enabled = false;
            this.ToolStripMenuItem_copy.Name = "ToolStripMenuItem_copy";
            this.ToolStripMenuItem_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItem_copy.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_copy.Text = "复制";
            this.ToolStripMenuItem_copy.Click += new System.EventHandler(this.ToolStripMenuItem_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Enabled = false;
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_paste.Text = "粘贴";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.ToolStripMenuItem_paste_Click);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Enabled = false;
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_delete.Text = "删除";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // ToolStripMenuItem_all
            // 
            this.ToolStripMenuItem_all.Enabled = false;
            this.ToolStripMenuItem_all.Name = "ToolStripMenuItem_all";
            this.ToolStripMenuItem_all.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItem_all.Size = new System.Drawing.Size(145, 22);
            this.ToolStripMenuItem_all.Text = "全选";
            this.ToolStripMenuItem_all.Click += new System.EventHandler(this.ToolStripMenuItem_all_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_msgBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息栏";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer_edit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑栏";
            // 
            // splitContainer_edit
            // 
            this.splitContainer_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_edit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_edit.Location = new System.Drawing.Point(3, 25);
            this.splitContainer_edit.Name = "splitContainer_edit";
            // 
            // splitContainer_edit.Panel1
            // 
            this.splitContainer_edit.Panel1.Controls.Add(this.richTextBox_msgEditBox);
            // 
            // splitContainer_edit.Panel2
            // 
            this.splitContainer_edit.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer_edit.Size = new System.Drawing.Size(595, 84);
            this.splitContainer_edit.SplitterDistance = 355;
            this.splitContainer_edit.TabIndex = 4;
            // 
            // richTextBox_msgEditBox
            // 
            this.richTextBox_msgEditBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox_msgEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_msgEditBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_msgEditBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_msgEditBox.Name = "richTextBox_msgEditBox";
            this.richTextBox_msgEditBox.Size = new System.Drawing.Size(355, 84);
            this.richTextBox_msgEditBox.TabIndex = 2;
            this.richTextBox_msgEditBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.btn_sendMsg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_clearMsg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkBox_TimedContinuousTransmission, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 84);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_sendMsg
            // 
            this.btn_sendMsg.AutoSize = true;
            this.btn_sendMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sendMsg.Location = new System.Drawing.Point(3, 3);
            this.btn_sendMsg.Name = "btn_sendMsg";
            this.btn_sendMsg.Size = new System.Drawing.Size(123, 36);
            this.btn_sendMsg.TabIndex = 0;
            this.btn_sendMsg.Text = "发    送";
            this.btn_sendMsg.UseVisualStyleBackColor = true;
            this.btn_sendMsg.Click += new System.EventHandler(this.btn_sendMsg_Click);
            // 
            // btn_clearMsg
            // 
            this.btn_clearMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearMsg.Location = new System.Drawing.Point(3, 45);
            this.btn_clearMsg.Name = "btn_clearMsg";
            this.btn_clearMsg.Size = new System.Drawing.Size(123, 36);
            this.btn_clearMsg.TabIndex = 1;
            this.btn_clearMsg.Text = "清空消息栏";
            this.btn_clearMsg.UseVisualStyleBackColor = true;
            this.btn_clearMsg.Click += new System.EventHandler(this.btn_clearMsg_Click);
            // 
            // chkBox_TimedContinuousTransmission
            // 
            this.chkBox_TimedContinuousTransmission.AutoSize = true;
            this.chkBox_TimedContinuousTransmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBox_TimedContinuousTransmission.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_TimedContinuousTransmission.Location = new System.Drawing.Point(132, 3);
            this.chkBox_TimedContinuousTransmission.Name = "chkBox_TimedContinuousTransmission";
            this.chkBox_TimedContinuousTransmission.Size = new System.Drawing.Size(101, 36);
            this.chkBox_TimedContinuousTransmission.TabIndex = 2;
            this.chkBox_TimedContinuousTransmission.Text = "定时连续发送";
            this.chkBox_TimedContinuousTransmission.UseVisualStyleBackColor = true;
            this.chkBox_TimedContinuousTransmission.CheckedChanged += new System.EventHandler(this.chkBox_TimedContinuousTransmission_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timerInterval);
            this.panel1.Controls.Add(label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(132, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 36);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // timerInterval
            // 
            this.timerInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerInterval.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timerInterval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.timerInterval.Location = new System.Drawing.Point(0, 0);
            this.timerInterval.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.timerInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.Size = new System.Drawing.Size(76, 23);
            this.timerInterval.TabIndex = 0;
            this.toolTip.SetToolTip(this.timerInterval, "设置定时器间隔，取值范围 50~120000");
            this.timerInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.timerInterval.ValueChanged += new System.EventHandler(this.timerInterval_ValueChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer.Size = new System.Drawing.Size(601, 416);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Size = new System.Drawing.Size(792, 416);
            this.splitContainer1.SplitterDistance = 601;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_clientPort);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label_clientIP);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_clientName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(188, 358);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "客户端信息";
            // 
            // label_clientPort
            // 
            this.label_clientPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_clientPort.Location = new System.Drawing.Point(2, 184);
            this.label_clientPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clientPort.Name = "label_clientPort";
            this.label_clientPort.Size = new System.Drawing.Size(184, 32);
            this.label_clientPort.TabIndex = 5;
            this.label_clientPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(2, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "客户端端口号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_clientIP
            // 
            this.label_clientIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_clientIP.Location = new System.Drawing.Point(2, 120);
            this.label_clientIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clientIP.Name = "label_clientIP";
            this.label_clientIP.Size = new System.Drawing.Size(184, 32);
            this.label_clientIP.TabIndex = 3;
            this.label_clientIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(2, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户端 IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_clientName
            // 
            this.label_clientName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_clientName.Location = new System.Drawing.Point(2, 56);
            this.label_clientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clientName.Name = "label_clientName";
            this.label_clientName.Size = new System.Drawing.Size(184, 32);
            this.label_clientName.TabIndex = 1;
            this.label_clientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户端名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.comboBox_quickMsg);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(0, 358);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 58);
            this.groupBox6.TabIndex = 6;
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
            this.comboBox_quickMsg.Size = new System.Drawing.Size(182, 29);
            this.comboBox_quickMsg.TabIndex = 1;
            this.comboBox_quickMsg.SelectionChangeCommitted += new System.EventHandler(this.comboBox_quickMsg_SelectionChangeCommitted);
            // 
            // transmissionTimer
            // 
            this.transmissionTimer.Interval = 2000;
            this.transmissionTimer.Tick += new System.EventHandler(this.transmissionTimer_Tick);
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 416);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientPage";
            this.Text = "ClientPage";
            this.Load += new System.EventHandler(this.ClientPage_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer_edit.Panel1.ResumeLayout(false);
            this.splitContainer_edit.Panel2.ResumeLayout(false);
            this.splitContainer_edit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_edit)).EndInit();
            this.splitContainer_edit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerInterval)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_msgBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_msgEditBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_sendMsg;
        private System.Windows.Forms.Button btn_clearMsg;
        private System.Windows.Forms.SplitContainer splitContainer_edit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox_quickMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_clientIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_clientName;
        private System.Windows.Forms.Label label_clientPort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_all;
        private System.Windows.Forms.CheckBox chkBox_TimedContinuousTransmission;
        private System.Windows.Forms.NumericUpDown timerInterval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer transmissionTimer;
        private System.Windows.Forms.ToolTip toolTip;
    }
}