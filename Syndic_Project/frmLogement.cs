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
    public partial class frmLogement : MetroFramework.Forms.MetroForm
    {
        public DB_SyndicEntities1 db = new DB_SyndicEntities1();
        public frmLogement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 dba = new DB_SyndicEntities1())
            {
                if(txtNumLog.Text=="")
                {
                    //MetroFramework.MetroMessageBox("Inserer")
                }
                else
                {
                    int NumLog = int.Parse(txtNumLog.Text);
                    dba.Logements.Add(new Logement { NumLogement = NumLog });
                    dba.SaveChanges();
                    MessageBox.Show("Ajouter");
                    var listLog = (from c in db.Logements
                                   select new { c.NumLogement }).ToList();
                    grilleListeLogement.DataSource = listLog;

                }
            }
        }

        private void frmLogement_Load(object sender, EventArgs e)
        {
            var listLog = (from c in db.Logements
                            select new {c.NumLogement }).ToList();
            grilleListeLogement.DataSource = listLog;
        }
    }
}
