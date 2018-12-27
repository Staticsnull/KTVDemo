using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ClientDemo
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        String[] musics = {"D:\\Program Files\\MyKTV\\song\\筷子兄弟 - 父亲.mp4",
                 "D:\\Program Files\\MyKTV\\song\\千里之外.mp3",
            "D:\\Program Files\\MyKTV\\song\\筷子兄弟 - 老男孩.mp4"};
        public void Form6_Load(object sender, EventArgs e)
        {
            //播放歌曲
            //PlayMusic();
            //timer1.Start();
        }
        public void PlayMusic()
        {
            //清空播放列表
            int count = this.axWindowsMediaPlayer1.currentPlaylist.count;
            if(count > 0)
            {
                this.axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            foreach (String s in musics)
            {
                if(null != s)
                {
                    //获取每首歌
                    IWMPMedia meidia = this.axWindowsMediaPlayer1.newMedia(s);
                    //将歌曲追加到播放列表
                    this.axWindowsMediaPlayer1.currentPlaylist.appendItem(meidia);
                    //播放当前歌曲
                    this.axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.next();
        }
        public String music ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(music == null)
            {
                PlayMusic();
            }
            if(this.axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)
            {
                PlayMusic();
            }
        }
    }
}
