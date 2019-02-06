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

      SetDefaultRadioChecked(rb_release);
      LoadSites();
    }

    private static string SiteName { get; set; }
    private static string SelectedPublish { get; set; }
    public static string SortBy { get; set; }
    // The column we are currently using for sorting.
    private ColumnHeader SortingColumn = null;

    private void LoadSites()
    {
      ListViewItem[] sites = SitesLogic.GetSites(lw_Sites, SortBy);
      lw_Sites.Items.AddRange(sites);
      CustomizeListView(lw_Sites);
    }

    private void CustomizeListView(ListView listView)
    {
      listView.View = View.Details;
      listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    private void SetDefaultRadioChecked(RadioButton radioButton)
    {
      radioButton.Checked = true;
      SortBy = rb_release.Text;
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

    private void lw_Sites_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lw_Sites.SelectedItems.Count <= 0)
      {
        return;
      }

      lw_SitePublishDir.Items.Clear();
      CustomizeListView(lw_SitePublishDir);

      lbl_SiteDirectory.Text += (string)lw_Sites.SelectedItems[0].Text;
      SiteName = (string)lw_Sites.SelectedItems[0].Text;

      try
      {
        lw_SitePublishDir.Items.AddRange(SitesLogic.GetSitePublishDirectoryContent(SiteName));
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

    private void lw_SitePublishDir_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lw_SitePublishDir.SelectedItems.Count <= 0)
      {
        return;
      }

      SelectedPublish = (string)lw_SitePublishDir.SelectedItems[0].Text;
      tb_selectedPublishItemFullPath.Text += SitesLogic.SitesRootDirectory + SiteName + SitesLogic.SitesPublishDirectory + SelectedPublish;
    }

    private void btn_refresh_Click(object sender, EventArgs e)
    {
      lw_Sites.Items.Clear();
      LoadSites();
    }

    private void rb_release_CheckedChanged(object sender, EventArgs e)
    {
      SortBy = ((RadioButton)sender).Text;
    }

    private void rb_tester_CheckedChanged(object sender, EventArgs e)
    {
      SortBy = ((RadioButton)sender).Text;
    }

    private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      // Get the new sorting column.
      ColumnHeader new_sorting_column = lw_Sites.Columns[e.Column];

      // Figure out the new sorting order.
      System.Windows.Forms.SortOrder sort_order;
      if (SortingColumn == null)
      {
        // New column. Sort ascending.
        sort_order = SortOrder.Ascending;
      }
      else
      {
        // See if this is the same column.
        if (new_sorting_column == SortingColumn)
        {
          // Same column. Switch the sort order.
          if (SortingColumn.Text.StartsWith(@"/\ "))
          {
            sort_order = SortOrder.Ascending;
          }
          else
          {
            sort_order = SortOrder.Descending;
          }
        }
        else
        {
          // New column. Sort ascending.
          sort_order = SortOrder.Ascending;
        }

        // Remove the old sort indicator.
        SortingColumn.Text = SortingColumn.Text.Substring(2);
      }

      // Display the new sort order.
      SortingColumn = new_sorting_column;
      if (sort_order == SortOrder.Ascending)
      {
        SortingColumn.Text = @"\/ " + SortingColumn.Text.Trim();
      }
      else
      {
        SortingColumn.Text = @"/\ " + SortingColumn.Text.Trim();
      }

      // Create a comparer.
      lw_Sites.ListViewItemSorter =
          new ListViewComparer(e.Column, sort_order);

      // Sort.
      lw_Sites.Sort();

    }

    private void btn_sortSites_Click(object sender, EventArgs e)
    {
      ColumnClickEventArgs eArgs = new ColumnClickEventArgs(1);

      listView_ColumnClick(lw_Sites, eArgs);
    }

    private void tb_searchSites_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_ZipFtp_Click(object sender, EventArgs e)
    {

    }


    #endregion

  }
}
