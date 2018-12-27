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

namespace KTVDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        string[] urls =
        {
            @"D:\Program Files\MyKTV\song\BEYOND - 大地 (粤语).mkv",
            @"D:\Program Files\MyKTV\song\朴树 - 生如夏花.mkv",
            @"D:\Program Files\MyKTV\song\周传雄 - 寂寞沙洲冷.mkv",
            @"D:\Program Files\MyKTV\song\周杰伦、费玉清 - 千里之外.mkv"
        };
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.uiMode = "Mini";
            //Full:有控制条 显示整个界面
            //None:只有播放部分 没有控制条
            //Mini:迷你模式 有控制条但是不能操作
            //Invisible:不显示图像,只有音频
            //this.axWindowsMediaPlayer2.URL = @"D:\Program Files\MyKTV\song\李翊君 - 雨蝶.mkv";
            foreach (string url in urls)
            {
                //根据url创建新的媒体播放设备
                IWMPMedia media = this.axWindowsMediaPlayer2.newMedia(url);
                //将媒体添加到当前播放列表中
                this.axWindowsMediaPlayer2.currentPlaylist.appendItem(media);
                this.axWindowsMediaPlayer2.Ctlcontrols.play();//播放当前歌曲
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.Ctlcontrols.next();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.Ctlcontrols.stop();
            this.axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.Ctlcontrols.pause();//暂停
        }
            
        private void button3_Click(object sender, EventArgs e)
        {
            IWMPControls3 controls3 = (this.axWindowsMediaPlayer2.Ctlcontrols as WMPLib.IWMPControls3);
            if(controls3.currentAudioLanguageIndex == 1)//原唱
            {
                controls3.currentAudioLanguageIndex = 2;//切换为伴奏
                this.button3.Text = "伴奏";
            }
            else
            {
                controls3.currentAudioLanguageIndex = 1;//切换为原唱
                this.button3.Text = "原唱";
            }
        }
        //增加音量
        private void button4_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.settings.volume++;
        }
        //减少音量
        private void button5_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.settings.volume--;
        }
        //设置为静音
        private void button6_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.settings.mute = true;
        }
    }
}
