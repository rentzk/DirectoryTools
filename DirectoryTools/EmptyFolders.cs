using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DirectoryTools
{
	public partial class Form1 : Form
	{
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
						UpdateEmptyFoldersUI();
						return;
					}
				}
			}
			UpdateEmptyFoldersUI();
		}

		private void _EmptyFoldersInvertSelection_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _EmptyFoldersListBox.Items.Count; i++)
			{
				_EmptyFoldersListBox.SetItemChecked(i, !_EmptyFoldersListBox.GetItemChecked(i));
			}

			UpdateEmptyFoldersUI();
		}

		private void _EmptyFoldersListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			// since this event is triggered befor ethe ui is updated, we want to delay things a little bit.
			this.BeginInvoke((MethodInvoker)(() => UpdateEmptyFoldersUI()));
		}

		private void _EmptyFoldersSelectAll_Click(object sender, EventArgs e)
		{
			bool newState = !_EmptyFoldersSelectAll.Text.ToUpper().Contains("UN");
			for (int i = 0; i < _EmptyFoldersListBox.Items.Count; i++)
			{
				_EmptyFoldersListBox.SetItemChecked(i, newState);
			}

			UpdateEmptyFoldersUI();
		}

		private void FindFolders()
		{
			_EmptyFoldersListBox.Items.Clear();
			List<string> paths = DirectoryUtils.GetEmptyFolders(_FolderPath.Text);
			if (paths.Any())
			{
				foreach (string path in paths)
				{
					_EmptyFoldersListBox.Items.Add(path);
				}
				UpdateEmptyFoldersUI();
			}
			else
			{
				MessageBox.Show("No empty folders found");
			}
		}

		private void UpdateEmptyFoldersUI()
		{
			bool startingDirectoryExists = Directory.Exists(_FolderPath.Text);
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
	}
}