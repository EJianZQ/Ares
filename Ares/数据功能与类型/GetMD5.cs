using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ares
{
    class MD5
    {
        /// <summary>
        /// 获取文件的MD5值，成功返回大写MD5，失败返回-1
        /// </summary>
        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();//释放文件流

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return "-1";
            }
        }
    }
}
