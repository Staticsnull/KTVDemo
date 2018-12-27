using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTVDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //当前页
        int pageIndex = 1;
        //总页数
        int totalCount = 0;
        //页面显示的记录数
        int pageSize = 5;
        private void Form4_Load(object sender, EventArgs e)
        {
            string sql = "select count(1) from song_info";
            int count = DBHelper.ExecuteScalar(sql);//总记录数
            totalCount = count % pageSize == 0 ? count / pageSize : count / pageSize + 1;
            this.label3.Text = "共" + totalCount + "页";
            BindData();
        }

        public void BindData()
        {
            string sql = string.Format(@"SELECT TOP {0} * FROM[MyKTV].[dbo].[song_info]
                          where song_id not in
                            (
                             select top({0}*({1} -1)) song_id from[song_info]
                             order by song_id
	                        )
                          order by song_id ", pageSize, pageIndex);
            this.dataGridView1.DataSource = DBHelper.GetTable(sql);
            this.label2.Text = "当前" + pageIndex + "页";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            BindData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pageIndex = totalCount;
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pageIndex == 1)
            {
                MessageBox.Show("已经是首页了");
            }
            else
            {
                pageIndex--;
            }
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageIndex == totalCount)
            {
                MessageBox.Show("已经是末页了");
            }
            else
            {
                pageIndex++;
            }
            BindData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(this.textBox1.Text);
            if(input <= 0 || input > totalCount)
            {
                MessageBox.Show("输入有误");
            }
            else
            {
                pageIndex = input;
                BindData();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            (this.Tag as Form1).textBox1.Text =  this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
