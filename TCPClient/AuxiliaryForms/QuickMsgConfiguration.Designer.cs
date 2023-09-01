namespace TCPClient
{
    partial class QuickMsgConfiguration
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.watermarkTextBox_name = new WindowsFormsControlLibraryMadeByXJY.WatermarkTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoSize = true;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Image = global::TCPClient.Properties.Resources._2_Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(283, 8);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 38);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.AutoSize = true;
            this.btn_OK.Enabled = false;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Image = global::TCPClient.Properties.Resources._1_OK;
            this.btn_OK.Location = new System.Drawing.Point(391, 8);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(91, 38);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "确定";
            this.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 52);
            this.panel1.TabIndex = 17;
            // 
            // watermarkTextBox_name
            // 
            this.watermarkTextBox_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.watermarkTextBox_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.watermarkTextBox_name.Location = new System.Drawing.Point(3, 3);
            this.watermarkTextBox_name.Name = "watermarkTextBox_name";
            this.watermarkTextBox_name.Size = new System.Drawing.Size(489, 34);
            this.watermarkTextBox_name.TabIndex = 18;
            this.watermarkTextBox_name.WaterMarkFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.watermarkTextBox_name.WaterMarkLocation = new System.Drawing.Point(2, 7);
            this.watermarkTextBox_name.WaterText = "快捷消息名称";
            this.watermarkTextBox_name.TextChanged += new System.EventHandler(this.watermarkTextBox_name_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_message);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 233);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快捷消息内容";
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_message.Location = new System.Drawing.Point(3, 30);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.Size = new System.Drawing.Size(483, 200);
            this.richTextBox_message.TabIndex = 0;
            this.richTextBox_message.Text = "";
            // 
            // QuickMsgConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 325);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.watermarkTextBox_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QuickMsgConfiguration";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "快捷消息配置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibraryMadeByXJY.WatermarkTextBox watermarkTextBox_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_message;
    }
}