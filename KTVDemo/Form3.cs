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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.textBox2.Text = this.folderBrowserDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //移动文件
            //if (Directory.Exists(this.textBox2.Text))
            //{
            //    Directory.Delete(this.textBox2.Text);
            //}
            //Directory.Move(this.textBox1.Text, this.textBox2.Text);
            //先找到源目录
            DirectoryInfo directoryInfo = new DirectoryInfo(this.textBox1.Text);
            //获取源目录底下所有的子文件
            FileInfo[] fileInfos =  directoryInfo.GetFiles();
            foreach (FileInfo file in fileInfos)
            {
                //E:/abc/02.jpg
                // Path.Combine方法的目的是拼接两个路径字符串
                file.MoveTo(Path.Combine(this.textBox2.Text, file.Name));
            }
            MessageBox.Show("文件移动成功!");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //File.Delete(@"D:\Pictures\01.jpg");
            //MessageBox.Show("删除成功!");
        }

    }
}
