namespace WinFormsApp1
{
    partial class LoginForm
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
            loginbox = new TextBox();
            passbox = new TextBox();
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginbox
            // 
            loginbox.Location = new Point(234, 105);
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(109, 23);
            loginbox.TabIndex = 0;
            // 
            // passbox
            // 
            passbox.Location = new Point(234, 152);
            passbox.Name = "passbox";
            passbox.Size = new Size(109, 23);
            passbox.TabIndex = 1;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(234, 181);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(109, 33);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Войти";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 81);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(255, 128);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Controls.Add(passbox);
            Controls.Add(loginbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginbox;
        private TextBox passbox;
        private Button loginbtn;
        private Label label1;
        private Label label2;
    }
}