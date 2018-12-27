using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ClientDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            //this.axWindowsMediaPlayer1.URL = "D:\\Program Files\\MyKTV\\MP4\\王菲 - 传奇.mp4";
            //timer1.Interval = 50000;
            //this.Close();
            //this.
            //this.Close();
            //判断当前播放视频的状态: WMPLib.WMPPlayState.wmppsStopped
            //若当前视频播放的状态为 WMPLib.WMPPlayState.wmppsStopped 停止状态
            //说明该视频已经播放完毕 然后关闭窗体
            //if (this.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            //{
                
            //    this.Close();
            //}
        }
        String[] urls = { @"D:\Program Files\MyKTV\song\麦子杰 - 少年梦.mkv",
                            "D:\\Program Files\\MyKTV\\song\\亚东 - 卓玛.mkv",
                            "D:\\Program Files\\MyKTV\\song\\张雨生 - 我的未来不是梦.mkv",
                            "D:\\Program Files\\MyKTV\\song\\汪峰 - 光明.mkv",
                            "D:\\Program Files\\MyKTV\\song\\等你等了那么久.mkv",
                            "D:\\Program Files\\MyKTV\\song\\郑智化 - 星星点灯.mkv",
                            "D:\\Program Files\\MyKTV\\song\\白晓 - 贝加尔湖畔.mkv",
                            "D:\\Program Files\\MyKTV\\song\\李翊君 - 雨蝶.mkv",
                            "D:\\Program Files\\MyKTV\\song\\童年.mkv",
                            "D:\\Program Files\\MyKTV\\song\\明天会更好.mkv",
                            "D:\\Program Files\\MyKTV\\song\\朴树 - 生如夏花.mkv",
                            "D:\\Program Files\\MyKTV\\song\\珊瑚颂.mkv",
                            "D:\\Program Files\\MyKTV\\song\\浪人情歌.mkv",
                            "D:\\Program Files\\MyKTV\\song\\孙露 - 小情歌.mkv",
                        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String url in urls)
            {
                IWMPMedia media = this.axWindowsMediaPlayer1.newMedia(url);
                this.axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.axWindowsMediaPlayer1.URL = "D:\\Program Files\\MyKTV\\MP4\\王菲 - 传奇.mp4";
            this.axWindowsMediaPlayer1.Ctlcontrols.next();
            this.button2.Text = "原唱";
            //his.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPControls3 iwmpc = (axWindowsMediaPlayer1.Ctlcontrols as WMPLib.IWMPControls3);
            if(iwmpc.currentAudioLanguageIndex == 1)
            {
                iwmpc.currentAudioLanguageIndex = 2;//2为伴奏
                this.button2.Text = "伴奏";
            }
            else
            {
                iwmpc.currentAudioLanguageIndex = 1;//1为原唱
                this.button2.Text = "原唱";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (axWindowsMediaPlayer1.Ctlcontrols as WMPLib.IWMPControls3).currentAudioLanguageIndex = 1;
        }
    }
}
