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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static String[] strs = //new String[50];
            { "D:\\Program Files\\MyKTV\\song\\筷子兄弟 - 父亲.mp4",
                 "D:\\Program Files\\MyKTV\\song\\千里之外.mp3",
            "D:\\Program Files\\MyKTV\\song\\筷子兄弟 - 老男孩.mp4" };
        String str = null;
        private void Form3_Load(object sender, EventArgs e)
        {
            //PlayMusic();
            PlaySong();
            timer1.Start();
        }
        //播放歌曲
        public void PlaySong()
        {
            //得到歌曲
            str = GetSong();
            if (str != null)
            {
                //不为空 播放当前歌曲
                this.axWindowsMediaPlayer1.URL = str;
            }
            //if (strs[index] != null)
            //{
            //    this.axWindowsMediaPlayer1.URL = strs[index];
            //}
        }
        public String GetSong()
        {
            if(strs[index] != null)
            {
                return strs[index];
            }
            else
            {
                return null;
            }
        }
        public void PlayMusic()
        {
            //清空播放列表
            int count = this.axWindowsMediaPlayer1.currentPlaylist.count;
            if(count > 0)
            {
                this.axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            foreach (String s in strs)
            {
                //创建新的媒体
                IWMPMedia media = this.axWindowsMediaPlayer1.newMedia(s);
                //
                this.axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        static int index = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //PlayMusic();
            //借助第三方播放歌曲
            if (str == null)
            {
                PlaySong();
            }
            if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                //播放下一首
                this.str = null;
                index++;
            }
            //切歌
            if (str != null && state == 2)
            {
                this.axWindowsMediaPlayer1.URL = "";
                this.str = null;
                index++;
                state = 1;
            }
        }
        int state = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            state = 2;
            ////切换下一首
            //index
            // this.axWindowsMediaPlayer1.Ctlcontrols.next();
        }
    }
}
