using System;


namespace Ares
{
    public class UserLoginData
    {
        /// <summary>
        /// 登录成功的卡密
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 登录成功后返回的状态码
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// 到期时间字符串
        /// </summary>
        public string ExpiredTimeS { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime ExpiredTime { get; set; }
    }

    public class UserUpdateData
    {
        /// <summary>
        /// 在线QQ
        /// </summary>
        public string OnlineQQ { get; set; }

        /// <summary>
        /// 硬盘序列号
        /// </summary>
        public string DiskSerialNumber { get; set; }

        /// <summary>
        /// CPU序列号
        /// </summary>
        public string CpuID { get; set; }

        /// <summary>
        /// 主板序列号
        /// </summary>
        public string BoardId { get; set; }
    }
}
