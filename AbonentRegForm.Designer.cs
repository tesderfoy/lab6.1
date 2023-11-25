namespace lab6._1
{
    partial class AbonentRegForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.registration = new System.Windows.Forms.Button();
            this.passwordTwoBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.midlleNameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Повторите пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(156, 130);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(159, 22);
            this.loginBox.TabIndex = 19;
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.SkyBlue;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registration.Location = new System.Drawing.Point(270, 328);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(212, 41);
            this.registration.TabIndex = 18;
            this.registration.Text = "Зарегистрироваться";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // passwordTwoBox
            // 
            this.passwordTwoBox.Location = new System.Drawing.Point(156, 231);
            this.passwordTwoBox.Name = "passwordTwoBox";
            this.passwordTwoBox.Size = new System.Drawing.Size(159, 22);
            this.passwordTwoBox.TabIndex = 17;
            this.passwordTwoBox.UseSystemPasswordChar = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(156, 203);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(159, 22);
            this.passwordBox.TabIndex = 16;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // midlleNameBox
            // 
            this.midlleNameBox.Location = new System.Drawing.Point(156, 96);
            this.midlleNameBox.Name = "midlleNameBox";
            this.midlleNameBox.Size = new System.Drawing.Size(159, 22);
            this.midlleNameBox.TabIndex = 15;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(156, 65);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(159, 22);
            this.nameBox.TabIndex = 14;
            // 
            // AbonentRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.passwordTwoBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.midlleNameBox);
            this.Controls.Add(this.nameBox);
            this.Name = "AbonentRegForm";
            this.Text = "AbonentRegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.TextBox passwordTwoBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox midlleNameBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}