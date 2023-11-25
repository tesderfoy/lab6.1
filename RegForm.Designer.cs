namespace lab6._1
{
    partial class RegForm
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
            this.components = new System.ComponentModel.Container();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.midlleNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordTwoBox = new System.Windows.Forms.TextBox();
            this.registration = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regautDataSet = new lab6._1.regautDataSet();
            this.userTableAdapter = new lab6._1.regautDataSetTableAdapters.userTableAdapter();
            this.postItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regautDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(157, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(159, 22);
            this.nameBox.TabIndex = 0;
            // 
            // midlleNameBox
            // 
            this.midlleNameBox.Location = new System.Drawing.Point(157, 99);
            this.midlleNameBox.Name = "midlleNameBox";
            this.midlleNameBox.Size = new System.Drawing.Size(159, 22);
            this.midlleNameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(157, 206);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(159, 22);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordTwoBox
            // 
            this.passwordTwoBox.Location = new System.Drawing.Point(157, 234);
            this.passwordTwoBox.Name = "passwordTwoBox";
            this.passwordTwoBox.Size = new System.Drawing.Size(159, 22);
            this.passwordTwoBox.TabIndex = 4;
            this.passwordTwoBox.UseSystemPasswordChar = true;
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.SkyBlue;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registration.Location = new System.Drawing.Point(271, 331);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(212, 41);
            this.registration.TabIndex = 5;
            this.registration.Text = "Зарегистрироваться";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(157, 155);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(159, 22);
            this.loginBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Повторите пароль";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.regautDataSet;
            // 
            // regautDataSet
            // 
            this.regautDataSet.DataSetName = "regautDataSet";
            this.regautDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // postItem
            // 
            this.postItem.FormattingEnabled = true;
            this.postItem.Items.AddRange(new object[] {
            "Администратор",
            "Оператор",
            "Абонент"});
            this.postItem.Location = new System.Drawing.Point(157, 127);
            this.postItem.Name = "postItem";
            this.postItem.Size = new System.Drawing.Size(159, 24);
            this.postItem.TabIndex = 13;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.passwordTwoBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.midlleNameBox);
            this.Controls.Add(this.nameBox);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regautDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox midlleNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox passwordTwoBox;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private regautDataSet regautDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private regautDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.ComboBox postItem;
    }
}