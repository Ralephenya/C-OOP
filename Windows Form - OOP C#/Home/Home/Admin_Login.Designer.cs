
namespace Home
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.A_Username = new System.Windows.Forms.TextBox();
            this.A_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.A_HOME = new System.Windows.Forms.Label();
            this.hidepassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hidepassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // A_Username
            // 
            this.A_Username.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A_Username.Location = new System.Drawing.Point(282, 125);
            this.A_Username.Multiline = true;
            this.A_Username.Name = "A_Username";
            this.A_Username.Size = new System.Drawing.Size(236, 35);
            this.A_Username.TabIndex = 1;
            // 
            // A_Password
            // 
            this.A_Password.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A_Password.Location = new System.Drawing.Point(282, 236);
            this.A_Password.Multiline = true;
            this.A_Password.Name = "A_Password";
            this.A_Password.PasswordChar = '*';
            this.A_Password.Size = new System.Drawing.Size(236, 35);
            this.A_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(358, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(358, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLogin);
            // 
            // A_HOME
            // 
            this.A_HOME.AutoSize = true;
            this.A_HOME.BackColor = System.Drawing.Color.Transparent;
            this.A_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A_HOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.A_HOME.Location = new System.Drawing.Point(21, 9);
            this.A_HOME.Name = "A_HOME";
            this.A_HOME.Size = new System.Drawing.Size(92, 29);
            this.A_HOME.TabIndex = 5;
            this.A_HOME.Text = "HOME";
            this.A_HOME.Click += new System.EventHandler(this.A_HOME_Click);
            // 
            // hidepassword
            // 
            this.hidepassword.BackColor = System.Drawing.Color.Transparent;
            this.hidepassword.BackgroundImage = global::Home.Properties.Resources.hide;
            this.hidepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hidepassword.Location = new System.Drawing.Point(536, 236);
            this.hidepassword.Name = "hidepassword";
            this.hidepassword.Size = new System.Drawing.Size(59, 35);
            this.hidepassword.TabIndex = 6;
            this.hidepassword.TabStop = false;
            this.hidepassword.Tag = "hide";
            this.hidepassword.Click += new System.EventHandler(this.hidepassword_Click);
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 430);
            this.Controls.Add(this.hidepassword);
            this.Controls.Add(this.A_HOME);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.A_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A_Username);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Admin_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hidepassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox A_Username;
        private System.Windows.Forms.TextBox A_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label A_HOME;
        private System.Windows.Forms.PictureBox hidepassword;
    }
}