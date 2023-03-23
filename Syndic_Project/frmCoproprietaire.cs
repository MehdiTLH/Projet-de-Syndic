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
    public partial class frmCoproprietaire : MetroFramework.Forms.MetroForm
    {
        public DB_SyndicEntities1 db = new DB_SyndicEntities1();
        public frmCoproprietaire()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //txtCin.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            ComboNumLog.Text = "";
            txtMail.Clear();
            txtTel.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 dba = new DB_SyndicEntities1())
            {
                if (/*txtCin.Text != "" && */txtMail.Text != "" && txtNom.Text != "" && txtPrenom.Text != "" && txtTel.Text != "" && ComboNumLog.Text != "")
                {
                    //int cin = int.Parse(txtCin.Text);
                    string email = txtMail.Text;
                    string nom = txtNom.Text;
                    string prenom = txtPrenom.Text;
                    int tel = int.Parse(txtTel.Text);
                    int log = int.Parse(ComboNumLog.Text);


                    try
                    {
                        dba.Coproprietaires.Add(new Coproprietaire { /*CinCop = cin*/ NomCop = nom, PrenomCop = prenom, NumLogement = log, Email = email, Tel = tel });
                        dba.SaveChanges();
                        //MessageBox.Show("okok");
                        //MetroFramework.MetroMessageBox.Show("Insertion Effectuee ! ", "Insertion", MetroMessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Insertion Effectuee ! ", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var listcopr = (from c in dba.Coproprietaires
                                        select new { c.CinCop, c.NumLogement, c.PrenomCop, c.NomCop, c.Email, c.Tel }).ToList();
                        grilleListeCop.DataSource = listcopr;
                        //var listtypelog = (from t in db.TypeLogements
                        //                   select t).ToList();
                        //combotypelogement.DataSource = listtypelog;
                        //combotypelogement.DisplayMember = "NomType";
                        //txtCin.Clear();
                        txtMail.Clear();
                        txtNom.Clear();
                        txtPrenom.Clear();
                        txtTel.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else

                    MessageBox.Show("Un ou plusieurs champs vides ! ", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //int cin = int.Parse(txtCin.Text);
            //var LogementExist = db.Logements.Any(c=> c. = )
        }

        private void metroTabPageNew_Click(object sender, EventArgs e)
        {

        }

        private void frmCoproprietaire_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dB_SyndicDataSet1.Logement' table. You can move, or remove it, as needed.
            //this.logementTableAdapter.Fill(this.dB_SyndicDataSet1.Logement);
            //// TODO: This line of code loads data into the 'dB_SyndicDataSet.Coproprietaire' table. You can move, or remove it, as needed.
            //this.coproprietaireTableAdapter.Fill(this.dB_SyndicDataSet.Coproprietaire);
            var listcop = (from c in db.Coproprietaires
                           select new { c.CinCop, c.NumLogement, c.PrenomCop, c.NomCop, c.Email, c.Tel }).ToList();
            grilleListeCop.DataSource = listcop;
            var q = (from c in db.Logements
                     select c).ToList();

            ComboNumLog.DataSource = q;
            ComboNumLog.ValueMember = "NumLogement";
            ComboNumLog.DisplayMember = "NumLogement";

            var qu = (from d in db.Coproprietaires
                      select d).ToList();
            ComboBoxCin.DataSource = qu;
            ComboBoxCin.ValueMember = "CinCop";
            ComboBoxCin.DisplayMember = "CinCop";
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 context = new DB_SyndicEntities1())
            {
                var co = context.Coproprietaires.Where(c => c.CinCop.ToString() == ComboBoxCin.Text).First();
                context.Coproprietaires.Remove(co);
                context.SaveChanges();
                MessageBox.Show("Supprimer avec succés");
               
                var list = (from c in context.Coproprietaires

                            select new { c.CinCop, c.NumLogement, c.PrenomCop, c.NomCop, c.Email, c.Tel }).ToList();

                grilleListeCop.DataSource = list;
            }
        }
    }
}
