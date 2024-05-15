namespace LibraryManagement.app
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddMember = new System.Windows.Forms.ToolStripButton();
            this.btnEditMember = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMember = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(192)))), ((int)(((byte)(163)))));
            this.toolStrip2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMember,
            this.btnEditMember,
            this.btnDeleteMember,
            this.btnRefresh,
            this.toolStripLabel1,
            this.txtSearch,
            this.toolStripSeparator1,
            this.btnClose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(584, 71);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "s";
            // 
            // btnAddMember
            // 
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnAddMember.Image = global::LibraryManagement.app.Properties.Resources.addmember;
            this.btnAddMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(72, 68);
            this.btnAddMember.Text = "افزودن عضو";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMember.ToolTipText = "toolStripButton1";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnEditMember.Image = global::LibraryManagement.app.Properties.Resources.edit_member;
            this.btnEditMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(76, 68);
            this.btnEditMember.Text = "ویرایش عضو";
            this.btnEditMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.btnDeleteMember.Image = global::LibraryManagement.app.Properties.Resources.delete_member;
            this.btnDeleteMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(67, 68);
            this.btnDeleteMember.Text = "حذف عضو";
            this.btnDeleteMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 68);
            this.toolStripLabel1.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(61)))), ((int)(((byte)(59)))));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 71);
            this.txtSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.GridColor = System.Drawing.Color.Chocolate;
            this.dgvMembers.Location = new System.Drawing.Point(0, 71);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(584, 250);
            this.dgvMembers.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "memberID";
            this.Column1.HeaderText = "memberID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "memberName";
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "memberLastName";
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "memberPhone";
            this.Column4.HeaderText = "شماره تلفن";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "membershipDate";
            this.Column5.HeaderText = "تاریخ عضویت";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اعضا";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddMember;
        private System.Windows.Forms.ToolStripButton btnEditMember;
        private System.Windows.Forms.ToolStripButton btnDeleteMember;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}