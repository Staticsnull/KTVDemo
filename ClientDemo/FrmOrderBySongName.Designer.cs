namespace ClientDemo
{
    partial class FrmOrderBySongName
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBySongName));
            this.lblTip = new System.Windows.Forms.Label();
            this.singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAgain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.tsWordCount = new System.Windows.Forms.ToolStrip();
            this.tsbtnOrdered = new System.Windows.Forms.ToolStripButton();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.tsWordCount.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTip.Location = new System.Drawing.Point(12, 25);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(261, 19);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "请输入歌曲名称或拼音缩写";
            // 
            // singer
            // 
            this.singer.DataPropertyName = "singer_name";
            this.singer.HeaderText = "歌手";
            this.singer.Name = "singer";
            this.singer.ReadOnly = true;
            // 
            // songName
            // 
            this.songName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.songName.DataPropertyName = "song_name";
            this.songName.HeaderText = "歌曲名";
            this.songName.Name = "songName";
            this.songName.ReadOnly = true;
            this.songName.Width = 350;
            // 
            // songURL
            // 
            this.songURL.DataPropertyName = "song_url";
            this.songURL.HeaderText = "歌曲路径";
            this.songURL.Name = "songURL";
            this.songURL.ReadOnly = true;
            this.songURL.Visible = false;
            // 
            // songId
            // 
            this.songId.DataPropertyName = "song_id";
            this.songId.HeaderText = "歌曲编号";
            this.songId.Name = "songId";
            this.songId.ReadOnly = true;
            this.songId.Visible = false;
            // 
            // dgvSong
            // 
            this.dgvSong.AllowUserToAddRows = false;
            this.dgvSong.AllowUserToDeleteRows = false;
            this.dgvSong.AllowUserToResizeColumns = false;
            this.dgvSong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvSong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSong.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvSong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSong.CausesValidation = false;
            this.dgvSong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSong.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSong.ColumnHeadersHeight = 25;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songId,
            this.songURL,
            this.songName,
            this.singer});
            this.dgvSong.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSong.GridColor = System.Drawing.Color.Black;
            this.dgvSong.Location = new System.Drawing.Point(12, 91);
            this.dgvSong.MultiSelect = false;
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.ReadOnly = true;
            this.dgvSong.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSong.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSong.RowTemplate.Height = 23;
            this.dgvSong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(626, 371);
            this.dgvSong.TabIndex = 3;
            this.dgvSong.Click += new System.EventHandler(this.dgvSong_Click);
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
            this.tsWordCount.TabIndex = 5;
            this.tsWordCount.Text = "toolStrip1";
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
            // txtSongName
            // 
            this.txtSongName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSongName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSongName.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSongName.Location = new System.Drawing.Point(12, 56);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(435, 28);
            this.txtSongName.TabIndex = 1;
            this.txtSongName.TextChanged += new System.EventHandler(this.txtSongName_TextChanged);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Ivory;
            this.pnlMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMiddle.BackgroundImage")));
            this.pnlMiddle.Controls.Add(this.dgvSong);
            this.pnlMiddle.Controls.Add(this.txtSongName);
            this.pnlMiddle.Controls.Add(this.lblTip);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 30);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(650, 543);
            this.pnlMiddle.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 30);
            this.pnlTop.TabIndex = 4;
            // 
            // FrmOrderBySongName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 573);
            this.Controls.Add(this.tsWordCount);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderBySongName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "拼音点歌";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.tsWordCount.ResumeLayout(false);
            this.tsWordCount.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn songURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn songId;
        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnAgain;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStrip tsWordCount;
        private System.Windows.Forms.ToolStripButton tsbtnOrdered;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlTop;
    }
}