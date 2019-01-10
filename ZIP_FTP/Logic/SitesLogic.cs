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
    public static string SitesRootFolder { get { return @"W:\Razvoj\WEM\EasyEditCms\Sites"; } }

    public static ListBox.ObjectCollection GetSitesAsListBoxObjectCollection(ListBox lb_Sites)
    {
      string[] sitesFullPath = Directory.GetDirectories(SitesLogic.SitesRootFolder);
      string[] sitesNames = GetSitesNameFromFullpath(sitesFullPath);

      ListBox.ObjectCollection sitesAsObjectCollection = new ListBox.ObjectCollection(lb_Sites, sitesNames);

      return sitesAsObjectCollection;
    }

    private static string[] GetSitesNameFromFullpath(string[] sitesFullPath)
    {
      string[] sitesName = new string[sitesFullPath.Length];

      for (int i = 0; i < sitesFullPath.Length; i++)
      {
        sitesName[i] = sitesFullPath[i].Substring(sitesFullPath[i].LastIndexOf(@"\") + 1);
      }

      return sitesName;
    }
  }
}
