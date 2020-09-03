namespace FileExplorer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tvPath = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.새로고침ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btFileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.이름변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prb1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbPath
            // 
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPath.Location = new System.Drawing.Point(0, 25);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(797, 21);
            this.tbPath.TabIndex = 2;
            // 
            // tvPath
            // 
            this.tvPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvPath.Location = new System.Drawing.Point(0, 46);
            this.tvPath.Name = "tvPath";
            this.tvPath.Size = new System.Drawing.Size(194, 437);
            this.tvPath.TabIndex = 3;
            this.tvPath.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPath_AfterSelect);
            this.tvPath.DoubleClick += new System.EventHandler(this.tvPath_DoubleClick);
            // 
            // lvFiles
            // 
            this.lvFiles.CheckBoxes = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(194, 46);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(603, 437);
            this.lvFiles.TabIndex = 4;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "날짜";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "확장자";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "크기";
            this.columnHeader4.Width = 112;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로고침ToolStripMenuItem,
            this.btFileDelete,
            this.이름변경ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.이동ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 114);
            // 
            // 새로고침ToolStripMenuItem
            // 
            this.새로고침ToolStripMenuItem.Name = "새로고침ToolStripMenuItem";
            this.새로고침ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.새로고침ToolStripMenuItem.Text = "새로고침";
            this.새로고침ToolStripMenuItem.Click += new System.EventHandler(this.새로고침ToolStripMenuItem_Click);
            // 
            // btFileDelete
            // 
            this.btFileDelete.Name = "btFileDelete";
            this.btFileDelete.Size = new System.Drawing.Size(122, 22);
            this.btFileDelete.Text = "삭제";
            this.btFileDelete.Click += new System.EventHandler(this.btFileDelete_Click);
            // 
            // 이름변경ToolStripMenuItem
            // 
            this.이름변경ToolStripMenuItem.Enabled = false;
            this.이름변경ToolStripMenuItem.Name = "이름변경ToolStripMenuItem";
            this.이름변경ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.이름변경ToolStripMenuItem.Text = "이름변경";
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Enabled = false;
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Enabled = false;
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.이동ToolStripMenuItem.Text = "이동";
            // 
            // prb1
            // 
            this.prb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prb1.Location = new System.Drawing.Point(0, 483);
            this.prb1.Name = "prb1";
            this.prb1.Size = new System.Drawing.Size(797, 5);
            this.prb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 510);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tvPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.prb1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TreeView tvPath;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 새로고침ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btFileDelete;
        private System.Windows.Forms.ToolStripMenuItem 이름변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prb1;
    }
}

