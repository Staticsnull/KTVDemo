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
    public partial class FrmOrderBySongType : Form
    {
        public FrmOrderBySongType()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(620, 100);
        }
        //窗体加载事件
        private void FrmOrderBySongType_Load(object sender, EventArgs e)
        {
            String sql = "SELECT [songtype_id],[songtype_name]FROM[MyKTV].[dbo].[song_type]";
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            this.lvListType.Items.Clear();
            int i = 0;
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader["songtype_name"].ToString(),i);
                lvi.Tag = reader["songtype_id"];
                this.lvListType.Items.Add(lvi);
                i++;
            }
            reader.Close();
        }
        //选择歌曲类型
        private void lvListType_Click(object sender, EventArgs e)
        {
            FrmSongList songList = new FrmSongList();
            songList.Sql = String.Format(@"SELECT song_id,song_url,song_name,singer_name
                          FROM [MyKTV].[dbo].[song_type] t join [MyKTV].[dbo].[song_info] i
                          on t.songtype_id = i.songtype_id  join [MyKTV].[dbo].[singer_info] s
                          on i.singer_id = s.singer_id where t.songtype_id ='{0}' ", this.lvListType.SelectedItems[0].Tag);
            //songList.Tag = ;
            songList.Previois = PrevioisForm.SongType;
            songList.Show();
            this.Close();
        }
        //
        private void tsbtnOrdered_Click(object sender, EventArgs e)
        {
            FrmOrderedSongList fosl = new FrmOrderedSongList();
            fosl.Show();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
