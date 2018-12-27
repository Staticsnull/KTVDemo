using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    //定义歌曲播放状态的枚举值
    public enum SongPlayState
    {
        unplayed,played,again,cut
    }
    //歌曲类 封装歌曲名 歌曲路径 歌曲的播放状态
    public class Song
    {
        public String SongName { get; set; }
        public String SongUrl { get; set; }
        //初始化歌曲状态为 未播放
        private SongPlayState playState = SongPlayState.unplayed;
        public SongPlayState PlayState
        {
            get
            {
                return playState;
            }
            set
            {
                playState = value;
            }
        }
        //播放歌曲
        public void SetSongPlayed()
        {
            this.playState = SongPlayState.played;
        }
        //重播
        public void SetSongAgain()
        {
            this.playState = SongPlayState.again;
        }
        //切歌
        public void SetSongCut()
        {
            this.playState = SongPlayState.cut;
        }
    }
}
