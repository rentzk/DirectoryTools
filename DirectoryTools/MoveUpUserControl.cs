using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DirectoryTools
{
	public partial class MoveUpUserControl : UserControl
	{
		private string _FolderPath;

		public MoveUpUserControl()
		{
			InitializeComponent();
		}

		public void SetContexctMenu(ContextMenuStrip listboxContextMenu)
		{
			_MoveFoldersListBox.ContextMenuStrip = listboxContextMenu;
		}

		public void SetFolder(string folderPath)
		{
			_FolderPath = folderPath;
			_MoveFoldersListBox.Items.Clear();
			FillMoveUpFolderList();
		}


		private void _MoveUpInvertSelection_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _MoveFoldersListBox.Items.Count; i++)
			{
				_MoveFoldersListBox.SetItemChecked(i, !_MoveFoldersListBox.GetItemChecked(i));
			}

			UpdateUI();
		}

		private void _MoveUpSelectAll_Click(object sender, EventArgs e)
		{
			bool newState = !_MoveFoldersListBox.Text.ToUpper().Contains("UN");
			for (int i = 0; i < _MoveFoldersListBox.Items.Count; i++)
			{
				_MoveFoldersListBox.SetItemChecked(i, newState);
			}

			UpdateUI();
		}

		private void _MoveUpMoveButton_Click(object sender, EventArgs e)
		{
			// go backwards so we can remove the deleted items from the list with the same loop
			for (int i = (_MoveFoldersListBox.Items.Count - 1); i >= 0; i--)
			{
				if (_MoveFoldersListBox.GetItemChecked(i))

				{
					try
					{
						string folder = _MoveFoldersListBox.Items[i].ToString();
						MoveFolderContentsUp(folder);
						_MoveFoldersListBox.Items.RemoveAt(i);
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

		private void MoveFolderContentsUp(string folder)
		{
			bool statusOK = true;
			try
			{
				string destinationFolder = Path.GetDirectoryName(folder);
				foreach (string file in Directory.EnumerateFiles(folder))
				{
					string currentFile = Path.GetFileName(file);
					string destinationFile = Path.Combine(destinationFolder, currentFile);
					File.Copy(file, destinationFile); // no overwriting
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				statusOK = false;
			}

			if (statusOK)
			{
				try
				{
					foreach (string file in Directory.EnumerateFiles(folder))
					{
						File.Delete(file);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}


		private void FillMoveUpFolderList()
		{
			List<string> paths = GetFoldersToMoveUp(_FolderPath);
			if (paths.Any())
			{
				foreach (string path in paths)
				{
					_MoveFoldersListBox.Items.Add(path);
				}
				UpdateUI();
			}
			else
			{
				MessageBox.Show("No movable folders found");
			}
		}

		public static List<string> GetFoldersToMoveUp(string rootPath)
		{
			List<string> paths = new List<string>();

			int directoryCount = Directory.GetDirectories(rootPath).Count();
			int fileCount = Directory.EnumerateFiles(rootPath).Count();

			foreach (string directory in Directory.GetDirectories(rootPath))
			{
				MovableDirSearch(directory, (directoryCount == 1 && fileCount == 0), paths);
			}

			return paths;
		}

		// a folders contents are movable if it contains files and no sub folders and it's parent folder has no files.
		public static List<string> MovableDirSearch(string startingDir, bool parentHasNothingButOneDirectory, List<string> paths)
		{
			try
			{
				int directoryCount = Directory.GetDirectories(startingDir).Count();
				int fileCount = Directory.EnumerateFiles(startingDir).Count();

				// does the current directory match?
				if (directoryCount == 0 && fileCount > 0 && parentHasNothingButOneDirectory)
					paths.Add(startingDir);

				// now handle any sub directories
				if (directoryCount > 0)
				{
					foreach (string directory in Directory.GetDirectories(startingDir))
					{
						MovableDirSearch(directory, (directoryCount == 1 && fileCount == 0), paths);
					}
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
			_MoveUpMoveButton.Enabled = startingDirectoryExists;
			_MoveFoldersListBox.Enabled = startingDirectoryExists;
			_MoveUpInvertSelection.Enabled = startingDirectoryExists && _MoveFoldersListBox.Items.Count > 0;

			_MoveUpSelectAll.Enabled = startingDirectoryExists && _MoveFoldersListBox.Items.Count > 0;
			if ((_MoveFoldersListBox.CheckedItems.Count == 0) || (_MoveFoldersListBox.CheckedItems.Count != _MoveFoldersListBox.Items.Count))
				_MoveUpSelectAll.Text = "Select All";
			else
				_MoveUpSelectAll.Text = "UnSelect All";
		}

		private void _MoveFoldersListBox_MouseDown(object sender, MouseEventArgs e)
		{
			Common.ListBox_MouseDownHandler(sender, e);
		}
	}
}

