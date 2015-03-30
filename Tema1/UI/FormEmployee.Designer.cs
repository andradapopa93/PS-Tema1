namespace Tema1.UI
{
    partial class FormEmployee
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
            this.buttonAddAnnounce = new System.Windows.Forms.Button();
            this.buttonDeleteAnnounce = new System.Windows.Forms.Button();
            this.buttonUpdateAnnounce = new System.Windows.Forms.Button();
            this.buttonReadAnnounce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddAnnounce
            // 
            this.buttonAddAnnounce.Location = new System.Drawing.Point(44, 36);
            this.buttonAddAnnounce.Name = "buttonAddAnnounce";
            this.buttonAddAnnounce.Size = new System.Drawing.Size(157, 33);
            this.buttonAddAnnounce.TabIndex = 0;
            this.buttonAddAnnounce.Text = "Adauga anunt";
            this.buttonAddAnnounce.UseVisualStyleBackColor = true;
            this.buttonAddAnnounce.Click += new System.EventHandler(this.buttonAddAnnounce_Click);
            // 
            // buttonDeleteAnnounce
            // 
            this.buttonDeleteAnnounce.Location = new System.Drawing.Point(44, 93);
            this.buttonDeleteAnnounce.Name = "buttonDeleteAnnounce";
            this.buttonDeleteAnnounce.Size = new System.Drawing.Size(157, 34);
            this.buttonDeleteAnnounce.TabIndex = 1;
            this.buttonDeleteAnnounce.Text = "Sterge anunt";
            this.buttonDeleteAnnounce.UseVisualStyleBackColor = true;
            this.buttonDeleteAnnounce.Click += new System.EventHandler(this.buttonDeleteAnnounce_Click);
            // 
            // buttonUpdateAnnounce
            // 
            this.buttonUpdateAnnounce.Location = new System.Drawing.Point(44, 149);
            this.buttonUpdateAnnounce.Name = "buttonUpdateAnnounce";
            this.buttonUpdateAnnounce.Size = new System.Drawing.Size(157, 34);
            this.buttonUpdateAnnounce.TabIndex = 2;
            this.buttonUpdateAnnounce.Text = "Actualizare anunt";
            this.buttonUpdateAnnounce.UseVisualStyleBackColor = true;
            this.buttonUpdateAnnounce.Click += new System.EventHandler(this.buttonUpdateAnnounce_Click);
            // 
            // buttonReadAnnounce
            // 
            this.buttonReadAnnounce.Location = new System.Drawing.Point(44, 201);
            this.buttonReadAnnounce.Name = "buttonReadAnnounce";
            this.buttonReadAnnounce.Size = new System.Drawing.Size(157, 35);
            this.buttonReadAnnounce.TabIndex = 3;
            this.buttonReadAnnounce.Text = "Cauta anunt";
            this.buttonReadAnnounce.UseVisualStyleBackColor = true;
            this.buttonReadAnnounce.Click += new System.EventHandler(this.buttonReadAnnounce_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 260);
            this.Controls.Add(this.buttonReadAnnounce);
            this.Controls.Add(this.buttonUpdateAnnounce);
            this.Controls.Add(this.buttonDeleteAnnounce);
            this.Controls.Add(this.buttonAddAnnounce);
            this.Name = "FormEmployee";
            this.Text = "FormAngajat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAnnounce;
        private System.Windows.Forms.Button buttonDeleteAnnounce;
        private System.Windows.Forms.Button buttonUpdateAnnounce;
        private System.Windows.Forms.Button buttonReadAnnounce;
    }
}