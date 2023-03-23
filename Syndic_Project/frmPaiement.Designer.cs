namespace Syndic_Project
{
    partial class frmPaiement
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
            this.ComboCin = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.ComboLog = new MetroFramework.Controls.MetroComboBox();
            this.txtNomPayeur = new MetroFramework.Controls.MetroTextBox();
            this.txtNbrMois = new MetroFramework.Controls.MetroTextBox();
            this.txtMontant = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btnADD = new MetroFramework.Controls.MetroButton();
            this.dB_SyndicDataSetLogemntCop = new Syndic_Project.DB_SyndicDataSetLogemntCop();
            this.dBSyndicDataSetLogemntCopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logementTableAdapter = new Syndic_Project.DB_SyndicDataSetLogemntCopTableAdapters.LogementTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SyndicDataSetLogemntCop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSyndicDataSetLogemntCopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboCin
            // 
            this.ComboCin.FormattingEnabled = true;
            this.ComboCin.ItemHeight = 23;
            this.ComboCin.Location = new System.Drawing.Point(250, 104);
            this.ComboCin.Name = "ComboCin";
            this.ComboCin.Size = new System.Drawing.Size(121, 29);
            this.ComboCin.TabIndex = 0;
            this.ComboCin.UseSelectable = true;
            this.ComboCin.SelectedIndexChanged += new System.EventHandler(this.ComboCin_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Cin Cop :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "NumLogement : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Nom Payeur :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(39, 240);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Nombre de mois :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(39, 279);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Date Paiement :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(39, 318);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(143, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Montant fix d\'un mois :";
            // 
            // ComboLog
            // 
            this.ComboLog.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.logementBindingSource, "NumLogement", true));
            this.ComboLog.DataSource = this.logementBindingSource;
            this.ComboLog.DisplayMember = "NumLogement";
            this.ComboLog.FormattingEnabled = true;
            this.ComboLog.ItemHeight = 23;
            this.ComboLog.Location = new System.Drawing.Point(250, 146);
            this.ComboLog.Name = "ComboLog";
            this.ComboLog.Size = new System.Drawing.Size(121, 29);
            this.ComboLog.TabIndex = 0;
            this.ComboLog.UseSelectable = true;
            this.ComboLog.ValueMember = "NumLogement";
            // 
            // txtNomPayeur
            // 
            // 
            // 
            // 
            this.txtNomPayeur.CustomButton.Image = null;
            this.txtNomPayeur.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtNomPayeur.CustomButton.Name = "";
            this.txtNomPayeur.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomPayeur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomPayeur.CustomButton.TabIndex = 1;
            this.txtNomPayeur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomPayeur.CustomButton.UseSelectable = true;
            this.txtNomPayeur.CustomButton.Visible = false;
            this.txtNomPayeur.Lines = new string[0];
            this.txtNomPayeur.Location = new System.Drawing.Point(250, 198);
            this.txtNomPayeur.MaxLength = 32767;
            this.txtNomPayeur.Name = "txtNomPayeur";
            this.txtNomPayeur.PasswordChar = '\0';
            this.txtNomPayeur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomPayeur.SelectedText = "";
            this.txtNomPayeur.SelectionLength = 0;
            this.txtNomPayeur.SelectionStart = 0;
            this.txtNomPayeur.ShortcutsEnabled = true;
            this.txtNomPayeur.Size = new System.Drawing.Size(121, 23);
            this.txtNomPayeur.TabIndex = 2;
            this.txtNomPayeur.UseSelectable = true;
            this.txtNomPayeur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomPayeur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNbrMois
            // 
            // 
            // 
            // 
            this.txtNbrMois.CustomButton.Image = null;
            this.txtNbrMois.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtNbrMois.CustomButton.Name = "";
            this.txtNbrMois.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNbrMois.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNbrMois.CustomButton.TabIndex = 1;
            this.txtNbrMois.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNbrMois.CustomButton.UseSelectable = true;
            this.txtNbrMois.CustomButton.Visible = false;
            this.txtNbrMois.Lines = new string[0];
            this.txtNbrMois.Location = new System.Drawing.Point(250, 227);
            this.txtNbrMois.MaxLength = 32767;
            this.txtNbrMois.Name = "txtNbrMois";
            this.txtNbrMois.PasswordChar = '\0';
            this.txtNbrMois.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNbrMois.SelectedText = "";
            this.txtNbrMois.SelectionLength = 0;
            this.txtNbrMois.SelectionStart = 0;
            this.txtNbrMois.ShortcutsEnabled = true;
            this.txtNbrMois.Size = new System.Drawing.Size(121, 23);
            this.txtNbrMois.TabIndex = 2;
            this.txtNbrMois.UseSelectable = true;
            this.txtNbrMois.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNbrMois.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMontant
            // 
            // 
            // 
            // 
            this.txtMontant.CustomButton.Image = null;
            this.txtMontant.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtMontant.CustomButton.Name = "";
            this.txtMontant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontant.CustomButton.TabIndex = 1;
            this.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontant.CustomButton.UseSelectable = true;
            this.txtMontant.CustomButton.Visible = false;
            this.txtMontant.Lines = new string[] {
        "100"};
            this.txtMontant.Location = new System.Drawing.Point(250, 314);
            this.txtMontant.MaxLength = 32767;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontant.SelectedText = "";
            this.txtMontant.SelectionLength = 0;
            this.txtMontant.SelectionStart = 0;
            this.txtMontant.ShortcutsEnabled = true;
            this.txtMontant.Size = new System.Drawing.Size(121, 23);
            this.txtMontant.TabIndex = 2;
            this.txtMontant.Text = "100";
            this.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontant.UseSelectable = true;
            this.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(250, 277);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(121, 29);
            this.metroDateTime1.TabIndex = 3;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(188, 372);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(119, 61);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "&Ajouter";
            this.btnADD.UseSelectable = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // dB_SyndicDataSetLogemntCop
            // 
            this.dB_SyndicDataSetLogemntCop.DataSetName = "DB_SyndicDataSetLogemntCop";
            this.dB_SyndicDataSetLogemntCop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBSyndicDataSetLogemntCopBindingSource
            // 
            this.dBSyndicDataSetLogemntCopBindingSource.DataSource = this.dB_SyndicDataSetLogemntCop;
            this.dBSyndicDataSetLogemntCopBindingSource.Position = 0;
            // 
            // logementBindingSource
            // 
            this.logementBindingSource.DataMember = "Logement";
            this.logementBindingSource.DataSource = this.dBSyndicDataSetLogemntCopBindingSource;
            // 
            // logementTableAdapter
            // 
            this.logementTableAdapter.ClearBeforeFill = true;
            // 
            // frmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 527);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtNbrMois);
            this.Controls.Add(this.txtNomPayeur);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ComboLog);
            this.Controls.Add(this.ComboCin);
            this.Name = "frmPaiement";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Paiement";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmPaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_SyndicDataSetLogemntCop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSyndicDataSetLogemntCopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboCin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox ComboLog;
        private MetroFramework.Controls.MetroTextBox txtNomPayeur;
        private MetroFramework.Controls.MetroTextBox txtNbrMois;
        private MetroFramework.Controls.MetroTextBox txtMontant;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton btnADD;
        private System.Windows.Forms.BindingSource dBSyndicDataSetLogemntCopBindingSource;
        private DB_SyndicDataSetLogemntCop dB_SyndicDataSetLogemntCop;
        private System.Windows.Forms.BindingSource logementBindingSource;
        private DB_SyndicDataSetLogemntCopTableAdapters.LogementTableAdapter logementTableAdapter;
    }
}