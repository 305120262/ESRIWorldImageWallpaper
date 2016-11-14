namespace ESRIWorldImageWallpaper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xmintbx = new System.Windows.Forms.TextBox();
            this.ymintbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ymaxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xmaxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametbx = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.periodiccbx = new System.Windows.Forms.CheckBox();
            this.namecbx = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.favoritecbx = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Set and Share";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "xmin";
            // 
            // xmintbx
            // 
            this.xmintbx.Location = new System.Drawing.Point(109, 26);
            this.xmintbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xmintbx.Name = "xmintbx";
            this.xmintbx.Size = new System.Drawing.Size(156, 25);
            this.xmintbx.TabIndex = 3;
            this.xmintbx.Text = "114.318895308";
            // 
            // ymintbx
            // 
            this.ymintbx.Location = new System.Drawing.Point(109, 89);
            this.ymintbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ymintbx.Name = "ymintbx";
            this.ymintbx.Size = new System.Drawing.Size(156, 25);
            this.ymintbx.TabIndex = 5;
            this.ymintbx.Text = "36.0909887004";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ymin";
            // 
            // ymaxtbx
            // 
            this.ymaxtbx.Location = new System.Drawing.Point(379, 89);
            this.ymaxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ymaxtbx.Name = "ymaxtbx";
            this.ymaxtbx.Size = new System.Drawing.Size(146, 25);
            this.ymaxtbx.TabIndex = 7;
            this.ymaxtbx.Text = "36.10901";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ymax";
            // 
            // xmaxtbx
            // 
            this.xmaxtbx.Location = new System.Drawing.Point(379, 26);
            this.xmaxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xmaxtbx.Name = "xmaxtbx";
            this.xmaxtbx.Size = new System.Drawing.Size(146, 25);
            this.xmaxtbx.TabIndex = 9;
            this.xmaxtbx.Text = "114.341104691";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "xmax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Place Name";
            // 
            // nametbx
            // 
            this.nametbx.Location = new System.Drawing.Point(109, 160);
            this.nametbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nametbx.Name = "nametbx";
            this.nametbx.Size = new System.Drawing.Size(156, 25);
            this.nametbx.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 162);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Pick on Map";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // periodiccbx
            // 
            this.periodiccbx.AutoSize = true;
            this.periodiccbx.Checked = true;
            this.periodiccbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.periodiccbx.Location = new System.Drawing.Point(28, 38);
            this.periodiccbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.periodiccbx.Name = "periodiccbx";
            this.periodiccbx.Size = new System.Drawing.Size(270, 22);
            this.periodiccbx.TabIndex = 11;
            this.periodiccbx.Text = "Change Periodicly (10 minutes)";
            this.periodiccbx.UseVisualStyleBackColor = true;
            this.periodiccbx.CheckedChanged += new System.EventHandler(this.periodiccbx_CheckedChanged);
            // 
            // namecbx
            // 
            this.namecbx.AutoSize = true;
            this.namecbx.Checked = true;
            this.namecbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.namecbx.Location = new System.Drawing.Point(28, 104);
            this.namecbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namecbx.Name = "namecbx";
            this.namecbx.Size = new System.Drawing.Size(150, 22);
            this.namecbx.TabIndex = 12;
            this.namecbx.Text = "Show Place Name";
            this.namecbx.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "ESRIWorldImageWallpaper";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ESRIWorldImageWallpaper";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hideToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 100);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 24);
            this.toolStripMenuItem1.Text = "&SetWallpaper";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.hideToolStripMenuItem.Text = "&HideSetting";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 24);
            this.toolStripMenuItem3.Text = "&MarkFavorite";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 24);
            this.toolStripMenuItem2.Text = "&Exit";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // favoritecbx
            // 
            this.favoritecbx.AutoSize = true;
            this.favoritecbx.Location = new System.Drawing.Point(28, 162);
            this.favoritecbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.favoritecbx.Name = "favoritecbx";
            this.favoritecbx.Size = new System.Drawing.Size(190, 22);
            this.favoritecbx.TabIndex = 13;
            this.favoritecbx.Text = "Pick From MyFavorite";
            this.favoritecbx.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 350);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.periodiccbx);
            this.tabPage1.Controls.Add(this.favoritecbx);
            this.tabPage1.Controls.Add(this.namecbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(538, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nametbx);
            this.tabPage2.Controls.Add(this.ymintbx);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.xmintbx);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.xmaxtbx);
            this.tabPage2.Controls.Add(this.ymaxtbx);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(538, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 380);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ESRI World Image Wallpaper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xmintbx;
        private System.Windows.Forms.TextBox ymintbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ymaxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xmaxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox periodiccbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametbx;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox namecbx;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.CheckBox favoritecbx;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

