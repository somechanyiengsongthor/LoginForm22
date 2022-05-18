
namespace LoginForm2
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.text_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.buton_login = new System.Windows.Forms.Button();
            this.buton_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(230, 45);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(94, 25);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "UserName:";
            this.label_UserName.Click += new System.EventHandler(this.label_UserName_Click);
            // 
            // text_UserName
            // 
            this.text_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_UserName.Location = new System.Drawing.Point(340, 43);
            this.text_UserName.Name = "text_UserName";
            this.text_UserName.Size = new System.Drawing.Size(187, 26);
            this.text_UserName.TabIndex = 1;
            this.text_UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(230, 98);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(88, 25);
            this.label_Password.TabIndex = 0;
            this.label_Password.Text = "Password:";
            this.label_Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_Password
            // 
            this.text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Password.Location = new System.Drawing.Point(340, 98);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(187, 26);
            this.text_Password.TabIndex = 1;
            this.text_Password.TextChanged += new System.EventHandler(this.text_Password_TextChanged);
            // 
            // buton_login
            // 
            this.buton_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_login.Location = new System.Drawing.Point(340, 142);
            this.buton_login.Name = "buton_login";
            this.buton_login.Size = new System.Drawing.Size(75, 30);
            this.buton_login.TabIndex = 2;
            this.buton_login.Text = "login";
            this.buton_login.UseVisualStyleBackColor = true;
            this.buton_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // buton_cancel
            // 
            this.buton_cancel.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_cancel.Location = new System.Drawing.Point(452, 142);
            this.buton_cancel.Name = "buton_cancel";
            this.buton_cancel.Size = new System.Drawing.Size(75, 30);
            this.buton_cancel.TabIndex = 3;
            this.buton_cancel.Text = "cancel";
            this.buton_cancel.UseVisualStyleBackColor = true;
            this.buton_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm2.Properties.Resources.Screenshot__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buton_cancel);
            this.Controls.Add(this.buton_login);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.text_UserName);
            this.Controls.Add(this.label_UserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox text_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.Button buton_login;
        private System.Windows.Forms.Button buton_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

