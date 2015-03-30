using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1.UI
{
    public partial class FormEmployee : Form
    {
        private String username;

        public FormEmployee(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void buttonAddAnnounce_Click(object sender, EventArgs e)
        {
            FormAddAnnouncement form = new FormAddAnnouncement(username);
            form.Show();
        }

        private void buttonDeleteAnnounce_Click(object sender, EventArgs e)
        {
            FormDeleteAnnouncement form = new FormDeleteAnnouncement();
            form.Show();
        }

        private void buttonUpdateAnnounce_Click(object sender, EventArgs e)
        {
            FormUpdateAnnouncement form = new FormUpdateAnnouncement();
            form.Show();
        }

        private void buttonReadAnnounce_Click(object sender, EventArgs e)
        {
            FormSearchAnnouncement form = new FormSearchAnnouncement();
            form.Show();
        }
    }
}
