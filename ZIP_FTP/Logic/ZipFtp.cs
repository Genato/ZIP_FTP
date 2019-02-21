using Helpers;
using SimplePasswordManager.Crypt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZIP_FTP.Extenders;

namespace ZIP_FTP.Logic
{
  public class ZipFtp
  {
    private static string FTP_URL { get { return "ftp://server.wem.hr/_upload/"; } }
    public MainWnd MainWnd { get; set; }
    public static string UserName { get { return ConfigurationManager.AppSettings["UserName"]; } }
    public static string Password { get { return Crypting.DecryptSecret(ConfigurationManager.AppSettings["Password"]); } }

    public static void ZipThenFtp(MainWnd mainWnd, TextBox tb_selectedPublishItemFullPath, CustomProgressBar pb_ZIP, CustomProgressBar pb_FTP, string SiteName)
    {
      string directoryForZipFtp = tb_selectedPublishItemFullPath.Text;

      string currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
      currentUser = currentUser.Contains(@"\") == true ? currentUser.Replace('\\', '_') : currentUser;

      string zipFileName_Path = directoryForZipFtp + "_" + SitesLogic.Frontend + "_" + currentUser + ".zip";

      Compression.SimpleZip(directoryForZipFtp, zipFileName_Path, mainWnd, pb_ZIP);

      string fileName = zipFileName_Path.Substring(zipFileName_Path.LastIndexOf('\\') + 1);
      fileName = SiteName + "_" + fileName;

      using (WebClient client = new WebClient())
      {
        CancellationTokenSource ts_FTP = new CancellationTokenSource();
        CancellationToken ct_FTP = ts_FTP.Token;
        Task pbFtp_Task = new Task(() => { pb_FTP.SetProgressBarValueByTicks(mainWnd, 100, "Uploading...", ct_FTP); }, ct_FTP);
        pbFtp_Task.Start();

        client.Credentials = new NetworkCredential(UserName, Password);
        client.UploadFile(FTP_URL + fileName, WebRequestMethods.Ftp.UploadFile, zipFileName_Path);

        ts_FTP.Cancel();
        mainWnd.SetProgressBarValue(100, "Upload Finished", pb_FTP);
      }

      MessageBox.Show("upload finished !!");

      File.Delete(zipFileName_Path);
      mainWnd.SetProgressBarValue(0, "", pb_ZIP);
      mainWnd.SetProgressBarValue(0, "", pb_FTP);
    }

  }
}
