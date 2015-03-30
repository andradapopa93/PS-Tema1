namespace Tema1.UI
{
    partial class FormDeleteAccount
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
            this.textBoxDeleteName = new System.Windows.Forms.TextBox();
            this.textBoxDeleteUsername = new System.Windows.Forms.TextBox();
            this.buttonDeleteOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(28, 34);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(217, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Introduceti datele contului care se va sterge:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nume:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(26, 126);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxDeleteName
            // 
            this.textBoxDeleteName.Location = new System.Drawing.Point(124, 88);
            this.textBoxDeleteName.Name = "textBoxDeleteName";
            this.textBoxDeleteName.Size = new System.Drawing.Size(121, 20);
            this.textBoxDeleteName.TabIndex = 3;
            // 
            // textBoxDeleteUsername
            // 
            this.textBoxDeleteUsername.Location = new System.Drawing.Point(124, 126);
            this.textBoxDeleteUsername.Name = "textBoxDeleteUsername";
            this.textBoxDeleteUsername.Size = new System.Drawing.Size(121, 20);
            this.textBoxDeleteUsername.TabIndex = 4;
            // 
            // buttonDeleteOK
            // 
            this.buttonDeleteOK.Location = new System.Drawing.Point(92, 177);
            this.buttonDeleteOK.Name = "buttonDeleteOK";
            this.buttonDeleteOK.Size = new System.Drawing.Size(86, 25);
            this.buttonDeleteOK.TabIndex = 5;
            this.buttonDeleteOK.Text = "OK";
            this.buttonDeleteOK.UseVisualStyleBackColor = true;
            this.buttonDeleteOK.Click += new System.EventHandler(this.buttonDeleteOK_Click);
            // 
            // FormDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 228);
            this.Controls.Add(this.buttonDeleteOK);
            this.Controls.Add(this.textBoxDeleteUsername);
            this.Controls.Add(this.textBoxDeleteName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormDeleteAccount";
            this.Text = "Stergere Cont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxDeleteName;
        private System.Windows.Forms.TextBox textBoxDeleteUsername;
        private System.Windows.Forms.Button buttonDeleteOK;
    }
}