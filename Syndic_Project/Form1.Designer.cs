namespace Syndic_Project
{
    partial class frmMain
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
            this.mtCop = new MetroFramework.Controls.MetroTile();
            this.mtRubrique = new MetroFramework.Controls.MetroTile();
            this.mtDepense = new MetroFramework.Controls.MetroTile();
            this.mtPaiement = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.mtLog = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtCop
            // 
            this.mtCop.ActiveControl = null;
            this.mtCop.Location = new System.Drawing.Point(37, 103);
            this.mtCop.Name = "mtCop";
            this.mtCop.Size = new System.Drawing.Size(133, 105);
            this.mtCop.TabIndex = 0;
            this.mtCop.Text = "Copropriétaires";
            this.mtCop.UseSelectable = true;
            this.mtCop.Click += new System.EventHandler(this.mtCop_Click);
            // 
            // mtRubrique
            // 
            this.mtRubrique.ActiveControl = null;
            this.mtRubrique.Location = new System.Drawing.Point(252, 103);
            this.mtRubrique.Name = "mtRubrique";
            this.mtRubrique.Size = new System.Drawing.Size(133, 105);
            this.mtRubrique.TabIndex = 1;
            this.mtRubrique.Text = "Rubrique";
            this.mtRubrique.UseSelectable = true;
            this.mtRubrique.Click += new System.EventHandler(this.mtRubrique_Click);
            // 
            // mtDepense
            // 
            this.mtDepense.ActiveControl = null;
            this.mtDepense.Location = new System.Drawing.Point(656, 103);
            this.mtDepense.Name = "mtDepense";
            this.mtDepense.Size = new System.Drawing.Size(133, 105);
            this.mtDepense.TabIndex = 2;
            this.mtDepense.Text = "Dépenses";
            this.mtDepense.UseSelectable = true;
            this.mtDepense.Click += new System.EventHandler(this.mtDepense_Click);
            // 
            // mtPaiement
            // 
            this.mtPaiement.ActiveControl = null;
            this.mtPaiement.Location = new System.Drawing.Point(37, 265);
            this.mtPaiement.Name = "mtPaiement";
            this.mtPaiement.Size = new System.Drawing.Size(133, 105);
            this.mtPaiement.TabIndex = 3;
            this.mtPaiement.Text = "Paiement";
            this.mtPaiement.UseSelectable = true;
            this.mtPaiement.Click += new System.EventHandler(this.mtPaiement_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(252, 265);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(133, 105);
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Liste des Non Payé";
            this.metroTile5.UseSelectable = true;
            // 
            // mtLog
            // 
            this.mtLog.ActiveControl = null;
            this.mtLog.Location = new System.Drawing.Point(458, 103);
            this.mtLog.Name = "mtLog";
            this.mtLog.Size = new System.Drawing.Size(133, 105);
            this.mtLog.TabIndex = 5;
            this.mtLog.Text = "Logement";
            this.mtLog.UseSelectable = true;
            this.mtLog.Click += new System.EventHandler(this.mtLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 492);
            this.Controls.Add(this.mtLog);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.mtPaiement);
            this.Controls.Add(this.mtDepense);
            this.Controls.Add(this.mtRubrique);
            this.Controls.Add(this.mtCop);
            this.Name = "frmMain";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Gestion Syndic";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCop;
        private MetroFramework.Controls.MetroTile mtRubrique;
        private MetroFramework.Controls.MetroTile mtDepense;
        private MetroFramework.Controls.MetroTile mtPaiement;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile mtLog;
    }
}

