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
    public partial class frmPaiement : MetroFramework.Forms.MetroForm
    {
        public frmPaiement()
        {
            InitializeComponent();
        }

        private void frmPaiement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SyndicDataSetLogemntCop.Logement' table. You can move, or remove it, as needed.
            //this.logementTableAdapter.Fill(this.dB_SyndicDataSetLogemntCop.Logement);
            using (DB_SyndicEntities1 db = new DB_SyndicEntities1())
            {
                var listcin = (from c in db.Coproprietaires
                               select new { c.CinCop }).ToList();
                ComboCin.DataSource = listcin;
                ComboCin.DisplayMember = "CinCop";
                ComboCin.ValueMember = "CinCop";
            }
        }

        private void ComboCin_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 db = new DB_SyndicEntities1())
            {
                var listlog = (from c in db.Logements
                               where( c.NumLogement==(int.Parse(ComboCin.ValueMember)))
                               select new { c }).ToList();
                ComboLog.DataSource = listlog;
                ComboLog.DisplayMember = "NumLogement";
                ComboLog.ValueMember = "NumLogement";
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            int cin = int.Parse(ComboCin.Text);
            //int log = int.Parse(ComboLog.Text);
            if (txtMontant.Text != "" && txtNbrMois.Text != "" && txtNomPayeur.Text != "")
            {
                using (DB_SyndicEntities1 db = new DB_SyndicEntities1())
                {
                    int mm = 1;
                    int nbrmois = int.Parse(txtNbrMois.Text);
                    int mois = int.Parse(metroDateTime1.Value.Month.ToString());
                    int annee = int.Parse(metroDateTime1.Value.Year.ToString());
                    var log =int.Parse( ComboLog.Text);
                    var nomp = txtNomPayeur.Text;
                    var montant = txtMontant.Text;
                    Paiement p = new Paiement { CinCop = cin, NumLogement = log, NomPayeur = nomp, Datepaiement = metroDateTime1.Value, NbrMois = nbrmois, MontatP = int.Parse(montant) };
                    db.Paiements.Add(p);
                    db.SaveChanges();
                    //for (int i = 0; i < nbrmois; i++)
                    //{
                    //    if (mois > 12)
                    //    {
                    //        Statupaiement s = new Statupaiement { CinCoproprio = cin, NomLogement = log, Mois = mm, Annee = annee + 1 };
                    //        db.Statupaiements.Add(s);
                    //        db.SaveChanges();
                    //        mm++;
                    //    }
                    //    else
                    //    {
                    //        Statupaiement s = new Statupaiement { CinCoproprio = cin, NomLogement = log, Mois = mois, Annee = annee };
                    //        db.Statupaiements.Add(s);
                    //        db.SaveChanges();
                    //        mois++;
                    //    }
                    //}
                    MessageBox.Show("Insertion Effectuee ! ", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMontant.Clear();
                    txtNbrMois.Clear();
                    txtNomPayeur.Clear();
                    //groupBox2.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir les champs! ", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
