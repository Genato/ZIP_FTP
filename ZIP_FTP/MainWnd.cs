using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Microsoft.WindowsAPICodePack.Dialogs;
using ZIP_FTP.Logic;

namespace ZIP_FTP
{
  public partial class MainWnd : Form
  {
    public MainWnd()
    {
      InitializeComponent();

      LoadSites();
    }

    private void LoadSites()
    {
      lb_Sites.Items.AddRange(SitesLogic.GetSites(lb_Sites));
    }

    #region TEST METHODS

    private void button1_Click(object sender, EventArgs e)
    {
      CommonOpenFileDialog dialog = new CommonOpenFileDialog();
      dialog.InitialDirectory = @"W:\Razvoj\WEM\EasyEditCms\Sites";
      dialog.IsFolderPicker = true;

      if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
      {
        SimpleZip(dialog.FileName, dialog.FileName + "ZIP_TEST.zip", CompressionLevel.Optimal, true);
      }
    }

    //Example 1
    static void SimpleZip(string dirToZip, string zipName)
    {
      ZipFile.CreateFromDirectory(dirToZip, zipName);
    }

    //Example 2
    static void SimpleZip(string dirToZip, string zipName, CompressionLevel compression, bool includeRoot)
    {
      ZipFile.CreateFromDirectory(dirToZip, zipName, compression, includeRoot);
    }


    #endregion

    #region EVENTS

    private void lb_Sites_SelectedIndexChanged(object sender, EventArgs e)
    {
      lb_SitePublishDir.Items.Clear();

      lbl_SiteDirectory.Text = (string)lb_Sites.SelectedItem;

      try
      {
        lb_SitePublishDir.Items.AddRange(SitesLogic.GetSitePublishDirectoryContent(lb_SitePublishDir, (string)lb_Sites.SelectedItem));
      }
      catch (FileNotFoundException exception)
      {
        MessageBox.Show(exception.Message);
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
      }
    }

    #endregion
  }
}
