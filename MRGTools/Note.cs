using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayeredSkin.Forms;

namespace MRGTools
{
    public partial class Note : LayeredForm
    {
        public Note()
        {
            InitializeComponent();
            this.Initialize();//初始化
        }

        private void Initialize()
        {

        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.OnWindowStateChanged();
        }

        /// <summary>
        /// 修改窗口状态时调用
        /// </summary>
        private void OnWindowStateChanged()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(3000, "小工具在这里哦！", "点击气泡显示", ToolTipIcon.None);
            }
            else
            {
                this.notifyIcon1.Visible = false;
            }
        }

        #region 托盘相关
        /// <summary>
        /// 当气泡被点击
        /// </summary>
        private void OnBalloonTipClicked(object sender, EventArgs e)
        {
            /*this.OnNotifyIconDoubleClicked(null, null);*/
        }

        /// <summary>
        /// 当托盘图标被双击
        /// </summary>
        private void OnNotifyIconDoubleClicked(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.OnWindowStateChanged();
        }

        /// <summary>
        /// 托盘图标菜单项
        /// 退出
        /// </summary>
        private void OnExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 托盘图标菜单项
        /// 显示
        /// </summary>
        private void OnShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OnNotifyIconDoubleClicked(null, null);
        }
        #endregion

        #region 输入相关
        private TextBox currentInputTextBox;

        private void InputConfirm(object sender, EventArgs e)
        {
            if (currentInputTextBox != null)
            {
                this.layeredLabel1.Text = this.currentInputTextBox.Text;
                this.currentInputTextBox.Visible = false;
                this.currentInputTextBox.Dispose();
            }
        }

        private void OnLabelDoubleClick(object sender, EventArgs e)
        {
            this.currentInputTextBox = new TextBox();
            this.currentInputTextBox.Name = "currentInputTextBox";
            this.currentInputTextBox.Location = this.layeredLabel1.Location;
            this.currentInputTextBox.Size = this.layeredLabel1.Size;
            this.currentInputTextBox.TabIndex = 5;
            this.currentInputTextBox.TabStop = false;
            this.Controls.Add(this.currentInputTextBox);

            this.currentInputTextBox.Text = this.layeredLabel1.Text;
            this.currentInputTextBox.Visible = true;
            this.currentInputTextBox.Focus();
        }
        #endregion
    }
}
