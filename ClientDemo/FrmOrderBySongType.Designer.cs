namespace ClientDemo
{
    partial class FrmOrderBySongType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBySongType));
            this.tsSinger = new System.Windows.Forms.ToolStrip();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.ilSongType = new System.Windows.Forms.ImageList(this.components);
            this.lvListType = new System.Windows.Forms.ListView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tsSinger.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSinger
            // 
            this.tsSinger.BackColor = System.Drawing.Color.Transparent;
            this.tsSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsSinger.BackgroundImage")));
            this.tsSinger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSinger.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSinger.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsSinger.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHome,
            this.tsbtnAgain,
            this.tsbtnCut,
            this.tsbtnOrdered,
            this.toolStripButton1,
            this.tsbtnExit});
            this.tsSinger.Location = new System.Drawing.Point(0, 514);
            this.tsSinger.Name = "tsSinger";
            this.tsSinger.Size = new System.Drawing.Size(650, 59);
            this.tsSinger.TabIndex = 3;
            this.tsSinger.Text = "toolStrip1";
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
            this.tsbtnHome.Click += new System.EventHandler(this.tsbtnExit_Click);
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
            // ilSongType
            // 
            this.ilSongType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSongType.ImageStream")));
            this.ilSongType.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSongType.Images.SetKeyName(0, "remenliuxing.png");
            this.ilSongType.Images.SetKeyName(1, "jingdianlaoge.png");
            this.ilSongType.Images.SetKeyName(2, "yingshijinqu.png");
            this.ilSongType.Images.SetKeyName(3, "katongdongman.png");
            this.ilSongType.Images.SetKeyName(4, "xiqu.png");
            this.ilSongType.Images.SetKeyName(5, "erge.png");
            // 
            // lvListType
            // 
            this.lvListType.LargeImageList = this.ilSongType;
            this.lvListType.Location = new System.Drawing.Point(0, 36);
            this.lvListType.Name = "lvListType";
            this.lvListType.Size = new System.Drawing.Size(648, 441);
            this.lvListType.TabIndex = 4;
            this.lvListType.UseCompatibleStateImageBehavior = false;
            this.lvListType.Click += new System.EventHandler(this.lvListType_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 30);
            this.pnlTop.TabIndex = 5;
            // 
            // FrmOrderBySongType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 573);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lvListType);
            this.Controls.Add(this.tsSinger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderBySongType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌曲分类列表";
            this.Load += new System.EventHandler(this.FrmOrderBySongType_Load);
            this.tsSinger.ResumeLayout(false);
            this.tsSinger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSinger;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ImageList ilSongType;
        private System.Windows.Forms.ListView lvListType;
        private System.Windows.Forms.Panel pnlTop;
    }
}