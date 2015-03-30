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
    public partial class FormDeleteAccount : Form
    {
        UserService userS = new UserService();


        public FormDeleteAccount()
        {
            InitializeComponent();
        }


        private void buttonDeleteOK_Click(object sender, EventArgs e)
        {
            String name = textBoxDeleteName.Text;
            String username = textBoxDeleteUsername.Text;

            if (String.Compare(name, "") != 0 && String.Compare(username, "") != 0)
            {
                String s = userS.deleteAccount(name, username);
                if (s != null)
                {
                    this.Close();
                    MessageBox.Show("Contul a fost sters cu succes!");
                }
                else
                    MessageBox.Show("Datele introduse nu sunt complete si/sau nu corespund aceluiasi cont!");

            }
            else
                MessageBox.Show("Datele introduse sunt invalide!\n Va rugam sa reintroduceti datele necesare stergerii contului!");
        }
    }
}
