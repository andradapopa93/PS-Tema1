namespace Tema1.UI
{
    partial class FormGenerateRaports
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
            this.dataGridViewRaport = new System.Windows.Forms.DataGridView();
            this.buttonViewRaportsOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRaport
            // 
            this.dataGridViewRaport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaport.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRaport.Name = "dataGridViewRaport";
            this.dataGridViewRaport.Size = new System.Drawing.Size(528, 293);
            this.dataGridViewRaport.TabIndex = 0;
            // 
            // buttonViewRaportsOK
            // 
            this.buttonViewRaportsOK.Location = new System.Drawing.Point(189, 397);
            this.buttonViewRaportsOK.Name = "buttonViewRaportsOK";
            this.buttonViewRaportsOK.Size = new System.Drawing.Size(183, 48);
            this.buttonViewRaportsOK.TabIndex = 1;
            this.buttonViewRaportsOK.Text = "Afiseaza raport";
            this.buttonViewRaportsOK.UseVisualStyleBackColor = true;
            this.buttonViewRaportsOK.Click += new System.EventHandler(this.buttonViewRaportsOK_Click);
            // 
            // FormGenerateRaports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 495);
            this.Controls.Add(this.buttonViewRaportsOK);
            this.Controls.Add(this.dataGridViewRaport);
            this.Name = "FormGenerateRaports";
            this.Text = "Vizualizare Rapoarte";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRaport;
        private System.Windows.Forms.Button buttonViewRaportsOK;
    }
}