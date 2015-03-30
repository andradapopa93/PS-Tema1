using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema1.UI;

namespace Tema1.DAL
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewRaports_Click(object sender, EventArgs e)
        {
            //FormGenerateRaports form = new FormGenerateRaports();
            //form.Show();
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            FormDeleteAccount form = new FormDeleteAccount();
            form.Show();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount form = new FormAddAccount();
            form.Show();
        }

        private void buttonUpdateAccount_Click(object sender, EventArgs e)
        {
            FormUpdateAccount form = new FormUpdateAccount();
            form.Show();
        }

        private void buttonReadAccount_Click(object sender, EventArgs e)
        {
            FormSearchEmployee form = new FormSearchEmployee();
            form.Show();
        }
    }
}
