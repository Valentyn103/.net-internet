namespace VkApi
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
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.GetAccessToken = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FillNickname = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Like = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(12, 114);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(566, 57);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // GetAccessToken
            // 
            this.GetAccessToken.Location = new System.Drawing.Point(12, 12);
            this.GetAccessToken.Name = "GetAccessToken";
            this.GetAccessToken.Size = new System.Drawing.Size(559, 25);
            this.GetAccessToken.TabIndex = 1;
            this.GetAccessToken.Text = "GetAccessToken";
            this.GetAccessToken.UseVisualStyleBackColor = true;
            this.GetAccessToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(566, 186);
            this.listBox1.TabIndex = 3;
            // 
            // FillNickname
            // 
            this.FillNickname.Location = new System.Drawing.Point(301, 43);
            this.FillNickname.Name = "FillNickname";
            this.FillNickname.Size = new System.Drawing.Size(270, 25);
            this.FillNickname.TabIndex = 4;
            this.FillNickname.Text = "getFollowers";
            this.FillNickname.UseVisualStyleBackColor = true;
            this.FillNickname.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "friends.get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Friends :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Followers :";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 421);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(566, 186);
            this.listBox2.TabIndex = 8;
            // 
            // Like
            // 
            this.Like.Location = new System.Drawing.Point(189, 75);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(197, 23);
            this.Like.TabIndex = 9;
            this.Like.Text = "Like";
            this.Like.UseVisualStyleBackColor = true;
            this.Like.Click += new System.EventHandler(this.Like_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 628);
            this.Controls.Add(this.Like);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FillNickname);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GetAccessToken);
            this.Controls.Add(this.WebBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Button GetAccessToken;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button FillNickname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Like;
    }
}

