using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace P_Prod_TimFroidevaux_MySql
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=mysql;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                if (btnConnexion.Text == "Connexion") {
                    btnConnexion.Text = "Déconnexion";
                    conn.Open();
                    btnCreeTable.Visible = true;
                    btnCreeBdd.Visible = true;
                }
                else {
                    btnConnexion.Text = "Connexion";
                    conn.Close();
                    btnCreeTable.Visible = false;
                    btnCreeBdd.Visible = false;
                }

            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=mysql;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);

            if (tbxNewBdd.Text == string.Empty) {
                MessageBox.Show("Entrez un nom de base de données");
            } else
            {
                string newDb = "CREATE DATABASE IF NOT EXISTS " + tbxNewBdd.Text + ";";
                MySqlCommand sqlNewDb = new MySqlCommand(newDb, conn);

                try
                {
                    conn.Open();
                    sqlNewDb.ExecuteNonQuery();
                    MessageBox.Show("La base de donnée " + tbxNewBdd.Text + " a été crée"); 
                    tbxNewBdd.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void PnlCree_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCreeBdd_Click(object sender, EventArgs e)
        {
            pnlBdd.Visible = true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreeTable_Click(object sender, EventArgs e)
        {
            pnlTable.Visible = true;
        }

        private void TbxNewBdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            pnlBdd.Visible = false;
            tbxNewBdd.Text = string.Empty;
        }

        private void BtnRetour2_Click(object sender, EventArgs e)
        {
            pnlTable.Visible = false;
            tbxTaille.Text = string.Empty;
            tbxType.Text = string.Empty;
            tbxTableCree.Text = string.Empty;
            tbxColonne.Text = string.Empty;
        }

        private void BtnCreeLaTable_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=mysql;port=3306;password=root";
            MySqlConnection conn = new MySqlConnection(connStr);

            if(tbxTableCree.Text == string.Empty)
            {
                MessageBox.Show("Entrez un nom de table");
            }
            else if(tbxColonne.Text == string.Empty)
            {
                MessageBox.Show("Entrez un nom de colonne");
            }
            else if(tbxType.Text == string.Empty)
            {
                MessageBox.Show("Entrez un type");
            }
            else if(tbxTaille.Text == string.Empty)
            {
                MySqlCommand table = new MySqlCommand("CREATE TABLE IF NOT EXISTS " + tbxTableCree.Text + " (" + tbxColonne.Text + " " + tbxType.Text + ") ", conn);
                try
                {
                    conn.Open();
                    MessageBox.Show("La base de donnée " + tbxNewBdd.Text + " a été crée");
                    table.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MySqlCommand table = new MySqlCommand("CREATE TABLE IF NOT EXISTS " + tbxTableCree.Text + " (" + tbxColonne.Text + " " + tbxType.Text + "(" + tbxTaille.Text + ")) ", conn);
                try
                {
                    conn.Open();
                    MessageBox.Show("La base de donnée " + tbxNewBdd.Text + " a été crée");
                    table.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}