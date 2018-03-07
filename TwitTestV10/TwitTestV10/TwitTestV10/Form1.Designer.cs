namespace TwitTestV10
{
    partial class Form1
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
            this.lstTweet = new System.Windows.Forms.ListBox();
            this.lstTweetId = new System.Windows.Forms.ListBox();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnMyTweet = new System.Windows.Forms.Button();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.btnTweetGonder = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnMention = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTweet
            // 
            this.lstTweet.FormattingEnabled = true;
            this.lstTweet.Location = new System.Drawing.Point(12, 11);
            this.lstTweet.Name = "lstTweet";
            this.lstTweet.Size = new System.Drawing.Size(258, 225);
            this.lstTweet.TabIndex = 0;
            this.lstTweet.SelectedIndexChanged += new System.EventHandler(this.lstTweet_SelectedIndexChanged);
            // 
            // lstTweetId
            // 
            this.lstTweetId.FormattingEnabled = true;
            this.lstTweetId.Location = new System.Drawing.Point(276, 11);
            this.lstTweetId.Name = "lstTweetId";
            this.lstTweetId.Size = new System.Drawing.Size(143, 225);
            this.lstTweetId.TabIndex = 1;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(425, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(187, 45);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "Ana Sayfa Tweetler";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnMyTweet
            // 
            this.btnMyTweet.Location = new System.Drawing.Point(425, 63);
            this.btnMyTweet.Name = "btnMyTweet";
            this.btnMyTweet.Size = new System.Drawing.Size(187, 45);
            this.btnMyTweet.TabIndex = 3;
            this.btnMyTweet.Text = "MyTweets";
            this.btnMyTweet.UseVisualStyleBackColor = true;
            this.btnMyTweet.Click += new System.EventHandler(this.btnMyTweet_Click);
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(425, 114);
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(187, 20);
            this.txtTweet.TabIndex = 4;
            // 
            // btnTweetGonder
            // 
            this.btnTweetGonder.Location = new System.Drawing.Point(425, 140);
            this.btnTweetGonder.Name = "btnTweetGonder";
            this.btnTweetGonder.Size = new System.Drawing.Size(187, 45);
            this.btnTweetGonder.TabIndex = 5;
            this.btnTweetGonder.Text = "Tweet Gonder";
            this.btnTweetGonder.UseVisualStyleBackColor = true;
            this.btnTweetGonder.Click += new System.EventHandler(this.btnTweetGonder_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(425, 191);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(187, 45);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnMention
            // 
            this.btnMention.Location = new System.Drawing.Point(12, 243);
            this.btnMention.Name = "btnMention";
            this.btnMention.Size = new System.Drawing.Size(292, 45);
            this.btnMention.TabIndex = 7;
            this.btnMention.Text = "Mention";
            this.btnMention.UseVisualStyleBackColor = true;
            this.btnMention.Click += new System.EventHandler(this.btnMention_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(530, 259);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "********";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnMention);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTweetGonder);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.btnMyTweet);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.lstTweetId);
            this.Controls.Add(this.lstTweet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTweet;
        private System.Windows.Forms.ListBox lstTweetId;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnMyTweet;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button btnTweetGonder;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnMention;
        private System.Windows.Forms.Label lblError;
    }
}

