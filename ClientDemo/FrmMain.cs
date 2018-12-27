using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
            //this.Location = new Point(SystemInformation.WorkingArea.Width - this.Width, SystemInformation.WorkingArea.Height - this.Height);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化歌手图片路径和歌曲路径
            InitialPhotoPath();
            //启动定时器
            this.timer1.Start();
            //启动播放窗体
            FrmPlayer player = new FrmPlayer();
            this.Tag = player;//绑定窗体的tag属性
            player.Show();
        }
        //初始化歌手图片路径和歌曲路径
        public void InitialPhotoPath()
        {
            //初始化歌手图片和歌曲图片路径
            String sql = "select * from [resource_path] where resource_id=1";
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            if (reader.Read())
            {
                //注意列名千万别写错 下标越界了就是列名写错了
                KTVUtil.SingerPhotoPath = reader["resource_path"].ToString();
            }
            reader.Close();
            String sqlSong = "select * from [resource_path] where resource_type='song';";
            SqlDataReader songReader = DBHelper.ExecuteReader(sqlSong);
            if (songReader.Read())
            {
                //列名
                KTVUtil.SongPhotoPath = songReader["resource_path"].ToString();
            }
            songReader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowPlayingSongName();
        }
        //显示当前播放歌曲的名字
        public void ShowPlayingSongName()
        {
            this.lblPlayingSong.Text = PlayList.PlayingSongName();
            this.lblNextSong.Text = PlayList.NextSongName();
        }
        
        //类型选择
        private void picSongType_Click(object sender, EventArgs e)
        {
            FrmOrderBySongType fobt = new FrmOrderBySongType();
            fobt.Show();
        }
        //按照歌手查询
        private void picSinger_Click(object sender, EventArgs e)
        {
            FrmOrderBySinger fobs = new FrmOrderBySinger();
            fobs.Show();
        }
        //字数点歌
        private void picWordCount_Click(object sender, EventArgs e)
        {
            FrmOrderByWordCount fobc = new FrmOrderByWordCount();
            fobc.Show();
        }
        //按照歌曲名查询 拼音点歌
        private void picSongName_Click(object sender, EventArgs e)
        {
            FrmOrderBySongName fobs = new FrmOrderBySongName();
            fobs.Show();
        }
        //排行榜点歌
        private void picSongList_Click(object sender, EventArgs e)
        {
            FrmSongList fsl = new FrmSongList();
            fsl.Sql = @"select top 20 song_id, song_url ,song_name,singer_name from song_info inner
                join singer_info on song_info.singer_id=singer_info.singer_id order by song_play_count desc";
            //使用枚举常量 绑定窗体跳转属性
            fsl.Previois = PrevioisForm.Main;
            fsl.Show();
        }
        
        //重唱
        private void tsbtnAgain_Click(object sender, EventArgs e)
        {
            //重新播放当前歌曲
            PlayList.PlayAgain();
        }
        //切歌
        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认切歌吗?", "提示", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                //切歌
                PlayList.CutSong(-1);
                toolStripButton2.Text = "原唱";
            }
        }
        //点歌 窗体
        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList fosl = new FrmOrderedSongList();
            fosl.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您启用呼叫服务..", "提示");
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboMV_Click(object sender, EventArgs e)
        {
            String sql = String.Format(@"select song_id, song_url ,song_name,singer_name from song_info inner
                join singer_info on song_info.singer_id = singer_info.singer_id where songtype_id=2 ");
            FrmSongList fsl = new FrmSongList();
            //KTVUtil.IsMv = true;
            fsl.Sql = sql;
            fsl.Show();
            //this.Close();
        }
        //原唱
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmPlayer player = this.Tag as FrmPlayer;//强制转换
            WMPLib.IWMPControls3 iwmpc = (player.axWindowsMediaPlayer1.Ctlcontrols as WMPLib.IWMPControls3);
            //判断控件的状态
            if (iwmpc.currentAudioLanguageIndex == 1)
            {
                iwmpc.currentAudioLanguageIndex = 2;//2为伴奏
                this.toolStripButton2.Text = "伴奏";
            }
            else
            {
                iwmpc.currentAudioLanguageIndex = 1;//1为原唱
                this.toolStripButton2.Text = "原唱";
            }
        }
    }
}
