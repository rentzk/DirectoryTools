using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTools
{
	static class DirectoryUtils
	{
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
					if(!Directory.GetDirectories(directory).Any() && !Directory.EnumerateFiles(directory).Any())
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
	}
}
