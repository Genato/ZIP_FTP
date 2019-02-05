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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.lb_Sites = new System.Windows.Forms.ListBox();
      this.lbl_Sites = new System.Windows.Forms.Label();
      this.lb_SitePublishDir = new System.Windows.Forms.ListBox();
      this.lbl_SiteDirectory = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lw_Sites = new System.Windows.Forms.ListView();
      this.lbl_SelectedPublish = new System.Windows.Forms.Label();
      this.btn_ZipFtp = new System.Windows.Forms.Button();
      this.sitesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(885, 515);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lb_Sites
      // 
      this.lb_Sites.FormattingEnabled = true;
      this.lb_Sites.Location = new System.Drawing.Point(6, 44);
      this.lb_Sites.Name = "lb_Sites";
      this.lb_Sites.Size = new System.Drawing.Size(224, 290);
      this.lb_Sites.TabIndex = 1;
      this.lb_Sites.SelectedIndexChanged += new System.EventHandler(this.lb_Sites_SelectedIndexChanged);
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
      // lb_SitePublishDir
      // 
      this.lb_SitePublishDir.FormattingEnabled = true;
      this.lb_SitePublishDir.Location = new System.Drawing.Point(257, 44);
      this.lb_SitePublishDir.Name = "lb_SitePublishDir";
      this.lb_SitePublishDir.Size = new System.Drawing.Size(262, 82);
      this.lb_SitePublishDir.TabIndex = 3;
      this.lb_SitePublishDir.SelectedIndexChanged += new System.EventHandler(this.lb_SitePublishDir_SelectedIndexChanged);
      // 
      // lbl_SiteDirectory
      // 
      this.lbl_SiteDirectory.AutoSize = true;
      this.lbl_SiteDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SiteDirectory.Location = new System.Drawing.Point(254, 16);
      this.lbl_SiteDirectory.Name = "lbl_SiteDirectory";
      this.lbl_SiteDirectory.Size = new System.Drawing.Size(134, 13);
      this.lbl_SiteDirectory.TabIndex = 4;
      this.lbl_SiteDirectory.Text = "Site publish directory: ";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lw_Sites);
      this.groupBox1.Controls.Add(this.lbl_SelectedPublish);
      this.groupBox1.Controls.Add(this.btn_ZipFtp);
      this.groupBox1.Controls.Add(this.lbl_Sites);
      this.groupBox1.Controls.Add(this.lbl_SiteDirectory);
      this.groupBox1.Controls.Add(this.lb_SitePublishDir);
      this.groupBox1.Controls.Add(this.lb_Sites);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBox1.Size = new System.Drawing.Size(647, 501);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      // 
      // lw_Sites
      // 
      this.lw_Sites.AllowColumnReorder = true;
      this.lw_Sites.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.lw_Sites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sitesHeader});
      this.lw_Sites.FullRowSelect = true;
      this.lw_Sites.GridLines = true;
      this.lw_Sites.Location = new System.Drawing.Point(9, 367);
      this.lw_Sites.Name = "lw_Sites";
      this.lw_Sites.Size = new System.Drawing.Size(379, 128);
      this.lw_Sites.TabIndex = 7;
      this.lw_Sites.UseCompatibleStateImageBehavior = false;
      // 
      // lbl_SelectedPublish
      // 
      this.lbl_SelectedPublish.AutoSize = true;
      this.lbl_SelectedPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_SelectedPublish.Location = new System.Drawing.Point(254, 167);
      this.lbl_SelectedPublish.Name = "lbl_SelectedPublish";
      this.lbl_SelectedPublish.Size = new System.Drawing.Size(101, 13);
      this.lbl_SelectedPublish.TabIndex = 6;
      this.lbl_SelectedPublish.Text = "Selected publish";
      // 
      // btn_ZipFtp
      // 
      this.btn_ZipFtp.Location = new System.Drawing.Point(391, 311);
      this.btn_ZipFtp.Name = "btn_ZipFtp";
      this.btn_ZipFtp.Size = new System.Drawing.Size(75, 23);
      this.btn_ZipFtp.TabIndex = 5;
      this.btn_ZipFtp.Text = "ZIP_FTP";
      this.btn_ZipFtp.UseVisualStyleBackColor = true;
      this.btn_ZipFtp.Click += new System.EventHandler(this.btn_ZipFtp_Click);
      // 
      // sitesHeader
      // 
      this.sitesHeader.Text = "Sites";
      // 
      // MainWnd
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(981, 550);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button1);
      this.Name = "MainWnd";
      this.Text = "ZIP_FTP";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox lb_Sites;
    private System.Windows.Forms.Label lbl_Sites;
    private System.Windows.Forms.ListBox lb_SitePublishDir;
    private System.Windows.Forms.Label lbl_SiteDirectory;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btn_ZipFtp;
    private System.Windows.Forms.Label lbl_SelectedPublish;
    private System.Windows.Forms.ListView lw_Sites;
    public System.Windows.Forms.ColumnHeader sitesHeader;
  }
}

