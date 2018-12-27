namespace ClientDemo
{
    partial class FrmOrderBySinger
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBySinger));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("组合", 2);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("女歌手", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("男歌手", 0);
            this.tsSinger = new System.Windows.Forms.ToolStrip();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.tsbtnService = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.ilSingerSex = new System.Windows.Forms.ImageList(this.components);
            this.pnlSingerSex = new System.Windows.Forms.Panel();
            this.ilSingerType = new System.Windows.Forms.ImageList(this.components);
            this.ilSinger = new System.Windows.Forms.ImageList(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lvSingerType = new System.Windows.Forms.ListView();
            this.pnlSingerType = new System.Windows.Forms.Panel();
            this.pnlSingerList = new System.Windows.Forms.Panel();
            this.lvSinger = new System.Windows.Forms.ListView();
            this.tsSinger.SuspendLayout();
            this.pnlSingerSex.SuspendLayout();
            this.pnlSingerType.SuspendLayout();
            this.pnlSingerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSinger
            // 
            this.tsSinger.BackColor = System.Drawing.Color.Transparent;
            this.tsSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsSinger.BackgroundImage")));
            this.tsSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsSinger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSinger.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSinger.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsSinger.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHome,
            this.tsbtnAgain,
            this.tsbtnCut,
            this.tsbtnOrdered,
            this.tsbtnService,
            this.tsbtnExit});
            this.tsSinger.Location = new System.Drawing.Point(0, 441);
            this.tsSinger.Name = "tsSinger";
            this.tsSinger.Size = new System.Drawing.Size(650, 59);
            this.tsSinger.TabIndex = 1;
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
            // tsbtnService
            // 
            this.tsbtnService.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnService.Image")));
            this.tsbtnService.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnService.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnService.Name = "tsbtnService";
            this.tsbtnService.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsbtnService.Size = new System.Drawing.Size(58, 56);
            this.tsbtnService.Text = "服务";
            this.tsbtnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnService.Click += new System.EventHandler(this.tsbtnService_Click);
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
            // lvOrder
            // 
            this.lvOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvOrder.BackgroundImage")));
            this.lvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrder.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            listViewItem1.Tag = "组合";
            listViewItem2.Tag = "女";
            listViewItem3.Tag = "男";
            this.lvOrder.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvOrder.LargeImageList = this.ilSingerSex;
            this.lvOrder.Location = new System.Drawing.Point(0, 0);
            this.lvOrder.MultiSelect = false;
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(650, 411);
            this.lvOrder.TabIndex = 2;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.Click += new System.EventHandler(this.lvOrder_Click);
            // 
            // ilSingerSex
            // 
            this.ilSingerSex.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSingerSex.ImageStream")));
            this.ilSingerSex.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSingerSex.Images.SetKeyName(0, "male.png");
            this.ilSingerSex.Images.SetKeyName(1, "female.png");
            this.ilSingerSex.Images.SetKeyName(2, "couple.png");
            // 
            // pnlSingerSex
            // 
            this.pnlSingerSex.Controls.Add(this.lvOrder);
            this.pnlSingerSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSingerSex.Location = new System.Drawing.Point(0, 30);
            this.pnlSingerSex.Name = "pnlSingerSex";
            this.pnlSingerSex.Size = new System.Drawing.Size(650, 411);
            this.pnlSingerSex.TabIndex = 3;
            // 
            // ilSingerType
            // 
            this.ilSingerType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSingerType.ImageStream")));
            this.ilSingerType.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSingerType.Images.SetKeyName(0, "dalu.png");
            this.ilSingerType.Images.SetKeyName(1, "xianggang.png");
            this.ilSingerType.Images.SetKeyName(2, "taiwan.png");
            this.ilSingerType.Images.SetKeyName(3, "oumei.png");
            this.ilSingerType.Images.SetKeyName(4, "rihan.png");
            // 
            // ilSinger
            // 
            this.ilSinger.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilSinger.ImageSize = new System.Drawing.Size(200, 200);
            this.ilSinger.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 30);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // lvSingerType
            // 
            this.lvSingerType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSingerType.BackgroundImage")));
            this.lvSingerType.BackgroundImageTiled = true;
            this.lvSingerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSingerType.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSingerType.LargeImageList = this.ilSingerType;
            this.lvSingerType.Location = new System.Drawing.Point(0, 0);
            this.lvSingerType.Name = "lvSingerType";
            this.lvSingerType.Size = new System.Drawing.Size(563, 335);
            this.lvSingerType.TabIndex = 3;
            this.lvSingerType.UseCompatibleStateImageBehavior = false;
            this.lvSingerType.SelectedIndexChanged += new System.EventHandler(this.lvSingerType_SelectedIndexChanged);
            this.lvSingerType.Click += new System.EventHandler(this.lvSingerType_Click);
            // 
            // pnlSingerType
            // 
            this.pnlSingerType.Controls.Add(this.lvSingerType);
            this.pnlSingerType.Location = new System.Drawing.Point(55, 69);
            this.pnlSingerType.Name = "pnlSingerType";
            this.pnlSingerType.Size = new System.Drawing.Size(563, 335);
            this.pnlSingerType.TabIndex = 3;
            this.pnlSingerType.Visible = false;
            // 
            // pnlSingerList
            // 
            this.pnlSingerList.Controls.Add(this.lvSinger);
            this.pnlSingerList.Location = new System.Drawing.Point(152, 79);
            this.pnlSingerList.Name = "pnlSingerList";
            this.pnlSingerList.Size = new System.Drawing.Size(563, 335);
            this.pnlSingerList.TabIndex = 4;
            this.pnlSingerList.Visible = false;
            // 
            // lvSinger
            // 
            this.lvSinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSinger.BackgroundImage")));
            this.lvSinger.BackgroundImageTiled = true;
            this.lvSinger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinger.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSinger.LargeImageList = this.ilSinger;
            this.lvSinger.Location = new System.Drawing.Point(0, 0);
            this.lvSinger.Name = "lvSinger";
            this.lvSinger.Size = new System.Drawing.Size(563, 335);
            this.lvSinger.TabIndex = 0;
            this.lvSinger.UseCompatibleStateImageBehavior = false;
            this.lvSinger.Click += new System.EventHandler(this.lvSinger_Click);
            // 
            // FrmOrderBySinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.pnlSingerList);
            this.Controls.Add(this.pnlSingerType);
            this.Controls.Add(this.pnlSingerSex);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tsSinger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderBySinger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌星点歌";
            this.tsSinger.ResumeLayout(false);
            this.tsSinger.PerformLayout();
            this.pnlSingerSex.ResumeLayout(false);
            this.pnlSingerType.ResumeLayout(false);
            this.pnlSingerList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSinger;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ImageList ilSingerSex;
        private System.Windows.Forms.ToolStripButton tsbtnService;
        private System.Windows.Forms.Panel pnlSingerSex;
        private System.Windows.Forms.ImageList ilSingerType;
        private System.Windows.Forms.ImageList ilSinger;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ListView lvSingerType;
        private System.Windows.Forms.Panel pnlSingerType;
        private System.Windows.Forms.Panel pnlSingerList;
        private System.Windows.Forms.ListView lvSinger;
    }
}

