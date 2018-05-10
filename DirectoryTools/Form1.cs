using System;
using System.IO;
using System.Windows.Forms;

namespace DirectoryTools
{
	public partial class Form1 : Form
	{
		private ContextMenuStrip listboxContextMenu;
		public Form1()
		{
			InitializeComponent();

			listboxContextMenu = new ContextMenuStrip();

			_EmptyFoldersUserControl.SetContexctMenu(listboxContextMenu);
			_EmptyFoldersUserControl.UpdateUI();

			_MoveUpUserControl.SetContexctMenu(listboxContextMenu);
			_MoveUpUserControl.UpdateUI();
		}

		private void FindAppropriateFolders()
		{
			_TabControl.Enabled = false;
			FillAppropriateList();
			_TabControl.Enabled = true;
		}

		private void FillAppropriateList()
		{
			switch (_TabControl.SelectedTab.TabIndex)
			{
				case 0:
					_EmptyFoldersUserControl.SetFolder(_FolderPath.Text);
					break;
				case 1:
					_MoveUpUserControl.SetFolder(_FolderPath.Text);

					break;
				default:
					throw new NotImplementedException();
			}
		}

		private void _FolderBrowse_Click(object sender, EventArgs e)
		{
			if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				_FolderPath.Text = _FolderBrowserDialog.SelectedPath;

				if (Directory.Exists(_FolderPath.Text))
					FindAppropriateFolders();
			}
		}

		// support drag & drop
		private void _FolderPath_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void _FolderPath_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

				if (Directory.Exists(files[0]))
				{
					_FolderPath.Text = files[0];
					FindAppropriateFolders();
				}
			}
		}

		// support manually entering a path
		private void _FolderPath_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && Directory.Exists(_FolderPath.Text))
					FindAppropriateFolders();
		}
	}
}