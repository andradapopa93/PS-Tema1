namespace Tema1.UI
{
    partial class FormUpdateAccount
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelDates = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewRole = new System.Windows.Forms.TextBox();
            this.buttonUpdateOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(29, 35);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(187, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Introduceti contul care va fi actualizat:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(32, 65);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(142, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelDates
            // 
            this.labelDates.AutoSize = true;
            this.labelDates.Location = new System.Drawing.Point(29, 128);
            this.labelDates.Name = "labelDates";
            this.labelDates.Size = new System.Drawing.Size(241, 13);
            this.labelDates.TabIndex = 2;
            this.labelDates.Text = "Introduceti datele care urmeaza sa fie actualizate:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 169);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nume:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(96, 166);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(148, 20);
            this.textBoxNewName.TabIndex = 4;
            this.textBoxNewName.TextChanged += new System.EventHandler(this.textBoxNewName_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(29, 209);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(40, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Parola:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(96, 206);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(148, 20);
            this.textBoxNewPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rol:";
            // 
            // textBoxNewRole
            // 
            this.textBoxNewRole.Location = new System.Drawing.Point(96, 246);
            this.textBoxNewRole.Name = "textBoxNewRole";
            this.textBoxNewRole.Size = new System.Drawing.Size(148, 20);
            this.textBoxNewRole.TabIndex = 8;
            // 
            // buttonUpdateOK
            // 
            this.buttonUpdateOK.Location = new System.Drawing.Point(190, 297);
            this.buttonUpdateOK.Name = "buttonUpdateOK";
            this.buttonUpdateOK.Size = new System.Drawing.Size(103, 33);
            this.buttonUpdateOK.TabIndex = 9;
            this.buttonUpdateOK.Text = "Actualizeaza";
            this.buttonUpdateOK.UseVisualStyleBackColor = true;
            this.buttonUpdateOK.Click += new System.EventHandler(this.buttonUpdateOK_Click);
            // 
            // FormUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 356);
            this.Controls.Add(this.buttonUpdateOK);
            this.Controls.Add(this.textBoxNewRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDates);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormUpdateAccount";
            this.Text = "FormUpdateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelDates;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewRole;
        private System.Windows.Forms.Button buttonUpdateOK;
    }
}