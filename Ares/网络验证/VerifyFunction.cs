using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;
using Ares.加解密;

namespace Ares
{
    class Cmd
    {
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";
        /// <summary>
        /// 执行cmd命令 返回cmd窗口显示的信息
        /// 多命令请使用批处理命令连接符：
        /// <![CDATA[
        /// &:同时执行两个命令
        /// |:将上一个命令的输出,作为下一个命令的输入
        /// &&：当&&前的命令成功时,才执行&&后的命令
        /// ||：当||前的命令失败时,才执行||后的命令]]>
        /// </summary>
        /// <param name="cmd">执行的命令</param>
        public static string RunCmd(string cmd)
        {
            cmd = cmd.Trim().TrimEnd('&') + "&exit";//说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
                p.Start();//启动程序

                //向cmd窗口写入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();

                return output;
            }
        }
    }

    class IpConfig
    {
        /// <summary>
        /// 取MAC地址，传入本机IP
        /// </summary>
        public static string GetMac(string remoteIP)
        {
            StringBuilder macAddress = new StringBuilder();
            try
            {
                Int32 remote = inet_addr(remoteIP);
                Int64 macInfo = new Int64();
                Int32 length = 6;
                SendARP(remote, 0, ref macInfo, ref length);
                string temp = Convert.ToString(macInfo, 16).PadLeft(12, '0').ToUpper();
                int x = 12;
                for (int i = 0; i < 6; i++)
                {
                    if (i == 5)
                    {
                        macAddress.Append(temp.Substring(x - 2, 2));
                    }
                    else
                    {
                        macAddress.Append(temp.Substring(x - 2, 2) + "-");
                    }
                    x -= 2;
                }
                return macAddress.ToString();
            }
            catch
            {
                return macAddress.ToString();
            }

        }
        [DllImport("Iphlpapi.dll")]
        private static extern int SendARP(Int32 dest, Int32 host, ref Int64 mac, ref Int32 length);
        [DllImport("Ws2_32.dll")]
        private static extern Int32 inet_addr(string ip);

        /// <summary>
        /// 取本机IP
        /// </summary>
        public static string GetLocalIP()
        {
            //得到本机的主机名
            string strHostName = Dns.GetHostName();
            try
            {
                //取得本机所有IP
                IPAddress[] ipAddress = Dns.GetHostEntry(strHostName).AddressList;
                byte[] host = null;
                foreach (var ip in ipAddress)
                {
                    while (ip.GetAddressBytes().Length == 4)
                    {
                        host = ip.GetAddressBytes();
                        break;
                    }
                    if (host != null)
                        break;
                }
                string ret = null;

                for (int i = 0; i < host.Length; i++)
                {
                    if (i < host.Length - 1)
                        ret += host[i] + ".";
                    else
                        ret += host[i];
                }

                return ret;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
    public class VerifyFunction
    {
        private static WebApiUrlData webApiUrl { get; set; }
        public VerifyFunction(WebApiUrlData data)
        {
            webApiUrl = data;
        }

        public VerifyFunction()
        {

        }

        #region 检测版本更新
        /// <summary>
        /// 检测版本更新，返回1为最新版，0不是最新版，-1出错
        /// </summary>
        public string VersionCheck(string Version)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                // 添加待传递参数
                parameters.Add("1", Version);
                var ret = WebPost.ApiPost(Decrypt.DES(webApiUrl.CheckAppVersion, Decrypt.DES(webApiUrl.Key, "actingnb")), parameters);

                return ret;
            }
            catch
            {
                return "-1";
            }
        }
        #endregion

        #region 获取公告
        /// <summary>
        /// 获取公告，成功返回公告文本，返回-1出错
        /// </summary>
        public string GetBulletin()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                parameters.Add("1", "1");//随便传个参进去

                var ret = WebPost.ApiPost(Decrypt.DES(webApiUrl.GetBulletin, Decrypt.DES(webApiUrl.Key, "actingnb")), parameters);

                return ret;
            }
            catch
            {
                return "-1";
            }
        }
        #endregion

        #region 单码登录
        /// <summary>
        /// 登录，成功返回状态码，失败返回错误码
        /// </summary>
        public string Login(string Key,string Version,string Mac)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                // 添加待传递参数
                parameters.Add("1", Key);
                parameters.Add("2", Version);
                parameters.Add("3", Mac);

                var ret = WebPost.ApiPost(Decrypt.DES(webApiUrl.SingleLogin, Decrypt.DES(webApiUrl.Key, "actingnb")), parameters);

                return ret;
            }
            catch
            {
                return "-1";
            }
        }
        #endregion

        #region 获取到期时间
        /// <summary>
        /// 获取到期时间，失败返回-1
        /// </summary>
        public string GetExpired(string Key)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                // 添加待传递参数
                parameters.Add("1", Key);

                var ret = WebPost.ApiPost(Decrypt.DES(webApiUrl.GetExpired, Decrypt.DES(webApiUrl.Key, "actingnb")), parameters);

                return ret;
            }
            catch
            {
                return "-1";
            }
        }
        #endregion

        #region 获取核心数据
        /// <summary>
        /// 获取核心数据，成功返回数据，失败返回-1
        /// </summary>
        public string GetAppCore(string StatusCode,string Key)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                // 添加待传递参数
                parameters.Add("1", StatusCode);
                parameters.Add("2", Key);

                var ret = WebPost.ApiPost(Decrypt.DES(webApiUrl.GetAppCode, Decrypt.DES(webApiUrl.Key, "actingnb")), parameters);

                return ret;
            }
            catch
            {
                return "-1";
            }
        }
        #endregion

        #region 机器码解绑
        /// <summary>
        /// 机器码解绑，成功返回1，失败返回错误码
        /// </summary>
        public string HwidReset(string Key,string NewMac)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                // 添加待传递参数
                parameters.Add("1", Key);
                parameters.Add("2", string.Empty);
                parameters.Add("3", NewMac);
                parameters.Add("4", "0");

                var ret = WebPost.ApiPost(Decrypt.DES(webApiUrl.MacChangeBind, Decrypt.DES(webApiUrl.Key, "actingnb")), parameters);

                return ret;
            }
            catch
            {
                return "-1";
            }
        }
        #endregion
    }
}
