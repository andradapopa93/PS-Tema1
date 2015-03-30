namespace Tema1.UI
{
    partial class FormUpdateAnnouncement
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
            this.textBoxUpdateTitle = new System.Windows.Forms.TextBox();
            this.labelUpdateDates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxUpdateDescription = new System.Windows.Forms.RichTextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxUpdateImage = new System.Windows.Forms.TextBox();
            this.labelUpdateType = new System.Windows.Forms.Label();
            this.comboBoxUpdateType = new System.Windows.Forms.ComboBox();
            this.buttonUpdateOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(30, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(262, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Introduceti titlul anuntului pe care doriti sa il actualizati:";
            // 
            // textBoxUpdateTitle
            // 
            this.textBoxUpdateTitle.Location = new System.Drawing.Point(57, 65);
            this.textBoxUpdateTitle.Name = "textBoxUpdateTitle";
            this.textBoxUpdateTitle.Size = new System.Drawing.Size(154, 20);
            this.textBoxUpdateTitle.TabIndex = 1;
            // 
            // labelUpdateDates
            // 
            this.labelUpdateDates.AutoSize = true;
            this.labelUpdateDates.Location = new System.Drawing.Point(30, 121);
            this.labelUpdateDates.Name = "labelUpdateDates";
            this.labelUpdateDates.Size = new System.Drawing.Size(228, 13);
            this.labelUpdateDates.TabIndex = 2;
            this.labelUpdateDates.Text = "Introduceti datele pe care doriti sa le modificati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descriere:";
            // 
            // richTextBoxUpdateDescription
            // 
            this.richTextBoxUpdateDescription.Location = new System.Drawing.Point(91, 166);
            this.richTextBoxUpdateDescription.Name = "richTextBoxUpdateDescription";
            this.richTextBoxUpdateDescription.Size = new System.Drawing.Size(259, 128);
            this.richTextBoxUpdateDescription.TabIndex = 4;
            this.richTextBoxUpdateDescription.Text = "";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(30, 335);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(81, 13);
            this.labelImage.TabIndex = 5;
            this.labelImage.Text = "Fisierul imagine:";
            // 
            // textBoxUpdateImage
            // 
            this.textBoxUpdateImage.Location = new System.Drawing.Point(132, 332);
            this.textBoxUpdateImage.Name = "textBoxUpdateImage";
            this.textBoxUpdateImage.Size = new System.Drawing.Size(171, 20);
            this.textBoxUpdateImage.TabIndex = 6;
            // 
            // labelUpdateType
            // 
            this.labelUpdateType.AutoSize = true;
            this.labelUpdateType.Location = new System.Drawing.Point(30, 380);
            this.labelUpdateType.Name = "labelUpdateType";
            this.labelUpdateType.Size = new System.Drawing.Size(79, 13);
            this.labelUpdateType.TabIndex = 7;
            this.labelUpdateType.Text = "Tipul anuntului:";
            // 
            // comboBoxUpdateType
            // 
            this.comboBoxUpdateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateType.FormattingEnabled = true;
            this.comboBoxUpdateType.Items.AddRange(new object[] {
            "Autoturisme",
            "Imobiliare",
            "Prestari servicii"});
            this.comboBoxUpdateType.Location = new System.Drawing.Point(158, 377);
            this.comboBoxUpdateType.Name = "comboBoxUpdateType";
            this.comboBoxUpdateType.Size = new System.Drawing.Size(145, 21);
            this.comboBoxUpdateType.Sorted = true;
            this.comboBoxUpdateType.TabIndex = 8;
            // 
            // buttonUpdateOK
            // 
            this.buttonUpdateOK.Location = new System.Drawing.Point(129, 446);
            this.buttonUpdateOK.Name = "buttonUpdateOK";
            this.buttonUpdateOK.Size = new System.Drawing.Size(129, 35);
            this.buttonUpdateOK.TabIndex = 9;
            this.buttonUpdateOK.Text = "OK";
            this.buttonUpdateOK.UseVisualStyleBackColor = true;
            this.buttonUpdateOK.Click += new System.EventHandler(this.buttonUpdateOK_Click);
            // 
            // FormUpdateAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 506);
            this.Controls.Add(this.buttonUpdateOK);
            this.Controls.Add(this.comboBoxUpdateType);
            this.Controls.Add(this.labelUpdateType);
            this.Controls.Add(this.textBoxUpdateImage);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.richTextBoxUpdateDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUpdateDates);
            this.Controls.Add(this.textBoxUpdateTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormUpdateAnnouncement";
            this.Text = "Actualizare anunturi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxUpdateTitle;
        private System.Windows.Forms.Label labelUpdateDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxUpdateDescription;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBoxUpdateImage;
        private System.Windows.Forms.Label labelUpdateType;
        private System.Windows.Forms.ComboBox comboBoxUpdateType;
        private System.Windows.Forms.Button buttonUpdateOK;
    }
}