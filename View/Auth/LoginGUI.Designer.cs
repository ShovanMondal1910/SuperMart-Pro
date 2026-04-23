namespace SuperMart_Pro.View.Auth
{
    partial class LoginGUI
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
            ShowPasswordcheckBox = new CheckBox();
            UserNamelabel = new Label();
            UserNametextBox = new TextBox();
            LogingroupBox = new GroupBox();
            PasswordErrorlabel = new Label();
            UserNameErrorlabel = new Label();
            Cancelbutton = new Button();
            Loginbutton = new Button();
            Passwordlabel = new Label();
            PasswordtextBox = new TextBox();
            ForgetPasswordlabel = new Label();
            LogingroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ShowPasswordcheckBox
            // 
            ShowPasswordcheckBox.AutoSize = true;
            ShowPasswordcheckBox.Location = new Point(476, 171);
            ShowPasswordcheckBox.Name = "ShowPasswordcheckBox";
            ShowPasswordcheckBox.Size = new Size(72, 25);
            ShowPasswordcheckBox.TabIndex = 0;
            ShowPasswordcheckBox.Text = "Show";
            ShowPasswordcheckBox.UseVisualStyleBackColor = true;
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Location = new Point(99, 90);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(102, 21);
            UserNamelabel.TabIndex = 1;
            UserNamelabel.Text = "User Name :";
            // 
            // UserNametextBox
            // 
            UserNametextBox.Location = new Point(207, 87);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(254, 29);
            UserNametextBox.TabIndex = 2;
            // 
            // LogingroupBox
            // 
            LogingroupBox.Controls.Add(PasswordErrorlabel);
            LogingroupBox.Controls.Add(UserNameErrorlabel);
            LogingroupBox.Controls.Add(Cancelbutton);
            LogingroupBox.Controls.Add(Loginbutton);
            LogingroupBox.Controls.Add(Passwordlabel);
            LogingroupBox.Controls.Add(ShowPasswordcheckBox);
            LogingroupBox.Controls.Add(PasswordtextBox);
            LogingroupBox.Controls.Add(UserNamelabel);
            LogingroupBox.Controls.Add(UserNametextBox);
            LogingroupBox.Location = new Point(150, 102);
            LogingroupBox.Name = "LogingroupBox";
            LogingroupBox.Size = new Size(628, 338);
            LogingroupBox.TabIndex = 3;
            LogingroupBox.TabStop = false;
            LogingroupBox.Text = "Login by Username/UserID";
            // 
            // PasswordErrorlabel
            // 
            PasswordErrorlabel.AutoSize = true;
            PasswordErrorlabel.Location = new Point(207, 199);
            PasswordErrorlabel.Name = "PasswordErrorlabel";
            PasswordErrorlabel.Size = new Size(0, 21);
            PasswordErrorlabel.TabIndex = 8;
            // 
            // UserNameErrorlabel
            // 
            UserNameErrorlabel.AutoSize = true;
            UserNameErrorlabel.Location = new Point(207, 119);
            UserNameErrorlabel.Name = "UserNameErrorlabel";
            UserNameErrorlabel.Size = new Size(0, 21);
            UserNameErrorlabel.TabIndex = 7;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Location = new Point(335, 263);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(126, 39);
            Cancelbutton.TabIndex = 6;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = true;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.Location = new Point(192, 263);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(126, 39);
            Loginbutton.TabIndex = 5;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(99, 170);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(93, 21);
            Passwordlabel.TabIndex = 3;
            Passwordlabel.Text = "Password :";
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(207, 167);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.Size = new Size(254, 29);
            PasswordtextBox.TabIndex = 4;
            // 
            // ForgetPasswordlabel
            // 
            ForgetPasswordlabel.AutoSize = true;
            ForgetPasswordlabel.Location = new Point(746, 472);
            ForgetPasswordlabel.Name = "ForgetPasswordlabel";
            ForgetPasswordlabel.Size = new Size(146, 21);
            ForgetPasswordlabel.TabIndex = 4;
            ForgetPasswordlabel.Text = "Forget Password?";
            ForgetPasswordlabel.Click += ForgetPasswordlabel_Click;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 569);
            Controls.Add(ForgetPasswordlabel);
            Controls.Add(LogingroupBox);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginGUI";
            Text = "LoginGUI";
            LogingroupBox.ResumeLayout(false);
            LogingroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ShowPasswordcheckBox;
        private Label UserNamelabel;
        private TextBox UserNametextBox;
        private GroupBox LogingroupBox;
        private Label Passwordlabel;
        private TextBox PasswordtextBox;
        private Label PasswordErrorlabel;
        private Label UserNameErrorlabel;
        private Button Cancelbutton;
        private Button Loginbutton;
        private Label ForgetPasswordlabel;
    }
}