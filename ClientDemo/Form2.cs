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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //获取总页码
        //int count = 0;
        int pageSize = 5;//页面记录数
        int pageIndex = 1;
        int totalCount = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "select count(1) from [song_info]";
            int count = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            totalCount = count % 5 == 0 ? count / 5 : count / 5 + 1;
            this.linkLabel5.Text = "共"+ totalCount + "页";
            BindSongInfo();
        }
        public void BindSongInfo()
        {
            string sql = string.Format(@"SELECT TOP {0}  *
                            from[song_info] where song_id not in
	                        (
                                SELECT TOP ({0} * ({1} - 1)) song_id
                                   from[song_info] order by song_id
	                        )
	                        order by song_id", pageSize, pageIndex);
            this.dataGridView1.DataSource = DBHelper.GetTable(sql);
            this.linkLabel6.Text = "当前第" + pageIndex + "页";
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = totalCount;
            BindSongInfo();
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pageIndex = 1;
            BindSongInfo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(pageIndex == 1)
            {
                MessageBox.Show("已经是首页了");
            }
            else
            {
                pageIndex--;
            }
            BindSongInfo();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(pageIndex == totalCount)
            {
                MessageBox.Show("已经是最后一页了");
            }
            else
            {
                pageIndex++;
            }
            BindSongInfo();
        }
    }
}
