using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace offibook_v0
{
    public partial class frm_home : Form
    {
        int ID = 0;
        String host = "127.0.0.1";
        String database = "offibook_v0";
        String port = "3306";
        String username = "root";
        String password = "root";
        MySqlDataReader reader;
        public frm_home()
        {
            InitializeComponent();

            dtg_livre.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(livreOnRowHeaderMouseClick);
            dtg_emprunt.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(empruntOnRowHeaderMouseClick);


        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'offibook_v0DataSet2.emprunt'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.empruntTableAdapter.Fill(this.offibook_v0DataSet2.emprunt);
            // TODO: cette ligne de code charge les données dans la table 'offibook_v0DataSet2.emprunt'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.empruntTableAdapter.Fill(this.offibook_v0DataSet2.emprunt);
            // TODO: cette ligne de code charge les données dans la table 'offibook_v0DataSet1.livre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.livreTableAdapter.Fill(this.offibook_v0DataSet1.livre);

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new frm_login().Show();
            this.Hide();
        }
        private void dtg_livre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Clear Data  
        private void ClearData()
        {
            txt_isbn.Text = "";
            txt_auteur.Text = "";
            txt_titre.Text = "";
            txt_edition.Text = "";
            txt_code.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

            dtg_livre.Update();
            dtg_livre.Refresh();
        }
        //dtg_livre RowHeaderMouseClick Event  
        private void livreOnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dtg_livre.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_isbn.Text = dtg_livre.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_titre.Text = dtg_livre.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_auteur.Text = dtg_livre.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_edition.Text = dtg_livre.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_code.Text = dtg_livre.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
        private void empruntOnRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dtg_emprunt.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_nom.Text = dtg_emprunt.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_prenom.Text = dtg_emprunt.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_isbn_livre.Text = dtg_emprunt.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_date.Text = dtg_emprunt.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void fillByLivreToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.livreTableAdapter.FillByLivre(this.offibook_v0DataSet.livre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lbl_isbn_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (txt_isbn.Text != "" && txt_titre.Text != "" && txt_auteur.Text != "" && txt_edition.Text != "" && txt_code.Text != "")
            {
                String isbn = txt_isbn.Text;
                String titre = txt_titre.Text;
                String auteur = txt_auteur.Text;
                String edition = txt_edition.Text;
                String code = txt_code.Text;

                if (Convert.ToBoolean(this.livreTableAdapter.FillByIsbn(this.offibook_v0DataSet.livre, isbn)))
                {
                    if (Convert.ToBoolean(this.livreTableAdapter.InsertQueryLivre(isbn, titre, auteur, edition, code, 0)))
                    {
                        MessageBox.Show("Le livre est ajouter avec succès");
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout");
                    }
                }
                else
                {
                    MessageBox.Show("Le livre est deja dans la liste");
                }

            }
            else
            {
                MessageBox.Show("Completer les champs!");
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (txt_isbn.Text != "" && txt_titre.Text != "" && txt_auteur.Text != "" && txt_edition.Text != "" && txt_code.Text != "")
            {

                String isbn = txt_isbn.Text;
                String titre = txt_titre.Text;
                String auteur = txt_auteur.Text;
                String edition = txt_edition.Text;
                String code = txt_code.Text;
                if (Convert.ToBoolean(this.livreTableAdapter.UpdateQueryLivre(isbn, titre, auteur, edition, code, ID)))
                {
                    MessageBox.Show("Le livre est modifier avec succès");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modication");
                }

            }
            else
            {
                MessageBox.Show("Completer les champs!");
            }
        }

        private void btn_delete_Click_2(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (Convert.ToBoolean(this.livreTableAdapter.DeleteQueryLivre(ID)))
                {
                    MessageBox.Show("Le livre est supprimer avec succès!");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modication");
                }
            }
            else
            {
                MessageBox.Show("Selectioner un livre");
            }
        }

        private void tbp_livre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addEmprunt_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != "" && txt_prenom.Text != "" && txt_isbn_livre.Text != "" && txt_date.Text != "")
            {
                String nom = txt_nom.Text;
                String prenom = txt_prenom.Text;
                String isbn = txt_isbn_livre.Text;
                String date = txt_date.Text;
                var parsedDate = DateTime.Parse(date);

                if (Convert.ToBoolean(this.livreTableAdapter.FillByIsbn(this.offibook_v0DataSet.livre, isbn)))
                {
                    if (Convert.ToBoolean(this.empruntTableAdapter.FillByLivre_Iisbn(this.offibook_v0DataSet.emprunt, isbn)))
                    {
                        MessageBox.Show("Livre deja réserver");
                    }
                    else
                    {
                        if (Convert.ToBoolean(this.livreTableAdapter.UpdateQueryLivreEmprunt(1, isbn)))
                        {
                            if (Convert.ToBoolean(this.empruntTableAdapter.InsertQueryEmprunt(nom, prenom, isbn, parsedDate)))
                            {
                                MessageBox.Show("L'emprunt est ajouter avec succès");
                                dtg_emprunt.Refresh();
                                ClearData();
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de l'ajout");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ISBN inexistant");

                }
            }
            else
            {
                MessageBox.Show("Completer les champs!");
            }
        }

        private class Date
        {
        }

        private void fillByEmpruntToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empruntTableAdapter.FillByEmprunt(this.offibook_v0DataSet.emprunt);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_updateEmprunt_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != "" && txt_prenom.Text != "" && txt_isbn_livre.Text != "" && txt_date.Text != "")
            {

                String nom = txt_nom.Text;
                String prenom = txt_prenom.Text;
                String isbn = txt_isbn_livre.Text;
                String date = txt_date.Text;
                var parsedDate = DateTime.Parse(date);
                if (Convert.ToBoolean(this.empruntTableAdapter.UpdateQueryEmprunt(nom, prenom, isbn, parsedDate, ID)))
                {
                    MessageBox.Show("L'emprunt est modifer avec succès");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modication");
                }

            }
            else
            {
                MessageBox.Show("Completer les champs!");
            }
        }

        private void tbp_emprunt_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteEmprunt_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (Convert.ToBoolean(this.empruntTableAdapter.DeleteQueryEmprunt(ID)))
                {
                    MessageBox.Show("L'emprunt est supprimer avec succès!");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modication");
                }
            }
            else
            {
                MessageBox.Show("Selectioner un emprunt");
            }
        }
        public class UpdateEventArgs
        {
        }
    }
}
