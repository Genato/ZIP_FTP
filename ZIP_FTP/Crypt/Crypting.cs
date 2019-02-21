using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SimplePasswordManager.Crypt
{
  public class Crypting
  {
    private Crypting() { }

    private static string Key { get { return "ZIP_FTP"; } }

    /// <summary>
    /// Function that encrytps password with key.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    public static string EncryptSecret(string password)
    {
      byte[] clearBytes = Encoding.Unicode.GetBytes(password);

      using (Aes encryptor = Aes.Create())
      {
        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        encryptor.Key = pdb.GetBytes(32);
        encryptor.IV = pdb.GetBytes(16);

        using (MemoryStream ms = new MemoryStream())
        {
          using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
          {
            cs.Write(clearBytes, 0, clearBytes.Length);
            cs.Close();
          }

          return Convert.ToBase64String(ms.ToArray());
        }
      }
    }

    /// <summary>
    /// Function that decrypt user secret if right key is provided.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string DecryptSecret(string cryptedPassword)
    {
      byte[] cipherBytes = Convert.FromBase64String(cryptedPassword);
      string decryptedPassword = "";

      using (Aes encryptor = Aes.Create())
      {
        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Key.ToString(), new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        encryptor.Key = pdb.GetBytes(32);
        encryptor.IV = pdb.GetBytes(16);

        using (MemoryStream ms = new MemoryStream())
        {
          using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
          {
            cs.Write(cipherBytes, 0, cipherBytes.Length);
            cs.Close();
          }

          decryptedPassword = Encoding.Unicode.GetString(ms.ToArray());
        }
      }

      return decryptedPassword;
    }
  }
}