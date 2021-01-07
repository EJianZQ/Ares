using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Forms;
using HZH_Controls.Controls;

namespace Ares
{
    public partial class MainForm : FrmBase
    {
        public MainForm()
        {
            InitializeComponent();

            /*List<ListEntity> list = new List<ListEntity>();
            ListEntity listEntity1 = new ListEntity();
            ListEntity listEntity2 = new ListEntity();
            ListEntity listEntity3 = new ListEntity();
            listEntity1.ID = "1";
            listEntity1.Title = "Ares";
            list.Add(listEntity1);
            listEntity2.ID = "2";
            listEntity2.Title = "功能界面";
            list.Add(listEntity2);
            listEntity3.ID = "3";
            listEntity3.Title = "云端参数";
            list.Add(listEntity3);
            this.ucListExt1.SetList(list);*/
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
