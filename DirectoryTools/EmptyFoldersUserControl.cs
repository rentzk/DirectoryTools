using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Microsoft.VisualBasic.FileIO;

namespace DirectoryTools
{
	public partial class EmptyFoldersUserControl : UserControl
	{
		private string _FolderPath;

		public EmptyFoldersUserControl()
		{
			InitializeComponent();
		}

		public void SetContexctMenu(ContextMenuStrip listboxContextMenu)
		{
			_EmptyFoldersListBox.ContextMenuStrip = listboxContextMenu;
		}

		public void SetFolder(string folderPath)
		{
			_FolderPath = folderPath;
			_EmptyFoldersListBox.Items.Clear();
			FillEmptyFolderList();
		}

		private void _EmptyFoldersDeleteButton_Click(object sender, EventArgs e)
		{
			// go backwards so we can remove the deleted items from the list with the same loop
			for (int i = (_EmptyFoldersListBox.Items.Count - 1); i >= 0; i--)
			{
				if (_EmptyFoldersListBox.GetItemChecked(i))

				{
					try
					{
						string folder = _EmptyFoldersListBox.Items[i].ToString();
						FileSystem.DeleteDirectory(folder, UIOption.OnlyErrorDialogs,
													_EmptyFoldersDeleteToRecycleBin.Checked ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently,
													UICancelOption.ThrowException);
						_EmptyFoldersListBox.Items.RemoveAt(i);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						UpdateUI();
						return;
					}
				}
			}
			UpdateUI();
		}

		private void _EmptyFoldersInvertSelection_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _EmptyFoldersListBox.Items.Count; i++)
			{
				_EmptyFoldersListBox.SetItemChecked(i, !_EmptyFoldersListBox.GetItemChecked(i));
			}

			UpdateUI();
		}

		private void _EmptyFoldersListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			// since this event is triggered before the ui is updated, we want to delay things a little bit.
			this.BeginInvoke((MethodInvoker)(() => UpdateUI()));
		}

		private void _EmptyFoldersSelectAll_Click(object sender, EventArgs e)
		{
			bool newState = !_EmptyFoldersSelectAll.Text.ToUpper().Contains("UN");
			for (int i = 0; i < _EmptyFoldersListBox.Items.Count; i++)
			{
				_EmptyFoldersListBox.SetItemChecked(i, newState);
			}

			UpdateUI();
		}


		private void FillEmptyFolderList()
		{
			List<string> paths = GetEmptyFolders(_FolderPath);
			if (paths.Any())
			{
				foreach (string path in paths)
				{
					_EmptyFoldersListBox.Items.Add(path);
				}
				UpdateUI();
			}
			else
			{
				MessageBox.Show("No empty folders found");
			}
		}

		public static List<string> GetEmptyFolders(string rootPath)
		{
			List<string> paths = new List<string>();
			DirSearch(rootPath, paths);
			return paths;
		}

		public static List<string> DirSearch(string startingDir, List<string> paths)
		{
			try
			{
				foreach (string directory in Directory.GetDirectories(startingDir))
				{
					if (!Directory.GetDirectories(directory).Any() && !Directory.EnumerateFiles(directory).Any())
					{
						paths.Add(directory);
					}

					DirSearch(directory, paths);
				}
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return paths;
		}

		public void UpdateUI()
		{
			bool startingDirectoryExists = Directory.Exists(_FolderPath);
			_EmptyFoldersDeleteButton.Enabled = startingDirectoryExists;
			_EmptyFoldersListBox.Enabled = startingDirectoryExists;
			_EmptyFoldersInvertSelection.Enabled = startingDirectoryExists && _EmptyFoldersListBox.Items.Count > 0;
			_EmptyFoldersDeleteToRecycleBin.Enabled = startingDirectoryExists && _EmptyFoldersListBox.Items.Count > 0;

			_EmptyFoldersSelectAll.Enabled = startingDirectoryExists && _EmptyFoldersListBox.Items.Count > 0;
			if ((_EmptyFoldersListBox.CheckedItems.Count == 0) || (_EmptyFoldersListBox.CheckedItems.Count != _EmptyFoldersListBox.Items.Count))
				_EmptyFoldersSelectAll.Text = "Select All";
			else
				_EmptyFoldersSelectAll.Text = "UnSelect All";
		}

		private void _EmptyFoldersListBox_MouseDown(object sender, MouseEventArgs e)
		{
			Common.ListBox_MouseDownHandler(sender, e);
		}
	}
}

