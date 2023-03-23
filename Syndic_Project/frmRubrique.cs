using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndic_Project
{
    public partial class frmRubrique : MetroFramework.Forms.MetroForm
    {
        public DB_SyndicEntities1 db = new DB_SyndicEntities1();
        public frmRubrique()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 dba = new DB_SyndicEntities1())
            {
                if (txtRubrique.Text == "")
                {
                    //MetroFramework.MetroMessageBox("Inserer")
                    MessageBox.Show("Champs Obligatoires ");
                }
                else
                {
                    string NomRub = txtRubrique.Text;
                    dba.Rubriques.Add(new Rubrique { NomRubrique = NomRub });
                    dba.SaveChanges();
                    MessageBox.Show("Ajouter");
                    var listRub = (from c in db.Rubriques
                                   select new { c.NomRubrique }).ToList();
                    grilleListe.DataSource = listRub;


                }
            }
        }

        private void frmRubrique_Load(object sender, EventArgs e)
        {
            var listRub = (from c in db.Rubriques
                           select new { c.NomRubrique }).ToList();
            grilleListe.DataSource = listRub;

        }
    }
}
