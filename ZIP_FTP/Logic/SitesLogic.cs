using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace ZIP_FTP.Logic
{
  public class SitesLogic
  {
    public static string SitesRootDirectory { get { return @"W:\Razvoj\WEM\EasyEditCms\Sites\"; } }
    public static string SitesPublishDirectory { get { return @"\Publish\"; } }

    public static ListViewItem[] GetSites(ListView lw_Sites)
    {
      string[] sitesFullPath = Directory.GetDirectories(SitesLogic.SitesRootDirectory);
      string[] sitesNames = GetLastPartFromPath(sitesFullPath);
      string[] sitesLastModified = GetSitesDirectoryLastModifiedTime(sitesFullPath);

      ListViewItem[] listViewItems = new ListViewItem[sitesFullPath.Length];

      for (int i = 0; i < sitesNames.Length; i++)
      {
        ListViewItem _listViewItem = new ListViewItem(sitesNames[i]);
        _listViewItem.SubItems.Add(sitesLastModified[i]);

        listViewItems[i] = _listViewItem;
        listViewItems[i].BackColor = Color.Bisque;
      }

      return listViewItems;
    }

    public static ListViewItem[] GetSitePublishDirectoryContent(string siteName)
    {
      string[] sitePublishDirectory;

      try
      {
        sitePublishDirectory = Directory.GetDirectories(SitesLogic.SitesRootDirectory + siteName + SitesPublishDirectory);

        if (sitePublishDirectory.Length < 1)
        {
          throw new FileNotFoundException();
        }
      }
      catch (FileNotFoundException)
      {
        throw new FileNotFoundException("There is no content in publish directory !!");
      }
      catch (Exception)
      {
        throw new Exception("Publish directory does not exist !!");
      }

      string[] publishDirectoriesNames = GetLastPartFromPath(sitePublishDirectory);
      string[] publishDirectoriesLastWriten = GetSitesDirectoryLastModifiedTime(sitePublishDirectory);
      //string[] concatenatedPublishNamesAndLastModified = ConcatPublishNamesAndLastMo0dified(publishDirectoriesNames, publishDirectoriesLastWriten);

      ListViewItem[] listViewItems = new ListViewItem[publishDirectoriesNames.Length];

      for (int i = 0; i < publishDirectoriesNames.Length; i++)
      {
        ListViewItem _listViewItem = new ListViewItem(publishDirectoriesNames[i]);
        _listViewItem.SubItems.Add(publishDirectoriesLastWriten[i]);

        listViewItems[i] = _listViewItem;
        listViewItems[i].BackColor = Color.Bisque;
      }


      return listViewItems;
    }

    /// <summary>
    /// Method parse full paths and return last parts of paths (i.e. c:\something\else\nothing --> "nothing" is taken)
    /// </summary>
    /// <param name="fullPaths"></param>
    /// <returns></returns>
    private static string[] GetLastPartFromPath(string[] fullPaths)
    {
      string[] lastPartOfPaths = new string[fullPaths.Length];

      for (int i = 0; i < fullPaths.Length; i++)
      {
        lastPartOfPaths[i] = fullPaths[i].Substring(fullPaths[i].LastIndexOf(@"\") + 1);
      }

      return lastPartOfPaths;
    }

    private static string[] GetSitesDirectoryLastModifiedTime(string[] directoriePaths)
    {
      string[] directoriesLastWritenTime = new string[directoriePaths.Length];

      for (int i = 0; i < directoriePaths.Length; i++)
      {
        directoriesLastWritenTime[i] = Directory.GetLastWriteTime(directoriePaths[i]).ToString();
      }

      return directoriesLastWritenTime;
    }

    private static string[] ConcatPublishNamesAndLastMo0dified(string[] directoriesName, string[] directoriesLastModified)
    {
      string[] newStringArray = new string[directoriesName.Length];

      for (int i = 0; i < directoriesName.Length; i++)
      {
        newStringArray[i] = directoriesName[i] + " - " + directoriesLastModified[i];
      }

      return newStringArray;
    }
  }
}
