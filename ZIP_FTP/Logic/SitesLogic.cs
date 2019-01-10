using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIP_FTP.Logic
{
  public class SitesLogic
  {
    public static string SitesRootDirectory { get { return @"W:\Razvoj\WEM\EasyEditCms\Sites\"; } }
    public static string SitesPublishDirectory { get { return @"\Publish"; } }

    public static ListBox.ObjectCollection GetSites(ListBox lb_Sites)
    {
      string[] sitesFullPath = Directory.GetDirectories(SitesLogic.SitesRootDirectory);
      string[] sitesNames = GetLastPartFromPath(sitesFullPath);

      ListBox.ObjectCollection sitesAsObjectCollection = new ListBox.ObjectCollection(lb_Sites, sitesNames);

      return sitesAsObjectCollection;
    }

    public static ListBox.ObjectCollection GetSitePublishDirectoryContent(ListBox lb_SitePublishDir, string siteName)
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

      string[] publishNames = GetLastPartFromPath(sitePublishDirectory);
      ListBox.ObjectCollection sitesAsObjectCollection = new ListBox.ObjectCollection(lb_SitePublishDir, publishNames);

      return new ListBox.ObjectCollection(lb_SitePublishDir);
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
  }
}
