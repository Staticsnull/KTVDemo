using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // ADO.NET

namespace ClientDemo
{
    public partial class FrmOrderBySinger : Form
    {
        private string singerSex = "男"; // 当前选择的歌手性别
        private int singerTypeId = 0;  // 当前选择的歌手类型的编号
        
        public FrmOrderBySinger()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
        }

        // 点击后，显示歌手类别
        private void lvOrder_Click(object sender, EventArgs e)
        {
            if (lvOrder.SelectedItems[0] != null)
            {
                // 隐藏歌手性别，显示歌手类别
                pnlSingerSex.Visible = false;
                pnlSingerType.Location = pnlSingerSex.Location;
                pnlSingerType.Dock = DockStyle.Fill;
                pnlSingerType.Visible = true;
                this.singerSex = Convert.ToString(lvOrder.SelectedItems[0].Tag);  // 记录选择的性别
            }      
    
            // 读取歌手类别
            //DBHelper dbHelper = new DBHelper();
            string sql = "select * from singer_type";
            try
            {
                // 查询数据库
                //SqlCommand command = new SqlCommand(sql, dbHelper.Connection);
                //dbHelper.OpenConnection();
                SqlDataReader reader =DBHelper.ExecuteReader(sql);

                // 循环将类别读取出来添加到ListView中
                lvSingerType.Items.Clear();
                int i = 0;
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = Convert.ToString(reader["singertype_name"]);
                    item.Tag = Convert.ToInt32(reader["singertype_id"]);
                    item.ImageIndex = i;
                    lvSingerType.Items.Add(item);
                    i++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("系统错误，请联系服务人员！"+ex.Message);
                
            }
        }

        // 点击类别后，显示对应类别下的歌手列表
        private void lvSingerType_Click(object sender, EventArgs e)
        {
            // 隐藏歌手类别，显示歌手列表
            pnlSingerType.Visible = false;
            pnlSingerList.Location = pnlSingerSex.Location;
            pnlSingerList.Dock = DockStyle.Fill;
            pnlSingerList.Visible = true;
            this.singerTypeId = Convert.ToInt32(lvSingerType.SelectedItems[0].Tag); // 保存选中的类别编号
            
            // 读取数据库，读出歌手信息
            DBHelper dbHelper = new DBHelper();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select singer_id,singer_name,singer_photo_url from singer_info where singertype_id={0} and singer_gender='{1}'",
                this.singerTypeId,this.singerSex);
           
            try
            {
                //SqlCommand command = new SqlCommand(sql.ToString(),dbHelper.Connection);
                //dbHelper.OpenConnection();
                SqlDataReader reader = DBHelper.ExecuteReader(sql.ToString());

                int imageIndex = 0; // 代表歌手头像的索引
                ilSinger.Images.Clear();

                // 循环读出歌手信息添加到窗体中显示
                lvSinger.Items.Clear();
                while (reader.Read())
                {
                    // 将歌手头像放在ImageList控件中
                    string photoURL = KTVUtil.SingerPhotoPath + "\\" + Convert.ToString(reader["singer_photo_url"]);
                    ilSinger.Images.Add(Image.FromFile(photoURL));

                    // 将歌手添加到ListView中
                    ListViewItem item = new ListViewItem();
                    item.Text = Convert.ToString(reader["singer_name"]);
                    item.Tag = Convert.ToString(reader["singer_id"]);                   
                    item.ImageIndex = imageIndex;
                    lvSinger.Items.Add(item);

                    imageIndex++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("系统错误，请联系服务人员！"+ex.Message);
            }
        }

        // 点击歌手姓名，打开歌曲列表窗口
        private void lvSinger_Click(object sender, EventArgs e)
        {
            // 读取数据库，读出该歌手的所有歌曲
            DBHelper dbHelper = new DBHelper();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select song_id,song_name, singer_name='{0}',song_url  from song_info where singer_id={1}",
                lvSinger.SelectedItems[0].Text, Convert.ToInt32(lvSinger.SelectedItems[0].Tag));

            FrmSongList songList = new FrmSongList();
            songList.Sql = sb.ToString();
            songList.Previois = PrevioisForm.Singer; // 指定返回的窗体是按歌手点歌
            songList.Show();
            this.Close();
        }

        // 关闭当前窗体，显示主界面
        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 重新播放当前歌曲
        private void tsbtnAgain_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }

        // 切歌
        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要切歌吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                PlayList.CutSong(-1);
            }
        }

        // 打开已点歌曲窗体
        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList orderedForm = new FrmOrderedSongList();
            orderedForm.Show();
        }

        // 呼叫服务
        private void tsbtnService_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您发出了呼叫服务！");
        }

        // 处理返回按钮的事件
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            if (this.pnlSingerList.Visible)
            {
                this.pnlSingerType.Visible = true;
                this.pnlSingerList.Visible = false;
            }
            else if (this.pnlSingerType.Visible)
            {
                this.pnlSingerSex.Visible = true;
                this.pnlSingerType.Visible = false;
            }
            else if (this.pnlSingerSex.Visible)
            {
                this.Close();
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvSingerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
