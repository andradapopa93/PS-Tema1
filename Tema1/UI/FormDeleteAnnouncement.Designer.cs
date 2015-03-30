namespace Tema1.UI
{
    partial class FormDeleteAnnouncement
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxDeleteTitle = new System.Windows.Forms.TextBox();
            this.labelAnnounceType = new System.Windows.Forms.Label();
            this.comboBoxDeleteType = new System.Windows.Forms.ComboBox();
            this.buttonDeleteOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(23, 35);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(316, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Introduceti datele pentru identificarea anuntului care se va sterge:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(51, 83);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Titlu anunt:";
            // 
            // textBoxDeleteTitle
            // 
            this.textBoxDeleteTitle.Location = new System.Drawing.Point(149, 80);
            this.textBoxDeleteTitle.Name = "textBoxDeleteTitle";
            this.textBoxDeleteTitle.Size = new System.Drawing.Size(172, 20);
            this.textBoxDeleteTitle.TabIndex = 3;
            // 
            // labelAnnounceType
            // 
            this.labelAnnounceType.AutoSize = true;
            this.labelAnnounceType.Location = new System.Drawing.Point(51, 143);
            this.labelAnnounceType.Name = "labelAnnounceType";
            this.labelAnnounceType.Size = new System.Drawing.Size(79, 13);
            this.labelAnnounceType.TabIndex = 4;
            this.labelAnnounceType.Text = "Tipul anuntului:";
            // 
            // comboBoxDeleteType
            // 
            this.comboBoxDeleteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteType.FormattingEnabled = true;
            this.comboBoxDeleteType.Items.AddRange(new object[] {
            "Autoturisme",
            "Imobiliare",
            "Prestari servicii"});
            this.comboBoxDeleteType.Location = new System.Drawing.Point(170, 140);
            this.comboBoxDeleteType.Name = "comboBoxDeleteType";
            this.comboBoxDeleteType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxDeleteType.Sorted = true;
            this.comboBoxDeleteType.TabIndex = 8;
            // 
            // buttonDeleteOK
            // 
            this.buttonDeleteOK.Location = new System.Drawing.Point(117, 194);
            this.buttonDeleteOK.Name = "buttonDeleteOK";
            this.buttonDeleteOK.Size = new System.Drawing.Size(126, 30);
            this.buttonDeleteOK.TabIndex = 6;
            this.buttonDeleteOK.Text = "OK";
            this.buttonDeleteOK.UseVisualStyleBackColor = true;
            this.buttonDeleteOK.Click += new System.EventHandler(this.buttonDeleteOK_Click);
            // 
            // FormDeleteAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 255);
            this.Controls.Add(this.buttonDeleteOK);
            this.Controls.Add(this.comboBoxDeleteType);
            this.Controls.Add(this.labelAnnounceType);
            this.Controls.Add(this.textBoxDeleteTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormDeleteAnnouncement";
            this.Text = "Stergere anunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxDeleteTitle;
        private System.Windows.Forms.Label labelAnnounceType;
        private System.Windows.Forms.ComboBox comboBoxDeleteType;
        private System.Windows.Forms.Button buttonDeleteOK;
    }
}