using System;
using System.Windows.Forms;
using EncryptionDecryptionLib;
using System.Security.Cryptography;

namespace EncryptDecrypt
{
    /// <summary>
    /// 暗号・復号ビュア
    /// </summary>
    public partial class EncryptionDecryptionViewer : Form
    {
        /// <summary>
        /// 暗号・複合
        /// </summary>
        readonly EncryptionDecryption encryptionDecryption;

        /// <summary>
        /// コンストラクタ処理
        /// </summary>
        public EncryptionDecryptionViewer()
        {
            InitializeComponent();

            this.encryptionDecryption = new EncryptionDecryption();
        }

        /// <summary>
        /// クリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            AESIVTextBox.Text = String.Empty;
            AESKeyTextBox.Text = String.Empty;
            AESKeySizeComboBox.Text = String.Empty;
            AESBlockSizeComboBox.Text = String.Empty;
            RSAKeySizeComboBox.Text = String.Empty;
            InputRichTextBox.Text = String.Empty;
            OutPutRichTextBox.Text = String.Empty;
            PublicKeyRichTextBox.Text = String.Empty;
            PrivateKeyRichTextBox.Text = String.Empty;
            RSARadioButton.Checked = true;
        }

        /// <summary>
        /// 暗号ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RSARadioButton.Checked)
                {
                    this.SetDataRSA();

                    OutPutRichTextBox.Text = this.encryptionDecryption.Encryption(EncryptionDecryption.Type.RSA, InputRichTextBox.Text);

                    PublicKeyRichTextBox.Text = this.encryptionDecryption.PublicKey;
                    PrivateKeyRichTextBox.Text = this.encryptionDecryption.PrivateKey;
                }
                else if (AESRadioButton.Checked)
                {
                    this.SetDataAES();

                    OutPutRichTextBox.Text = this.encryptionDecryption.Encryption(EncryptionDecryption.Type.ASE, InputRichTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 復号ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RSARadioButton.Checked)
                {
                    this.SetDataRSA();

                    OutPutRichTextBox.Text = this.encryptionDecryption.Decrypt(EncryptionDecryption.Type.RSA, InputRichTextBox.Text);
                }
                else if (AESRadioButton.Checked)
                {
                    this.SetDataAES();

                    OutPutRichTextBox.Text = this.encryptionDecryption.Decrypt(EncryptionDecryption.Type.ASE, InputRichTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// AESデータ設定
        /// </summary>
        private void SetDataAES()
        {
            int size = EncryptionDecryption.ZERO;

            this.encryptionDecryption.IvAES = AESIVTextBox.Text;

            this.encryptionDecryption.KeyAES = AESKeyTextBox.Text;

            int.TryParse(AESKeySizeComboBox.Text, out size);

            this.encryptionDecryption.KeySizeAES = size;

            int.TryParse(AESBlockSizeComboBox.Text, out size);

            this.encryptionDecryption.BlockSizeAES = size;

            CipherMode mode;

            switch (AESModeComboBox.Text)
            {
                case EncryptionDecryption.AES_CBC:
                    mode = CipherMode.CBC;
                    break;
                case EncryptionDecryption.AES_ECB:
                    mode = CipherMode.ECB;
                    break;
                case EncryptionDecryption.AES_OFB:
                    mode = CipherMode.OFB;
                    break;
                case EncryptionDecryption.AES_CFB:
                    mode = CipherMode.CFB;
                    break;
                case EncryptionDecryption.AES_CTS:
                    mode = CipherMode.CTS;
                    break;
                default:
                    mode = CipherMode.CBC;
                    break;
            }

            this.encryptionDecryption.ModeAES = mode;
        }

        /// <summary>
        /// RSAデータ設定
        /// </summary>
        private void SetDataRSA()
        {
            int.TryParse(RSAKeySizeComboBox.Text, out int size);

            this.encryptionDecryption.KeySizeRSA = size;

            this.encryptionDecryption.PublicKey = PublicKeyRichTextBox.Text;
            this.encryptionDecryption.PrivateKey = PrivateKeyRichTextBox.Text;
        }
    }
}
