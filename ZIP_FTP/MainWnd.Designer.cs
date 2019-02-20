using System.Drawing;
using ZIP_FTP.Extenders;

namespace ZIP_FTP
{
  partial class MainWnd
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.lbl_Sites = new System.Windows.Forms.Label();
      this.lbl_SiteDirectory = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.pb_FTP = new CustomProgressBar();
      this.pb_ZIP = new CustomProgressBar();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rb_tester = new System.Windows.Forms.RadioButton();
      this.rb_release = new System.Windows.Forms.RadioButton();
      this.btn_sortSites = new System.Windows.Forms.Button();
      this.lbl_SearchSites = new System.Windows.Forms.Label();
      this.tb_searchSites = new System.Windows.Forms.TextBox();
      this.tb_selectedPublishItemFullPath = new System.Windows.Forms.TextBox();
      this.btn_refresh = new System.Windows.Forms.Button();
      this.lw_SitePublishDir = new System.Windows.Forms.ListView();
      this.publishDirectoryContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.timeOfPublish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lw_Sites = new System.Windows.Forms.ListView();
      this.sitesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lbl_SelectedPublish = new System.Windows.Forms.Label();
      this.btn_ZipFtp = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // lbl_Sites
      // 
      this.lbl_Sites.AutoSize = true;
      this.lbl_Sites.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Sites.Location = new System.Drawing.Point(6, 16);
      this.lbl_Sites.Name = "lbl_Sites";
      this.lbl_Sites.Size = new System.Drawing.Size(224, 13);
      this.lbl_Sites.TabIndex = 2;
      this.lbl_Sites.Text = "W:\\Razvoj\\WEM\\EasyEditCms\\Sites :";
      // 
      // lbl_SiteDirectory
      // 
      this.lbl_SiteDirectory.AutoSize = true;
      this.lbl_SiteDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SiteDirectory.Location = new System.Drawing.Point(410, 16);
      this.lbl_SiteDirectory.Name = "lbl_SiteDirectory";
      this.lbl_SiteDirectory.Size = new System.Drawing.Size(134, 13);
      this.lbl_SiteDirectory.TabIndex = 4;
      this.lbl_SiteDirectory.Text = "Site publish directory: ";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.pb_FTP);
      this.groupBox1.Controls.Add(this.pb_ZIP);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.btn_sortSites);
      this.groupBox1.Controls.Add(this.lbl_SearchSites);
      this.groupBox1.Controls.Add(this.tb_searchSites);
      this.groupBox1.Controls.Add(this.tb_selectedPublishItemFullPath);
      this.groupBox1.Controls.Add(this.btn_refresh);
      this.groupBox1.Controls.Add(this.lw_SitePublishDir);
      this.groupBox1.Controls.Add(this.lw_Sites);
      this.groupBox1.Controls.Add(this.lbl_SelectedPublish);
      this.groupBox1.Controls.Add(this.btn_ZipFtp);
      this.groupBox1.Controls.Add(this.lbl_Sites);
      this.groupBox1.Controls.Add(this.lbl_SiteDirectory);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBox1.Size = new System.Drawing.Size(724, 669);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      // 
      // pb_FTP
      // 
      this.pb_FTP.Location = new System.Drawing.Point(6, 527);
      this.pb_FTP.Name = "pb_FTP";
      this.pb_FTP.Size = new System.Drawing.Size(711, 33);
      this.pb_FTP.TabIndex = 18;
      // 
      // pb_ZIP
      // 
      this.pb_ZIP.Location = new System.Drawing.Point(6, 465);
      this.pb_ZIP.Name = "pb_ZIP";
      this.pb_ZIP.Size = new System.Drawing.Size(711, 32);
      this.pb_ZIP.TabIndex = 17;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rb_tester);
      this.groupBox2.Controls.Add(this.rb_release);
      this.groupBox2.Location = new System.Drawing.Point(6, 302);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(386, 48);
      this.groupBox2.TabIndex = 16;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Sort by (Publish directory content)";
      // 
      // rb_tester
      // 
      this.rb_tester.AutoSize = true;
      this.rb_tester.Location = new System.Drawing.Point(195, 19);
      this.rb_tester.Name = "rb_tester";
      this.rb_tester.Size = new System.Drawing.Size(55, 17);
      this.rb_tester.TabIndex = 15;
      this.rb_tester.TabStop = true;
      this.rb_tester.Text = "Tester";
      this.rb_tester.UseVisualStyleBackColor = true;
      this.rb_tester.CheckedChanged += new System.EventHandler(this.rb_tester_CheckedChanged);
      // 
      // rb_release
      // 
      this.rb_release.AutoSize = true;
      this.rb_release.Location = new System.Drawing.Point(6, 19);
      this.rb_release.Name = "rb_release";
      this.rb_release.Size = new System.Drawing.Size(64, 17);
      this.rb_release.TabIndex = 14;
      this.rb_release.TabStop = true;
      this.rb_release.Text = "Release";
      this.rb_release.UseVisualStyleBackColor = true;
      this.rb_release.CheckedChanged += new System.EventHandler(this.rb_release_CheckedChanged);
      // 
      // btn_sortSites
      // 
      this.btn_sortSites.Location = new System.Drawing.Point(201, 356);
      this.btn_sortSites.Name = "btn_sortSites";
      this.btn_sortSites.Size = new System.Drawing.Size(191, 23);
      this.btn_sortSites.TabIndex = 13;
      this.btn_sortSites.Text = "Sort sites (by publish time)";
      this.btn_sortSites.UseVisualStyleBackColor = true;
      this.btn_sortSites.Click += new System.EventHandler(this.btn_sortSites_Click);
      // 
      // lbl_SearchSites
      // 
      this.lbl_SearchSites.AutoSize = true;
      this.lbl_SearchSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SearchSites.Location = new System.Drawing.Point(3, 398);
      this.lbl_SearchSites.Name = "lbl_SearchSites";
      this.lbl_SearchSites.Size = new System.Drawing.Size(79, 13);
      this.lbl_SearchSites.TabIndex = 12;
      this.lbl_SearchSites.Text = "Search site: ";
      // 
      // tb_searchSites
      // 
      this.tb_searchSites.Location = new System.Drawing.Point(93, 395);
      this.tb_searchSites.Name = "tb_searchSites";
      this.tb_searchSites.Size = new System.Drawing.Size(299, 20);
      this.tb_searchSites.TabIndex = 11;
      this.tb_searchSites.TextChanged += new System.EventHandler(this.tb_searchSites_TextChanged);
      // 
      // tb_selectedPublishItemFullPath
      // 
      this.tb_selectedPublishItemFullPath.Location = new System.Drawing.Point(3, 612);
      this.tb_selectedPublishItemFullPath.Multiline = true;
      this.tb_selectedPublishItemFullPath.Name = "tb_selectedPublishItemFullPath";
      this.tb_selectedPublishItemFullPath.ReadOnly = true;
      this.tb_selectedPublishItemFullPath.Size = new System.Drawing.Size(714, 20);
      this.tb_selectedPublishItemFullPath.TabIndex = 10;
      // 
      // btn_refresh
      // 
      this.btn_refresh.Location = new System.Drawing.Point(6, 356);
      this.btn_refresh.Name = "btn_refresh";
      this.btn_refresh.Size = new System.Drawing.Size(189, 23);
      this.btn_refresh.TabIndex = 9;
      this.btn_refresh.Text = "Refresh";
      this.btn_refresh.UseVisualStyleBackColor = true;
      this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
      // 
      // lw_SitePublishDir
      // 
      this.lw_SitePublishDir.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.lw_SitePublishDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.publishDirectoryContent,
            this.timeOfPublish});
      this.lw_SitePublishDir.FullRowSelect = true;
      this.lw_SitePublishDir.Location = new System.Drawing.Point(413, 44);
      this.lw_SitePublishDir.MultiSelect = false;
      this.lw_SitePublishDir.Name = "lw_SitePublishDir";
      this.lw_SitePublishDir.Size = new System.Drawing.Size(304, 81);
      this.lw_SitePublishDir.TabIndex = 8;
      this.lw_SitePublishDir.UseCompatibleStateImageBehavior = false;
      this.lw_SitePublishDir.SelectedIndexChanged += new System.EventHandler(this.lw_SitePublishDir_SelectedIndexChanged);
      // 
      // publishDirectoryContent
      // 
      this.publishDirectoryContent.Text = "Publish Content";
      // 
      // timeOfPublish
      // 
      this.timeOfPublish.Text = "Time of publish";
      // 
      // lw_Sites
      // 
      this.lw_Sites.AllowColumnReorder = true;
      this.lw_Sites.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.lw_Sites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sitesName,
            this.lastModified});
      this.lw_Sites.FullRowSelect = true;
      this.lw_Sites.GridLines = true;
      this.lw_Sites.Location = new System.Drawing.Point(6, 44);
      this.lw_Sites.MultiSelect = false;
      this.lw_Sites.Name = "lw_Sites";
      this.lw_Sites.Size = new System.Drawing.Size(386, 252);
      this.lw_Sites.TabIndex = 7;
      this.lw_Sites.UseCompatibleStateImageBehavior = false;
      this.lw_Sites.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
      this.lw_Sites.SelectedIndexChanged += new System.EventHandler(this.lw_Sites_SelectedIndexChanged);
      // 
      // sitesName
      // 
      this.sitesName.Text = "Sites";
      // 
      // lastModified
      // 
      this.lastModified.Text = "Last modified (Publish directory content)";
      // 
      // lbl_SelectedPublish
      // 
      this.lbl_SelectedPublish.AutoSize = true;
      this.lbl_SelectedPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SelectedPublish.Location = new System.Drawing.Point(3, 586);
      this.lbl_SelectedPublish.Name = "lbl_SelectedPublish";
      this.lbl_SelectedPublish.Size = new System.Drawing.Size(159, 13);
      this.lbl_SelectedPublish.TabIndex = 6;
      this.lbl_SelectedPublish.Text = "Selected publish (full path)";
      // 
      // btn_ZipFtp
      // 
      this.btn_ZipFtp.Location = new System.Drawing.Point(3, 640);
      this.btn_ZipFtp.Name = "btn_ZipFtp";
      this.btn_ZipFtp.Size = new System.Drawing.Size(715, 23);
      this.btn_ZipFtp.TabIndex = 5;
      this.btn_ZipFtp.Text = "ZIP_FTP";
      this.btn_ZipFtp.UseVisualStyleBackColor = true;
      this.btn_ZipFtp.Click += new System.EventHandler(this.btn_ZipFtp_Click);
      // 
      // MainWnd
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(748, 693);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainWnd";
      this.Text = "ZIP_FTP";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Label lbl_Sites;
    private System.Windows.Forms.Label lbl_SiteDirectory;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btn_ZipFtp;
    private System.Windows.Forms.Label lbl_SelectedPublish;
    private System.Windows.Forms.ListView lw_Sites;
    public System.Windows.Forms.ColumnHeader sitesName;
    private System.Windows.Forms.ListView lw_SitePublishDir;
    private System.Windows.Forms.ColumnHeader lastModified;
    private System.Windows.Forms.Button btn_refresh;
    private System.Windows.Forms.ColumnHeader publishDirectoryContent;
    private System.Windows.Forms.ColumnHeader timeOfPublish;
    private System.Windows.Forms.TextBox tb_selectedPublishItemFullPath;
    private System.Windows.Forms.Label lbl_SearchSites;
    private System.Windows.Forms.TextBox tb_searchSites;
    private System.Windows.Forms.Button btn_sortSites;
    private System.Windows.Forms.RadioButton rb_tester;
    private System.Windows.Forms.RadioButton rb_release;
    private System.Windows.Forms.GroupBox groupBox2;
    private CustomProgressBar pb_FTP;
    private CustomProgressBar pb_ZIP;
  }
}

