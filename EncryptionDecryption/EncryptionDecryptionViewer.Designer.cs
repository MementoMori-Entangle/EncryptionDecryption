namespace EncryptDecrypt
{
    partial class EncryptionDecryptionViewer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.AESIVLabel = new System.Windows.Forms.Label();
            this.AESKeyLabel = new System.Windows.Forms.Label();
            this.AESKeySizeLabel = new System.Windows.Forms.Label();
            this.AESBlockSizeLabel = new System.Windows.Forms.Label();
            this.AESIVTextBox = new System.Windows.Forms.TextBox();
            this.AESKeyTextBox = new System.Windows.Forms.TextBox();
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.OutPutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.DecryptionButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.RSARadioButton = new System.Windows.Forms.RadioButton();
            this.AESRadioButton = new System.Windows.Forms.RadioButton();
            this.AESKeySizeComboBox = new System.Windows.Forms.ComboBox();
            this.AESBlockSizeComboBox = new System.Windows.Forms.ComboBox();
            this.PublicKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PublicKeyLabel = new System.Windows.Forms.Label();
            this.PrivateKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.RSAKeySizeLabel = new System.Windows.Forms.Label();
            this.RSAKeySizeComboBox = new System.Windows.Forms.ComboBox();
            this.AESModeLabel = new System.Windows.Forms.Label();
            this.AESModeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AESIVLabel
            // 
            this.AESIVLabel.AutoSize = true;
            this.AESIVLabel.Location = new System.Drawing.Point(12, 9);
            this.AESIVLabel.Name = "AESIVLabel";
            this.AESIVLabel.Size = new System.Drawing.Size(42, 12);
            this.AESIVLabel.TabIndex = 0;
            this.AESIVLabel.Text = "AES IV";
            // 
            // AESKeyLabel
            // 
            this.AESKeyLabel.AutoSize = true;
            this.AESKeyLabel.Location = new System.Drawing.Point(12, 35);
            this.AESKeyLabel.Name = "AESKeyLabel";
            this.AESKeyLabel.Size = new System.Drawing.Size(50, 12);
            this.AESKeyLabel.TabIndex = 1;
            this.AESKeyLabel.Text = "AES Key";
            // 
            // AESKeySizeLabel
            // 
            this.AESKeySizeLabel.AutoSize = true;
            this.AESKeySizeLabel.Location = new System.Drawing.Point(12, 61);
            this.AESKeySizeLabel.Name = "AESKeySizeLabel";
            this.AESKeySizeLabel.Size = new System.Drawing.Size(75, 12);
            this.AESKeySizeLabel.TabIndex = 2;
            this.AESKeySizeLabel.Text = "AES Key Size";
            // 
            // AESBlockSizeLabel
            // 
            this.AESBlockSizeLabel.AutoSize = true;
            this.AESBlockSizeLabel.Location = new System.Drawing.Point(12, 86);
            this.AESBlockSizeLabel.Name = "AESBlockSizeLabel";
            this.AESBlockSizeLabel.Size = new System.Drawing.Size(85, 12);
            this.AESBlockSizeLabel.TabIndex = 3;
            this.AESBlockSizeLabel.Text = "AES Block Size";
            // 
            // AESIVTextBox
            // 
            this.AESIVTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AESIVTextBox.Location = new System.Drawing.Point(97, 6);
            this.AESIVTextBox.Name = "AESIVTextBox";
            this.AESIVTextBox.Size = new System.Drawing.Size(671, 19);
            this.AESIVTextBox.TabIndex = 4;
            // 
            // AESKeyTextBox
            // 
            this.AESKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AESKeyTextBox.Location = new System.Drawing.Point(97, 32);
            this.AESKeyTextBox.Name = "AESKeyTextBox";
            this.AESKeyTextBox.Size = new System.Drawing.Size(671, 19);
            this.AESKeyTextBox.TabIndex = 5;
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Location = new System.Drawing.Point(14, 137);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.Size = new System.Drawing.Size(373, 101);
            this.InputRichTextBox.TabIndex = 8;
            this.InputRichTextBox.Text = "";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 122);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(30, 12);
            this.InputLabel.TabIndex = 9;
            this.InputLabel.Text = "Input";
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.AutoSize = true;
            this.OutPutLabel.Location = new System.Drawing.Point(12, 252);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(40, 12);
            this.OutPutLabel.TabIndex = 10;
            this.OutPutLabel.Text = "OutPut";
            // 
            // OutPutRichTextBox
            // 
            this.OutPutRichTextBox.Location = new System.Drawing.Point(14, 267);
            this.OutPutRichTextBox.Name = "OutPutRichTextBox";
            this.OutPutRichTextBox.Size = new System.Drawing.Size(373, 182);
            this.OutPutRichTextBox.TabIndex = 11;
            this.OutPutRichTextBox.Text = "";
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Location = new System.Drawing.Point(233, 111);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptionButton.TabIndex = 12;
            this.EncryptionButton.Text = "Encryption";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // DecryptionButton
            // 
            this.DecryptionButton.Location = new System.Drawing.Point(312, 111);
            this.DecryptionButton.Name = "DecryptionButton";
            this.DecryptionButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptionButton.TabIndex = 13;
            this.DecryptionButton.Text = "Decryption";
            this.DecryptionButton.UseVisualStyleBackColor = true;
            this.DecryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(178, 111);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(49, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.RSARadioButton);
            this.TypeGroupBox.Controls.Add(this.AESRadioButton);
            this.TypeGroupBox.Location = new System.Drawing.Point(343, 62);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(109, 43);
            this.TypeGroupBox.TabIndex = 15;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Type";
            // 
            // RSARadioButton
            // 
            this.RSARadioButton.AutoSize = true;
            this.RSARadioButton.Checked = true;
            this.RSARadioButton.Location = new System.Drawing.Point(57, 18);
            this.RSARadioButton.Name = "RSARadioButton";
            this.RSARadioButton.Size = new System.Drawing.Size(46, 16);
            this.RSARadioButton.TabIndex = 16;
            this.RSARadioButton.TabStop = true;
            this.RSARadioButton.Text = "RSA";
            this.RSARadioButton.UseVisualStyleBackColor = true;
            // 
            // AESRadioButton
            // 
            this.AESRadioButton.AutoSize = true;
            this.AESRadioButton.Location = new System.Drawing.Point(6, 18);
            this.AESRadioButton.Name = "AESRadioButton";
            this.AESRadioButton.Size = new System.Drawing.Size(45, 16);
            this.AESRadioButton.TabIndex = 0;
            this.AESRadioButton.TabStop = true;
            this.AESRadioButton.Text = "AES";
            this.AESRadioButton.UseVisualStyleBackColor = true;
            // 
            // AESKeySizeComboBox
            // 
            this.AESKeySizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AESKeySizeComboBox.FormattingEnabled = true;
            this.AESKeySizeComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.AESKeySizeComboBox.Location = new System.Drawing.Point(97, 57);
            this.AESKeySizeComboBox.Name = "AESKeySizeComboBox";
            this.AESKeySizeComboBox.Size = new System.Drawing.Size(68, 20);
            this.AESKeySizeComboBox.TabIndex = 16;
            // 
            // AESBlockSizeComboBox
            // 
            this.AESBlockSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AESBlockSizeComboBox.FormattingEnabled = true;
            this.AESBlockSizeComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.AESBlockSizeComboBox.Location = new System.Drawing.Point(97, 83);
            this.AESBlockSizeComboBox.Name = "AESBlockSizeComboBox";
            this.AESBlockSizeComboBox.Size = new System.Drawing.Size(68, 20);
            this.AESBlockSizeComboBox.TabIndex = 17;
            // 
            // PublicKeyRichTextBox
            // 
            this.PublicKeyRichTextBox.Location = new System.Drawing.Point(393, 137);
            this.PublicKeyRichTextBox.Name = "PublicKeyRichTextBox";
            this.PublicKeyRichTextBox.Size = new System.Drawing.Size(375, 101);
            this.PublicKeyRichTextBox.TabIndex = 18;
            this.PublicKeyRichTextBox.Text = "";
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Location = new System.Drawing.Point(393, 122);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(59, 12);
            this.PublicKeyLabel.TabIndex = 19;
            this.PublicKeyLabel.Text = "Public Key";
            // 
            // PrivateKeyRichTextBox
            // 
            this.PrivateKeyRichTextBox.Location = new System.Drawing.Point(393, 267);
            this.PrivateKeyRichTextBox.Name = "PrivateKeyRichTextBox";
            this.PrivateKeyRichTextBox.Size = new System.Drawing.Size(375, 182);
            this.PrivateKeyRichTextBox.TabIndex = 20;
            this.PrivateKeyRichTextBox.Text = "";
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Location = new System.Drawing.Point(393, 252);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(64, 12);
            this.PrivateKeyLabel.TabIndex = 21;
            this.PrivateKeyLabel.Text = "Private Key";
            // 
            // RSAKeySizeLabel
            // 
            this.RSAKeySizeLabel.AutoSize = true;
            this.RSAKeySizeLabel.Location = new System.Drawing.Point(477, 62);
            this.RSAKeySizeLabel.Name = "RSAKeySizeLabel";
            this.RSAKeySizeLabel.Size = new System.Drawing.Size(76, 12);
            this.RSAKeySizeLabel.TabIndex = 22;
            this.RSAKeySizeLabel.Text = "RSA Key Size";
            // 
            // RSAKeySizeComboBox
            // 
            this.RSAKeySizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RSAKeySizeComboBox.FormattingEnabled = true;
            this.RSAKeySizeComboBox.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.RSAKeySizeComboBox.Location = new System.Drawing.Point(559, 59);
            this.RSAKeySizeComboBox.Name = "RSAKeySizeComboBox";
            this.RSAKeySizeComboBox.Size = new System.Drawing.Size(68, 20);
            this.RSAKeySizeComboBox.TabIndex = 23;
            // 
            // AESModeLabel
            // 
            this.AESModeLabel.AutoSize = true;
            this.AESModeLabel.Location = new System.Drawing.Point(176, 61);
            this.AESModeLabel.Name = "AESModeLabel";
            this.AESModeLabel.Size = new System.Drawing.Size(58, 12);
            this.AESModeLabel.TabIndex = 24;
            this.AESModeLabel.Text = "AES Mode";
            // 
            // AESModeComboBox
            // 
            this.AESModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AESModeComboBox.FormattingEnabled = true;
            this.AESModeComboBox.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.AESModeComboBox.Location = new System.Drawing.Point(240, 57);
            this.AESModeComboBox.Name = "AESModeComboBox";
            this.AESModeComboBox.Size = new System.Drawing.Size(68, 20);
            this.AESModeComboBox.TabIndex = 25;
            // 
            // EncryptionDecryptionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.AESModeComboBox);
            this.Controls.Add(this.AESModeLabel);
            this.Controls.Add(this.RSAKeySizeComboBox);
            this.Controls.Add(this.RSAKeySizeLabel);
            this.Controls.Add(this.PrivateKeyLabel);
            this.Controls.Add(this.PrivateKeyRichTextBox);
            this.Controls.Add(this.PublicKeyLabel);
            this.Controls.Add(this.PublicKeyRichTextBox);
            this.Controls.Add(this.AESBlockSizeComboBox);
            this.Controls.Add(this.AESKeySizeComboBox);
            this.Controls.Add(this.TypeGroupBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DecryptionButton);
            this.Controls.Add(this.EncryptionButton);
            this.Controls.Add(this.OutPutRichTextBox);
            this.Controls.Add(this.OutPutLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputRichTextBox);
            this.Controls.Add(this.AESKeyTextBox);
            this.Controls.Add(this.AESIVTextBox);
            this.Controls.Add(this.AESBlockSizeLabel);
            this.Controls.Add(this.AESKeySizeLabel);
            this.Controls.Add(this.AESKeyLabel);
            this.Controls.Add(this.AESIVLabel);
            this.Name = "EncryptionDecryptionViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptionDecryptionViewer";
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AESIVLabel;
        private System.Windows.Forms.Label AESKeyLabel;
        private System.Windows.Forms.Label AESKeySizeLabel;
        private System.Windows.Forms.Label AESBlockSizeLabel;
        private System.Windows.Forms.TextBox AESIVTextBox;
        private System.Windows.Forms.TextBox AESKeyTextBox;
        private System.Windows.Forms.RichTextBox InputRichTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutPutLabel;
        private System.Windows.Forms.RichTextBox OutPutRichTextBox;
        private System.Windows.Forms.Button EncryptionButton;
        private System.Windows.Forms.Button DecryptionButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.RadioButton AESRadioButton;
        private System.Windows.Forms.RadioButton RSARadioButton;
        private System.Windows.Forms.ComboBox AESKeySizeComboBox;
        private System.Windows.Forms.ComboBox AESBlockSizeComboBox;
        private System.Windows.Forms.RichTextBox PublicKeyRichTextBox;
        private System.Windows.Forms.Label PublicKeyLabel;
        private System.Windows.Forms.RichTextBox PrivateKeyRichTextBox;
        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.Label RSAKeySizeLabel;
        private System.Windows.Forms.ComboBox RSAKeySizeComboBox;
        private System.Windows.Forms.Label AESModeLabel;
        private System.Windows.Forms.ComboBox AESModeComboBox;
    }
}

