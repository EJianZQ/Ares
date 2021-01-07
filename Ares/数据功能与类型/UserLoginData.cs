using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// 到期时间
        /// </summary>
        public string ExpiredTime { get; set; }
    }
}
