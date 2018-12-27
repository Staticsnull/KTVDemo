namespace ClientDemo
{
    partial class FrmSongList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSongList));
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.songId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsSongList = new System.Windows.Forms.ToolStrip();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.tsSongList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSong
            // 
            this.dgvSong.AllowUserToAddRows = false;
            this.dgvSong.AllowUserToDeleteRows = false;
            this.dgvSong.AllowUserToResizeColumns = false;
            this.dgvSong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgvSong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSong.CausesValidation = false;
            this.dgvSong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSong.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSong.ColumnHeadersHeight = 25;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songId,
            this.songURL,
            this.songName,
            this.singer});
            this.dgvSong.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSong.EnableHeadersVisualStyles = false;
            this.dgvSong.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvSong.Location = new System.Drawing.Point(0, 30);
            this.dgvSong.MultiSelect = false;
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.ReadOnly = true;
            this.dgvSong.RowHeadersVisible = false;
            this.dgvSong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSong.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSong.RowTemplate.Height = 23;
            this.dgvSong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(578, 332);
            this.dgvSong.TabIndex = 5;
            this.dgvSong.Click += new System.EventHandler(this.dgvSong_Click);
            // 
            // songId
            // 
            this.songId.DataPropertyName = "song_id";
            this.songId.HeaderText = "歌曲编号";
            this.songId.Name = "songId";
            this.songId.ReadOnly = true;
            this.songId.Visible = false;
            // 
            // songURL
            // 
            this.songURL.DataPropertyName = "song_url";
            this.songURL.HeaderText = "歌曲路径";
            this.songURL.Name = "songURL";
            this.songURL.ReadOnly = true;
            this.songURL.Visible = false;
            // 
            // songName
            // 
            this.songName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.songName.DataPropertyName = "song_name";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.songName.DefaultCellStyle = dataGridViewCellStyle3;
            this.songName.HeaderText = "歌曲名";
            this.songName.Name = "songName";
            this.songName.ReadOnly = true;
            this.songName.Width = 350;
            // 
            // singer
            // 
            this.singer.DataPropertyName = "singer_name";
            this.singer.HeaderText = "歌手";
            this.singer.Name = "singer";
            this.singer.ReadOnly = true;
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
            this.tsSongList.Location = new System.Drawing.Point(0, 362);
            this.tsSongList.Name = "tsSongList";
            this.tsSongList.Size = new System.Drawing.Size(578, 59);
            this.tsSongList.TabIndex = 4;
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
            // pnlTop
            // 
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(578, 30);
            this.pnlTop.TabIndex = 3;
            // 
            // FrmSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 421);
            this.Controls.Add(this.dgvSong);
            this.Controls.Add(this.tsSongList);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌曲列表";
            this.Load += new System.EventHandler(this.FrmSongList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.tsSongList.ResumeLayout(false);
            this.tsSongList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn songId;
        private System.Windows.Forms.DataGridViewTextBoxColumn songURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer;
        private System.Windows.Forms.ToolStrip tsSongList;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.Panel pnlTop;
    }
}