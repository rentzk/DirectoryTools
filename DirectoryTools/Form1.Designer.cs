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
			this._TabControl = new System.Windows.Forms.TabControl();
			this._EmptyFoldersTab = new System.Windows.Forms.TabPage();
			this._EmptyFoldersDeleteToRecycleBin = new System.Windows.Forms.CheckBox();
			this._EmptyFoldersInvertSelection = new System.Windows.Forms.Button();
			this._EmptyFoldersSelectAll = new System.Windows.Forms.Button();
			this._EmptyFoldersListBox = new System.Windows.Forms.CheckedListBox();
			this._EmptyFoldersDeleteButton = new System.Windows.Forms.Button();
			this._MoveUpTab = new System.Windows.Forms.TabPage();
			this._FolderPath = new System.Windows.Forms.TextBox();
			this._FolderBrowseButton = new System.Windows.Forms.Button();
			this._FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this._BackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this._TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._TabControl.SuspendLayout();
			this._EmptyFoldersTab.SuspendLayout();
			this._TableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _StatusStrip
			// 
			this._StatusStrip.Location = new System.Drawing.Point(0, 353);
			this._StatusStrip.Name = "_StatusStrip";
			this._StatusStrip.Size = new System.Drawing.Size(433, 22);
			this._StatusStrip.TabIndex = 1;
			this._StatusStrip.Text = "statusStrip1";
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
			this._EmptyFoldersTab.Controls.Add(this._EmptyFoldersDeleteToRecycleBin);
			this._EmptyFoldersTab.Controls.Add(this._EmptyFoldersInvertSelection);
			this._EmptyFoldersTab.Controls.Add(this._EmptyFoldersSelectAll);
			this._EmptyFoldersTab.Controls.Add(this._EmptyFoldersListBox);
			this._EmptyFoldersTab.Controls.Add(this._EmptyFoldersDeleteButton);
			this._EmptyFoldersTab.Location = new System.Drawing.Point(4, 22);
			this._EmptyFoldersTab.Name = "_EmptyFoldersTab";
			this._EmptyFoldersTab.Padding = new System.Windows.Forms.Padding(3);
			this._EmptyFoldersTab.Size = new System.Drawing.Size(419, 292);
			this._EmptyFoldersTab.TabIndex = 0;
			this._EmptyFoldersTab.Text = "Empty Folders";
			this._EmptyFoldersTab.UseVisualStyleBackColor = true;
			// 
			// _EmptyFoldersDeleteToRecycleBin
			// 
			this._EmptyFoldersDeleteToRecycleBin.AutoSize = true;
			this._EmptyFoldersDeleteToRecycleBin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._EmptyFoldersDeleteToRecycleBin.Location = new System.Drawing.Point(282, 8);
			this._EmptyFoldersDeleteToRecycleBin.Name = "_EmptyFoldersDeleteToRecycleBin";
			this._EmptyFoldersDeleteToRecycleBin.Size = new System.Drawing.Size(129, 17);
			this._EmptyFoldersDeleteToRecycleBin.TabIndex = 6;
			this._EmptyFoldersDeleteToRecycleBin.Text = "Delete to Recycle Bin";
			this._EmptyFoldersDeleteToRecycleBin.UseVisualStyleBackColor = true;
			// 
			// _EmptyFoldersInvertSelection
			// 
			this._EmptyFoldersInvertSelection.Location = new System.Drawing.Point(87, 3);
			this._EmptyFoldersInvertSelection.Name = "_EmptyFoldersInvertSelection";
			this._EmptyFoldersInvertSelection.Size = new System.Drawing.Size(75, 23);
			this._EmptyFoldersInvertSelection.TabIndex = 5;
			this._EmptyFoldersInvertSelection.Text = "Invert Selection";
			this._EmptyFoldersInvertSelection.UseVisualStyleBackColor = true;
			this._EmptyFoldersInvertSelection.Click += new System.EventHandler(this._EmptyFoldersInvertSelection_Click);
			// 
			// _EmptyFoldersSelectAll
			// 
			this._EmptyFoldersSelectAll.Location = new System.Drawing.Point(6, 3);
			this._EmptyFoldersSelectAll.Name = "_EmptyFoldersSelectAll";
			this._EmptyFoldersSelectAll.Size = new System.Drawing.Size(75, 23);
			this._EmptyFoldersSelectAll.TabIndex = 4;
			this._EmptyFoldersSelectAll.Text = "Select All";
			this._EmptyFoldersSelectAll.UseVisualStyleBackColor = true;
			this._EmptyFoldersSelectAll.Click += new System.EventHandler(this._EmptyFoldersSelectAll_Click);
			// 
			// _EmptyFoldersListBox
			// 
			this._EmptyFoldersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._EmptyFoldersListBox.CheckOnClick = true;
			this._EmptyFoldersListBox.FormattingEnabled = true;
			this._EmptyFoldersListBox.Location = new System.Drawing.Point(6, 40);
			this._EmptyFoldersListBox.Name = "_EmptyFoldersListBox";
			this._EmptyFoldersListBox.Size = new System.Drawing.Size(318, 244);
			this._EmptyFoldersListBox.Sorted = true;
			this._EmptyFoldersListBox.TabIndex = 3;
			this._EmptyFoldersListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._EmptyFoldersListBox_ItemCheck);
			// 
			// _EmptyFoldersDeleteButton
			// 
			this._EmptyFoldersDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._EmptyFoldersDeleteButton.Location = new System.Drawing.Point(338, 40);
			this._EmptyFoldersDeleteButton.Name = "_EmptyFoldersDeleteButton";
			this._EmptyFoldersDeleteButton.Size = new System.Drawing.Size(75, 23);
			this._EmptyFoldersDeleteButton.TabIndex = 2;
			this._EmptyFoldersDeleteButton.Text = "Delete";
			this._EmptyFoldersDeleteButton.UseVisualStyleBackColor = true;
			this._EmptyFoldersDeleteButton.Click += new System.EventHandler(this._EmptyFoldersDeleteButton_Click);
			// 
			// _MoveUpTab
			// 
			this._MoveUpTab.Location = new System.Drawing.Point(4, 22);
			this._MoveUpTab.Name = "_MoveUpTab";
			this._MoveUpTab.Padding = new System.Windows.Forms.Padding(3);
			this._MoveUpTab.Size = new System.Drawing.Size(419, 292);
			this._MoveUpTab.TabIndex = 1;
			this._MoveUpTab.Text = "Move Up";
			this._MoveUpTab.UseVisualStyleBackColor = true;
			// 
			// _FolderPath
			// 
			this._FolderPath.AllowDrop = true;
			this._FolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this._FolderPath.Location = new System.Drawing.Point(3, 327);
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
			this._TabControl.ResumeLayout(false);
			this._EmptyFoldersTab.ResumeLayout(false);
			this._EmptyFoldersTab.PerformLayout();
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
		private System.Windows.Forms.Button _EmptyFoldersDeleteButton;
		private System.Windows.Forms.CheckedListBox _EmptyFoldersListBox;
		private System.Windows.Forms.Button _EmptyFoldersInvertSelection;
		private System.Windows.Forms.Button _EmptyFoldersSelectAll;
		private System.Windows.Forms.CheckBox _EmptyFoldersDeleteToRecycleBin;
	}
}

