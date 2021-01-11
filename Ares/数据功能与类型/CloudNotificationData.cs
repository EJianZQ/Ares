using System;

namespace Ares
{
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
}
