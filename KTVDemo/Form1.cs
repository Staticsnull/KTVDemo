using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KTVDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //使用流读取图片
            FileStream fs = new FileStream("D:\\Pictures\\2018.jpg", FileMode.Open);
            this.pictureBox1.Image = Image.FromStream(fs);
            //关闭流
            fs.Close();
        }

        /// <summary>
        /// 浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //获取文件名字 用来判断后缀是否符合要求
            string fileName = this.openFileDialog1.SafeFileName;
            //获取文件的完整路径 用来显示图片
            string fullName = this.openFileDialog1.FileName;
            //MessageBox.Show(fileName);
            if(fileName.EndsWith(".jpg") || fileName.EndsWith(".mkv"))
            {
                MessageBox.Show("文件符合要求");
                this.pictureBox1.Image = Image.FromFile(fullName);
                //File.Copy(fullName, "D:\\周杰伦.mkv");
                //删除之前的图片
                File.Delete("D:\\Pictures\\2018.jpg");
            }
            else
            {
                MessageBox.Show("不符合要求");
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Tag = this;
            form4.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }
    }
}
