using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using Ares.加解密;
using COSXML;
using COSXML.Auth;
using COSXML.Model.Object;
using COSXML.CosException;


namespace Ares
{
    public partial class LoginForm : FrmBase
    {
        private const string localVersion = "0.99";
        public string hwidResetContent = string.Empty;
        public CloudNotificationData cloudNotificationData;
        public static WebApiUrlData webApiUrlData;
        public static UserLoginData userLoginData = new UserLoginData();

        /// <summary>
        /// 登录窗口载入
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            ///////////////////////////////////////////////////////////////////////用于代码功能的测试区

            //Console.WriteLine("Mutex Create:"+ MutexEx.CreateMutex("1").ToString());

            ///////////////////////////////////////////////////////////////////////用于代码功能的测试区

            //允许线程操作窗口控件
            Control.CheckForIllegalCrossThreadCalls = false;

            //设置窗口的拖动
            this.InitFormMove(this);
            this.InitFormMove(pictureBox);

            string cloudWeiApiJson = GetData.Get("https://download.3tme.cn/Ares/WebApiUrl.json", true);//获取WeiApi地址原始数据

            //判断取回数据是否有错，有错则报错然后结束进程
            if (cloudWeiApiJson == "Error" || cloudWeiApiJson == null)
            {
                this.Visible = false;
                this.Enabled = false;
                if (FrmDialog.ShowDialog(this, "Ares当前无法获取系统重要云端数据\n\n点击\"确定\"按钮为您打开相关解决方法的网页链接\n\n点击\"取消\"按钮退出Ares软件", "Ares - 致命错误", true) == DialogResult.OK)
                    System.Diagnostics.Process.Start("https://tz.3tme.cn/error-information/server-connection-failed.html");
                Environment.Exit(0);
            }
            webApiUrlData = JsonConvert.DeserializeObject<WebApiUrlData>(cloudWeiApiJson);//解析Json数据

            //通过Lambda表达式创建线程获取云通知
            Thread cloudNotificationThread = new Thread(() =>
            {
                string cloudNotificationJson = GetData.Get("https://download.3tme.cn/Ares/CloudNotification.json", true);//获取云通知原始数据

                //判断取回数据是否有错，有错则报错提醒用户无法收到消息
                if (cloudNotificationJson == "Error" || cloudNotificationJson == null)
                    FrmDialog.ShowDialog(this, "Ares当前无法获取通知类云端数据\n\n您可能会因此而无法收到管理员推送的程序通知或节假日活动等内容", "Ares - 错误");
                else
                {
                    cloudNotificationData = JsonConvert.DeserializeObject<CloudNotificationData>(cloudNotificationJson);//解析Json数据

                    //判断信息框的操作
                    if(cloudNotificationData.MsgBoxSwitch =="1")
                    {
                        switch (cloudNotificationData.MsgBoxType)
                        {
                            case "1":
                                {
                                    //仅弹窗提示
                                    FrmDialog.ShowDialog(this, cloudNotificationData.MsgBoxContent.Replace("*","\n"), cloudNotificationData.MsgBoxTitle);
                                    break;
                                }

                            case "2":
                                {
                                    //弹窗提示+是否打开链接
                                    if (FrmDialog.ShowDialog(this, cloudNotificationData.MsgBoxContent.Replace("*", "\n"), cloudNotificationData.MsgBoxTitle, true) == DialogResult.OK)
                                        System.Diagnostics.Process.Start(cloudNotificationData.MsgBoxLink);
                                    break;
                                }

                            case "3":
                                {
                                    //直接打开链接
                                    System.Diagnostics.Process.Start(cloudNotificationData.MsgBoxLink);
                                    break;
                                }
                        }
                    }

                    //判断按钮的操作，接下来的操作要写在按钮被点击的方法里
                    if (cloudNotificationData.BtnSwitch == "1")
                    {
                        ucBtnExt_CloudNotification.Location = new Point(224,485);//设置按钮位置正常
                        ucBtnExt_CloudNotification.BtnText = cloudNotificationData.BtnText;
                    }
                }
            });
            cloudNotificationThread.Start();

            //通过Lambda表达式创建线程检测版本更新
            Thread checkVersionThread = new Thread(() => {
                string result = VerifyFunction.VersionCheck(Decrypt.DES(webApiUrlData.CheckAppVersion, Decrypt.DES(webApiUrlData.Key, "actingnb")), localVersion);
                //1为最新版，0为不是最新版，-1为出错
                //1就直接跳出循环，0载入更新窗口，-1报错然后退出程序
                //后期预想：0载入更新窗口，窗口中显示新版本更新内容，目前只要弹窗告诉不是最新版然后弹下载地址就好
                switch (result)
                {
                    case "1":
                        {
                            break;
                        }
                    case "0":
                        {
                            this.Visible = false;
                            if (FrmDialog.ShowDialog(this, "检测到当前Ares版本不是最新版\n\n点击\"确定\"按钮为您打开最新版下载链接\n\n点击\"取消\"按钮退出Ares软件", "Ares - 版本更新", true) == DialogResult.OK)
                                System.Diagnostics.Process.Start("https://wp.3tme.cn/");
                            Environment.Exit(0);
                            break;
                        }
                    case "-1":
                        {
                            this.Visible = false;
                            if (FrmDialog.ShowDialog(this, "Ares当前无法连接至验证服务器\n\n点击\"确定\"按钮为您打开相关解决方法的网页链接\n\n点击\"取消\"按钮退出Ares软件", "Ares - 致命错误", true) == DialogResult.OK)
                                System.Diagnostics.Process.Start("https://tz.3tme.cn/error-information/verify-server-connection-failed.html");
                            Environment.Exit(0);
                            break;
                        }
                }
            });
            checkVersionThread.Start();
        }

        /// <summary>
        /// 登录按钮被点击
        /// </summary>
        private void ucBtnExt_Login_BtnClick(object sender, EventArgs e)
        {
            ucBtnExt_Login.FillColor = Color.FromArgb(155,155,155);
            ucBtnExt_Login.Enabled = false;
            
            string ret = VerifyFunction.Login(Decrypt.DES(webApiUrlData.SingleLogin, Decrypt.DES(webApiUrlData.Key, "actingnb")), ucTextBoxEx_Key.InputText, localVersion, IpConfig.GetMac(IpConfig.GetLocalIP()));
            if (ret.Length == 32)
            {

                //登录按钮消失，进度条取代，进行必要的变量的声明
                ucBtnExt_Login.Visible = false;
                ucProcessLine.Visible = true;
                ucProcessLine.Location = ucBtnExt_Login.Location;
                string expiredTimeS = null;
                bool isDownload = false;

                Thread loginSuccessThread = new Thread(() =>
                {
                    //对userLoginData进行赋值
                    userLoginData.Key = ucTextBoxEx_Key.InputText;
                    userLoginData.StatusCode = ret;
                    expiredTimeS = VerifyFunction.GetExpired(Decrypt.DES(webApiUrlData.GetExpired, Decrypt.DES(webApiUrlData.Key, "actingnb")), userLoginData.Key);
                    userLoginData.ExpiredTime = expiredTimeS;

                    //取到期时间的时间间隔
                    DateTime expiredTime = Convert.ToDateTime(userLoginData.ExpiredTime);
                    TimeSpan ts = expiredTime.Subtract(DateTime.Now);

                    label_Status.ForeColor = Color.FromArgb(66, 66, 66);
                    label_Status.Text = String.Format("{0}{1}天{2}时{3}分", "卡密剩余时间：", ts.Days.ToString(), ts.Hours.ToString(), ts.Minutes.ToString());

                    //核心数据取COS下载数据并解析
                    string appCode = VerifyFunction.GetAppCore(Decrypt.DES(webApiUrlData.GetAppCode, Decrypt.DES(webApiUrlData.Key, "actingnb")), userLoginData.StatusCode, userLoginData.Key);
                    if (appCode == "-1")
                    {
                        FrmDialog.ShowDialog(this, "Ares无法下载核心云端数据\n\n点击\"确定\"按钮退出Ares软件", "Ares - 致命错误");
                        Environment.Exit(0);
                    }
                    if (appCode.Length <= 10)
                    {
                        FrmDialog.ShowDialog(this, "Ares下载的核心云端数据不合法\n\n点击\"确定\"按钮退出Ares软件", "Ares - 致命错误");
                        Environment.Exit(0);
                    }
                    DllDownloadData dllDownloadData = JsonConvert.DeserializeObject<DllDownloadData>(appCode);

                    //判断文档中的 TencentCos 文件夹是否存在，不存在就新建一个
                    if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos") != true)
                    {
                        try
                        {
                            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos");
                        }
                        catch
                        {
                            FrmDialog.ShowDialog(this, "Ares申请的读写目录权限申请失败\n\n点击\"确定\"按钮退出Ares软件", "Ares - 致命错误");
                            Environment.Exit(0);
                        }
                        Console.WriteLine("TencentCos文件夹不存在，已经新建完毕");
                    }

                    //文件是否已经存在，存在就不再下载，节省流量
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos\\" + Decrypt.DES(dllDownloadData.LocalFileName, Decrypt.DES(webApiUrlData.Key, "actingnb"))) == true)
                    {
                        //文件存在，进行MD5校验，校验通过就不重新下载了
                        string existFileMD5 = MD5.GetMD5HashFromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos\\" + Decrypt.DES(dllDownloadData.LocalFileName, Decrypt.DES(webApiUrlData.Key, "actingnb")));
                        if(existFileMD5 != "-1")//验证是否成功取到MD5
                        {
                            if(existFileMD5 == Decrypt.DES(dllDownloadData.MD5, Decrypt.DES(webApiUrlData.Key, "actingnb")))//验证MD5是否与服务器的相符
                            {
                                isDownload = false;//MD5相符，不需要重新下载
                                ucProcessLine.Value = 100;
                                Console.WriteLine("MD5相符，不需要重新下载");
                            }
                            else
                            {
                                isDownload = true;//MD5不符，需要重新下载
                                Console.WriteLine("MD5不符，需要重新下载");
                            }
                        }
                    }
                    else
                    {
                        isDownload = true;//文件不存在，进行下载
                        Console.WriteLine("文件不存在，进行下载");
                    }

                    //云下载DLL
                    if(isDownload == true)
                    {
                        string secretId = Decrypt.DES(dllDownloadData.SecretId, Decrypt.DES(webApiUrlData.Key, "actingnb")); // API SecretId
                        string secretKey = Decrypt.DES(dllDownloadData.SecretKey, Decrypt.DES(webApiUrlData.Key, "actingnb")); // API SecretKey
                        string region = Decrypt.DES(dllDownloadData.Region, Decrypt.DES(webApiUrlData.Key, "actingnb")); // 存储桶所在地域

                        CosXmlConfig config = new CosXmlConfig.Builder()//普通初始化方式
                            .IsHttps(true)  //设置默认 HTTPS 请求
                            .SetRegion(region)
                            .SetDebugLog(true)
                            .Build();

                        long durationSecond = 600;  //每次请求签名有效时长，单位为秒
                        QCloudCredentialProvider cosCredentialProvider = new DefaultQCloudCredentialProvider(secretId, secretKey, durationSecond);

                        CosXml cosXml = new CosXmlServer(config, cosCredentialProvider);

                        try
                        {
                            string bucket = Decrypt.DES(dllDownloadData.Bucket, Decrypt.DES(webApiUrlData.Key, "actingnb")); //存储桶，格式：BucketName-APPID
                            string key = Decrypt.DES(dllDownloadData.Key, Decrypt.DES(webApiUrlData.Key, "actingnb")); //对象键
                            string localDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos";//下载到的目录 不需要文件名
                            string localFileName = Decrypt.DES(dllDownloadData.LocalFileName, Decrypt.DES(webApiUrlData.Key, "actingnb")); //指定本地保存的文件名
                            GetObjectRequest request = new GetObjectRequest(bucket, key, localDir, localFileName);
                            //设置进度回调
                            request.SetCosProgressCallback(delegate (long completed, long total)
                            {
                                //Console.WriteLine(String.Format("progress = {0:##.##}%", completed * 100.0 / total));
                                ucProcessLine.Value = Convert.ToInt32(completed * 100.0 / total);
                            });
                            //执行请求
                            GetObjectResult result = cosXml.GetObject(request);
                            //请求成功
                            Console.WriteLine(result.GetResultInfo());
                        }
                        catch (CosClientException clientEx)
                        {
                            //请求失败
                            //MessageBox.Show("CosClientException: " + clientEx);
                            FrmDialog.ShowDialog(this, "Ares无法下载核心云端文件\n\n点击\"确定\"按钮退出Ares软件" + "CosClientException: " + clientEx, "Ares - 致命错误");
                            Environment.Exit(0);
                        }
                        catch (CosServerException serverEx)
                        {
                            //请求失败
                            //MessageBox.Show("CosServerException: " + serverEx.GetInfo());
                            FrmDialog.ShowDialog(this, "Ares无法下载核心云端文件\n\n点击\"确定\"按钮退出Ares软件" + "CosServerException: " + serverEx.GetInfo(), "Ares - 致命错误");
                            Environment.Exit(0);
                        }

                        //下载完成后判断文件是否已经存在，不存在就是下载失败
                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos\\" + Decrypt.DES(dllDownloadData.LocalFileName, Decrypt.DES(webApiUrlData.Key, "actingnb"))) == true)
                        {
                            //文件存在，进行MD5校验，校验通过就不重新下载了
                            string existFileMD5 = MD5.GetMD5HashFromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TencentCos\\" + Decrypt.DES(dllDownloadData.LocalFileName, Decrypt.DES(webApiUrlData.Key, "actingnb")));
                            if (existFileMD5 != "-1")//验证是否成功取到MD5
                            {
                                if (existFileMD5 != Decrypt.DES(dllDownloadData.MD5, Decrypt.DES(webApiUrlData.Key, "actingnb")))//验证MD5是否与服务器的相符
                                {
                                    FrmDialog.ShowDialog(this, "Ares下载的核心云端文件与服务器不符\n\n点击\"确定\"按钮退出Ares软件", "Ares - 致命错误");
                                    Console.WriteLine("下载的文件MD5不符");
                                    Environment.Exit(0);
                                }
                            }
                        }
                        else
                        {
                            FrmDialog.ShowDialog(this, "Ares未能成功下载核心云端文件\n\n点击\"确定\"按钮退出Ares软件" , "Ares - 致命错误");//下载的文件不存在
                            Console.WriteLine("下载的文件不存在");
                            Environment.Exit(0);
                        }
                    }
                });
                loginSuccessThread.Start();
            }
            else
            {
                //登录失败
                if(ret == "-402")//判断是否需要解绑
                {
                    if (FrmDialog.ShowDialog(this, "当前卡密未在绑定的电脑上登录\n\n点击\"确定\"按钮为您打开解绑窗口来解绑新的机器码\n\n点击\"取消\"按钮取消解绑操作并回到主界面", "Ares - 卡密解绑", true) == DialogResult.OK)
                    {
                        if(hwidResetContent == string.Empty)
                        {
                            hwidResetContent = VerifyFunction.GetBulletin(Decrypt.DES(webApiUrlData.GetBulletin, Decrypt.DES(webApiUrlData.Key, "actingnb")));
                            HwidResetForm hwidResetForm = new HwidResetForm(ucTextBoxEx_Key.InputText, hwidResetContent);
                            hwidResetForm.ShowDialog();
                        }
                        else
                        {
                            HwidResetForm hwidResetForm = new HwidResetForm(ucTextBoxEx_Key.InputText, hwidResetContent);
                            hwidResetForm.ShowDialog();
                        }
                        ucBtnExt_Login.FillColor = Color.FromArgb(221, 31, 50);
                        ucBtnExt_Login.Enabled = true;
                    }
                    else
                    {
                        ucBtnExt_Login.FillColor = Color.FromArgb(221, 31, 50);
                        ucBtnExt_Login.Enabled = true;
                        label_Status.ForeColor = Color.FromArgb(239, 51, 42);
                        label_Status.Text = "卡密未在绑定的电脑上登录且未解绑";
                    }
                }
                else
                {
                    ucBtnExt_Login.FillColor = Color.FromArgb(221, 31, 50);
                    ucBtnExt_Login.Enabled = true;
                    label_Status.ForeColor = Color.FromArgb(239, 51, 42);
                    label_Status.Text = ErrorCodeTranslation.Get(ret);
                }
            }
        }

        /// <summary>
        /// 云通知按钮被点击
        /// </summary>
        private void ucBtnExt_CloudNotification_BtnClick(object sender, EventArgs e)
        {
            switch (cloudNotificationData.BtnType)
            {
                case "1":
                    {
                        //仅弹窗提示
                        FrmDialog.ShowDialog(this, cloudNotificationData.BtnContent.Replace("*", "\n"), cloudNotificationData.BtnTitle);
                        break;
                    }

                case "2":
                    {
                        //弹窗提示+是否打开链接
                        if (FrmDialog.ShowDialog(this, cloudNotificationData.BtnContent.Replace("*", "\n"), cloudNotificationData.BtnTitle, true) == DialogResult.OK)
                            System.Diagnostics.Process.Start(cloudNotificationData.BtnLink);
                        break;
                    }

                case "3":
                    {
                        //直接打开链接
                        System.Diagnostics.Process.Start(cloudNotificationData.BtnLink);
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Mutex Create:" + MutexEx.CreateMutex("1").ToString());//创建同步对象
            /*MainForm hwidResetForm = new MainForm();
            hwidResetForm.Show();
            this.Visible = false;*/
        }
    }
}
