using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDemo
{
    public partial class Form5 : Form
    {
        //歌曲窗体的成员变量
        public Form4 frm;
        public Form5()
        {
            InitializeComponent();
        }
        //下标改变的事件
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //将歌曲窗体的文件控件的值 指定为combobox的文本信息
            this.frm.txtName.Text = this.cboName.Text;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Tag = f;
            //调用歌曲窗体的加载事件
            f.Form6_Load(sender, e);
            f.PlayMusic();
            //f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //切歌
            //调用歌曲窗体的 切歌事件
            ((Form6)(this.Tag)).button1_Click(sender, e);
        }
    }
}
