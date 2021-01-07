using System;

namespace Ares
{
    public class DllDownloadData
    {
        /// <summary>
        /// SecretId
        /// </summary>
        public string SecretId { get; set; }
        /// <summary>
        /// SecretKey
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// 存储桶地区
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 存储桶名
        /// </summary>
        public string Bucket { get; set; }
        /// <summary>
        /// 对象键
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 本地文件名
        /// </summary>
        public string LocalFileName { get; set; }
        /// <summary>
        /// 本地文件MD5
        /// </summary>
        public string MD5 { get; set; }
        /// <summary>
        /// 是否重复下载
        /// </summary>
        public int RepeatDownload { get; set; }
    }
}
