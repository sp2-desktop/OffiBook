using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offibook_v0
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'offibook_v0DataSet.user'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.userTableAdapter.Fill(this.offibook_v0DataSet.user);

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = tbx_login.Text;
            String password = tbx_password.Text;

            // query
            if (Convert.ToBoolean(this.userTableAdapter.FillByLogin(this.offibook_v0DataSet.user, username, password)))
            {
                new frm_home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur lors de la connection");
            }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.offibook_v0DataSet);

        }
    }
}
