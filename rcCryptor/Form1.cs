using rcCryptography;
using System;
using System.Windows.Forms;

namespace rcCryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = txbEncText.Text;
            string kvText = txbKeyVectorText.Text;
            string dec = null;

            try {
                dec = Crypto.Decrypt(text, Crypto.GetKeyMD5(kvText), Crypto.GetVectorMD5(kvText));
            } catch {
                dec = null;
            }

            txbDecrypt.Text = dec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = txbX1.Text;
            string x2 = txbX2.Text;
            string x3 = txbX3.Text;
            string user = txbUser.Text;
            string pwd = txbPwd.Text;

            string userPwd = x1 + user + x2 + pwd + x3;
            string pwdUser = x1 + pwd + x2 + user + x3;

            string hashUser = null;
            string hashPwd = null;
            string hashUserPwd = null;
            string hashPwdUser = null;

            if (rdbTypeMD5.Checked) {
                hashUser = Crypto.GetSecretMD5(user);
                hashPwd = Crypto.GetSecretMD5(pwd);
                hashUserPwd = Crypto.GetSecretMD5(userPwd);
                hashPwdUser = Crypto.GetSecretMD5(pwdUser);
            } if (rdbTypeSHA1.Checked) {
                hashUser = Crypto.GetSecretSHA1(user);
                hashPwd = Crypto.GetSecretSHA1(pwd);
                hashUserPwd = Crypto.GetSecretSHA1(userPwd);
                hashPwdUser = Crypto.GetSecretSHA1(pwdUser);
            } if (rdbTypeSHA256.Checked) {
                hashUser = Crypto.GetSecretSHA256(user);
                hashPwd = Crypto.GetSecretSHA256(pwd);
                hashUserPwd = Crypto.GetSecretSHA256(userPwd);
                hashPwdUser = Crypto.GetSecretSHA256(pwdUser);
            } if (rdbTypeSHA512.Checked) {
                hashUser = Crypto.GetSecretSHA512(user);
                hashPwd = Crypto.GetSecretSHA512(pwd);
                hashUserPwd = Crypto.GetSecretSHA512(userPwd);
                hashPwdUser = Crypto.GetSecretSHA512(pwdUser);
            }

            txbUserMD5.Text = Crypto.GetSecretMD5(user);
            txbPwdMD5.Text = Crypto.GetSecretMD5(pwd);

            txbHashUser.Text = hashUser;
            txbHashPwd.Text = hashPwd;
            txbHashUserPwd.Text = hashUserPwd;
            txbHashPwdUser.Text = hashPwdUser;

            string crpUser = Crypto.Encrypt(user);
            string crpPwd = Crypto.Encrypt(pwd);
            string crpUserPwd = Crypto.Encrypt(userPwd);
            string crpPwdUser = Crypto.Encrypt(pwdUser);

            txbCrpUser.Text = crpUser;
            txbCrpPwd.Text = crpPwd;
            txbCrpUserPwd.Text = crpUserPwd;
            txbCrpPwdUser.Text = crpPwdUser;
        }
    }
}
