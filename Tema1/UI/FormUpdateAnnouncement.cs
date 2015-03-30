using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema1.BL;
using Tema1.Entities;

namespace Tema1.UI
{
    public partial class FormUpdateAnnouncement : Form
    {
        AnnouncementService aService = new AnnouncementService();

        public FormUpdateAnnouncement()
        {
            InitializeComponent();
        }

        private void buttonUpdateOK_Click(object sender, EventArgs e)
        {
            Announcement a = null;

            a = aService.updateAnnouncement(textBoxUpdateTitle.Text, richTextBoxUpdateDescription.Text, textBoxUpdateImage.Text, comboBoxUpdateType.Text);

            if (a == null)
                MessageBox.Show("Nu exista niciun anunt cu titlul introdus in baza de date!");
            else
            {
                this.Close();
                MessageBox.Show("Anuntul a fost actualizat cu succes!");
            }
        }
    }
}
