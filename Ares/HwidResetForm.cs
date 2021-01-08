using System;
using HZH_Controls.Forms;
using Ares.加解密;

namespace Ares
{
    public partial class HwidResetForm : FrmWithTitle
    {
        public string key;
        public string expiredTimeS;
        public VerifyFunction Verify;
        public HwidResetForm(VerifyFunction ver,string Key,string HwidResetContent)
        {
            key = Key;
            Verify = ver;
            InitializeComponent();
            textBoxEx_Content.Text = HwidResetContent;
        }


        private void ucBtnExt_Cancel_BtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ucBtnExt_Hwid_BtnClick(object sender, EventArgs e)
        {
            string ret = Verify.HwidReset(key, IpConfig.GetMac(IpConfig.GetLocalIP()));
            if(ret == "1")
            {
                //解绑成功，查询剩余时间
                expiredTimeS = Verify.GetExpired(key);
                DateTime expiredTime = Convert.ToDateTime(expiredTimeS);
                TimeSpan ts = expiredTime.Subtract(DateTime.Now);
                string expiredTimes = String.Format("{0}{1}天{2}时{3}分", "卡密剩余时间：", ts.Days.ToString(), ts.Hours.ToString(), ts.Minutes.ToString());
                FrmDialog.ShowDialog(this, "当前卡密已成功解绑，您可在此台电脑上正常登录\n\n解绑后" + expiredTimes + "\n\n点击\"确定\"按钮返回登录界面", "Ares - 卡密解绑");
                Close();
            }
            else
            {
                //解绑失败，报错
                FrmDialog.ShowDialog(this, "当前卡密解绑失败\n\n失败原因：" + ErrorCodeTranslation.Get(ret) + "\n\n点击\"确定\"按钮返回登录界面", "Ares - 卡密解绑");
                Close();
            }
        }
    }
}
