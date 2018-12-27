namespace ClientDemo
{
    partial class FrmOrderedSongList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderedSongList));
            this.tsSongList = new System.Windows.Forms.ToolStrip();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tsSongList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSongList
            // 
            this.tsSongList.BackColor = System.Drawing.Color.Transparent;
            this.tsSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsSongList.BackgroundImage")));
            this.tsSongList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSongList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSongList.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsSongList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHome,
            this.tsbtnAgain,
            this.tsbtnCut,
            this.tsbtnOrdered,
            this.toolStripButton1,
            this.tsbtnExit});
            this.tsSongList.Location = new System.Drawing.Point(0, 514);
            this.tsSongList.Name = "tsSongList";
            this.tsSongList.Size = new System.Drawing.Size(650, 59);
            this.tsSongList.TabIndex = 5;
            this.tsSongList.Text = "toolStrip1";
            // 
            // tsbtnHome
            // 
            this.tsbtnHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHome.Image")));
            this.tsbtnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHome.Name = "tsbtnHome";
            this.tsbtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnHome.Size = new System.Drawing.Size(68, 56);
            this.tsbtnHome.Text = "主界面";
            this.tsbtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnHome.Click += new System.EventHandler(this.tsbtnHome_Click);
            // 
            // tsbtnAgain
            // 
            this.tsbtnAgain.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgain.Image")));
            this.tsbtnAgain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAgain.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnAgain.Name = "tsbtnAgain";
            this.tsbtnAgain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnAgain.Size = new System.Drawing.Size(58, 56);
            this.tsbtnAgain.Text = "重唱";
            this.tsbtnAgain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAgain.Click += new System.EventHandler(this.tsbtnAgain_Click);
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCut.Image")));
            this.tsbtnCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnCut.Size = new System.Drawing.Size(59, 56);
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
            this.tsbtnOrdered.Size = new System.Drawing.Size(59, 56);
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
            this.toolStripButton1.Size = new System.Drawing.Size(58, 56);
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
            this.tsbtnExit.Size = new System.Drawing.Size(59, 56);
            this.tsbtnExit.Text = "返回";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // lvSongList
            // 
            this.lvSongList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSongList.BackgroundImage")));
            this.lvSongList.BackgroundImageTiled = true;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSongList.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lvSongList.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.Color.Black;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongList.Location = new System.Drawing.Point(0, 33);
            this.lvSongList.MultiSelect = false;
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(650, 540);
            this.lvSongList.TabIndex = 6;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲名称";
            this.columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "播放状态";
            this.columnHeader2.Width = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Location = new System.Drawing.Point(0, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 29);
            this.pnlTop.TabIndex = 4;
            // 
            // FrmOrderedSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 573);
            this.Controls.Add(this.tsSongList);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lvSongList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderedSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已点歌曲";
            this.Load += new System.EventHandler(this.FrmOrderedSongList_Load);
            this.tsSongList.ResumeLayout(false);
            this.tsSongList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSongList;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
    }
}