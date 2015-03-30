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
    public partial class FormUpdateAccount : Form
    {
        UserService userS = new UserService();

        public FormUpdateAccount()
        {
            InitializeComponent();
        }

        private void textBoxNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateOK_Click(object sender, EventArgs e)
        {
            User u = null;

            u = userS.updateAccount(textBoxUsername.Text, textBoxNewName.Text, textBoxNewPassword.Text, textBoxNewRole.Text);

            if (u == null)
                MessageBox.Show("Username-ul introdus nu exista in baza de date!");
            else
            {
                this.Close();
                MessageBox.Show("Contul a fost actualizat cu succes!");
            }
            
        }
    }
}
