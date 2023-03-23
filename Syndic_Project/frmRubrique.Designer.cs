namespace Syndic_Project
{
    partial class frmRubrique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRubrique = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.grilleListe = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grilleListe)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom de Rubrique :";
            // 
            // txtRubrique
            // 
            // 
            // 
            // 
            this.txtRubrique.CustomButton.Image = null;
            this.txtRubrique.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtRubrique.CustomButton.Name = "";
            this.txtRubrique.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRubrique.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRubrique.CustomButton.TabIndex = 1;
            this.txtRubrique.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRubrique.CustomButton.UseSelectable = true;
            this.txtRubrique.CustomButton.Visible = false;
            this.txtRubrique.Lines = new string[0];
            this.txtRubrique.Location = new System.Drawing.Point(236, 86);
            this.txtRubrique.MaxLength = 32767;
            this.txtRubrique.Name = "txtRubrique";
            this.txtRubrique.PasswordChar = '\0';
            this.txtRubrique.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRubrique.SelectedText = "";
            this.txtRubrique.SelectionLength = 0;
            this.txtRubrique.SelectionStart = 0;
            this.txtRubrique.ShortcutsEnabled = true;
            this.txtRubrique.Size = new System.Drawing.Size(106, 23);
            this.txtRubrique.TabIndex = 1;
            this.txtRubrique.UseSelectable = true;
            this.txtRubrique.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRubrique.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(152, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grilleListe
            // 
            this.grilleListe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.grilleListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grilleListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilleListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grilleListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grilleListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilleListe.DefaultCellStyle = dataGridViewCellStyle3;
            this.grilleListe.EnableHeadersVisualStyles = false;
            this.grilleListe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grilleListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grilleListe.Location = new System.Drawing.Point(52, 189);
            this.grilleListe.Name = "grilleListe";
            this.grilleListe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilleListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grilleListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grilleListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleListe.Size = new System.Drawing.Size(290, 150);
            this.grilleListe.Style = MetroFramework.MetroColorStyle.Green;
            this.grilleListe.TabIndex = 3;
            // 
            // frmRubrique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 380);
            this.Controls.Add(this.grilleListe);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRubrique);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmRubrique";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Rubrique";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.frmRubrique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRubrique;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroGrid grilleListe;
    }
}