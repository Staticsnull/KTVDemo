namespace ClientDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.picWordCount = new System.Windows.Forms.PictureBox();
            this.picSongList = new System.Windows.Forms.PictureBox();
            this.picSongType = new System.Windows.Forms.PictureBox();
            this.picSongName = new System.Windows.Forms.PictureBox();
            this.picSinger = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNextSong = new System.Windows.Forms.Label();
            this.lblPlayingSong = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlMiddle.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMiddle.BackgroundImage")));
            this.pnlMiddle.Controls.Add(this.pnlCenter);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 30);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(650, 489);
            this.pnlMiddle.TabIndex = 6;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCenter.BackgroundImage")));
            this.pnlCenter.Controls.Add(this.picWordCount);
            this.pnlCenter.Controls.Add(this.picSongList);
            this.pnlCenter.Controls.Add(this.picSongType);
            this.pnlCenter.Controls.Add(this.picSongName);
            this.pnlCenter.Controls.Add(this.picSinger);
            this.pnlCenter.Location = new System.Drawing.Point(82, 69);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(394, 245);
            this.pnlCenter.TabIndex = 3;
            // 
            // picWordCount
            // 
            this.picWordCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWordCount.Location = new System.Drawing.Point(158, 133);
            this.picWordCount.Name = "picWordCount";
            this.picWordCount.Size = new System.Drawing.Size(76, 74);
            this.picWordCount.TabIndex = 4;
            this.picWordCount.TabStop = false;
            this.picWordCount.Click += new System.EventHandler(this.picWordCount_Click);
            // 
            // picSongList
            // 
            this.picSongList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongList.Location = new System.Drawing.Point(32, 133);
            this.picSongList.Name = "picSongList";
            this.picSongList.Size = new System.Drawing.Size(76, 74);
            this.picSongList.TabIndex = 3;
            this.picSongList.TabStop = false;
            this.picSongList.Click += new System.EventHandler(this.picSongList_Click);
            // 
            // picSongType
            // 
            this.picSongType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongType.Location = new System.Drawing.Point(283, 33);
            this.picSongType.Name = "picSongType";
            this.picSongType.Size = new System.Drawing.Size(76, 74);
            this.picSongType.TabIndex = 2;
            this.picSongType.TabStop = false;
            this.picSongType.Click += new System.EventHandler(this.picSongType_Click);
            // 
            // picSongName
            // 
            this.picSongName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongName.Location = new System.Drawing.Point(158, 33);
            this.picSongName.Name = "picSongName";
            this.picSongName.Size = new System.Drawing.Size(76, 74);
            this.picSongName.TabIndex = 1;
            this.picSongName.TabStop = false;
            this.picSongName.Click += new System.EventHandler(this.picSongName_Click);
            // 
            // picSinger
            // 
            this.picSinger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSinger.Location = new System.Drawing.Point(32, 34);
            this.picSinger.Name = "picSinger";
            this.picSinger.Size = new System.Drawing.Size(76, 74);
            this.picSinger.TabIndex = 0;
            this.picSinger.TabStop = false;
            this.picSinger.Click += new System.EventHandler(this.picSinger_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Controls.Add(this.lblNextSong);
            this.pnlTop.Controls.Add(this.lblPlayingSong);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 30);
            this.pnlTop.TabIndex = 4;
            // 
            // lblNextSong
            // 
            this.lblNextSong.BackColor = System.Drawing.Color.Transparent;
            this.lblNextSong.Location = new System.Drawing.Point(379, 4);
            this.lblNextSong.Name = "lblNextSong";
            this.lblNextSong.Size = new System.Drawing.Size(183, 23);
            this.lblNextSong.TabIndex = 3;
            this.lblNextSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayingSong
            // 
            this.lblPlayingSong.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayingSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayingSong.Location = new System.Drawing.Point(89, 4);
            this.lblPlayingSong.Name = "lblPlayingSong";
            this.lblPlayingSong.Size = new System.Drawing.Size(185, 23);
            this.lblPlayingSong.TabIndex = 1;
            this.lblPlayingSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.Transparent;
            this.tsMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMain.BackgroundImage")));
            this.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAgain,
            this.tsbtnCut,
            this.tsbtnOrdered,
            this.toolStripButton2,
            this.toolStripButton1,
            this.tsbtnExit});
            this.tsMain.Location = new System.Drawing.Point(0, 519);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(650, 54);
            this.tsMain.TabIndex = 5;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbtnAgain
            // 
            this.tsbtnAgain.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgain.Image")));
            this.tsbtnAgain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAgain.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnAgain.Name = "tsbtnAgain";
            this.tsbtnAgain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnAgain.Size = new System.Drawing.Size(58, 51);
            this.tsbtnAgain.Text = "重唱";
            this.tsbtnAgain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAgain.ToolTipText = "重唱";
            this.tsbtnAgain.Click += new System.EventHandler(this.tsbtnAgain_Click);
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCut.Image")));
            this.tsbtnCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnCut.Size = new System.Drawing.Size(59, 51);
            this.tsbtnCut.Text = "切歌";
            this.tsbtnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCut.Click += new System.EventHandler(this.tsbtnCut_Click);
            // 
            // tsbtnOrdered
            // 
            this.tsbtnOrdered.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOrdered.Image")));
            this.tsbtnOrdered.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOrdered.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnOrdered.Name = "tsbtnOrdered";
            this.tsbtnOrdered.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnOrdered.Size = new System.Drawing.Size(59, 51);
            this.tsbtnOrdered.Text = "已点";
            this.tsbtnOrdered.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnOrdered.Click += new System.EventHandler(this.tsbtnOrdered_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(58, 51);
            this.toolStripButton1.Text = "服务";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnExit.Size = new System.Drawing.Size(59, 51);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ClientDemo.Properties.Resources.tsbtn5;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButton2.Size = new System.Drawing.Size(56, 51);
            this.toolStripButton2.Text = "原唱";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 573);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KTV点歌系统主窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.PictureBox picWordCount;
        private System.Windows.Forms.PictureBox picSongList;
        private System.Windows.Forms.PictureBox picSongType;
        private System.Windows.Forms.PictureBox picSongName;
        private System.Windows.Forms.PictureBox picSinger;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNextSong;
        private System.Windows.Forms.Label lblPlayingSong;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

