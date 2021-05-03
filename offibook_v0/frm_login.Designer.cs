
namespace offibook_v0
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.offibook_v0DataSet = new offibook_v0.offibook_v0DataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new offibook_v0.offibook_v0DataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new offibook_v0.offibook_v0DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_password.Location = new System.Drawing.Point(182, 187);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(98, 18);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Mot de passe";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_login.Location = new System.Drawing.Point(182, 83);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(45, 18);
            this.lbl_login.TabIndex = 12;
            this.lbl_login.Text = "Email";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // tbx_password
            // 
            this.tbx_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(185, 208);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(399, 29);
            this.tbx_password.TabIndex = 11;
            this.tbx_password.UseSystemPasswordChar = true;
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
            // 
            // tbx_login
            // 
            this.tbx_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_login.Location = new System.Drawing.Point(185, 104);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(399, 29);
            this.tbx_login.TabIndex = 10;
            this.tbx_login.TextChanged += new System.EventHandler(this.tbx_login_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(320, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 49);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // offibook_v0DataSet
            // 
            this.offibook_v0DataSet.DataSetName = "offibook_v0DataSet";
            this.offibook_v0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.offibook_v0DataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.empruntTableAdapter = null;
            this.tableAdapterManager.livreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = offibook_v0.offibook_v0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 441);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_login);
            this.Name = "frm_login";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offibook_v0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.Button btnLogin;
        private offibook_v0DataSet offibook_v0DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private offibook_v0DataSetTableAdapters.userTableAdapter userTableAdapter;
        private offibook_v0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

