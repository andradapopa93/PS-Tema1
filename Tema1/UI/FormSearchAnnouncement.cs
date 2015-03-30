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
    public partial class FormSearchAnnouncement : Form
    {
        AnnouncementService aService = new AnnouncementService();

        public FormSearchAnnouncement()
        {
            InitializeComponent();
        }

        private void buttonSearchOK_Click(object sender, EventArgs e)
        {
            String title = textBoxSearchTitle.Text;
            Announcement a = aService.searchAnnouncement(title);

            if (a == null)
                MessageBox.Show("Anuntul cautat nu exista!");
            else
            {
                this.Close();
                MessageBox.Show("Anuntul gasit are titlul: " + title + " si este un anunt de: " + a.Type + ".");
            }
        }
    }
}
