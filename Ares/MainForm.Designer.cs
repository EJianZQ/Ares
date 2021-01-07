
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
            this.ucListExt1 = new HZH_Controls.Controls.UCListExt();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucListExt1
            // 
            this.ucListExt1.AutoScroll = true;
            this.ucListExt1.AutoSelectFirst = true;
            this.ucListExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucListExt1.ItemBackColor = System.Drawing.Color.White;
            this.ucListExt1.ItemForeColor = System.Drawing.Color.Black;
            this.ucListExt1.ItemForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.ucListExt1.ItemHeight = 60;
            this.ucListExt1.ItemSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.ucListExt1.ItemSelectedForeColor = System.Drawing.Color.White;
            this.ucListExt1.ItemSelectedForeColor2 = System.Drawing.Color.White;
            this.ucListExt1.Location = new System.Drawing.Point(0, 61);
            this.ucListExt1.Name = "ucListExt1";
            this.ucListExt1.SelectedCanClick = false;
            this.ucListExt1.Size = new System.Drawing.Size(115, 279);
            this.ucListExt1.SplitColor = System.Drawing.Color.DeepSkyBlue;
            this.ucListExt1.TabIndex = 0;
            this.ucListExt1.Title2Font = new System.Drawing.Font("微软雅黑", 14F);
            this.ucListExt1.TitleFont = new System.Drawing.Font("微软雅黑", 15F);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(447, -1);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(25, 25);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 339);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.ucListExt1);
            this.IsFullSize = false;
            this.IsShowRegion = true;
            this.Name = "MainForm";
            this.RegionRadius = 1;
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCListExt ucListExt1;
        private System.Windows.Forms.Button button_Exit;
    }
}