using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares
{
    public class CloudNotificationData
    {
        /// <summary>
        /// 信息框通知开关
        /// </summary>
        public string MsgBoxSwitch { get; set; }
        /// <summary>
        /// 信息框通知类型
        /// </summary>
        public string MsgBoxType { get; set; }
        /// <summary>
        /// 信息框通知标题
        /// </summary>
        public string MsgBoxTitle { get; set; }
        /// <summary>
        /// 信息框通知内容
        /// </summary>
        public string MsgBoxContent { get; set; }
        /// <summary>
        /// 信息框通知链接
        /// </summary>
        public string MsgBoxLink { get; set; }
        /// <summary>
        /// 按钮通知开关
        /// </summary>
        public string BtnSwitch { get; set; }
        /// <summary>
        /// 按钮通知类型
        /// </summary>
        /// <summary>
        /// 按钮文本
        /// </summary>
        public string BtnText { get; set; }
        public string BtnType { get; set; }
        /// <summary>
        /// 按钮通知标题
        /// </summary>
        public string BtnTitle { get; set; }
        /// <summary>
        /// 按钮通知内容
        /// </summary>
        public string BtnContent { get; set; }
        /// <summary>
        /// 按钮通知链接
        /// </summary>
        public string BtnLink { get; set; }
        /// <summary>
        /// 开关0关闭1开启。类型1仅提示，2是提示+打开网址，3是不弹窗直接打开网址。内容用*号换行。ShutDown直接关闭程序
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 强制关闭程序
        /// </summary>
        public int ShutDown { get; set; }
    }
}
