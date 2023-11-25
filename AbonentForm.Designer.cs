namespace lab6._1
{
    partial class AbonentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.toSend = new System.Windows.Forms.Button();
            this.textRequestBox = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.nameUser = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Абонент:";
            // 
            // toSend
            // 
            this.toSend.BackColor = System.Drawing.Color.SkyBlue;
            this.toSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toSend.Location = new System.Drawing.Point(616, 323);
            this.toSend.Name = "toSend";
            this.toSend.Size = new System.Drawing.Size(145, 39);
            this.toSend.TabIndex = 2;
            this.toSend.Text = "Отправить";
            this.toSend.UseVisualStyleBackColor = false;
            this.toSend.Click += new System.EventHandler(this.toSendButton_Click);
            // 
            // textRequestBox
            // 
            this.textRequestBox.Location = new System.Drawing.Point(12, 57);
            this.textRequestBox.Multiline = true;
            this.textRequestBox.Name = "textRequestBox";
            this.textRequestBox.Size = new System.Drawing.Size(565, 305);
            this.textRequestBox.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.SkyBlue;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Location = new System.Drawing.Point(12, 28);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // nameUser
            // 
            this.nameUser.AutoSize = true;
            this.nameUser.Location = new System.Drawing.Point(72, 9);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(44, 16);
            this.nameUser.TabIndex = 5;
            this.nameUser.Text = "label2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(616, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Новая";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(616, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Требует выезда";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(616, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 20);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Срочно";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // AbonentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.nameUser);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textRequestBox);
            this.Controls.Add(this.toSend);
            this.Controls.Add(this.label1);
            this.Name = "AbonentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbonentForm";
            this.Load += new System.EventHandler(this.AbonentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toSend;
        private System.Windows.Forms.TextBox textRequestBox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}