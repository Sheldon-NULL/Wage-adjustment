
namespace Wage_adjustment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.forget = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(256, 131);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(52, 15);
            this.user.TabIndex = 0;
            this.user.Text = "账号：";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(256, 206);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 15);
            this.password.TabIndex = 1;
            this.password.Text = "密码：";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(343, 206);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(243, 25);
            this.t2.TabIndex = 2;
            this.t2.UseSystemPasswordChar = true;
            this.t2.TextChanged += new System.EventHandler(this.t2_TextChanged);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(343, 131);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(243, 25);
            this.t1.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(470, 310);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 32);
            this.login.TabIndex = 4;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // forget
            // 
            this.forget.Location = new System.Drawing.Point(279, 310);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(93, 32);
            this.forget.TabIndex = 3;
            this.forget.Text = "忘记密码";
            this.forget.UseVisualStyleBackColor = true;
            this.forget.Click += new System.EventHandler(this.forget_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(343, 258);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(155, 33);
            this.reset.TabIndex = 5;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.forget);
            this.Controls.Add(this.login);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Name = "Form1";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button forget;
        private System.Windows.Forms.Button reset;
    }
}

