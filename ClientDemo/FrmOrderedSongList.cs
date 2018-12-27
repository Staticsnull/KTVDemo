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
    public partial class FrmOrderedSongList : Form
    {
        public FrmOrderedSongList()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
        }

        private void FrmOrderedSongList_Load(object sender, EventArgs e)
        {
            RefreshSongList();
            //timer1.Start();
        }
        //刷新歌曲
        public void RefreshSongList()
        {
            if (this.lvSongList.Items.Count > 0)
            {
                //注意数据不能被panel控件挡住
                this.lvSongList.Items.Clear();//清空列表
            }
            int i = 0;
            while (PlayList.SongList[i] != null)
            {
                ListViewItem lvi = new ListViewItem(PlayList.SongList[i].SongName);
                lvi.Tag = i;
                String palyState = PlayList.SongList[i].PlayState == SongPlayState.played ? "已播放" : "未播放";
                lvi.SubItems.Add(palyState);
                Console.WriteLine(lvi.Text);
                this.lvSongList.Items.Add(lvi);
                i++;
            }

        }

        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAgain_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }

        //切歌
        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认切歌吗?", "提示", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                int singerId = -1;
                if(this.lvSongList.SelectedItems.Count > 0)
                {
                    singerId =Convert.ToInt32(this.lvSongList.SelectedItems[0].Tag);
                }
                //切歌
                PlayList.CutSong(singerId);
                //刷新
                RefreshSongList();
            }
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您启用了呼叫服务!");
        }

        //定时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            //调用刷新歌曲列表
            RefreshSongList();
        }

        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            //RefreshSongList();
        }
    }
}
