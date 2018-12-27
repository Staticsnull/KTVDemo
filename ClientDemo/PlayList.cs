using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    /// <summary>
    /// 歌曲列表管理
    /// </summary>
    public class PlayList
    {
        // 歌曲播放列表数组
        private static Song[] songList = new Song[100];
        // 当前播放的歌曲在数组中的索引      
        private static int songIndex = 0;
        //提供方法获取播放列表的数组
        //封装数组的属性
        public static Song[] SongList
        {
            get
            {
                return PlayList.songList;
            }
        }
        //封装播放列表下标的属性
        public static int SongIndex
        {
            get
            {
                return PlayList.songIndex;
            }
        }
        //当前播放的歌曲名称
        public static String PlayingSongName()
        {
            String songName = "";
            if(SongList[SongIndex] != null)
            {
                songName = SongList[SongIndex].SongName;
            }
            return songName;
        }
        //当前播放的歌曲
        public static Song GetPlayingSong()
        {
            if(SongList[SongIndex] != null)
            {
                return SongList[SongIndex];
            }
            else
            {
                return null;
            }
        }
        //下一首要播放的歌曲名
        public static String NextSongName()
        {
            String songName = "";//歌曲名称
            if(SongList[SongIndex+1] != null)
            {
                songName = SongList[SongIndex + 1].SongName;
            }
            return songName;
        }
        //点播一首歌曲
        public static bool AddSong(Song song)
        {
            bool success = false;
            for (int i = 0; i < SongList.Length; i++)
            {
                //将歌曲循环添加到数组中
                if (null == SongList[i])
                {
                    SongList[i] = song;
                    success = true;
                    break;
                }
            }
            return success;
        }
        //重新播放当前歌曲
        public static void PlayAgain()
        {
            if(SongList[songIndex] != null)
            {
                SongList[songIndex].SetSongAgain();
            }
        }
        //播放下一首歌曲
        public static void MoveOn()
        {
            if(SongList[songIndex] != null && SongList[songIndex].PlayState == SongPlayState.again)
            {
                //
                SongList[songIndex].SetSongPlayed();
            }
            else
            {
                songIndex++;
            }
        }
        //切歌
        public static void CutSong(int index)
        {
            //判断下标
            int i;
            if(index == -1)
            {
                i = SongIndex;
            }
            else
            {
                i = index;
            }
            //设置状态为切歌状态
            SongList[i].SetSongCut();
            //使用循环遍历数组
            while (SongList[i] != null)
            {
                //位移元素
                SongList[i] = SongList[i + 1];
                i++;
                //若数组达到最后一个元素 将元素值设置为空
                if (i == SongList.Length)
                {
                    SongList[i] = null;
                }
            }
        }
    }
}
