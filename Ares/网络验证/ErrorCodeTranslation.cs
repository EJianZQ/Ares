using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares
{
    class ErrorCodeTranslation
    {
        public static string Get(string Code)
        {
            switch (Code)
            {
                case "-1":
                    {
                        return "网络链接失败";
                    }

                case "-3":
                    {
                        return "数据异常";
                    }

                case "-4":
                    {
                        return "数据异常";
                    }

                case "-5":
                    {
                        return "程序参数错误，请等待修复";
                    }

                case "-6":
                    {
                        return "还未登录或已被踢下线";
                    }

                case "-14":
                    {
                        return "错误的调用";
                    }

                case "-15":
                    {
                        return "服务器当前繁忙，请稍后登录";
                    }

                case "-18":
                    {
                        return "服务器内部错误";
                    }

                case "-21":
                    {
                        return "机器码未变动，无需解绑";
                    }

                case "-110":
                    {
                        return "卡密已过期";
                    }

                case "-112":
                    {
                        return "用户在别的地方登录";
                    }

                case "-113":
                    {
                        return "时间数据格式不合法";
                    }

                case "-114":
                    {
                        return "登录数据不存在";
                    }

                case "-115":
                    {
                        return "卡密已被封停";
                    }

                case "-117":
                    {
                        return "机器码为空";
                    }

                case "-118":
                    {
                        return "解绑次数超过每日上限";
                    }

                case "-119":
                    {
                        return "剩余时间不足以扣除解绑6小时时间";
                    }

                case "-121":
                    {
                        return "机器码出错，超过了32位";
                    }

                case "-201":
                    {
                        return "程序不存在";
                    }

                case "-203":
                    {
                        return "程序版本号错误";
                    }

                case "-204":
                    {
                        return "程序版本不存在";
                    }

                case "-206":
                    {
                        return "程序版本需要更新";
                    }

                case "-207":
                    {
                        return "程序版本已停用";
                    }

                case "-211":
                    {
                        return "当前禁止进行卡密解绑";
                    }

                case "-401":
                    {
                        return "卡密输入错误";
                    }

                case "-404":
                    {
                        return "卡密类型错误";
                    }

                case "-405":
                    {
                        return "卡密已被封停";
                    }

                case "-406":
                    {
                        return "卡密不存在";
                    }

                case "-407":
                    {
                        return "卡密未激活";
                    }

                case "-408":
                    {
                        return "卡密已经使用";
                    }

                case "-410":
                    {
                        return "卡密已经过期";
                    }

                case "-420":
                    {
                        return "卡密在别的电脑上登录";
                    }

                case "-421":
                    {
                        return "卡密超过最大登录数";
                    }

                case "-422":
                    {
                        return "机器码未变动，无需解绑";
                    }

                case "-502":
                    {
                        return "卡密解绑次数超过每日上限";
                    }

                case "-503":
                    {
                        return "卡密剩余时间不足以扣除解绑6小时";
                    }

                default:
                    {
                        return "未知错误，错误代码："+ Code;
                    } 
            }
        }
    }
}
