namespace MRGTools
{
    partial class Note
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            System.Drawing.Imaging.ImageAttributes imageAttributes1 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes2 = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ImageAttributes imageAttributes3 = new System.Drawing.Imaging.ImageAttributes();
            this.layeredButton1 = new LayeredSkin.Controls.LayeredButton();
            this.layeredButton2 = new LayeredSkin.Controls.LayeredButton();
            this.layeredTextBox1 = new LayeredSkin.Controls.LayeredTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layeredButton1
            // 
            this.layeredButton1.AdaptImage = true;
            this.layeredButton1.BackColor = System.Drawing.Color.Transparent;
            this.layeredButton1.BaseColor = System.Drawing.Color.Wheat;
            this.layeredButton1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredButton1.Canvas")));
            this.layeredButton1.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredButton1.HaloColor = System.Drawing.Color.White;
            this.layeredButton1.HaloSize = 5;
            this.layeredButton1.HoverImage = null;
            this.layeredButton1.ImageAttribute = imageAttributes1;
            this.layeredButton1.Location = new System.Drawing.Point(252, 12);
            this.layeredButton1.Name = "layeredButton1";
            this.layeredButton1.NormalImage = null;
            this.layeredButton1.PressedImage = null;
            this.layeredButton1.Size = new System.Drawing.Size(20, 20);
            this.layeredButton1.TabIndex = 0;
            this.layeredButton1.Text = "X";
            this.layeredButton1.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.layeredButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.layeredButton1.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.layeredButton1.Click += new System.EventHandler(this.CloseWindow);
            // 
            // layeredButton2
            // 
            this.layeredButton2.AdaptImage = true;
            this.layeredButton2.BackColor = System.Drawing.Color.Transparent;
            this.layeredButton2.BaseColor = System.Drawing.Color.Wheat;
            this.layeredButton2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredButton2.Canvas")));
            this.layeredButton2.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredButton2.HaloColor = System.Drawing.Color.White;
            this.layeredButton2.HaloSize = 5;
            this.layeredButton2.HoverImage = null;
            this.layeredButton2.ImageAttribute = imageAttributes2;
            this.layeredButton2.Location = new System.Drawing.Point(226, 12);
            this.layeredButton2.Name = "layeredButton2";
            this.layeredButton2.NormalImage = null;
            this.layeredButton2.PressedImage = null;
            this.layeredButton2.Size = new System.Drawing.Size(20, 20);
            this.layeredButton2.TabIndex = 1;
            this.layeredButton2.Text = "_";
            this.layeredButton2.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.layeredButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.layeredButton2.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.layeredButton2.Click += new System.EventHandler(this.MinimizeWindow);
            // 
            // layeredTextBox1
            // 
            this.layeredTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.layeredTextBox1.BorderColor = System.Drawing.Color.Empty;
            this.layeredTextBox1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredTextBox1.Canvas")));
            this.layeredTextBox1.ImageAttribute = imageAttributes3;
            this.layeredTextBox1.Location = new System.Drawing.Point(12, 38);
            this.layeredTextBox1.Multiline = true;
            this.layeredTextBox1.Name = "layeredTextBox1";
            this.layeredTextBox1.Size = new System.Drawing.Size(260, 211);
            this.layeredTextBox1.TabIndex = 2;
            this.layeredTextBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.layeredTextBox1.WaterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredTextBox1.WaterText = "";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnNotifyIconDoubleClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.OnShowToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItem_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.CaptionShowMode = LayeredSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.layeredTextBox1);
            this.Controls.Add(this.layeredButton2);
            this.Controls.Add(this.layeredButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Note";
            this.Radius = 20;
            this.ShowInTaskbar = false;
            this.Text = "Note";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LayeredSkin.Controls.LayeredButton layeredButton1;
        private LayeredSkin.Controls.LayeredButton layeredButton2;
        private LayeredSkin.Controls.LayeredTextBox layeredTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

