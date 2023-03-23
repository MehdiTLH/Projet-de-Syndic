namespace Syndic_Project
{
    partial class frmDepenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDepName = new MetroFramework.Controls.MetroTextBox();
            this.txtMontant = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtDep = new MetroFramework.Controls.MetroDateTime();
            this.grilleListeDep = new MetroFramework.Controls.MetroGrid();
            this.btnADD = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.comboRubName = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilleListeDep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDepName
            // 
            // 
            // 
            // 
            this.txtDepName.CustomButton.Image = null;
            this.txtDepName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtDepName.CustomButton.Name = "";
            this.txtDepName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDepName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepName.CustomButton.TabIndex = 1;
            this.txtDepName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepName.CustomButton.UseSelectable = true;
            this.txtDepName.CustomButton.Visible = false;
            this.txtDepName.Lines = new string[0];
            this.txtDepName.Location = new System.Drawing.Point(249, 160);
            this.txtDepName.MaxLength = 32767;
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.PasswordChar = '\0';
            this.txtDepName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepName.SelectedText = "";
            this.txtDepName.SelectionLength = 0;
            this.txtDepName.SelectionStart = 0;
            this.txtDepName.ShortcutsEnabled = true;
            this.txtDepName.Size = new System.Drawing.Size(200, 23);
            this.txtDepName.TabIndex = 0;
            this.txtDepName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDepName.UseSelectable = true;
            this.txtDepName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMontant
            // 
            // 
            // 
            // 
            this.txtMontant.CustomButton.Image = null;
            this.txtMontant.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtMontant.CustomButton.Name = "";
            this.txtMontant.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontant.CustomButton.TabIndex = 1;
            this.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontant.CustomButton.UseSelectable = true;
            this.txtMontant.CustomButton.Visible = false;
            this.txtMontant.Lines = new string[0];
            this.txtMontant.Location = new System.Drawing.Point(249, 201);
            this.txtMontant.MaxLength = 32767;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontant.SelectedText = "";
            this.txtMontant.SelectionLength = 0;
            this.txtMontant.SelectionStart = 0;
            this.txtMontant.ShortcutsEnabled = true;
            this.txtMontant.Size = new System.Drawing.Size(200, 23);
            this.txtMontant.TabIndex = 0;
            this.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontant.UseSelectable = true;
            this.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(65, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nom Rubrique :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(65, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nom Dépenses :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(65, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Montant :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(65, 251);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Date Dépenses :";
            // 
            // dtDep
            // 
            this.dtDep.Location = new System.Drawing.Point(249, 251);
            this.dtDep.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDep.Name = "dtDep";
            this.dtDep.Size = new System.Drawing.Size(200, 29);
            this.dtDep.TabIndex = 2;
            // 
            // grilleListeDep
            // 
            this.grilleListeDep.AllowUserToResizeRows = false;
            this.grilleListeDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleListeDep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListeDep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilleListeDep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grilleListeDep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListeDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilleListeDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilleListeDep.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilleListeDep.EnableHeadersVisualStyles = false;
            this.grilleListeDep.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grilleListeDep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListeDep.Location = new System.Drawing.Point(65, 333);
            this.grilleListeDep.Name = "grilleListeDep";
            this.grilleListeDep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListeDep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilleListeDep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grilleListeDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleListeDep.Size = new System.Drawing.Size(240, 150);
            this.grilleListeDep.Style = MetroFramework.MetroColorStyle.Yellow;
            this.grilleListeDep.TabIndex = 3;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(731, 115);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(100, 46);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Ajouter";
            this.btnADD.UseSelectable = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(731, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Supprimer ";
            this.btnDelete.UseSelectable = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(731, 234);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 46);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // comboRubName
            // 
            this.comboRubName.FormattingEnabled = true;
            this.comboRubName.ItemHeight = 23;
            this.comboRubName.Location = new System.Drawing.Point(249, 115);
            this.comboRubName.Name = "comboRubName";
            this.comboRubName.Size = new System.Drawing.Size(200, 29);
            this.comboRubName.TabIndex = 5;
            this.comboRubName.UseSelectable = true;
            // 
            // frmDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 504);
            this.Controls.Add(this.comboRubName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.grilleListeDep);
            this.Controls.Add(this.dtDep);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtDepName);
            this.Name = "frmDepenses";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Dépenses";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleListeDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtDepName;
        private MetroFramework.Controls.MetroTextBox txtMontant;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtDep;
        private MetroFramework.Controls.MetroGrid grilleListeDep;
        private MetroFramework.Controls.MetroButton btnADD;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroComboBox comboRubName;
    }
}