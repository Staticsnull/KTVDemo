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
    public partial class FrmPlayer : Form
    {
        public FrmPlayer()
        {
            InitializeComponent();
            this.axWindowsMediaPlayer1.uiMode = "None";
        }
        private Song song;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           if(song == null)
            {
                this.PlaySong();
            }
           //播放下一首
           if(this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //将当前歌曲设置为空
                this.song = null;
                //播放下一首
                PlayList.MoveOn();
            }
           //切歌
           if(song != null && song.PlayState == SongPlayState.cut)
            {
                this.axWindowsMediaPlayer1.URL = "";
                this.song = null;
            }
        }
        public void PlaySong()
        {
            this.song = PlayList.GetPlayingSong();
            if(song != null)
            {
                //设置状态为播放状态
                song.SetSongPlayed();
                //if (KTVUtil.IsMv)
                //{ //若是mv 则播放mv
                //    this.axWindowsMediaPlayer1.URL = KTVUtil.MVInofPath + "\\" + song.SongUrl;
                //}
                //else
                //{
                    this.axWindowsMediaPlayer1.URL = KTVUtil.SongPhotoPath + "\\" + song.SongUrl;
                //}
                //播放歌曲
                Console.WriteLine(this.axWindowsMediaPlayer1.URL);
            }
        }

        private void FrmPlayer_Load(object sender, EventArgs e)
        {
            //得到歌曲
            PlaySong();
            //启动定时器
            timer1.Start();
        }

    }
}
