namespace Tema1.UI
{
    partial class FormSearchEmployee
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSearchOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(30, 43);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(151, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Introduceti numele angajatului:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(33, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSearchOK
            // 
            this.buttonSearchOK.Location = new System.Drawing.Point(57, 136);
            this.buttonSearchOK.Name = "buttonSearchOK";
            this.buttonSearchOK.Size = new System.Drawing.Size(86, 29);
            this.buttonSearchOK.TabIndex = 2;
            this.buttonSearchOK.Text = "Cauta";
            this.buttonSearchOK.UseVisualStyleBackColor = true;
            this.buttonSearchOK.Click += new System.EventHandler(this.buttonSearchOK_Click);
            // 
            // FormSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 202);
            this.Controls.Add(this.buttonSearchOK);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormSearchEmployee";
            this.Text = "Cauta Angajat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSearchOK;
    }
}