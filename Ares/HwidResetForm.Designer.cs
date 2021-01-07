
namespace Ares
{
    partial class HwidResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HwidResetForm));
            this.ucBtnExt_Hwid = new HZH_Controls.Controls.UCBtnExt();
            this.textBoxEx_Content = new HZH_Controls.Controls.TextBoxEx();
            this.ucBtnExt_Cancel = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // ucBtnExt_Hwid
            // 
            this.ucBtnExt_Hwid.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_Hwid.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_Hwid.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_Hwid.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_Hwid.BtnText = "确 认 解 绑";
            this.ucBtnExt_Hwid.ConerRadius = 10;
            this.ucBtnExt_Hwid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_Hwid.EnabledMouseEffect = false;
            this.ucBtnExt_Hwid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_Hwid.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_Hwid.IsRadius = true;
            this.ucBtnExt_Hwid.IsShowRect = true;
            this.ucBtnExt_Hwid.IsShowTips = false;
            this.ucBtnExt_Hwid.Location = new System.Drawing.Point(79, 244);
            this.ucBtnExt_Hwid.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_Hwid.Name = "ucBtnExt_Hwid";
            this.ucBtnExt_Hwid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_Hwid.RectWidth = 1;
            this.ucBtnExt_Hwid.Size = new System.Drawing.Size(121, 40);
            this.ucBtnExt_Hwid.TabIndex = 7;
            this.ucBtnExt_Hwid.TabStop = false;
            this.ucBtnExt_Hwid.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_Hwid.TipsText = "";
            this.ucBtnExt_Hwid.BtnClick += new System.EventHandler(this.ucBtnExt_Hwid_BtnClick);
            // 
            // textBoxEx_Content
            // 
            this.textBoxEx_Content.DecLength = 2;
            this.textBoxEx_Content.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEx_Content.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEx_Content.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx_Content.Location = new System.Drawing.Point(30, 82);
            this.textBoxEx_Content.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxEx_Content.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxEx_Content.Multiline = true;
            this.textBoxEx_Content.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx_Content.Name = "textBoxEx_Content";
            this.textBoxEx_Content.OldText = null;
            this.textBoxEx_Content.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx_Content.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx_Content.PromptText = "";
            this.textBoxEx_Content.ReadOnly = true;
            this.textBoxEx_Content.RegexPattern = "";
            this.textBoxEx_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEx_Content.Size = new System.Drawing.Size(390, 141);
            this.textBoxEx_Content.TabIndex = 8;
            this.textBoxEx_Content.TabStop = false;
            this.textBoxEx_Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucBtnExt_Cancel
            // 
            this.ucBtnExt_Cancel.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_Cancel.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_Cancel.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_Cancel.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_Cancel.BtnText = "取 消 解 绑";
            this.ucBtnExt_Cancel.ConerRadius = 10;
            this.ucBtnExt_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_Cancel.EnabledMouseEffect = false;
            this.ucBtnExt_Cancel.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.ucBtnExt_Cancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_Cancel.IsRadius = true;
            this.ucBtnExt_Cancel.IsShowRect = true;
            this.ucBtnExt_Cancel.IsShowTips = false;
            this.ucBtnExt_Cancel.Location = new System.Drawing.Point(260, 244);
            this.ucBtnExt_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_Cancel.Name = "ucBtnExt_Cancel";
            this.ucBtnExt_Cancel.RectColor = System.Drawing.Color.DeepSkyBlue;
            this.ucBtnExt_Cancel.RectWidth = 1;
            this.ucBtnExt_Cancel.Size = new System.Drawing.Size(121, 40);
            this.ucBtnExt_Cancel.TabIndex = 9;
            this.ucBtnExt_Cancel.TabStop = false;
            this.ucBtnExt_Cancel.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_Cancel.TipsText = "";
            this.ucBtnExt_Cancel.BtnClick += new System.EventHandler(this.ucBtnExt_Cancel_BtnClick);
            // 
            // HwidResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.BorderStyleSize = 3;
            this.BorderStyleType = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ClientSize = new System.Drawing.Size(450, 302);
            this.Controls.Add(this.ucBtnExt_Cancel);
            this.Controls.Add(this.textBoxEx_Content);
            this.Controls.Add(this.ucBtnExt_Hwid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HwidResetForm";
            this.RegionRadius = 12;
            this.Text = "HwidResetForm";
            this.Title = "Ares - 卡密解绑";
            this.Controls.SetChildIndex(this.ucBtnExt_Hwid, 0);
            this.Controls.SetChildIndex(this.textBoxEx_Content, 0);
            this.Controls.SetChildIndex(this.ucBtnExt_Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt ucBtnExt_Hwid;
        private HZH_Controls.Controls.TextBoxEx textBoxEx_Content;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_Cancel;
    }
}