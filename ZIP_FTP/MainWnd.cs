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
using System.Net;
using ZIP_FTP.Extenders;

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
      tb_selectedPublishItemFullPath.Text = SitesLogic.SitesRootDirectory + SiteName + SitesLogic.SitesPublishDirectory + SelectedPublish;
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
      ListViewComparer.ColumnHeaderClickEvent(sender, e, (ListView)sender);
    }

    private void btn_sortSites_Click(object sender, EventArgs e)
    {
      ColumnClickEventArgs eArgs = new ColumnClickEventArgs(1);

      ListViewComparer.ColumnHeaderClickEvent(sender, eArgs, lw_Sites);
    }

    private void tb_searchSites_TextChanged(object sender, EventArgs e)
    {
      string siteName = (sender as TextBox).Text;

      if (siteName.Length < 4)
      {
        return;
      }

      ListViewItem[] listViewItems = new ListViewItem[0];

      for (int i = 0, j = 0; i < lw_Sites.Items.Count; i++)
      {
        if (lw_Sites.Items[i].Text.ToLower().Contains(siteName))
        {
          Array.Resize<ListViewItem>(ref listViewItems, listViewItems.Count() + 1);

          ListViewItem _listViewItem = new ListViewItem(lw_Sites.Items[i].Text);
          _listViewItem.SubItems.Add(lw_Sites.Items[i].SubItems[1].Text);

          listViewItems[j] = _listViewItem;
          listViewItems[j].BackColor = Color.Bisque;

          ++j;
        }
      }

      lw_Sites.Items.Clear();
      lw_Sites.Items.AddRange(listViewItems);
      CustomizeListView(lw_Sites);
    }

    private void btn_ZipFtp_Click(object sender, EventArgs e)
    {
      Task zipFtp_Task = new Task(() => ZipFtp.ZipThenFtp(this, tb_selectedPublishItemFullPath, pb_ZIP, pb_FTP, SiteName));
      zipFtp_Task.Start();
    }

    #endregion

    #region Cross threaded methods

    delegate void SetProgressBarDelegate(int value, string text, CustomProgressBar pb);

    /// <summary>
    /// Method for setting up ProgressBar value (for cross threaded) 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="pb"></param>
    public void SetProgressBarValue(int value, string text, CustomProgressBar pb)
    {
      // InvokeRequired required compares the thread ID of the
      // calling thread to the thread ID of the creating thread.
      // If these threads are different, it returns true.
      if (pb.InvokeRequired)
      {
        SetProgressBarDelegate del = new SetProgressBarDelegate(SetProgressBarValue);
        this.Invoke(del, new object[] { value, text, pb });
      }
      else
      {
        pb.Value = value;
        pb.CustomText = value == 0 ? "" : " - " + text;
      }

      #endregion
    }
  }
}