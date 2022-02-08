namespace P_Prod_TimFroidevaux_MySql
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblBdd = new System.Windows.Forms.Label();
            this.tbxNewBdd = new System.Windows.Forms.TextBox();
            this.btnNewBdd = new System.Windows.Forms.Button();
            this.btnCreeLaTable = new System.Windows.Forms.Button();
            this.tbxTableCree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreeBdd = new System.Windows.Forms.Button();
            this.btnCreeTable = new System.Windows.Forms.Button();
            this.pnlCree = new System.Windows.Forms.Panel();
            this.pnlBdd = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.tbxColonne = new System.Windows.Forms.TextBox();
            this.lblCol = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tbxTaille = new System.Windows.Forms.TextBox();
            this.lblTaille = new System.Windows.Forms.Label();
            this.btnRetour2 = new System.Windows.Forms.Button();
            this.pnlCree.SuspendLayout();
            this.pnlBdd.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(285, 417);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(279, 111);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // lblBdd
            // 
            this.lblBdd.AutoSize = true;
            this.lblBdd.Location = new System.Drawing.Point(19, 143);
            this.lblBdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBdd.Name = "lblBdd";
            this.lblBdd.Size = new System.Drawing.Size(268, 20);
            this.lblBdd.TabIndex = 1;
            this.lblBdd.Text = "Nom de la base de données  a créer:";
            // 
            // tbxNewBdd
            // 
            this.tbxNewBdd.Location = new System.Drawing.Point(326, 143);
            this.tbxNewBdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxNewBdd.Name = "tbxNewBdd";
            this.tbxNewBdd.Size = new System.Drawing.Size(234, 26);
            this.tbxNewBdd.TabIndex = 2;
            this.tbxNewBdd.TextChanged += new System.EventHandler(this.TbxNewBdd_TextChanged);
            // 
            // btnNewBdd
            // 
            this.btnNewBdd.Location = new System.Drawing.Point(326, 242);
            this.btnNewBdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewBdd.Name = "btnNewBdd";
            this.btnNewBdd.Size = new System.Drawing.Size(234, 35);
            this.btnNewBdd.TabIndex = 3;
            this.btnNewBdd.Text = "Créer la base de données";
            this.btnNewBdd.UseVisualStyleBackColor = true;
            this.btnNewBdd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCreeLaTable
            // 
            this.btnCreeLaTable.Location = new System.Drawing.Point(330, 389);
            this.btnCreeLaTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreeLaTable.Name = "btnCreeLaTable";
            this.btnCreeLaTable.Size = new System.Drawing.Size(234, 35);
            this.btnCreeLaTable.TabIndex = 6;
            this.btnCreeLaTable.Text = "Créer la table";
            this.btnCreeLaTable.UseVisualStyleBackColor = true;
            this.btnCreeLaTable.Click += new System.EventHandler(this.BtnCreeLaTable_Click);
            // 
            // tbxTableCree
            // 
            this.tbxTableCree.Location = new System.Drawing.Point(330, 51);
            this.tbxTableCree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTableCree.Name = "tbxTableCree";
            this.tbxTableCree.Size = new System.Drawing.Size(234, 26);
            this.tbxTableCree.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom d\'une table a créer :";
            // 
            // btnCreeBdd
            // 
            this.btnCreeBdd.Location = new System.Drawing.Point(285, 18);
            this.btnCreeBdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreeBdd.Name = "btnCreeBdd";
            this.btnCreeBdd.Size = new System.Drawing.Size(279, 117);
            this.btnCreeBdd.TabIndex = 7;
            this.btnCreeBdd.Text = "Créer une base de donnée";
            this.btnCreeBdd.UseVisualStyleBackColor = true;
            this.btnCreeBdd.Visible = false;
            this.btnCreeBdd.Click += new System.EventHandler(this.BtnCreeBdd_Click);
            // 
            // btnCreeTable
            // 
            this.btnCreeTable.Location = new System.Drawing.Point(285, 210);
            this.btnCreeTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreeTable.Name = "btnCreeTable";
            this.btnCreeTable.Size = new System.Drawing.Size(279, 117);
            this.btnCreeTable.TabIndex = 8;
            this.btnCreeTable.Text = "Créer une table";
            this.btnCreeTable.UseVisualStyleBackColor = true;
            this.btnCreeTable.Visible = false;
            this.btnCreeTable.Click += new System.EventHandler(this.BtnCreeTable_Click);
            // 
            // pnlCree
            // 
            this.pnlCree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCree.Controls.Add(this.btnCreeBdd);
            this.pnlCree.Controls.Add(this.btnCreeTable);
            this.pnlCree.Controls.Add(this.btnConnexion);
            this.pnlCree.Location = new System.Drawing.Point(12, 12);
            this.pnlCree.Name = "pnlCree";
            this.pnlCree.Size = new System.Drawing.Size(851, 551);
            this.pnlCree.TabIndex = 9;
            this.pnlCree.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCree_Paint);
            // 
            // pnlBdd
            // 
            this.pnlBdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBdd.Controls.Add(this.btnRetour);
            this.pnlBdd.Controls.Add(this.lblBdd);
            this.pnlBdd.Controls.Add(this.tbxNewBdd);
            this.pnlBdd.Controls.Add(this.btnNewBdd);
            this.pnlBdd.Location = new System.Drawing.Point(12, 13);
            this.pnlBdd.Name = "pnlBdd";
            this.pnlBdd.Size = new System.Drawing.Size(851, 551);
            this.pnlBdd.TabIndex = 10;
            this.pnlBdd.Visible = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(326, 493);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(234, 35);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTable.Controls.Add(this.tbxColonne);
            this.pnlTable.Controls.Add(this.lblCol);
            this.pnlTable.Controls.Add(this.tbxType);
            this.pnlTable.Controls.Add(this.lblType);
            this.pnlTable.Controls.Add(this.tbxTaille);
            this.pnlTable.Controls.Add(this.lblTaille);
            this.pnlTable.Controls.Add(this.btnRetour2);
            this.pnlTable.Controls.Add(this.tbxTableCree);
            this.pnlTable.Controls.Add(this.label1);
            this.pnlTable.Controls.Add(this.btnCreeLaTable);
            this.pnlTable.Location = new System.Drawing.Point(12, 13);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(851, 551);
            this.pnlTable.TabIndex = 10;
            this.pnlTable.Visible = false;
            // 
            // tbxColonne
            // 
            this.tbxColonne.Location = new System.Drawing.Point(330, 145);
            this.tbxColonne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxColonne.Name = "tbxColonne";
            this.tbxColonne.Size = new System.Drawing.Size(234, 26);
            this.tbxColonne.TabIndex = 13;
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(43, 145);
            this.lblCol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(137, 20);
            this.lblCol.TabIndex = 12;
            this.lblCol.Text = "Colonne a ajouté :";
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(330, 204);
            this.tbxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(234, 26);
            this.tbxType.TabIndex = 11;
            this.tbxType.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(43, 204);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(149, 20);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type de la colonne :";
            this.lblType.Click += new System.EventHandler(this.Label3_Click);
            // 
            // tbxTaille
            // 
            this.tbxTaille.Location = new System.Drawing.Point(330, 270);
            this.tbxTaille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTaille.Name = "tbxTaille";
            this.tbxTaille.Size = new System.Drawing.Size(234, 26);
            this.tbxTaille.TabIndex = 9;
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(43, 270);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(213, 20);
            this.lblTaille.TabIndex = 8;
            this.lblTaille.Text = "Taille/Valeurs de la colonne : ";
            // 
            // btnRetour2
            // 
            this.btnRetour2.Location = new System.Drawing.Point(330, 475);
            this.btnRetour2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetour2.Name = "btnRetour2";
            this.btnRetour2.Size = new System.Drawing.Size(234, 35);
            this.btnRetour2.TabIndex = 7;
            this.btnRetour2.Text = "Retour au menu";
            this.btnRetour2.UseVisualStyleBackColor = true;
            this.btnRetour2.Click += new System.EventHandler(this.BtnRetour2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 575);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlBdd);
            this.Controls.Add(this.pnlCree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCree.ResumeLayout(false);
            this.pnlBdd.ResumeLayout(false);
            this.pnlBdd.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblBdd;
        private System.Windows.Forms.TextBox tbxNewBdd;
        private System.Windows.Forms.Button btnNewBdd;
        private System.Windows.Forms.Button btnCreeLaTable;
        private System.Windows.Forms.TextBox tbxTableCree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreeBdd;
        private System.Windows.Forms.Button btnCreeTable;
        private System.Windows.Forms.Panel pnlCree;
        private System.Windows.Forms.Panel pnlBdd;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Button btnRetour2;
        private System.Windows.Forms.TextBox tbxColonne;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbxTaille;
        private System.Windows.Forms.Label lblTaille;
    }
}

