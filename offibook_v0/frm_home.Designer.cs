
namespace offibook_v0
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tbp_emprunt = new System.Windows.Forms.TabPage();
            this.btn_deleteEmprunt = new System.Windows.Forms.Button();
            this.btn_updateEmprunt = new System.Windows.Forms.Button();
            this.btn_addEmprunt = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_isbn_livre = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_isbn_livre = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.dtg_emprunt = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.offibook_v0DataSet2 = new offibook_v0.offibook_v0DataSet();
            this.tbp_livre = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_edition = new System.Windows.Forms.Label();
            this.lbl_auteur = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_edition = new System.Windows.Forms.TextBox();
            this.txt_auteur = new System.Windows.Forms.TextBox();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.dtg_livre = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.offibook_v0DataSet1 = new offibook_v0.offibook_v0DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.empruntBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empruntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offibook_v0DataSet = new offibook_v0.offibook_v0DataSet();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livreTableAdapter = new offibook_v0.offibook_v0DataSetTableAdapters.livreTableAdapter();
            this.empruntTableAdapter = new offibook_v0.offibook_v0DataSetTableAdapters.empruntTableAdapter();
            this.empruntBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbp_emprunt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_emprunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet2)).BeginInit();
            this.tbp_livre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_livre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1019, 28);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(192, 69);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Deconnexion";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // tbp_emprunt
            // 
            this.tbp_emprunt.Controls.Add(this.btn_deleteEmprunt);
            this.tbp_emprunt.Controls.Add(this.btn_updateEmprunt);
            this.tbp_emprunt.Controls.Add(this.btn_addEmprunt);
            this.tbp_emprunt.Controls.Add(this.lbl_nom);
            this.tbp_emprunt.Controls.Add(this.lbl_prenom);
            this.tbp_emprunt.Controls.Add(this.lbl_date);
            this.tbp_emprunt.Controls.Add(this.lbl_isbn_livre);
            this.tbp_emprunt.Controls.Add(this.txt_date);
            this.tbp_emprunt.Controls.Add(this.txt_isbn_livre);
            this.tbp_emprunt.Controls.Add(this.txt_prenom);
            this.tbp_emprunt.Controls.Add(this.txt_nom);
            this.tbp_emprunt.Controls.Add(this.dtg_emprunt);
            this.tbp_emprunt.Location = new System.Drawing.Point(4, 22);
            this.tbp_emprunt.Name = "tbp_emprunt";
            this.tbp_emprunt.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_emprunt.Size = new System.Drawing.Size(978, 827);
            this.tbp_emprunt.TabIndex = 1;
            this.tbp_emprunt.Text = "Liste des emprunts";
            this.tbp_emprunt.UseVisualStyleBackColor = true;
            this.tbp_emprunt.Click += new System.EventHandler(this.tbp_emprunt_Click);
            // 
            // btn_deleteEmprunt
            // 
            this.btn_deleteEmprunt.Location = new System.Drawing.Point(541, 107);
            this.btn_deleteEmprunt.Name = "btn_deleteEmprunt";
            this.btn_deleteEmprunt.Size = new System.Drawing.Size(133, 33);
            this.btn_deleteEmprunt.TabIndex = 38;
            this.btn_deleteEmprunt.Text = "Supprimer un emprunt";
            this.btn_deleteEmprunt.UseVisualStyleBackColor = true;
            this.btn_deleteEmprunt.Click += new System.EventHandler(this.btn_deleteEmprunt_Click);
            // 
            // btn_updateEmprunt
            // 
            this.btn_updateEmprunt.Location = new System.Drawing.Point(387, 107);
            this.btn_updateEmprunt.Name = "btn_updateEmprunt";
            this.btn_updateEmprunt.Size = new System.Drawing.Size(115, 33);
            this.btn_updateEmprunt.TabIndex = 37;
            this.btn_updateEmprunt.Text = "Modifier un emprunt";
            this.btn_updateEmprunt.UseVisualStyleBackColor = true;
            this.btn_updateEmprunt.Click += new System.EventHandler(this.btn_updateEmprunt_Click);
            // 
            // btn_addEmprunt
            // 
            this.btn_addEmprunt.Location = new System.Drawing.Point(226, 107);
            this.btn_addEmprunt.Name = "btn_addEmprunt";
            this.btn_addEmprunt.Size = new System.Drawing.Size(115, 33);
            this.btn_addEmprunt.TabIndex = 36;
            this.btn_addEmprunt.Text = "Ajouter un emprunt";
            this.btn_addEmprunt.UseVisualStyleBackColor = true;
            this.btn_addEmprunt.Click += new System.EventHandler(this.btn_addEmprunt_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(226, 25);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 8;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(226, 59);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 7;
            this.lbl_prenom.Text = "Prenom :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(451, 59);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(87, 13);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Date échéance :";
            // 
            // lbl_isbn_livre
            // 
            this.lbl_isbn_livre.AutoSize = true;
            this.lbl_isbn_livre.Location = new System.Drawing.Point(451, 22);
            this.lbl_isbn_livre.Name = "lbl_isbn_livre";
            this.lbl_isbn_livre.Size = new System.Drawing.Size(70, 13);
            this.lbl_isbn_livre.TabIndex = 5;
            this.lbl_isbn_livre.Text = "Isbn du livre :";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(544, 56);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 20);
            this.txt_date.TabIndex = 4;
            // 
            // txt_isbn_livre
            // 
            this.txt_isbn_livre.Location = new System.Drawing.Point(544, 19);
            this.txt_isbn_livre.Name = "txt_isbn_livre";
            this.txt_isbn_livre.Size = new System.Drawing.Size(100, 20);
            this.txt_isbn_livre.TabIndex = 3;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(306, 56);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 2;
            this.txt_prenom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(306, 22);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtg_emprunt
            // 
            this.dtg_emprunt.AutoGenerateColumns = false;
            this.dtg_emprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_emprunt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.livreisbnDataGridViewTextBoxColumn,
            this.dateEcheanceDataGridViewTextBoxColumn});
            this.dtg_emprunt.DataSource = this.empruntBindingSource3;
            this.dtg_emprunt.Location = new System.Drawing.Point(145, 201);
            this.dtg_emprunt.Name = "dtg_emprunt";
            this.dtg_emprunt.Size = new System.Drawing.Size(601, 592);
            this.dtg_emprunt.TabIndex = 0;
            this.dtg_emprunt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // livreisbnDataGridViewTextBoxColumn
            // 
            this.livreisbnDataGridViewTextBoxColumn.DataPropertyName = "livre_isbn";
            this.livreisbnDataGridViewTextBoxColumn.HeaderText = "livre_isbn";
            this.livreisbnDataGridViewTextBoxColumn.Name = "livreisbnDataGridViewTextBoxColumn";
            // 
            // dateEcheanceDataGridViewTextBoxColumn
            // 
            this.dateEcheanceDataGridViewTextBoxColumn.DataPropertyName = "dateEcheance";
            this.dateEcheanceDataGridViewTextBoxColumn.HeaderText = "dateEcheance";
            this.dateEcheanceDataGridViewTextBoxColumn.Name = "dateEcheanceDataGridViewTextBoxColumn";
            // 
            // empruntBindingSource3
            // 
            this.empruntBindingSource3.DataMember = "emprunt";
            this.empruntBindingSource3.DataSource = this.offibook_v0DataSet2;
            // 
            // offibook_v0DataSet2
            // 
            this.offibook_v0DataSet2.DataSetName = "offibook_v0DataSet";
            this.offibook_v0DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbp_livre
            // 
            this.tbp_livre.Controls.Add(this.btn_delete);
            this.tbp_livre.Controls.Add(this.btn_update);
            this.tbp_livre.Controls.Add(this.btn_add);
            this.tbp_livre.Controls.Add(this.label2);
            this.tbp_livre.Controls.Add(this.lbl_edition);
            this.tbp_livre.Controls.Add(this.lbl_auteur);
            this.tbp_livre.Controls.Add(this.lbl_titre);
            this.tbp_livre.Controls.Add(this.lbl_isbn);
            this.tbp_livre.Controls.Add(this.txt_code);
            this.tbp_livre.Controls.Add(this.txt_edition);
            this.tbp_livre.Controls.Add(this.txt_auteur);
            this.tbp_livre.Controls.Add(this.txt_titre);
            this.tbp_livre.Controls.Add(this.txt_isbn);
            this.tbp_livre.Controls.Add(this.dtg_livre);
            this.tbp_livre.Location = new System.Drawing.Point(4, 22);
            this.tbp_livre.Name = "tbp_livre";
            this.tbp_livre.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_livre.Size = new System.Drawing.Size(978, 827);
            this.tbp_livre.TabIndex = 0;
            this.tbp_livre.Text = "Liste des livres";
            this.tbp_livre.UseVisualStyleBackColor = true;
            this.tbp_livre.Click += new System.EventHandler(this.tbp_livre_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(578, 155);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 33);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Supprimer un livre";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_2);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(424, 155);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 33);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Modifier un livre";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(263, 155);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 33);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Ajouter un livre";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Code Barre :";
            // 
            // lbl_edition
            // 
            this.lbl_edition.AutoSize = true;
            this.lbl_edition.Location = new System.Drawing.Point(506, 19);
            this.lbl_edition.Name = "lbl_edition";
            this.lbl_edition.Size = new System.Drawing.Size(45, 13);
            this.lbl_edition.TabIndex = 30;
            this.lbl_edition.Text = "Edition :";
            // 
            // lbl_auteur
            // 
            this.lbl_auteur.AutoSize = true;
            this.lbl_auteur.Location = new System.Drawing.Point(260, 100);
            this.lbl_auteur.Name = "lbl_auteur";
            this.lbl_auteur.Size = new System.Drawing.Size(44, 13);
            this.lbl_auteur.TabIndex = 29;
            this.lbl_auteur.Text = "Auteur :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(260, 62);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(34, 13);
            this.lbl_titre.TabIndex = 28;
            this.lbl_titre.Text = "Titre :";
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(260, 19);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(33, 13);
            this.lbl_isbn.TabIndex = 27;
            this.lbl_isbn.Text = "Isbn :";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(578, 59);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(126, 20);
            this.txt_code.TabIndex = 26;
            // 
            // txt_edition
            // 
            this.txt_edition.Location = new System.Drawing.Point(578, 16);
            this.txt_edition.Name = "txt_edition";
            this.txt_edition.Size = new System.Drawing.Size(126, 20);
            this.txt_edition.TabIndex = 25;
            // 
            // txt_auteur
            // 
            this.txt_auteur.Location = new System.Drawing.Point(304, 97);
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.Size = new System.Drawing.Size(126, 20);
            this.txt_auteur.TabIndex = 24;
            // 
            // txt_titre
            // 
            this.txt_titre.Location = new System.Drawing.Point(304, 59);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(126, 20);
            this.txt_titre.TabIndex = 23;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(304, 16);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(126, 20);
            this.txt_isbn.TabIndex = 22;
            // 
            // dtg_livre
            // 
            this.dtg_livre.AutoGenerateColumns = false;
            this.dtg_livre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_livre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.titreDataGridViewTextBoxColumn,
            this.auteurDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.codeBarreDataGridViewTextBoxColumn,
            this.emprunt});
            this.dtg_livre.DataSource = this.livreBindingSource1;
            this.dtg_livre.Location = new System.Drawing.Point(96, 248);
            this.dtg_livre.Name = "dtg_livre";
            this.dtg_livre.Size = new System.Drawing.Size(793, 525);
            this.dtg_livre.TabIndex = 1;
            this.dtg_livre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_livre_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "isbn";
            this.dataGridViewTextBoxColumn1.HeaderText = "isbn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            // 
            // auteurDataGridViewTextBoxColumn
            // 
            this.auteurDataGridViewTextBoxColumn.DataPropertyName = "auteur";
            this.auteurDataGridViewTextBoxColumn.HeaderText = "auteur";
            this.auteurDataGridViewTextBoxColumn.Name = "auteurDataGridViewTextBoxColumn";
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "edition";
            this.editionDataGridViewTextBoxColumn.HeaderText = "edition";
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            // 
            // codeBarreDataGridViewTextBoxColumn
            // 
            this.codeBarreDataGridViewTextBoxColumn.DataPropertyName = "codeBarre";
            this.codeBarreDataGridViewTextBoxColumn.HeaderText = "codeBarre";
            this.codeBarreDataGridViewTextBoxColumn.Name = "codeBarreDataGridViewTextBoxColumn";
            // 
            // emprunt
            // 
            this.emprunt.DataPropertyName = "emprunt";
            this.emprunt.HeaderText = "emprunt";
            this.emprunt.Name = "emprunt";
            // 
            // livreBindingSource1
            // 
            this.livreBindingSource1.DataMember = "livre";
            this.livreBindingSource1.DataSource = this.offibook_v0DataSet1;
            // 
            // offibook_v0DataSet1
            // 
            this.offibook_v0DataSet1.DataSetName = "offibook_v0DataSet";
            this.offibook_v0DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_livre);
            this.tabControl1.Controls.Add(this.tbp_emprunt);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 853);
            this.tabControl1.TabIndex = 4;
            // 
            // empruntBindingSource1
            // 
            this.empruntBindingSource1.DataMember = "emprunt";
            this.empruntBindingSource1.DataSource = this.offibook_v0DataSet1;
            // 
            // empruntBindingSource
            // 
            this.empruntBindingSource.DataMember = "emprunt";
            this.empruntBindingSource.DataSource = this.offibook_v0DataSet;
            // 
            // offibook_v0DataSet
            // 
            this.offibook_v0DataSet.DataSetName = "offibook_v0DataSet";
            this.offibook_v0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataMember = "livre";
            this.livreBindingSource.DataSource = this.offibook_v0DataSet;
            // 
            // livreTableAdapter
            // 
            this.livreTableAdapter.ClearBeforeFill = true;
            // 
            // empruntTableAdapter
            // 
            this.empruntTableAdapter.ClearBeforeFill = true;
            // 
            // empruntBindingSource2
            // 
            this.empruntBindingSource2.DataMember = "emprunt";
            this.empruntBindingSource2.DataSource = this.offibook_v0DataSet2;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 876);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_logout);
            this.Name = "frm_home";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.tbp_emprunt.ResumeLayout(false);
            this.tbp_emprunt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_emprunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet2)).EndInit();
            this.tbp_livre.ResumeLayout(false);
            this.tbp_livre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_livre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private offibook_v0DataSet offibook_v0DataSet;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private offibook_v0DataSetTableAdapters.livreTableAdapter livreTableAdapter;
        private System.Windows.Forms.BindingSource empruntBindingSource;
        private offibook_v0DataSetTableAdapters.empruntTableAdapter empruntTableAdapter;
        private offibook_v0DataSet offibook_v0DataSet1;
        private System.Windows.Forms.BindingSource livreBindingSource1;
        private System.Windows.Forms.BindingSource empruntBindingSource1;
        private System.Windows.Forms.TabPage tbp_emprunt;
        private System.Windows.Forms.DataGridView dtg_emprunt;
        private System.Windows.Forms.TabPage tbp_livre;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_edition;
        private System.Windows.Forms.Label lbl_auteur;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_edition;
        private System.Windows.Forms.TextBox txt_auteur;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.DataGridView dtg_livre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_isbn_livre;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_isbn_livre;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_deleteEmprunt;
        private System.Windows.Forms.Button btn_updateEmprunt;
        private System.Windows.Forms.Button btn_addEmprunt;
        private offibook_v0DataSet offibook_v0DataSet2;
        private System.Windows.Forms.BindingSource empruntBindingSource2;
        private System.Windows.Forms.BindingSource empruntBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livreisbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emprunt;
    }
}