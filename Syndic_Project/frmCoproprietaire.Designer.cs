namespace Syndic_Project
{
    partial class frmCoproprietaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SyndicDataSet1 = new Syndic_Project.DB_SyndicDataSet1();
            this.dB_SyndicDataSet = new Syndic_Project.DB_SyndicDataSet();
            this.coproprietaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coproprietaireTableAdapter = new Syndic_Project.DB_SyndicDataSetTableAdapters.CoproprietaireTableAdapter();
            this.logementTableAdapter = new Syndic_Project.DB_SyndicDataSet1TableAdapters.LogementTableAdapter();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnSupp = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxCin = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPageNew = new MetroFramework.Controls.MetroTabPage();
            this.ComboNumLog = new MetroFramework.Controls.MetroComboBox();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtTel = new MetroFramework.Controls.MetroTextBox();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.txtPrenom = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.grilleListeCop = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.logementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SyndicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SyndicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coproprietaireBindingSource)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPageNew.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleListeCop)).BeginInit();
            this.SuspendLayout();
            // 
            // logementBindingSource
            // 
            this.logementBindingSource.DataMember = "Logement";
            this.logementBindingSource.DataSource = this.dB_SyndicDataSet1;
            // 
            // dB_SyndicDataSet1
            // 
            this.dB_SyndicDataSet1.DataSetName = "DB_SyndicDataSet1";
            this.dB_SyndicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dB_SyndicDataSet
            // 
            this.dB_SyndicDataSet.DataSetName = "DB_SyndicDataSet";
            this.dB_SyndicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coproprietaireBindingSource
            // 
            this.coproprietaireBindingSource.DataMember = "Coproprietaire";
            this.coproprietaireBindingSource.DataSource = this.dB_SyndicDataSet;
            // 
            // coproprietaireTableAdapter
            // 
            this.coproprietaireTableAdapter.ClearBeforeFill = true;
            // 
            // logementTableAdapter
            // 
            this.logementTableAdapter.ClearBeforeFill = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnSupp);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.ComboBoxCin);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(806, 287);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Supprimer";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(263, 127);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(122, 47);
            this.btnSupp.TabIndex = 8;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseSelectable = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(186, 64);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Cin :";
            // 
            // ComboBoxCin
            // 
            this.ComboBoxCin.FormattingEnabled = true;
            this.ComboBoxCin.ItemHeight = 23;
            this.ComboBoxCin.Location = new System.Drawing.Point(332, 54);
            this.ComboBoxCin.Name = "ComboBoxCin";
            this.ComboBoxCin.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxCin.TabIndex = 6;
            this.ComboBoxCin.UseSelectable = true;
            // 
            // metroTabPageNew
            // 
            this.metroTabPageNew.Controls.Add(this.ComboNumLog);
            this.metroTabPageNew.Controls.Add(this.btnNew);
            this.metroTabPageNew.Controls.Add(this.btnAdd);
            this.metroTabPageNew.Controls.Add(this.txtTel);
            this.metroTabPageNew.Controls.Add(this.txtMail);
            this.metroTabPageNew.Controls.Add(this.txtPrenom);
            this.metroTabPageNew.Controls.Add(this.txtNom);
            this.metroTabPageNew.Controls.Add(this.metroLabel6);
            this.metroTabPageNew.Controls.Add(this.metroLabel5);
            this.metroTabPageNew.Controls.Add(this.metroLabel4);
            this.metroTabPageNew.Controls.Add(this.metroLabel3);
            this.metroTabPageNew.Controls.Add(this.metroLabel2);
            this.metroTabPageNew.HorizontalScrollbarBarColor = true;
            this.metroTabPageNew.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageNew.HorizontalScrollbarSize = 10;
            this.metroTabPageNew.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageNew.Name = "metroTabPageNew";
            this.metroTabPageNew.Size = new System.Drawing.Size(806, 287);
            this.metroTabPageNew.TabIndex = 0;
            this.metroTabPageNew.Text = "Ajouter";
            this.metroTabPageNew.VerticalScrollbarBarColor = true;
            this.metroTabPageNew.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageNew.VerticalScrollbarSize = 10;
            this.metroTabPageNew.Click += new System.EventHandler(this.metroTabPageNew_Click);
            // 
            // ComboNumLog
            // 
            this.ComboNumLog.DataSource = this.logementBindingSource;
            this.ComboNumLog.DisplayMember = "NumLogement";
            this.ComboNumLog.FormattingEnabled = true;
            this.ComboNumLog.ItemHeight = 23;
            this.ComboNumLog.Location = new System.Drawing.Point(157, 142);
            this.ComboNumLog.Name = "ComboNumLog";
            this.ComboNumLog.Size = new System.Drawing.Size(112, 29);
            this.ComboNumLog.TabIndex = 16;
            this.ComboNumLog.UseSelectable = true;
            this.ComboNumLog.ValueMember = "NumLogement";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(506, 131);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 40);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(506, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTel
            // 
            // 
            // 
            // 
            this.txtTel.CustomButton.Image = null;
            this.txtTel.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtTel.CustomButton.Name = "";
            this.txtTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTel.CustomButton.TabIndex = 1;
            this.txtTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTel.CustomButton.UseSelectable = true;
            this.txtTel.CustomButton.Visible = false;
            this.txtTel.Lines = new string[0];
            this.txtTel.Location = new System.Drawing.Point(157, 239);
            this.txtTel.MaxLength = 32767;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.ShortcutsEnabled = true;
            this.txtTel.Size = new System.Drawing.Size(112, 23);
            this.txtTel.TabIndex = 13;
            this.txtTel.UseSelectable = true;
            this.txtTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(157, 189);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(112, 23);
            this.txtMail.TabIndex = 12;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrenom
            // 
            // 
            // 
            // 
            this.txtPrenom.CustomButton.Image = null;
            this.txtPrenom.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtPrenom.CustomButton.Name = "";
            this.txtPrenom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrenom.CustomButton.TabIndex = 1;
            this.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrenom.CustomButton.UseSelectable = true;
            this.txtPrenom.CustomButton.Visible = false;
            this.txtPrenom.Lines = new string[0];
            this.txtPrenom.Location = new System.Drawing.Point(157, 101);
            this.txtPrenom.MaxLength = 32767;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.ShortcutsEnabled = true;
            this.txtPrenom.Size = new System.Drawing.Size(112, 23);
            this.txtPrenom.TabIndex = 10;
            this.txtPrenom.UseSelectable = true;
            this.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNom
            // 
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(157, 58);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(112, 23);
            this.txtNom.TabIndex = 9;
            this.txtNom.UseSelectable = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 243);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Telephone :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 193);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Email :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Numero Logement :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Prenom :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nom : ";
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPageNew);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Controls.Add(this.metroTabPage3);
            this.metroTabControl.Location = new System.Drawing.Point(23, 77);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(814, 329);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.grilleListeCop);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(806, 287);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Afficher";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // grilleListeCop
            // 
            this.grilleListeCop.AllowUserToAddRows = false;
            this.grilleListeCop.AllowUserToDeleteRows = false;
            this.grilleListeCop.AllowUserToResizeRows = false;
            this.grilleListeCop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleListeCop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListeCop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilleListeCop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grilleListeCop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListeCop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grilleListeCop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilleListeCop.DefaultCellStyle = dataGridViewCellStyle5;
            this.grilleListeCop.EnableHeadersVisualStyles = false;
            this.grilleListeCop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grilleListeCop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListeCop.Location = new System.Drawing.Point(28, 18);
            this.grilleListeCop.Name = "grilleListeCop";
            this.grilleListeCop.ReadOnly = true;
            this.grilleListeCop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListeCop.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grilleListeCop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grilleListeCop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleListeCop.Size = new System.Drawing.Size(564, 250);
            this.grilleListeCop.TabIndex = 2;
            // 
            // frmCoproprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 429);
            this.Controls.Add(this.metroTabControl);
            this.Name = "frmCoproprietaire";
            this.Text = "Copropriétaire";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmCoproprietaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SyndicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SyndicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coproprietaireBindingSource)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPageNew.ResumeLayout(false);
            this.metroTabPageNew.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleListeCop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DB_SyndicDataSet dB_SyndicDataSet;
        private System.Windows.Forms.BindingSource coproprietaireBindingSource;
        private DB_SyndicDataSetTableAdapters.CoproprietaireTableAdapter coproprietaireTableAdapter;
        private DB_SyndicDataSet1 dB_SyndicDataSet1;
        private System.Windows.Forms.BindingSource logementBindingSource;
        private DB_SyndicDataSet1TableAdapters.LogementTableAdapter logementTableAdapter;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnSupp;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox ComboBoxCin;
        private MetroFramework.Controls.MetroTabPage metroTabPageNew;
        private MetroFramework.Controls.MetroComboBox ComboNumLog;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtTel;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroTextBox txtPrenom;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroGrid grilleListeCop;
    }
}