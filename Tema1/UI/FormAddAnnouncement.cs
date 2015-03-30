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
    public partial class FormAddAnnouncement : Form
    {
        AnnouncementService aService = new AnnouncementService();
        UserService userS = new UserService();

        private String username;

        public FormAddAnnouncement(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void comboBoxAnnounceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddOK_Click(object sender, EventArgs e)
        {
            String title = textBoxAddTitle.Text; 
            String description = richTextBoxDescription.Text;
            String pictureFile = textBoxPictureFile.Text;
            String type = comboBoxAnnounceType.Text;

            
            if (String.Compare(title, "") != 0 && String.Compare(description, "") != 0 && String.Compare(pictureFile, "") != 0 && String.Compare(type, "") != 0)
            {
                Announcement a = aService.addAnnouncement(title, description, pictureFile, type);
                String s = userS.updateNumberOfUserAnnouncements(username);

                this.Close();
                if (a == null)
                    MessageBox.Show("Adaugarea anuntului nu s-a putut efectua!");
                else
                    if (String.Compare(a.Title, title) == 0 && String.Compare(a.Type, type) == 0 && String.Compare(a.Description, description) == 0)
                        MessageBox.Show("Anuntul a fost adaugat cu succes!");
            }
            else
                MessageBox.Show("Datele introduse sunt incorecte!\n Va rugam sa reintroduceti datele pentru adaugarea noului anunt!");
             
        }
    }
}
