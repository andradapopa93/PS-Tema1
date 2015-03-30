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
    public partial class FormSearchEmployee : Form
    {
        User u = null;
        UserService userS = new UserService();

        public FormSearchEmployee()
        {
            InitializeComponent();
        }

        private void buttonSearchOK_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            u = userS.searchUser(name);

            if (u == null)
                MessageBox.Show("Angajatul cautat nu exista!");
            else
            {
                this.Close();
                MessageBox.Show("Angajatul " + name + " este inregistrat cu \n contul: " + u.getUsername() +
                     " si are rolul de " + u.getRole() + ".");
            }
        }
    }
}
