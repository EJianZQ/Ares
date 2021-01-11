using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ares
{
    public class WebPost
    {
        private static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors errors)
        {
            return true; //总是接受     
        }

        public static string ApiPost(string url, IDictionary<string, string> parameters)
        {
            try
            {
                Encoding charset = Encoding.UTF8;
                HttpWebRequest request = null;
                //HTTPSQ请求  
                ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
                request = WebRequest.Create(url.Trim()) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = DefaultUserAgent;

                //如果需要POST数据，不可以忘了判断是否为空哦     
                if (!(parameters == null || parameters.Count == 0))
                {
                    var buffer = new StringBuilder();
                    foreach (var key in parameters.Keys)
                    {
                        buffer.AppendFormat(buffer.Length > 0 ? "&{0}={1}" : "{0}={1}", key, parameters[key]);
                    }
                    byte[] data = charset.GetBytes(buffer.ToString());
                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }

                HttpWebResponse response = (request.GetResponse() as HttpWebResponse);

                Stream htmlStream = response.GetResponseStream();

                StreamReader sr = new StreamReader(htmlStream);

                var html = sr.ReadToEnd();

                //别忘了释放
                sr.Close(); 

                return html;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
