namespace Tema1.UI
{
    partial class FormSearchAnnouncement
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.buttonSearchOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(24, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Introduceti titlul anuntului pe care il cautati:";
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(27, 73);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(144, 20);
            this.textBoxSearchTitle.TabIndex = 1;
            // 
            // buttonSearchOK
            // 
            this.buttonSearchOK.Location = new System.Drawing.Point(85, 121);
            this.buttonSearchOK.Name = "buttonSearchOK";
            this.buttonSearchOK.Size = new System.Drawing.Size(97, 28);
            this.buttonSearchOK.TabIndex = 2;
            this.buttonSearchOK.Text = "Cauta";
            this.buttonSearchOK.UseVisualStyleBackColor = true;
            this.buttonSearchOK.Click += new System.EventHandler(this.buttonSearchOK_Click);
            // 
            // FormSearchAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.buttonSearchOK);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormSearchAnnouncement";
            this.Text = "Cautare anunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Button buttonSearchOK;
    }
}