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
    //切换窗体的枚举常量:Main:主窗体 Singer:歌手窗体 SongType:歌曲类型
    //WordCount:字数 SongName:歌曲名称 SongList:歌曲列表
    public enum PrevioisForm
    {
        Main, Singer, SongType, WordCount, SongName, SongList
    }
    //歌曲列表窗体
    public partial class FrmSongList : Form
    {
        public PrevioisForm Previois { get; set; }
        public FrmSongList()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
        }
        public String Sql { get; set; }
        //窗体加载事件
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            //绑定数据源
            if(this.Sql != null)
            {
                this.dgvSong.DataSource = DBHelper.GetTable(Sql);
            }
            
        }


         //单击组件触发事件 播放歌曲
        private void dgvSong_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("单击组件:" + this.dgvSong.CurrentRow.Cells[0].Value);
            //播放歌曲
            Song song = new Song();//song_url 
            song.SongUrl = this.dgvSong.CurrentRow.Cells["songURL"].Value.ToString();
            song.SongName = this.dgvSong.CurrentRow.Cells["songName"].Value.ToString();
            //添加播放列表中
            if (PlayList.AddSong(song))
            {
                //修改点播次数
                String sql = String.Format(@"update song_info set song_play_count = song_play_count+1
                            where song_id='{0}'", this.dgvSong.CurrentRow.Cells["songId"].Value);
                int count = DBHelper.ExecuteNonQuery(sql);
                if (count > 0)
                {
                    MessageBox.Show("点播成功!");
                }
                else
                {
                    MessageBox.Show("点播失败!");
                }
            }
           else
            {
                MessageBox.Show("点播失败!");
            }
        }

        

        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要切歌吗?", "提示", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                PlayList.CutSong(-1);
            }
        }

        //返回窗体
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            switch (this.Previois)
            {
                case PrevioisForm.Singer:
                    FrmOrderBySinger fobsSinger = new FrmOrderBySinger();
                    fobsSinger.Show();
                    break;
                 //返回歌曲类型点歌
                case PrevioisForm.SongType:
                    FrmOrderBySongType fobs = new FrmOrderBySongType();
                    fobs.Show();
                    break;
                case PrevioisForm.WordCount://字数点歌窗体
                    FrmOrderByWordCount fowc = new FrmOrderByWordCount();
                    fowc.Show();
                    break;
            }
            //关闭窗体
            this.Close();
        }
        //主界面
        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList fosl = new FrmOrderedSongList();
            fosl.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("启用呼叫服务");
        }

        private void tsbtnAgain_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }
    }
}
