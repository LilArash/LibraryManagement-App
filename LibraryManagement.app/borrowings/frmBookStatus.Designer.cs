namespace LibraryManagement.app.borrowings
{
    partial class frmBookStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookStatus));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddStatus = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteStatus = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.toolStrip2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStatus,
            this.btnDeleteStatus,
            this.btnRefresh,
            this.toolStripSeparator1,
            this.btnClose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(584, 71);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "s";
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnAddStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStatus.Image")));
            this.btnAddStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(76, 68);
            this.btnAddStatus.Text = "افزودن امانت";
            this.btnAddStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddStatus.ToolTipText = "افزودن امانت";
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // btnDeleteStatus
            // 
            this.btnDeleteStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnDeleteStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStatus.Image")));
            this.btnDeleteStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteStatus.Name = "btnDeleteStatus";
            this.btnDeleteStatus.Size = new System.Drawing.Size(71, 68);
            this.btnDeleteStatus.Text = "حذف امانت";
            this.btnDeleteStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteStatus.Click += new System.EventHandler(this.btnDeleteStatus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnRefresh.Image = global::LibraryManagement.app.Properties.Resources.refresh1;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 68);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnClose.Image = global::LibraryManagement.app.Properties.Resources.close;
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 68);
            this.btnClose.Text = "بستن";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AllowUserToDeleteRows = false;
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatus.GridColor = System.Drawing.Color.Chocolate;
            this.dgvStatus.Location = new System.Drawing.Point(0, 71);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatus.Size = new System.Drawing.Size(584, 250);
            this.dgvStatus.TabIndex = 4;
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "statusID";
            this.bookID.HeaderText = "Column1";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            this.bookID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bookName";
            this.Column1.HeaderText = "نام کتاب";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "memberName";
            this.Column2.HeaderText = "نام عضو";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "memberLastName";
            this.Column3.HeaderText = "نام خانوادگی عضو";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "borrowDate";
            this.Column4.HeaderText = "تاریخ امانت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "returnDate";
            this.Column5.HeaderText = "تاریخ بازگشت";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmBookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.dgvStatus);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBookStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وضعیت امانات";
            this.Load += new System.EventHandler(this.frmBookStatus_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddStatus;
        private System.Windows.Forms.ToolStripButton btnDeleteStatus;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}