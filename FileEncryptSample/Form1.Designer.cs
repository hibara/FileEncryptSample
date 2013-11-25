namespace FileEncryptSample
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
			this.cmdExit = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cmdEncrypt = new System.Windows.Forms.Button();
			this.cmdDecrypt = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdExit
			// 
			this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdExit.Location = new System.Drawing.Point(252, 255);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(75, 23);
			this.cmdExit.TabIndex = 1;
			this.cmdExit.Text = "E&xit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(12, 29);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(315, 167);
			this.textBox1.TabIndex = 2;
			// 
			// cmdEncrypt
			// 
			this.cmdEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdEncrypt.Location = new System.Drawing.Point(13, 255);
			this.cmdEncrypt.Name = "cmdEncrypt";
			this.cmdEncrypt.Size = new System.Drawing.Size(75, 23);
			this.cmdEncrypt.TabIndex = 3;
			this.cmdEncrypt.Text = "&Encrypt";
			this.cmdEncrypt.UseVisualStyleBackColor = true;
			this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
			// 
			// cmdDecrypt
			// 
			this.cmdDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdDecrypt.Location = new System.Drawing.Point(94, 255);
			this.cmdDecrypt.Name = "cmdDecrypt";
			this.cmdDecrypt.Size = new System.Drawing.Size(75, 23);
			this.cmdDecrypt.TabIndex = 4;
			this.cmdDecrypt.Text = "&Decrypt";
			this.cmdDecrypt.UseVisualStyleBackColor = true;
			this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(13, 226);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(314, 19);
			this.textBox2.TabIndex = 5;
			this.textBox2.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 208);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "File List:";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdExit;
			this.ClientSize = new System.Drawing.Size(339, 290);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.cmdDecrypt);
			this.Controls.Add(this.cmdEncrypt);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cmdExit);
			this.Name = "Form1";
			this.Text = "File Encryptor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button cmdEncrypt;
		private System.Windows.Forms.Button cmdDecrypt;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

