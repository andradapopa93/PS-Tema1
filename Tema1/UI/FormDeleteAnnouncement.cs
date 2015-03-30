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

namespace Tema1.UI
{
    public partial class FormDeleteAnnouncement : Form
    {
        AnnouncementService aService = new AnnouncementService();

        public FormDeleteAnnouncement()
        {
            InitializeComponent();
        }

        private void buttonDeleteOK_Click(object sender, EventArgs e)
        {
            String title = textBoxDeleteTitle.Text;
            String type = comboBoxDeleteType.Text;

            if (String.Compare(title, "") != 0 && String.Compare(type, "") != 0)
            {
                String s = aService.deleteAnnouncement(title, type);

                if (s != null)
                {
                    this.Close();
                    MessageBox.Show("Anuntul a fost sters cu succes din baza de date!");
                }
                else
                    MessageBox.Show("Datele introduse nu sunt complete si/sau nu corespund aceluiasi anunt!");

            }
            else
                MessageBox.Show("Datele introduse sunt invalide!\n Va rugam sa reintroduceti datele necesare stergerii anuntului!");
        }

    }
}
