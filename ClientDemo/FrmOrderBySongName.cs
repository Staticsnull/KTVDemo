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
    public partial class FrmOrderBySongName : Form
    {
        public FrmOrderBySongName()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
        }
       

        //文本框改变事件
        private void txtSongName_TextChanged(object sender, EventArgs e)
        {
            String sql = String.Format(@"SELECT song_id,song_url,song_name,singer_name
                          FROM [MyKTV].[dbo].[song_type] t join [MyKTV].[dbo].[song_info] i
                          on t.songtype_id = i.songtype_id  join [MyKTV].[dbo].[singer_info] s
                          on i.singer_id = s.singer_id where i.song_name like '%{0}%' or i.song_ab like '%{0}%' ",
                          this.txtSongName.Text);
            this.dgvSong.DataSource = DBHelper.GetTable(sql);

        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //单击组件改变事件 播放歌曲
        private void dgvSong_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("单击组件:" + this.dgvSong.CurrentRow.Cells[0].Value);
            //播放歌曲
            Song song = new Song();
            song.SongUrl = this.dgvSong.CurrentRow.Cells[1].Value.ToString();
            song.SongName = this.dgvSong.CurrentRow.Cells[2].Value.ToString();
            //添加播放列表中
            if (PlayList.AddSong(song))
            {
                //修改点播次数
                String sql = String.Format(@"update song_info set song_play_count = song_play_count+1
                            where song_id='{0}'", this.dgvSong.CurrentRow.Cells[0].Value);
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
        //重唱
        private void tsbtnAgain_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }
        //切歌
        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要切换到下一首个吗?", "提示", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                PlayList.CutSong(-1);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您使用了呼叫服务!");
        }
        //主界面
        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //点播歌曲
        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList fosl = new FrmOrderedSongList();
            fosl.Show();
        }
    }
}
