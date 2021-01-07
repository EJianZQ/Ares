using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares
{
    public class WebApiUrlData
    {
        /// <summary>
        /// 解密私钥
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 单码用户登录
        /// </summary>
        public string SingleLogin { get; set; }
        /// <summary>
        /// 获取用户的到期时间
        /// </summary>
        public string GetExpired { get; set; }
        /// <summary>
        /// 检测用户状态
        /// </summary>
        public string CheckUserStatus { get; set; }
        /// <summary>
        /// 退出登录
        /// </summary>
        public string LogOut { get; set; }
        /// <summary>
        /// 获取程序数据
        /// </summary>
        public string GetAppCode { get; set; }
        /// <summary>
        /// 获取程序版本数据
        /// </summary>
        public string GetVersionCode { get; set; }
        /// <summary>
        /// 获取变量数据
        /// </summary>
        public string GetViriable { get; set; }
        /// <summary>
        /// 获取程序公告
        /// </summary>
        public string GetBulletin { get; set; }
        /// <summary>
        /// 机器码转绑
        /// </summary>
        public string MacChangeBind { get; set; }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        public string GetUserData { get; set; }
        /// <summary>
        /// 设置用户数据
        /// </summary>
        public string SetUserData { get; set; }
        /// <summary>
        /// 检测版本是否是最新版
        /// </summary>
        public string CheckAppVersion { get; set; }
        /// <summary>
        /// 添加黑名单用户
        /// </summary>
        public string BlockUser { get; set; }
    }
}
