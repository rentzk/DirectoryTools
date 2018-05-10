using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryTools
{
	class Common
	{

		private static void ViewwFolderEvent(object sender, EventArgs e)
		{
			try
			{
				Process.Start((string)((ToolStripMenuItem)sender).Tag);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static void ListBox_MouseDownHandler(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				//select the item under the mouse pointer
				CheckedListBox listBox = (CheckedListBox)sender;
				listBox.SelectedIndex = listBox.IndexFromPoint(e.Location);
				if (listBox.SelectedIndex != -1)
				{
					listBox.ContextMenuStrip.Items.Clear();
					//ToolStripMenuItem menuItem = new ToolStripMenuItem("View Folder", null, ViewwFolderEvent);
					ToolStripMenuItem menuItem = new ToolStripMenuItem("View Folder", null, ViewwFolderEvent);
					menuItem.Tag = listBox.SelectedItem;
					listBox.ContextMenuStrip.Items.Add(menuItem);
					listBox.ContextMenuStrip.Show();
				}
			}
		}
	}
}
