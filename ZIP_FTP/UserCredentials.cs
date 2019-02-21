using SimplePasswordManager.Crypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIP_FTP
{
  public partial class UserCredentials : Form
  {
    public UserCredentials()
    {
      InitializeComponent();
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      string userName = tb_userName.Text;
      string password = Crypting.EncryptSecret(tb_password.Text);

      Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      configuration.AppSettings.Settings["UserName"].Value = userName;
      configuration.AppSettings.Settings["Password"].Value = password;
      configuration.Save(ConfigurationSaveMode.Full, true);
      ConfigurationManager.RefreshSection("appSettings");

      this.Close();
    }
  }
}
