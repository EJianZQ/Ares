using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HZH_Controls.Forms;
using Newtonsoft.Json;

namespace Ares
{
    public partial class MainForm : FrmBase
    {
        public static UserLoginData userLoginData;
        public static CloudBulletin bulletin;
        public object _ToastLocker = new object ();//Toast通知锁
        public MainForm(UserLoginData ud)
        {
            InitializeComponent();

            userLoginData = ud;
            
            //允许线程操作窗口控件
            Control.CheckForIllegalCrossThreadCalls = false;

            #region 设置窗口的拖动
            //设置窗口的拖动
            InitFormMove(this);
            InitFormMove(tabPage1);
            InitFormMove(tabPage2);
            InitFormMove(tabPage3);
            InitFormMove(tabPage4);
            InitFormMove(label_welcome);
            InitFormMove(label_leftTimelabel);
            InitFormMove(label_days);
            InitFormMove(label_leftTime);
            InitFormMove(ucPanelQuote_Bulletin);
            //InitFormMove(label_bulletin);
            #endregion

            List<KeyValuePair<string, string>> lstHL = new List<KeyValuePair<string, string>>();
            lstHL.Add(new KeyValuePair<string, string>("1", "  Ares  "));
            lstHL.Add(new KeyValuePair<string, string>("2", "  功能页面  "));
            lstHL.Add(new KeyValuePair<string, string>("3", "  云端参数  "));
            lstHL.Add(new KeyValuePair<string, string>("4", "  联系信息  "));
            this.ucHorizontalList.DataSource = lstHL;

            //去除TagPage选项卡
            this.tabControl.Region = new Region(new RectangleF(this.tabPage1.Left, this.tabPage1.Top, this.tabPage1.Width, this.tabPage1.Height));

            //倒计时与判断到期线程
            Thread countDownThread = new Thread(() =>
            {
                TimeSpan ts = userLoginData.ExpiredTime.Subtract(Convert.ToDateTime(GetData.GetNetDateTime()));
                //VIP永久卡用户专属问候
                if(ts.Days > 2)
                {
                    label_days.Text = string.Format("{0} Days", ts.Days.ToString());
                    label_leftTime.Text = string.Format("{0} Hours，{1} Minutes，{2} Seconds", ts.Hours.ToString(), ts.Minutes.ToString(), ts.Seconds.ToString());
                    string sourceVIPData = GetData.Get("https://download.3tme.cn/Ares/VipData.json", true);
                    VIPNotificationData vIPNotificationData = JsonConvert.DeserializeObject<VIPNotificationData>(sourceVIPData);
                    if(vIPNotificationData.Switch == "1")
                    {
                        //替换{UserType}
                        if (vIPNotificationData.Title.Contains("{UserType}"))
                        {
                            if (ts.Days > 365)
                                vIPNotificationData.Title = vIPNotificationData.Title.Replace("{UserType}", "永久卡用户");
                            else
                                vIPNotificationData.Title = vIPNotificationData.Title.Replace("{UserType}", "VIP用户");
                        }
                        //替换{TimeGreeting}
                        if (vIPNotificationData.Title.Contains("{TimeGreeting}"))
                        {
                            int hour = DateTime.Now.Hour;
                            if (hour >= 0 && hour <= 6)
                                vIPNotificationData.Title = vIPNotificationData.Title.Replace("{TimeGreeting}", vIPNotificationData.TimeGreeting.Midnight);

                            if (hour >= 7 && hour <= 12)
                                vIPNotificationData.Title = vIPNotificationData.Title.Replace("{TimeGreeting}", vIPNotificationData.TimeGreeting.Noon);

                            if (hour >= 13 && hour <= 17)
                                vIPNotificationData.Title = vIPNotificationData.Title.Replace("{TimeGreeting}", vIPNotificationData.TimeGreeting.AfterNoon);

                            if (hour >= 18 && hour <= 23)
                                vIPNotificationData.Title = vIPNotificationData.Title.Replace("{TimeGreeting}", vIPNotificationData.TimeGreeting.Evening);
                        }
                        lock(_ToastLocker)
                        {
                            Toast.ShowNotifiy(vIPNotificationData.Title, vIPNotificationData.Text.Replace("*", Environment.NewLine), this.Icon, vIPNotificationData.Timeout);
                        }
                    }
                }
                //倒计时启动
                label_days.Text = string.Format("{0} Days", ts.Days.ToString());
                TimeSpan tss = new TimeSpan(0, 0, 0, 1);
                while (ts.TotalSeconds > 0)
                {
                    ts = ts.Subtract(tss);
                    label_days.Text = string.Format("{0} Days", ts.Days.ToString());
                    label_leftTime.Text = string.Format("{0} Hours，{1} Minutes，{2} Seconds", ts.Hours.ToString(), ts.Minutes.ToString(), ts.Seconds.ToString());
                    Thread.Sleep(1000);
                }
                //跳出了循环则说明到期了，结束CSGO进程并弹出到期网页
                foreach (var csgoProcess in System.Diagnostics.Process.GetProcessesByName("notepad"))
                {
                    try
                    {
                        // 杀掉这个进程
                        csgoProcess.Kill();

                        // 等待进程被杀掉
                        csgoProcess.WaitForExit();
                    }
                    catch (InvalidOperationException)
                    {
                        // 进程已经退出或不存在
                        System.Diagnostics.Process.Start("https://tz.3tme.cn/error-information/expired.html");
                        this.Visible = false;
                        Environment.Exit(0);
                    }
                    finally
                    {
                        System.Diagnostics.Process.Start("https://tz.3tme.cn/error-information/expired.html");
                        this.Visible = false;
                        Environment.Exit(0);
                    }
                }
            });

            Thread bulletinThread = new Thread(() =>
            {
                string sourceBulletin = LoginForm.Verify.GetBulletin();
                bulletin = JsonConvert.DeserializeObject<CloudBulletin>(sourceBulletin);
                label_bulletin.Text = bulletin.Label.Content.Replace("*",Environment.NewLine);
                label_bulletin.ForeColor = Color.FromArgb(bulletin.Label.Color.R, bulletin.Label.Color.G, bulletin.Label.Color.B);
                if(bulletin.NotifyIcon.Switch == "1")
                {
                    lock (_ToastLocker)
                    {
                        Toast.ShowNotifiy(bulletin.NotifyIcon.Title, bulletin.NotifyIcon.Text.Replace("*", Environment.NewLine), this.Icon, bulletin.NotifyIcon.Timeout);
                    }
                }
            });
            countDownThread.Start();
            bulletinThread.Start();
        }

        /// <summary>
        /// 切换选项卡
        /// </summary>
        private void ucHorizontalList_SelectedItemEvent(object sender, EventArgs e)
        {
            switch (ucHorizontalList.SelectedItem.DataSource.Key)
            {
                case "1":
                    {
                        tabControl.SelectedTab = tabPage1;
                        break;
                    }
                case "2":
                    {
                        tabControl.SelectedTab = tabPage2;
                        break;
                    }
                case "3":
                    {
                        tabControl.SelectedTab = tabPage3;
                        break;
                    }
                case "4":
                    {
                        tabControl.SelectedTab = tabPage4;
                        break;
                    }
            }
        }

        private void label_bulletin_Click(object sender, EventArgs e)
        {
            if(bulletin.Label.Switch == "1")
            {
                switch (bulletin.Label.Type)
                {
                    case "1":
                        {
                            //仅弹窗提示
                            FrmDialog.ShowDialog(this, bulletin.Label.Text.Replace("*", "\n"), bulletin.Label.Title);
                            break;
                        }

                    case "2":
                        {
                            //弹窗提示+是否打开链接
                            if (FrmDialog.ShowDialog(this, bulletin.Label.Text.Replace("*", "\n"), bulletin.Label.Title, true) == DialogResult.OK)
                                System.Diagnostics.Process.Start(bulletin.Label.Link);
                            break;
                        }

                    case "3":
                        {
                            //直接打开链接
                            System.Diagnostics.Process.Start(bulletin.Label.Link);
                            break;
                        }
                }
            }
        }



        private void ucBtnImg_Email_BtnClick(object sender, EventArgs e)
        {

        }

        private void ucBtnImg_Discord_BtnClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tz.3tme.cn/join-discord/");
        }

        private void ucBtnImg_WebSite_BtnClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://xz.3tme.cn/");
        }
    }
}
