using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace rcCryptor
{
    public partial class Form1 : Form
    {
        private const string conSalt = "6DEDCA12EAF258EF";
        private const string conKey = "15010CB6E7AD9B8CBD3D80D7E7539E80";
        private const string conVector = "A08FD5BA3BFA17C3";

        public Form1()
        {
            InitializeComponent();
        }

        private string GetKeyMD5(string text) 
        {
            return CryptlockMD5(text).Substring(0, 32);
        }

        private string GetVectorMD5(string text)
        {
            return CryptlockMD5(text).Substring(0, 16);
        }

        private string GetSaltMD5(string text)
        {
            return CryptlockMD5(text).Substring(0, 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = txbEncText.Text;
            string key = txbEncKey.Text;
            string dec = null;

            try {
                dec = Decrypt(text, key.Substring(0, 32), key.Substring(0, 16));
            } catch (Exception ex) {
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
                hashUser = CryptlockMD5(user);
                hashPwd = CryptlockMD5(pwd);
                hashUserPwd = CryptlockMD5(userPwd);
                hashPwdUser = CryptlockMD5(pwdUser);
            } if (rdbTypeSHA1.Checked) {
                hashUser = CryptlockSHA1(user);
                hashPwd = CryptlockSHA1(pwd);
                hashUserPwd = CryptlockSHA1(userPwd);
                hashPwdUser = CryptlockSHA1(pwdUser);
            } if (rdbTypeSHA256.Checked) {
                hashUser = CryptlockSHA256(user);
                hashPwd = CryptlockSHA256(pwd);
                hashUserPwd = CryptlockSHA256(userPwd);
                hashPwdUser = CryptlockSHA256(pwdUser);
            } if (rdbTypeSHA512.Checked) {
                hashUser = CryptlockSHA512(user);
                hashPwd = CryptlockSHA512(pwd);
                hashUserPwd = CryptlockSHA512(userPwd);
                hashPwdUser = CryptlockSHA512(pwdUser);
            }

            txbUserMD5.Text = CryptlockMD5(user);
            txbPwdMD5.Text = CryptlockMD5(pwd);

            txbHashUser.Text = hashUser;
            txbHashPwd.Text = hashPwd;
            txbHashUserPwd.Text = hashUserPwd;
            txbHashPwdUser.Text = hashPwdUser;

            string crpUser = Encrypt(user, GetKeyMD5(user), GetVectorMD5(user));
            string crpPwd = Encrypt(pwd, GetKeyMD5(pwd), GetVectorMD5(pwd));
            string crpUserPwd = Encrypt(userPwd, GetKeyMD5(userPwd), GetVectorMD5(userPwd));
            string crpPwdUser = Encrypt(pwdUser, GetKeyMD5(pwdUser), GetVectorMD5(pwdUser));

            txbCrpUser.Text = crpUser;
            txbCrpPwd.Text = crpPwd;
            txbCrpUserPwd.Text = crpUserPwd;
            txbCrpPwdUser.Text = crpPwdUser;
        }

        /// <summary>
        /// Misturar o texto com alguns caracteres
        /// </summary>
        /// <param name="text"></param>
        /// <returns>resultado</returns>
        public string Salt(string text)
        {
            string result = null;
            string saltText = null;

            saltText = GetSaltMD5(text);

            if (!String.IsNullOrEmpty(text)) {
                int textSize = text.Length;
                
                for (int i = 0; i < textSize; i++) {
                    result += text[i].ToString();

                    if (i < 16) {
                        result += saltText[i].ToString();
                    }
                }
            } else {
                result = text;
            }

            return result;
        }

        /// <summary>
        /// Retirar caracteres misturados no texto
        /// </summary>
        /// <param name="text"></param>
        /// <returns>resultado</returns>
        public string Desalt(string text)
        {
            string result = null;

            if (!String.IsNullOrEmpty(text)) {
                int textSize = text.Length;

                for (int i = 0; i < textSize; i++) {
                    if (i < 32) {
                        if (i % 2 == 0) {
                            result += text[i].ToString();
                        }
                    } else {
                        result += text[i].ToString();
                    }
                }
            } else {
                result = text;
            }

            return result;
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido descriptografável
        /// </summary>
        /// <returns></returns>
        public string Encrypt(string password, string key, string vector)
        {
            string secret = null;

            try {
                if (password != null) {
                    byte[] byteVector = null;
                    byte[] byteKey = null;
                    byte[] textByte = null;

                    MemoryStream memoryStream = null;
                    CryptoStream cryptoStream = null;
                    ICryptoTransform iCryptoTransform = null;
                    Rijndael rijndael = null;

                    byteKey = ASCIIEncoding.ASCII.GetBytes(key);
                    textByte = ASCIIEncoding.ASCII.GetBytes(password);
                    byteVector = ASCIIEncoding.ASCII.GetBytes(vector);

                    rijndael = new RijndaelManaged();
                    rijndael.KeySize = 256;
                    rijndael.Key = byteKey;
                    rijndael.IV = byteVector;
                    rijndael.BlockSize = 128;
                    rijndael.Padding = PaddingMode.PKCS7;

                    iCryptoTransform = rijndael.CreateEncryptor(byteKey, byteVector);

                    memoryStream = new MemoryStream();

                    cryptoStream = new CryptoStream(memoryStream, iCryptoTransform, CryptoStreamMode.Write);
                    cryptoStream.Write(textByte, 0, textByte.Length);
                    cryptoStream.FlushFinalBlock();
                    cryptoStream.Close();
                    memoryStream.Close();

                    textByte = memoryStream.ToArray();

                    secret = Convert.ToBase64String(textByte);
                }
            } catch (Exception e) {
                secret = null;
            }

            return secret;
        }

        /// <summary>
        /// Transformar texto desconhecido descriptografável para texto comum
        /// </summary>
        /// <returns></returns>
        public string Decrypt(string password, string key, string vector)
        {
            string secret = null;

            try {
                if (password != null) {
                    byte[] byteVector = null;
                    byte[] textByte = null;
                    byte[] byteKey = null;

                    MemoryStream memoryStream = null;
                    CryptoStream cryptoStream = null;
                    ICryptoTransform iCryptoTransform = null;
                    Rijndael rijndael = null;

                    byteKey = ASCIIEncoding.ASCII.GetBytes(key);
                    byteVector = ASCIIEncoding.ASCII.GetBytes(vector);

                    rijndael = new RijndaelManaged();
                    rijndael.KeySize = 256;
                    rijndael.Key = byteKey;
                    rijndael.IV = byteVector;
                    rijndael.BlockSize = 128;
                    rijndael.Padding = PaddingMode.PKCS7;

                    iCryptoTransform = rijndael.CreateDecryptor(byteKey, byteVector);

                    memoryStream = new MemoryStream();

                    textByte = Convert.FromBase64String(password);

                    cryptoStream = new CryptoStream(memoryStream, iCryptoTransform, CryptoStreamMode.Write);
                    cryptoStream.Write(textByte, 0, textByte.Length);
                    cryptoStream.FlushFinalBlock();
                    cryptoStream.Close();
                    memoryStream.Close();

                    textByte = memoryStream.ToArray();

                    secret = ASCIIEncoding.ASCII.GetString(textByte);
                }
            } catch (Exception e) {
                secret = null;
            }

            return secret;
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido descriptografável
        /// </summary>
        /// <returns></returns>
        public string Encrypt(string password)
        {
            return Encrypt(password, conKey, conVector);
        }

        /// <summary>
        /// Transformar texto desconhecido descriptografável para texto comum
        /// </summary>
        /// <returns></returns>
        public string Decrypt(string password)
        {
            return Decrypt(password, conKey, conVector);
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido descriptografável
        /// </summary>
        /// <returns></returns>
        public string Encrypt(string password, string key)
        {
            return Encrypt(password, key, conVector);
        }

        /// <summary>
        /// Transformar texto desconhecido descriptografável para texto comum
        /// </summary>
        /// <returns></returns>
        public string Decrypt(string password, string key)
        {
            return Decrypt(password, key, conVector);
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido não descriptografável / Hash / MD5
        /// </summary>
        /// <returns></returns>
        public string CryptlockMD5(string password)
        {
            string secret = null;

            try {
                if (!String.IsNullOrEmpty(password)) {
                    secret = password;

                    byte[] textByte = null;
                    byte[] textoHash = null;

                    StringBuilder sb = null;
                    MD5 md5 = null;

                    md5 = MD5.Create();

                    textByte = ASCIIEncoding.ASCII.GetBytes(secret);

                    textoHash = md5.ComputeHash(textByte);

                    sb = new StringBuilder();

                    for (int i = 0; i < textoHash.Length; i++)
                    {
                        sb.Append(textoHash[i].ToString("X2"));
                    }

                    secret = sb.ToString();
                }
            } catch (Exception e) {
                secret = null;
            }

            return secret;
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido não descriptografável / Hash / SHA1
        /// </summary>
        /// <returns></returns>
        public string CryptlockSHA1(string password)
        {
            string secret = null;

            try {
                if (!String.IsNullOrEmpty(password)) {
                    byte[] textByte = null;
                    byte[] textHash = null;

                    StringBuilder sb = null;
                    SHA1Managed sha1 = null;

                    sha1 = new SHA1Managed();

                    textByte = ASCIIEncoding.ASCII.GetBytes(password);

                    textHash = sha1.ComputeHash(textByte);

                    sb = new StringBuilder();

                    for (int i = 0; i < textHash.Length; i++)
                    {
                        sb.Append(textHash[i].ToString("X2"));
                    }

                    secret = sb.ToString();
                }
            } catch (Exception e) {
                secret = null;
            }

            return secret;
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido não descriptografável / Hash / SHA256
        /// </summary>
        /// <returns></returns>
        public string CryptlockSHA256(string password)
        {
            string secret = null;

            try {
                if (!String.IsNullOrEmpty(password)) {
                    byte[] textByte = null;
                    byte[] textHash = null;

                    StringBuilder sb = null;
                    SHA256Managed sha256 = null;

                    sha256 = new SHA256Managed();

                    textByte = ASCIIEncoding.ASCII.GetBytes(password);

                    textHash = sha256.ComputeHash(textByte);

                    sb = new StringBuilder();

                    for (int i = 0; i < textHash.Length; i++) {
                        sb.Append(textHash[i].ToString("X2"));
                    }

                    secret = sb.ToString();
                }
            } catch (Exception e) {
                secret = null;
            }

            return secret;
        }

        /// <summary>
        /// Transformar texto comum para texto desconhecido não descriptografável / Hash / SHA512
        /// </summary>
        /// <returns></returns>
        public string CryptlockSHA512(string password)
        {
            string secret = null;

            try {
                if (!String.IsNullOrEmpty(password)) {
                    byte[] textByte = null;
                    byte[] textHash = null;

                    StringBuilder sb = null;
                    SHA512Managed sha512 = null;

                    sha512 = new SHA512Managed();

                    textByte = ASCIIEncoding.ASCII.GetBytes(password);

                    textHash = sha512.ComputeHash(textByte);

                    sb = new StringBuilder();

                    for (int i = 0; i < textHash.Length; i++)
                    {
                        sb.Append(textHash[i].ToString("X2"));
                    }

                    secret = sb.ToString();
                }
            } catch (Exception e) {
                secret = null;
            }

            return secret;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
