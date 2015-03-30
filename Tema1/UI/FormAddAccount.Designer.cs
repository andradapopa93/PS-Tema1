namespace Tema1.DAL
{
    partial class FormAddAccount
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddUsername = new System.Windows.Forms.TextBox();
            this.textBoxAddPassword = new System.Windows.Forms.TextBox();
            this.textBoxAddRole = new System.Windows.Forms.TextBox();
            this.buttonAddOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(30, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(225, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Introduceti datele necesare crearii noului cont:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nume:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(14, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(14, 138);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(40, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Parola:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(14, 172);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(81, 13);
            this.labelRole.TabIndex = 4;
            this.labelRole.Text = "Tip de utilizator:";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(129, 77);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(126, 20);
            this.textBoxAddName.TabIndex = 5;
            // 
            // textBoxAddUsername
            // 
            this.textBoxAddUsername.Location = new System.Drawing.Point(129, 103);
            this.textBoxAddUsername.Name = "textBoxAddUsername";
            this.textBoxAddUsername.Size = new System.Drawing.Size(126, 20);
            this.textBoxAddUsername.TabIndex = 6;
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.Location = new System.Drawing.Point(129, 135);
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.PasswordChar = '*';
            this.textBoxAddPassword.Size = new System.Drawing.Size(126, 20);
            this.textBoxAddPassword.TabIndex = 7;
            // 
            // textBoxAddRole
            // 
            this.textBoxAddRole.Location = new System.Drawing.Point(129, 169);
            this.textBoxAddRole.Name = "textBoxAddRole";
            this.textBoxAddRole.Size = new System.Drawing.Size(126, 20);
            this.textBoxAddRole.TabIndex = 8;
            // 
            // buttonAddOK
            // 
            this.buttonAddOK.Location = new System.Drawing.Point(88, 213);
            this.buttonAddOK.Name = "buttonAddOK";
            this.buttonAddOK.Size = new System.Drawing.Size(97, 26);
            this.buttonAddOK.TabIndex = 9;
            this.buttonAddOK.Text = "OK";
            this.buttonAddOK.UseVisualStyleBackColor = true;
            this.buttonAddOK.Click += new System.EventHandler(this.buttonAddOK_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonAddOK);
            this.Controls.Add(this.textBoxAddRole);
            this.Controls.Add(this.textBoxAddPassword);
            this.Controls.Add(this.textBoxAddUsername);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormAddAccount";
            this.Text = "Adauga Cont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddUsername;
        private System.Windows.Forms.TextBox textBoxAddPassword;
        private System.Windows.Forms.TextBox textBoxAddRole;
        private System.Windows.Forms.Button buttonAddOK;
    }
}