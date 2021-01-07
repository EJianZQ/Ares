using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares
{
    public class FontsData
    {
        /// <summary>
        /// 版本号
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// 最新版下载链接
        /// </summary>
        public string DownLink { get; set; }
        /// <summary>
        /// 购买卡密开关
        /// </summary>
        public int BuyKeysSwitch { get; set; }
        /// <summary>
        /// 购买卡密链接
        /// </summary>
        public string BuyKeysLink { get; set; }
        /// <summary>
        /// 文字教程链接
        /// </summary>
        public string Texttutorial { get; set; }
        /// <summary>
        /// 视频教程链接
        /// </summary>
        public string Videotutorial { get; set; }
    }
}
