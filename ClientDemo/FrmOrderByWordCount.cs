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
    public partial class FrmOrderByWordCount : Form
    {
        public FrmOrderByWordCount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
        }

        //窗体加载
        private void FrmOrderByWordCount_Load(object sender, EventArgs e)
        {
            //显示数据
            for (int i = 0; i < 12; i++)
            {
                ListViewItem item = new ListViewItem((i + 1) + "字歌曲");
                item.Tag = i + 1;
                this.lvWordCount.Items.Add(item);
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

        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList fosl = new FrmOrderedSongList();
            fosl.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要切歌吗?", "提示", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                PlayList.CutSong(-1);
            }
        }
        //单击组件时 事件发生
        private void lvWordCount_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.lvWordCount.SelectedItems[0].Tag.ToString());
            FrmSongList fsl = new FrmSongList();
            fsl.Sql = String.Format(@"select  song_id, song_url ,song_name,singer_name from song_info inner
                                    join singer_info on song_info.singer_id = singer_info.singer_id 
                            where song_info.song_word_count='{0}' ", this.lvWordCount.SelectedItems[0].Tag.ToString());
            fsl.Previois = PrevioisForm.WordCount;
            fsl.Show();
            this.Close();
        }
    }
}
