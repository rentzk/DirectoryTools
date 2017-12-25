using System;
using System.IO;
using System.Windows.Forms;

namespace DirectoryTools
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			UpdateEmptyFoldersUI();
		}

		private void _FolderBrowse_Click(object sender, EventArgs e)
		{
			if (_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				_FolderPath.Text = _FolderBrowserDialog.SelectedPath;
				UpdateEmptyFoldersUI();
				if (Directory.Exists(_FolderPath.Text))
					FindFolders();
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
					FindFolders();
				}
			}
		}

		// support manually entering a path
		private void _FolderPath_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && Directory.Exists(_FolderPath.Text))
					FindFolders();
		}
	}
}