namespace DirectoryTools
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this._StatusStrip = new System.Windows.Forms.StatusStrip();
			this._ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this._Status = new System.Windows.Forms.ToolStripStatusLabel();
			this._TabControl = new System.Windows.Forms.TabControl();
			this._EmptyFoldersTab = new System.Windows.Forms.TabPage();
			this._EmptyFoldersUserControl = new DirectoryTools.EmptyFoldersUserControl();
			this._MoveUpTab = new System.Windows.Forms.TabPage();
			this._MoveUpUserControl = new DirectoryTools.MoveUpUserControl();
			this._FolderPath = new System.Windows.Forms.TextBox();
			this._FolderBrowseButton = new System.Windows.Forms.Button();
			this._FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._BackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._StatusStrip.SuspendLayout();
			this._TabControl.SuspendLayout();
			this._EmptyFoldersTab.SuspendLayout();
			this._MoveUpTab.SuspendLayout();
			this._TableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _StatusStrip
			// 
			this._StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ProgressBar,
            this._Status});
			this._StatusStrip.Location = new System.Drawing.Point(0, 353);
			this._StatusStrip.Name = "_StatusStrip";
			this._StatusStrip.Size = new System.Drawing.Size(433, 22);
			this._StatusStrip.TabIndex = 1;
			this._StatusStrip.Text = "statusStrip1";
			// 
			// _ProgressBar
			// 
			this._ProgressBar.Name = "_ProgressBar";
			this._ProgressBar.Size = new System.Drawing.Size(100, 16);
			// 
			// _Status
			// 
			this._Status.Name = "_Status";
			this._Status.Size = new System.Drawing.Size(0, 17);
			// 
			// _TabControl
			// 
			this._TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._TableLayoutPanel.SetColumnSpan(this._TabControl, 2);
			this._TabControl.Controls.Add(this._EmptyFoldersTab);
			this._TabControl.Controls.Add(this._MoveUpTab);
			this._TabControl.Location = new System.Drawing.Point(3, 3);
			this._TabControl.Name = "_TabControl";
			this._TabControl.SelectedIndex = 0;
			this._TabControl.Size = new System.Drawing.Size(427, 318);
			this._TabControl.TabIndex = 2;
			// 
			// _EmptyFoldersTab
			// 
			this._EmptyFoldersTab.Controls.Add(this._EmptyFoldersUserControl);
			this._EmptyFoldersTab.Location = new System.Drawing.Point(4, 22);
			this._EmptyFoldersTab.Name = "_EmptyFoldersTab";
			this._EmptyFoldersTab.Padding = new System.Windows.Forms.Padding(3);
			this._EmptyFoldersTab.Size = new System.Drawing.Size(419, 292);
			this._EmptyFoldersTab.TabIndex = 0;
			this._EmptyFoldersTab.Text = "Empty Folders";
			this._EmptyFoldersTab.UseVisualStyleBackColor = true;
			// 
			// _EmptyFoldersUserControl
			// 
			this._EmptyFoldersUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._EmptyFoldersUserControl.Location = new System.Drawing.Point(3, 3);
			this._EmptyFoldersUserControl.Name = "_EmptyFoldersUserControl";
			this._EmptyFoldersUserControl.Size = new System.Drawing.Size(413, 286);
			this._EmptyFoldersUserControl.TabIndex = 8;
			// 
			// _MoveUpTab
			// 
			this._MoveUpTab.Controls.Add(this._MoveUpUserControl);
			this._MoveUpTab.Location = new System.Drawing.Point(4, 22);
			this._MoveUpTab.Name = "_MoveUpTab";
			this._MoveUpTab.Padding = new System.Windows.Forms.Padding(3);
			this._MoveUpTab.Size = new System.Drawing.Size(419, 292);
			this._MoveUpTab.TabIndex = 1;
			this._MoveUpTab.Text = "Move Up";
			this._MoveUpTab.UseVisualStyleBackColor = true;
			// 
			// _MoveUpUserControl
			// 
			this._MoveUpUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._MoveUpUserControl.Location = new System.Drawing.Point(3, 3);
			this._MoveUpUserControl.Name = "_MoveUpUserControl";
			this._MoveUpUserControl.Size = new System.Drawing.Size(413, 286);
			this._MoveUpUserControl.TabIndex = 11;
			// 
			// _FolderPath
			// 
			this._FolderPath.AllowDrop = true;
			this._FolderPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._FolderPath.Location = new System.Drawing.Point(3, 328);
			this._FolderPath.Name = "_FolderPath";
			this._FolderPath.Size = new System.Drawing.Size(343, 20);
			this._FolderPath.TabIndex = 3;
			this._FolderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this._FolderPath_DragDrop);
			this._FolderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this._FolderPath_DragEnter);
			this._FolderPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this._FolderPath_KeyUp);
			// 
			// _FolderBrowseButton
			// 
			this._FolderBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._FolderBrowseButton.Location = new System.Drawing.Point(352, 327);
			this._FolderBrowseButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this._FolderBrowseButton.Name = "_FolderBrowseButton";
			this._FolderBrowseButton.Size = new System.Drawing.Size(75, 23);
			this._FolderBrowseButton.TabIndex = 4;
			this._FolderBrowseButton.Text = "Browse";
			this._FolderBrowseButton.UseVisualStyleBackColor = true;
			this._FolderBrowseButton.Click += new System.EventHandler(this._FolderBrowse_Click);
			// 
			// _FolderBrowserDialog
			// 
			this._FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this._FolderBrowserDialog.ShowNewFolderButton = false;
			// 
			// _BackgroundWorker
			// 
			this._BackgroundWorker.WorkerReportsProgress = true;
			// 
			// _TableLayoutPanel
			// 
			this._TableLayoutPanel.ColumnCount = 2;
			this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._TableLayoutPanel.Controls.Add(this._TabControl, 0, 0);
			this._TableLayoutPanel.Controls.Add(this._FolderPath, 0, 1);
			this._TableLayoutPanel.Controls.Add(this._FolderBrowseButton, 1, 1);
			this._TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._TableLayoutPanel.Name = "_TableLayoutPanel";
			this._TableLayoutPanel.RowCount = 2;
			this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._TableLayoutPanel.Size = new System.Drawing.Size(433, 353);
			this._TableLayoutPanel.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 375);
			this.Controls.Add(this._TableLayoutPanel);
			this.Controls.Add(this._StatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Directory Tools";
			this._StatusStrip.ResumeLayout(false);
			this._StatusStrip.PerformLayout();
			this._TabControl.ResumeLayout(false);
			this._EmptyFoldersTab.ResumeLayout(false);
			this._MoveUpTab.ResumeLayout(false);
			this._TableLayoutPanel.ResumeLayout(false);
			this._TableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip _StatusStrip;
		private System.Windows.Forms.TabControl _TabControl;
		private System.Windows.Forms.TabPage _EmptyFoldersTab;
		private System.Windows.Forms.TabPage _MoveUpTab;
		private System.Windows.Forms.TextBox _FolderPath;
		private System.Windows.Forms.Button _FolderBrowseButton;
		private System.Windows.Forms.FolderBrowserDialog _FolderBrowserDialog;
		private System.ComponentModel.BackgroundWorker _BackgroundWorker;
		private System.Windows.Forms.TableLayoutPanel _TableLayoutPanel;
		private MoveUpUserControl _MoveUpUserControl;
		private EmptyFoldersUserControl _EmptyFoldersUserControl;
		private System.Windows.Forms.ToolStripProgressBar _ProgressBar;
		private System.Windows.Forms.ToolStripStatusLabel _Status;
	}
}

