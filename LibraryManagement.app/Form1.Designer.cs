namespace LibraryManagement.app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMembers = new System.Windows.Forms.ToolStripButton();
            this.btnBooks = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoginSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnBookStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMembers,
            this.btnBooks,
            this.btnExit,
            this.toolStripSeparator1,
            this.btnSetting,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.btnBookStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(727, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "s";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(512, 74);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(203, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "خوش اومدی کتابدار!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.app.Properties.Resources.Library;
            this.pictureBox1.Location = new System.Drawing.Point(18, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.Transparent;
            this.btnMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(79, 68);
            this.btnMembers.Text = "مدیریت اعضا";
            this.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMembers.ToolTipText = "مدیریت اعضا";
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(93, 68);
            this.btnBooks.Text = "مدیریت کتاب‌ها";
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 68);
            this.btnExit.Text = "وضعیت امانات";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnBookStatus_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoginSetting});
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(66, 68);
            this.btnSetting.Text = "تنظیمات";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLoginSetting
            // 
            this.btnLoginSetting.Name = "btnLoginSetting";
            this.btnLoginSetting.Size = new System.Drawing.Size(180, 28);
            this.btnLoginSetting.Text = "تنظیمات ورود";
            this.btnLoginSetting.ToolTipText = "تنظیمات ورود";
            this.btnLoginSetting.Click += new System.EventHandler(this.btnLoginSetting_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 68);
            this.toolStripButton1.Text = "درباره‌ی ما";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnBookStatus
            // 
            this.btnBookStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnBookStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnBookStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnBookStatus.Image")));
            this.btnBookStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBookStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBookStatus.Name = "btnBookStatus";
            this.btnBookStatus.Size = new System.Drawing.Size(44, 68);
            this.btnBookStatus.Text = "خروج";
            this.btnBookStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookStatus.Click += new System.EventHandler(this.btnBookStatus_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(727, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کتابخانه";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMembers;
        private System.Windows.Forms.ToolStripButton btnBooks;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton btnSetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnBookStatus;
        private System.Windows.Forms.ToolStripMenuItem btnLoginSetting;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
    }
}

