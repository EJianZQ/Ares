using System;

namespace Ares
{
    public class RootData
    {
        /// <summary>
        /// WebApi地址
        /// </summary>
        public WebApiUrlData WebApiUrlData { get; set; }
        /// <summary>
        /// 云通知地址
        /// </summary>
        public CloudNotificationData CloudNotificationData { get; set; }
        /// <summary>
        /// 解绑须知
        /// </summary>
        public string HwidResetContent { get; set; }
    }
}
