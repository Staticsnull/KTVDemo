namespace ClientDemo
{
    partial class FrmOrderByWordCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderByWordCount));
            this.tsWordCount = new System.Windows.Forms.ToolStrip();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lvWordCount = new System.Windows.Forms.ListView();
            this.tsWordCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsWordCount
            // 
            this.tsWordCount.BackColor = System.Drawing.Color.Transparent;
            this.tsWordCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsWordCount.BackgroundImage")));
            this.tsWordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsWordCount.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsWordCount.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsWordCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHome,
            this.tsbtnAgain,
            this.tsbtnCut,
            this.tsbtnOrdered,
            this.toolStripButton1,
            this.tsbtnExit});
            this.tsWordCount.Location = new System.Drawing.Point(0, 514);
            this.tsWordCount.Name = "tsWordCount";
            this.tsWordCount.Size = new System.Drawing.Size(650, 59);
            this.tsWordCount.TabIndex = 6;
            this.tsWordCount.Text = "toolStrip1";
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Location = new System.Drawing.Point(0, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 30);
            this.pnlTop.TabIndex = 5;
            // 
            // lvWordCount
            // 
            this.lvWordCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvWordCount.BackgroundImage")));
            this.lvWordCount.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvWordCount.ForeColor = System.Drawing.Color.Black;
            this.lvWordCount.Location = new System.Drawing.Point(0, 32);
            this.lvWordCount.MultiSelect = false;
            this.lvWordCount.Name = "lvWordCount";
            this.lvWordCount.Size = new System.Drawing.Size(650, 479);
            this.lvWordCount.TabIndex = 7;
            this.lvWordCount.UseCompatibleStateImageBehavior = false;
            this.lvWordCount.View = System.Windows.Forms.View.Tile;
            this.lvWordCount.Click += new System.EventHandler(this.lvWordCount_Click);
            // 
            // FrmOrderByWordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 573);
            this.Controls.Add(this.tsWordCount);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lvWordCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderByWordCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按照字数点歌";
            this.Load += new System.EventHandler(this.FrmOrderByWordCount_Load);
            this.tsWordCount.ResumeLayout(false);
            this.tsWordCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsWordCount;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ListView lvWordCount;
    }
}