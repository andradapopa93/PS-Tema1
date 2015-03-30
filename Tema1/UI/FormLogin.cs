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
using Tema1.DAL;
using Tema1.Entities;
using Tema1.UI;

namespace Tema1
{
    public partial class FormLogin : Form
    {
        UserService userS = new UserService(); 

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User u = userS.login(textBoxUsername.Text, textBoxPassword.Text);

            if (u == null)
                MessageBox.Show("Utilizatorul nu exista!");
            else
            {
                if (String.Compare(u.getRole(), "admin") == 0)
                {
                    FormAdmin form = new FormAdmin();
                    form.Show();
                }
                else
                {
                    FormEmployee form = new FormEmployee(textBoxUsername.Text);
                    form.Show();
                }
            }
        }
    }
}
