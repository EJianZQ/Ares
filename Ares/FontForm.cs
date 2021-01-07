using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Forms;
using HZH_Controls.Controls;
using Newtonsoft.Json;

namespace Ares
{
    public partial class FontForm : FrmWithTitle
    {
        public string cloudJson;
        public FontsData fontsData;
        public FontForm()
        {
            InitializeComponent();
            cloudJson = GetData.Get("https://download.3tme.cn/FontsInstall/data.json", true);//获取数据
            if (cloudJson == "Error" || cloudJson == null)
            {
                FrmDialog.ShowDialog(this, "无法获取云端数据，下载链接与视频教程链接无法从云端获取\n\n已启用离线模式，链接均采用本地形式，如链接失效请访问:doc.3tme.cn\n\n", "Ares");
            }
            else
                fontsData = JsonConvert.DeserializeObject<FontsData>(cloudJson);
        }

        private void ucBtnExt_视频教程_BtnClick(object sender, EventArgs e)
        {
            if(cloudJson == "Error" || cloudJson == null)
            {
                System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1va411F7jZ");
            }
            else
            {
                System.Diagnostics.Process.Start(fontsData.Videotutorial);
            }
        }

        private void ucBtnExt_下载字体_BtnClick(object sender, EventArgs e)
        {
            if (cloudJson == "Error" || cloudJson == null)
            {
                System.Diagnostics.Process.Start("https://wwa.lanzous.com/i30W7jb0vsj");
            }
            else
            {
                System.Diagnostics.Process.Start(fontsData.DownLink);
            }
        }

        private void ucBtnExt_退出软件_BtnClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
