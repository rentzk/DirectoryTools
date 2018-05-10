namespace DirectoryTools
{
	partial class MoveUpUserControl
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
			this._MoveUpInvertSelection = new System.Windows.Forms.Button();
			this._MoveUpSelectAll = new System.Windows.Forms.Button();
			this._MoveFoldersListBox = new System.Windows.Forms.CheckedListBox();
			this._MoveUpMoveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _MoveUpInvertSelection
			// 
			this._MoveUpInvertSelection.Location = new System.Drawing.Point(93, 10);
			this._MoveUpInvertSelection.Name = "_MoveUpInvertSelection";
			this._MoveUpInvertSelection.Size = new System.Drawing.Size(75, 23);
			this._MoveUpInvertSelection.TabIndex = 13;
			this._MoveUpInvertSelection.Text = "Invert Selection";
			this._MoveUpInvertSelection.UseVisualStyleBackColor = true;
			// 
			// _MoveUpSelectAll
			// 
			this._MoveUpSelectAll.Location = new System.Drawing.Point(12, 10);
			this._MoveUpSelectAll.Name = "_MoveUpSelectAll";
			this._MoveUpSelectAll.Size = new System.Drawing.Size(75, 23);
			this._MoveUpSelectAll.TabIndex = 12;
			this._MoveUpSelectAll.Text = "Select All";
			this._MoveUpSelectAll.UseVisualStyleBackColor = true;
			// 
			// _MoveFoldersListBox
			// 
			this._MoveFoldersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._MoveFoldersListBox.CheckOnClick = true;
			this._MoveFoldersListBox.FormattingEnabled = true;
			this._MoveFoldersListBox.Location = new System.Drawing.Point(12, 47);
			this._MoveFoldersListBox.Name = "_MoveFoldersListBox";
			this._MoveFoldersListBox.Size = new System.Drawing.Size(318, 244);
			this._MoveFoldersListBox.Sorted = true;
			this._MoveFoldersListBox.TabIndex = 11;
			this._MoveFoldersListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MoveFoldersListBox_MouseDown);
			// 
			// _MoveUpMoveButton
			// 
			this._MoveUpMoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._MoveUpMoveButton.Location = new System.Drawing.Point(347, 47);
			this._MoveUpMoveButton.Name = "_MoveUpMoveButton";
			this._MoveUpMoveButton.Size = new System.Drawing.Size(75, 23);
			this._MoveUpMoveButton.TabIndex = 10;
			this._MoveUpMoveButton.Text = "Move";
			this._MoveUpMoveButton.UseVisualStyleBackColor = true;
			this._MoveUpMoveButton.Click += new System.EventHandler(this._MoveUpMoveButton_Click);
			// 
			// MoveUpUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._MoveUpInvertSelection);
			this.Controls.Add(this._MoveUpSelectAll);
			this.Controls.Add(this._MoveFoldersListBox);
			this.Controls.Add(this._MoveUpMoveButton);
			this.Name = "MoveUpUserControl";
			this.Size = new System.Drawing.Size(425, 310);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _MoveUpInvertSelection;
		private System.Windows.Forms.Button _MoveUpSelectAll;
		private System.Windows.Forms.CheckedListBox _MoveFoldersListBox;
		private System.Windows.Forms.Button _MoveUpMoveButton;
	}
}
