
namespace Ares
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ucHorizontalList = new HZH_Controls.Controls.UCHorizontalList();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPanelQuote_WebSite = new HZH_Controls.Controls.UCPanelQuote();
            this.ucBtnImg_WebSite = new HZH_Controls.Controls.UCBtnImg();
            this.ucPanelQuote_Discord = new HZH_Controls.Controls.UCPanelQuote();
            this.ucBtnImg_Discord = new HZH_Controls.Controls.UCBtnImg();
            this.ucPanelQuote_Mail = new HZH_Controls.Controls.UCPanelQuote();
            this.ucBtnImg_Email = new HZH_Controls.Controls.UCBtnImg();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucPanelQuote_Bulletin = new HZH_Controls.Controls.UCPanelQuote();
            this.label_bulletin = new System.Windows.Forms.Label();
            this.label_leftTime = new System.Windows.Forms.Label();
            this.label_days = new System.Windows.Forms.Label();
            this.label_leftTimelabel = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_云端参数2 = new System.Windows.Forms.Label();
            this.label_云端参数1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.ucPanelQuote_WebSite.SuspendLayout();
            this.ucPanelQuote_Discord.SuspendLayout();
            this.ucPanelQuote_Mail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ucPanelQuote_Bulletin.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucHorizontalList
            // 
            this.ucHorizontalList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ucHorizontalList.DataSource = null;
            this.ucHorizontalList.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucHorizontalList.IsAutoSelectFirst = true;
            this.ucHorizontalList.Location = new System.Drawing.Point(12, 4);
            this.ucHorizontalList.Name = "ucHorizontalList";
            this.ucHorizontalList.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucHorizontalList.SelectedItem = null;
            this.ucHorizontalList.Size = new System.Drawing.Size(446, 67);
            this.ucHorizontalList.TabIndex = 0;
            this.ucHorizontalList.SelectedItemEvent += new System.EventHandler(this.ucHorizontalList_SelectedItemEvent);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.ItemSize = new System.Drawing.Size(48, 10);
            this.tabControl.Location = new System.Drawing.Point(12, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(446, 306);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.ucPanelQuote_WebSite);
            this.tabPage4.Controls.Add(this.ucPanelQuote_Discord);
            this.tabPage4.Controls.Add(this.ucPanelQuote_Mail);
            this.tabPage4.Location = new System.Drawing.Point(4, 14);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(438, 288);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "联系信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "限时活动：加入我们的Discord即可赢取免费天卡";
            // 
            // ucPanelQuote_WebSite
            // 
            this.ucPanelQuote_WebSite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(196)))), ((int)(((byte)(249)))));
            this.ucPanelQuote_WebSite.Controls.Add(this.ucBtnImg_WebSite);
            this.ucPanelQuote_WebSite.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(196)))), ((int)(((byte)(249)))));
            this.ucPanelQuote_WebSite.Location = new System.Drawing.Point(29, 178);
            this.ucPanelQuote_WebSite.Name = "ucPanelQuote_WebSite";
            this.ucPanelQuote_WebSite.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote_WebSite.Size = new System.Drawing.Size(371, 53);
            this.ucPanelQuote_WebSite.TabIndex = 2;
            // 
            // ucBtnImg_WebSite
            // 
            this.ucBtnImg_WebSite.BackColor = System.Drawing.Color.White;
            this.ucBtnImg_WebSite.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImg_WebSite.BtnFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImg_WebSite.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg_WebSite.BtnText = "  WebSite：https://xz.3tme.cn";
            this.ucBtnImg_WebSite.ConerRadius = 5;
            this.ucBtnImg_WebSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImg_WebSite.EnabledMouseEffect = false;
            this.ucBtnImg_WebSite.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImg_WebSite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImg_WebSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg_WebSite.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg_WebSite.Image")));
            this.ucBtnImg_WebSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImg_WebSite.ImageFontIcons = null;
            this.ucBtnImg_WebSite.IsRadius = true;
            this.ucBtnImg_WebSite.IsShowRect = true;
            this.ucBtnImg_WebSite.IsShowTips = false;
            this.ucBtnImg_WebSite.Location = new System.Drawing.Point(9, 6);
            this.ucBtnImg_WebSite.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImg_WebSite.Name = "ucBtnImg_WebSite";
            this.ucBtnImg_WebSite.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImg_WebSite.RectWidth = 1;
            this.ucBtnImg_WebSite.Size = new System.Drawing.Size(354, 42);
            this.ucBtnImg_WebSite.TabIndex = 0;
            this.ucBtnImg_WebSite.TabStop = false;
            this.ucBtnImg_WebSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg_WebSite.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImg_WebSite.TipsText = "";
            this.ucBtnImg_WebSite.BtnClick += new System.EventHandler(this.ucBtnImg_WebSite_BtnClick);
            // 
            // ucPanelQuote_Discord
            // 
            this.ucPanelQuote_Discord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(150)))), ((int)(((byte)(211)))));
            this.ucPanelQuote_Discord.Controls.Add(this.ucBtnImg_Discord);
            this.ucPanelQuote_Discord.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(150)))), ((int)(((byte)(211)))));
            this.ucPanelQuote_Discord.Location = new System.Drawing.Point(29, 105);
            this.ucPanelQuote_Discord.Name = "ucPanelQuote_Discord";
            this.ucPanelQuote_Discord.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote_Discord.Size = new System.Drawing.Size(371, 53);
            this.ucPanelQuote_Discord.TabIndex = 1;
            // 
            // ucBtnImg_Discord
            // 
            this.ucBtnImg_Discord.BackColor = System.Drawing.Color.White;
            this.ucBtnImg_Discord.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImg_Discord.BtnFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImg_Discord.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg_Discord.BtnText = "           Discord：https://discord.gg/yQf7SKPy";
            this.ucBtnImg_Discord.ConerRadius = 5;
            this.ucBtnImg_Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImg_Discord.EnabledMouseEffect = false;
            this.ucBtnImg_Discord.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImg_Discord.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImg_Discord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg_Discord.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg_Discord.Image")));
            this.ucBtnImg_Discord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImg_Discord.ImageFontIcons = null;
            this.ucBtnImg_Discord.IsRadius = true;
            this.ucBtnImg_Discord.IsShowRect = true;
            this.ucBtnImg_Discord.IsShowTips = false;
            this.ucBtnImg_Discord.Location = new System.Drawing.Point(9, 6);
            this.ucBtnImg_Discord.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImg_Discord.Name = "ucBtnImg_Discord";
            this.ucBtnImg_Discord.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImg_Discord.RectWidth = 1;
            this.ucBtnImg_Discord.Size = new System.Drawing.Size(354, 42);
            this.ucBtnImg_Discord.TabIndex = 0;
            this.ucBtnImg_Discord.TabStop = false;
            this.ucBtnImg_Discord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg_Discord.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImg_Discord.TipsText = "";
            this.ucBtnImg_Discord.BtnClick += new System.EventHandler(this.ucBtnImg_Discord_BtnClick);
            // 
            // ucPanelQuote_Mail
            // 
            this.ucPanelQuote_Mail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.ucPanelQuote_Mail.Controls.Add(this.ucBtnImg_Email);
            this.ucPanelQuote_Mail.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(108)))), ((int)(((byte)(122)))));
            this.ucPanelQuote_Mail.Location = new System.Drawing.Point(29, 32);
            this.ucPanelQuote_Mail.Name = "ucPanelQuote_Mail";
            this.ucPanelQuote_Mail.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote_Mail.Size = new System.Drawing.Size(371, 53);
            this.ucPanelQuote_Mail.TabIndex = 0;
            // 
            // ucBtnImg_Email
            // 
            this.ucBtnImg_Email.BackColor = System.Drawing.Color.White;
            this.ucBtnImg_Email.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImg_Email.BtnFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImg_Email.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg_Email.BtnText = "Email：acting@111.com";
            this.ucBtnImg_Email.ConerRadius = 5;
            this.ucBtnImg_Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImg_Email.EnabledMouseEffect = false;
            this.ucBtnImg_Email.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImg_Email.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImg_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg_Email.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg_Email.Image")));
            this.ucBtnImg_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImg_Email.ImageFontIcons = null;
            this.ucBtnImg_Email.IsRadius = true;
            this.ucBtnImg_Email.IsShowRect = true;
            this.ucBtnImg_Email.IsShowTips = false;
            this.ucBtnImg_Email.Location = new System.Drawing.Point(9, 6);
            this.ucBtnImg_Email.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImg_Email.Name = "ucBtnImg_Email";
            this.ucBtnImg_Email.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImg_Email.RectWidth = 1;
            this.ucBtnImg_Email.Size = new System.Drawing.Size(354, 42);
            this.ucBtnImg_Email.TabIndex = 1;
            this.ucBtnImg_Email.TabStop = false;
            this.ucBtnImg_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg_Email.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImg_Email.TipsText = "";
            this.ucBtnImg_Email.BtnClick += new System.EventHandler(this.ucBtnImg_Email_BtnClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucPanelQuote_Bulletin);
            this.tabPage1.Controls.Add(this.label_leftTime);
            this.tabPage1.Controls.Add(this.label_days);
            this.tabPage1.Controls.Add(this.label_leftTimelabel);
            this.tabPage1.Controls.Add(this.label_welcome);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ares";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucPanelQuote_Bulletin
            // 
            this.ucPanelQuote_Bulletin.BorderColor = System.Drawing.Color.Transparent;
            this.ucPanelQuote_Bulletin.Controls.Add(this.label_bulletin);
            this.ucPanelQuote_Bulletin.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucPanelQuote_Bulletin.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucPanelQuote_Bulletin.Location = new System.Drawing.Point(14, 192);
            this.ucPanelQuote_Bulletin.Name = "ucPanelQuote_Bulletin";
            this.ucPanelQuote_Bulletin.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote_Bulletin.Size = new System.Drawing.Size(405, 84);
            this.ucPanelQuote_Bulletin.TabIndex = 6;
            // 
            // label_bulletin
            // 
            this.label_bulletin.BackColor = System.Drawing.Color.White;
            this.label_bulletin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_bulletin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_bulletin.Location = new System.Drawing.Point(8, 4);
            this.label_bulletin.Name = "label_bulletin";
            this.label_bulletin.Size = new System.Drawing.Size(381, 75);
            this.label_bulletin.TabIndex = 0;
            this.label_bulletin.Text = "正在获取公告请稍后......\r\n正在获取公告请稍后......\r\n正在获取公告请稍后......";
            this.label_bulletin.Click += new System.EventHandler(this.label_bulletin_Click);
            // 
            // label_leftTime
            // 
            this.label_leftTime.AutoSize = true;
            this.label_leftTime.BackColor = System.Drawing.Color.Transparent;
            this.label_leftTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_leftTime.Location = new System.Drawing.Point(11, 155);
            this.label_leftTime.Name = "label_leftTime";
            this.label_leftTime.Size = new System.Drawing.Size(317, 26);
            this.label_leftTime.TabIndex = 4;
            this.label_leftTime.Text = "0 Hours，0 Minutes，0 Seconds";
            // 
            // label_days
            // 
            this.label_days.AutoSize = true;
            this.label_days.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label_days.Location = new System.Drawing.Point(205, 105);
            this.label_days.Name = "label_days";
            this.label_days.Size = new System.Drawing.Size(137, 46);
            this.label_days.TabIndex = 3;
            this.label_days.Text = "0 Days";
            // 
            // label_leftTimelabel
            // 
            this.label_leftTimelabel.Font = new System.Drawing.Font("微软雅黑", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_leftTimelabel.Location = new System.Drawing.Point(3, 92);
            this.label_leftTimelabel.Name = "label_leftTimelabel";
            this.label_leftTimelabel.Size = new System.Drawing.Size(222, 70);
            this.label_leftTimelabel.TabIndex = 5;
            this.label_leftTimelabel.Text = "剩余时间";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("微软雅黑", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.label_welcome.Location = new System.Drawing.Point(3, 11);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(383, 75);
            this.label_welcome.TabIndex = 1;
            this.label_welcome.Text = "欢迎使用Ares";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "功能页面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_云端参数2);
            this.tabPage3.Controls.Add(this.label_云端参数1);
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(438, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "云端参数";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_云端参数2
            // 
            this.label_云端参数2.AutoSize = true;
            this.label_云端参数2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_云端参数2.Location = new System.Drawing.Point(109, 148);
            this.label_云端参数2.Name = "label_云端参数2";
            this.label_云端参数2.Size = new System.Drawing.Size(219, 38);
            this.label_云端参数2.TabIndex = 2;
            this.label_云端参数2.Text = "将会在下个版本发布时上线此功能\r\n敬请期待感谢关注";
            this.label_云端参数2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_云端参数1
            // 
            this.label_云端参数1.AutoSize = true;
            this.label_云端参数1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_云端参数1.Location = new System.Drawing.Point(19, 91);
            this.label_云端参数1.Name = "label_云端参数1";
            this.label_云端参数1.Size = new System.Drawing.Size(402, 42);
            this.label_云端参数1.TabIndex = 1;
            this.label_云端参数1.Text = "很抱歉，当前功能尚未上线";
            this.label_云端参数1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.BorderStyleSize = 1;
            this.ClientSize = new System.Drawing.Size(470, 353);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ucHorizontalList);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsFullSize = false;
            this.IsShowMaskDialog = true;
            this.IsShowRegion = true;
            this.Name = "MainForm";
            this.RegionRadius = 25;
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ucPanelQuote_WebSite.ResumeLayout(false);
            this.ucPanelQuote_Discord.ResumeLayout(false);
            this.ucPanelQuote_Mail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ucPanelQuote_Bulletin.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCHorizontalList ucHorizontalList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label_云端参数2;
        private System.Windows.Forms.Label label_云端参数1;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote_Mail;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote_Discord;
        private HZH_Controls.Controls.UCBtnImg ucBtnImg_Discord;
        private HZH_Controls.Controls.UCBtnImg ucBtnImg_Email;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote_WebSite;
        private HZH_Controls.Controls.UCBtnImg ucBtnImg_WebSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_days;
        private System.Windows.Forms.Label label_leftTime;
        private System.Windows.Forms.Label label_leftTimelabel;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote_Bulletin;
        private System.Windows.Forms.Label label_bulletin;
    }
}