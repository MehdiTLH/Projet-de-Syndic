namespace Syndic_Project
{
    partial class frmLogement
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNumLog = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grilleListeLogement = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grilleListeLogement)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Numero de Logement :";
            // 
            // txtNumLog
            // 
            // 
            // 
            // 
            this.txtNumLog.CustomButton.Image = null;
            this.txtNumLog.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtNumLog.CustomButton.Name = "";
            this.txtNumLog.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumLog.CustomButton.TabIndex = 1;
            this.txtNumLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumLog.CustomButton.UseSelectable = true;
            this.txtNumLog.CustomButton.Visible = false;
            this.txtNumLog.Lines = new string[0];
            this.txtNumLog.Location = new System.Drawing.Point(228, 87);
            this.txtNumLog.MaxLength = 32767;
            this.txtNumLog.Name = "txtNumLog";
            this.txtNumLog.PasswordChar = '\0';
            this.txtNumLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumLog.SelectedText = "";
            this.txtNumLog.SelectionLength = 0;
            this.txtNumLog.SelectionStart = 0;
            this.txtNumLog.ShortcutsEnabled = true;
            this.txtNumLog.Size = new System.Drawing.Size(97, 23);
            this.txtNumLog.TabIndex = 1;
            this.txtNumLog.UseSelectable = true;
            this.txtNumLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 212);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(212, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Liste des Numéros des logements :";
            // 
            // grilleListeLogement
            // 
            this.grilleListeLogement.AllowUserToResizeRows = false;
            this.grilleListeLogement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListeLogement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilleListeLogement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grilleListeLogement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListeLogement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilleListeLogement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilleListeLogement.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilleListeLogement.EnableHeadersVisualStyles = false;
            this.grilleListeLogement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grilleListeLogement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListeLogement.Location = new System.Drawing.Point(126, 256);
            this.grilleListeLogement.Name = "grilleListeLogement";
            this.grilleListeLogement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListeLogement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilleListeLogement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grilleListeLogement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleListeLogement.Size = new System.Drawing.Size(240, 72);
            this.grilleListeLogement.Style = MetroFramework.MetroColorStyle.Magenta;
            this.grilleListeLogement.TabIndex = 4;
            // 
            // frmLogement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 351);
            this.Controls.Add(this.grilleListeLogement);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumLog);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmLogement";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Logement";
            this.Load += new System.EventHandler(this.frmLogement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleListeLogement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNumLog;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid grilleListeLogement;
    }
}