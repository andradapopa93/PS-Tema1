namespace Tema1.UI
{
    partial class FormAddAnnouncement
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxAddTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.textBoxPictureFile = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxAnnounceType = new System.Windows.Forms.ComboBox();
            this.buttonAddOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(43, 40);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(210, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Introduceti datele pentru crearea anuntului:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 89);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Titlu anunt:";
            // 
            // textBoxAddTitle
            // 
            this.textBoxAddTitle.Location = new System.Drawing.Point(113, 86);
            this.textBoxAddTitle.Name = "textBoxAddTitle";
            this.textBoxAddTitle.Size = new System.Drawing.Size(114, 20);
            this.textBoxAddTitle.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(23, 134);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(55, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Descriere:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(113, 134);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(315, 139);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(23, 303);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(125, 13);
            this.labelPicture.TabIndex = 5;
            this.labelPicture.Text = "Numele fisierului imagine:";
            // 
            // textBoxPictureFile
            // 
            this.textBoxPictureFile.Location = new System.Drawing.Point(186, 300);
            this.textBoxPictureFile.Name = "textBoxPictureFile";
            this.textBoxPictureFile.Size = new System.Drawing.Size(242, 20);
            this.textBoxPictureFile.TabIndex = 6;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(23, 369);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(79, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Tipul anuntului:";
            // 
            // comboBoxAnnounceType
            // 
            this.comboBoxAnnounceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnnounceType.FormattingEnabled = true;
            this.comboBoxAnnounceType.Items.AddRange(new object[] {
            "Autoturisme",
            "Imobiliare",
            "Prestari servicii"});
            this.comboBoxAnnounceType.Location = new System.Drawing.Point(186, 366);
            this.comboBoxAnnounceType.Name = "comboBoxAnnounceType";
            this.comboBoxAnnounceType.Size = new System.Drawing.Size(159, 21);
            this.comboBoxAnnounceType.Sorted = true;
            this.comboBoxAnnounceType.TabIndex = 8;
            this.comboBoxAnnounceType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnnounceType_SelectedIndexChanged);
            // 
            // buttonAddOK
            // 
            this.buttonAddOK.Location = new System.Drawing.Point(186, 423);
            this.buttonAddOK.Name = "buttonAddOK";
            this.buttonAddOK.Size = new System.Drawing.Size(123, 37);
            this.buttonAddOK.TabIndex = 10;
            this.buttonAddOK.Text = "Adauga";
            this.buttonAddOK.UseVisualStyleBackColor = true;
            this.buttonAddOK.Click += new System.EventHandler(this.buttonAddOK_Click);
            // 
            // FormAddAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 500);
            this.Controls.Add(this.buttonAddOK);
            this.Controls.Add(this.comboBoxAnnounceType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxPictureFile);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxAddTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormAddAnnouncement";
            this.Text = "Adaugare anunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxAddTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.TextBox textBoxPictureFile;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxAnnounceType;
        private System.Windows.Forms.Button buttonAddOK;
    }
}