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

namespace Tema1.DAL
{
    public partial class FormAddAccount : Form
    {
        UserService userS = new UserService();


        public FormAddAccount()
        {
            InitializeComponent();
        }


        private void buttonAddOK_Click(object sender, EventArgs e)
        {
            String name = textBoxAddName.Text;
            String username = textBoxAddUsername.Text;
            String password = textBoxAddPassword.Text;
            String role = textBoxAddRole.Text;

            if (String.Compare(name, "") != 0 && String.Compare(username, "") != 0 && String.Compare(password, "") != 0 && String.Compare(role, "") != 0)
            {
                User u = userS.addAccount(name, username, password, role);
                this.Close();
                if (u == null)
                    MessageBox.Show("Adaugarea contului nu s-a putut efectua!");
                else
                    if (String.Compare(u.getName(), name) == 0 && String.Compare(u.getRole(), role) == 0 && String.Compare(u.getUsername(), username) == 0)
                        MessageBox.Show("Contul a fost creat cu succes!");
            }       
            else
                MessageBox.Show("Datele introduse sunt incorecte!\n Va rugam sa reintroduceti datele pentru crearea noului cont!");
        }
    }
}
