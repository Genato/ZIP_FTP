namespace ZIP_FTP
{
  partial class UserCredentials
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
      this.btn_save = new System.Windows.Forms.Button();
      this.tb_password = new System.Windows.Forms.TextBox();
      this.tb_userName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btn_save
      // 
      this.btn_save.Location = new System.Drawing.Point(9, 124);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(130, 23);
      this.btn_save.TabIndex = 9;
      this.btn_save.Text = "Save";
      this.btn_save.UseVisualStyleBackColor = true;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // tb_password
      // 
      this.tb_password.Location = new System.Drawing.Point(9, 80);
      this.tb_password.Name = "tb_password";
      this.tb_password.Size = new System.Drawing.Size(130, 20);
      this.tb_password.TabIndex = 8;
      // 
      // tb_userName
      // 
      this.tb_userName.Location = new System.Drawing.Point(9, 25);
      this.tb_userName.Name = "tb_userName";
      this.tb_userName.Size = new System.Drawing.Size(130, 20);
      this.tb_userName.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Password";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "UserName";
      // 
      // UserCredentials
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(151, 163);
      this.Controls.Add(this.btn_save);
      this.Controls.Add(this.tb_password);
      this.Controls.Add(this.tb_userName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "UserCredentials";
      this.Text = "UserCredentials";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.TextBox tb_password;
    private System.Windows.Forms.TextBox tb_userName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}