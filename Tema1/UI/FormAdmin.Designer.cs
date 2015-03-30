namespace Tema1.DAL
{
    partial class FormAdmin
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonViewRaports = new System.Windows.Forms.Button();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.buttonReadAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(23, 25);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(104, 27);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Bine ati venit!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(50, 83);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(121, 28);
            this.buttonCreateAccount.TabIndex = 1;
            this.buttonCreateAccount.Text = "Adauga cont";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(50, 129);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(121, 28);
            this.buttonDeleteAccount.TabIndex = 2;
            this.buttonDeleteAccount.Text = "Sterge cont";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // buttonViewRaports
            // 
            this.buttonViewRaports.Location = new System.Drawing.Point(50, 276);
            this.buttonViewRaports.Name = "buttonViewRaports";
            this.buttonViewRaports.Size = new System.Drawing.Size(121, 29);
            this.buttonViewRaports.TabIndex = 3;
            this.buttonViewRaports.Text = "Vizualizeaza rapoarte";
            this.buttonViewRaports.UseVisualStyleBackColor = true;
            this.buttonViewRaports.Click += new System.EventHandler(this.buttonViewRaports_Click);
            // 
            // buttonUpdateAccount
            // 
            this.buttonUpdateAccount.Location = new System.Drawing.Point(50, 177);
            this.buttonUpdateAccount.Name = "buttonUpdateAccount";
            this.buttonUpdateAccount.Size = new System.Drawing.Size(121, 29);
            this.buttonUpdateAccount.TabIndex = 4;
            this.buttonUpdateAccount.Text = "Actualizeaza cont";
            this.buttonUpdateAccount.UseVisualStyleBackColor = true;
            this.buttonUpdateAccount.Click += new System.EventHandler(this.buttonUpdateAccount_Click);
            // 
            // buttonReadAccount
            // 
            this.buttonReadAccount.Location = new System.Drawing.Point(50, 228);
            this.buttonReadAccount.Name = "buttonReadAccount";
            this.buttonReadAccount.Size = new System.Drawing.Size(121, 27);
            this.buttonReadAccount.TabIndex = 5;
            this.buttonReadAccount.Text = "Cauta cont";
            this.buttonReadAccount.UseVisualStyleBackColor = true;
            this.buttonReadAccount.Click += new System.EventHandler(this.buttonReadAccount_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 344);
            this.Controls.Add(this.buttonReadAccount);
            this.Controls.Add(this.buttonUpdateAccount);
            this.Controls.Add(this.buttonViewRaports);
            this.Controls.Add(this.buttonDeleteAccount);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelWelcome);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Button buttonViewRaports;
        private System.Windows.Forms.Button buttonUpdateAccount;
        private System.Windows.Forms.Button buttonReadAccount;
    }
}