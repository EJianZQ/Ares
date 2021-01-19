using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Ares
{
    #region Toast通知
    public class Toast
    {
        /// <summary>
        /// Toast 通知(不限显示时间)
        /// </summary>
        public static void ShowNotifiy(string Title,string Text,Icon Ico)
        {
            NotifyIcon fyIcon = new NotifyIcon();
            fyIcon.Icon = Ico;
            fyIcon.BalloonTipText = Text;
            fyIcon.BalloonTipTitle = Title;
            fyIcon.Visible = true;/*必须设置显隐，因为默认值是 false 不显示通知*/
            fyIcon.ShowBalloonTip(0);
        }

        /// <summary>
        /// Toast 通知
        /// </summary>
        public static void ShowNotifiy(string Title, string Text, Icon Ico,int Timeout)
        {
            NotifyIcon fyIcon = new NotifyIcon();
            fyIcon.Icon = Ico;
            fyIcon.BalloonTipText = Text;
            fyIcon.BalloonTipTitle = Title;
            fyIcon.Visible = true;/*必须设置显隐，因为默认值是 false 不显示通知*/
            fyIcon.ShowBalloonTip(Timeout);
            Thread.Sleep(Timeout);
            fyIcon.Dispose();//释放资源来消灭右下角的图标
        }
    }
    #endregion

    public class CloudNotificationData
    {
        /// <summary>
        /// 信息框通知
        /// </summary>
        public CloudMsgBox MsgBox { get; set; }
        /// <summary>
        /// 按钮通知
        /// </summary>
        public CloudButton Button { get; set; }
        /// <summary>
        /// 标签通知
        /// </summary>
        public CloudLabel Label { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// 强制关闭程序
        /// </summary>
        public int ShutDown { get; set; }
    }
    public class CloudBulletin
    {
        /// <summary>
        /// 公告标签
        /// </summary>
        public CloudLabel Label { get; set; }

        /// <summary>
        /// 气泡提示
        /// </summary>
        public CloudNotifyIcon NotifyIcon { get; set; }
    }

    public class CloudMsgBox
    {
        /// <summary>
        /// 信息框通知开关
        /// </summary>
        public string Switch { get; set; }
        /// <summary>
        /// 信息框通知类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 信息框通知标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 信息框通知内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 信息框通知链接
        /// </summary>
        public string Link { get; set; }
    }

    public class CloudButton
    {
        /// <summary>
        /// 按钮通知开关
        /// </summary>
        public string Switch { get; set; }
        /// <summary>
        /// 按钮通知类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 按钮文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 按钮通知标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 按钮通知内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 按钮通知链接
        /// </summary>
        public string Link { get; set; }
    }

    public class CloudLabel
    {
        /// <summary>
        /// 标签通知开关
        /// </summary>
        public string Switch { get; set; }
        /// <summary>
        /// 标签通知类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 标签上的内容
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 标签通知标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 标签通知内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 标签通知链接
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// 标签字体颜色
        /// </summary>
        public LabelColor Color { get; set; }
    }

    public class CloudNotifyIcon
    {
        /// <summary>
        /// 气泡通知开关
        /// </summary>
        public string Switch { get; set; }
        /// <summary>
        /// 气泡通知标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 气泡通知开关内容
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 气泡持续时间
        /// </summary>
        public int Timeout { get; set; }
    }

    public class LabelColor
    {
        /// <summary>
        /// 红
        /// </summary>
        public int R { get; set; }
        /// <summary>
        /// 绿
        /// </summary>
        public int G { get; set; }
        /// <summary>
        /// 蓝
        /// </summary>
        public int B { get; set; }
    }

    public class VIPNotificationData:CloudNotifyIcon
    {
        /// <summary>
        /// 时间段问候
        /// </summary>
        public TimeGreeting TimeGreeting { get; set; }
    }

    public class TimeGreeting
    {
        /// <summary>
        /// 早晨问候语
        /// </summary>
        public string Morning { get; set; }
        /// <summary>
        /// 中午问候语
        /// </summary>
        public string Noon { get; set; }
        /// <summary>
        /// 下午问候语
        /// </summary>
        public string AfterNoon { get; set; }
        /// <summary>
        /// 夜晚问候语
        /// </summary>
        public string Evening { get; set; }
        /// <summary>
        /// 半夜问候语
        /// </summary>
        public string Midnight { get; set; }
    }
}
