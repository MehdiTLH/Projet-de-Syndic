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
    public partial class frmDepenses : MetroFramework.Forms.MetroForm
    {
        public frmDepenses()
        {
            InitializeComponent();
        }

        private void frmDepenses_Load(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 db = new DB_SyndicEntities1())
            {
                var q = (from c in db.Rubriques
                         select c).ToList();
                
                comboRubName.DataSource = q;
                comboRubName.DisplayMember = "NomRubrique";
                comboRubName.ValueMember = "NomRubrique";

                {

                    var list = (from c in db.Depenses

                                select new {  c.Rubrique, c.NomDepense, c.MontantDepense, c.DateDepense }).ToList();

                    grilleListeDep.DataSource = list;
                }
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string rub = comboRubName.Text;
            string dep = txtDepName.Text;
            DateTime date = DateTime.Parse(dtDep.Text);

            using (DB_SyndicEntities1 context = new DB_SyndicEntities1())
            {
                {
                    if (txtDepName.Text == "" || comboRubName.Text == "" || dtDep.Text == "" || txtMontant.Text == "")
                    {
                        MessageBox.Show("Veuillez Remplir toutes les zones texte");
                    }

                    else
                    {
                        context.Depenses.Add(new Depense { Rubrique = rub, NomDepense = dep, DateDepense = date, MontantDepense = float.Parse(txtMontant.Text) });
                        context.SaveChanges();
                        MessageBox.Show("Ajouter avec succées");
                        txtDepName.Text = "";
                        txtMontant.Text = "";

                    }


                    var list = (from c in context.Depenses

                                select new { c.Rubrique, c.NomDepense, c.MontantDepense, c.DateDepense }).ToList();

                    grilleListeDep.DataSource = list;
                }
            }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDepName.Text = "";
            txtMontant.Text = "";
        }
    }
}
