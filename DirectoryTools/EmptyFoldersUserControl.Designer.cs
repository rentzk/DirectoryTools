namespace DirectoryTools
{
	partial class EmptyFoldersUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._EmptyFoldersDeleteToRecycleBin = new System.Windows.Forms.CheckBox();
			this._EmptyFoldersInvertSelection = new System.Windows.Forms.Button();
			this._EmptyFoldersSelectAll = new System.Windows.Forms.Button();
			this._EmptyFoldersListBox = new System.Windows.Forms.CheckedListBox();
			this._EmptyFoldersDeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _EmptyFoldersDeleteToRecycleBin
			// 
			this._EmptyFoldersDeleteToRecycleBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._EmptyFoldersDeleteToRecycleBin.AutoSize = true;
			this._EmptyFoldersDeleteToRecycleBin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._EmptyFoldersDeleteToRecycleBin.Location = new System.Drawing.Point(293, 14);
			this._EmptyFoldersDeleteToRecycleBin.Name = "_EmptyFoldersDeleteToRecycleBin";
			this._EmptyFoldersDeleteToRecycleBin.Size = new System.Drawing.Size(129, 17);
			this._EmptyFoldersDeleteToRecycleBin.TabIndex = 12;
			this._EmptyFoldersDeleteToRecycleBin.Text = "Delete to Recycle Bin";
			this._EmptyFoldersDeleteToRecycleBin.UseVisualStyleBackColor = true;
			// 
			// _EmptyFoldersInvertSelection
			// 
			this._EmptyFoldersInvertSelection.Location = new System.Drawing.Point(93, 10);
			this._EmptyFoldersInvertSelection.Name = "_EmptyFoldersInvertSelection";
			this._EmptyFoldersInvertSelection.Size = new System.Drawing.Size(75, 23);
			this._EmptyFoldersInvertSelection.TabIndex = 11;
			this._EmptyFoldersInvertSelection.Text = "Invert Selection";
			this._EmptyFoldersInvertSelection.UseVisualStyleBackColor = true;
			this._EmptyFoldersInvertSelection.Click += new System.EventHandler(this._EmptyFoldersInvertSelection_Click);
			// 
			// _EmptyFoldersSelectAll
			// 
			this._EmptyFoldersSelectAll.Location = new System.Drawing.Point(12, 10);
			this._EmptyFoldersSelectAll.Name = "_EmptyFoldersSelectAll";
			this._EmptyFoldersSelectAll.Size = new System.Drawing.Size(75, 23);
			this._EmptyFoldersSelectAll.TabIndex = 10;
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
			this._EmptyFoldersListBox.Location = new System.Drawing.Point(12, 47);
			this._EmptyFoldersListBox.Name = "_EmptyFoldersListBox";
			this._EmptyFoldersListBox.Size = new System.Drawing.Size(318, 244);
			this._EmptyFoldersListBox.Sorted = true;
			this._EmptyFoldersListBox.TabIndex = 9;
			this._EmptyFoldersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._EmptyFoldersListBox_MouseDown);
			// 
			// _EmptyFoldersDeleteButton
			// 
			this._EmptyFoldersDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._EmptyFoldersDeleteButton.Location = new System.Drawing.Point(347, 47);
			this._EmptyFoldersDeleteButton.Name = "_EmptyFoldersDeleteButton";
			this._EmptyFoldersDeleteButton.Size = new System.Drawing.Size(75, 23);
			this._EmptyFoldersDeleteButton.TabIndex = 8;
			this._EmptyFoldersDeleteButton.Text = "Delete";
			this._EmptyFoldersDeleteButton.UseVisualStyleBackColor = true;
			this._EmptyFoldersDeleteButton.Click += new System.EventHandler(this._EmptyFoldersDeleteButton_Click);
			// 
			// EmptyFoldersUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._EmptyFoldersDeleteToRecycleBin);
			this.Controls.Add(this._EmptyFoldersInvertSelection);
			this.Controls.Add(this._EmptyFoldersSelectAll);
			this.Controls.Add(this._EmptyFoldersListBox);
			this.Controls.Add(this._EmptyFoldersDeleteButton);
			this.Name = "EmptyFoldersUserControl";
			this.Size = new System.Drawing.Size(425, 310);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox _EmptyFoldersDeleteToRecycleBin;
		private System.Windows.Forms.Button _EmptyFoldersInvertSelection;
		private System.Windows.Forms.Button _EmptyFoldersSelectAll;
		private System.Windows.Forms.CheckedListBox _EmptyFoldersListBox;
		private System.Windows.Forms.Button _EmptyFoldersDeleteButton;
	}
}
