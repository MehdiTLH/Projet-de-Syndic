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
    public partial class frmStatusPaiement : MetroFramework.Forms.MetroForm
    {
        public frmStatusPaiement()
        {
            InitializeComponent();
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            using (DB_SyndicEntities1 db = new DB_SyndicEntities1())
            {
                System.Drawing.Color red = System.Drawing.ColorTranslator.FromHtml("#eb3036");
                System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#00d849");
                System.Drawing.Color white = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                int annee = metroDateTime1.Value.Year;
                int mois = metroDateTime1.Value.Month;
                var listcoprall = (from c in db.Coproprietaires
                                   select new { c.CinCop, c.NomCop, c.PrenomCop, c.NumLogement,  c.Email, c.Tel }).ToList();
                var listcopr = (from c in db.Coproprietaires
                                    //join s in db.Statupaiements on c.CINcopr equals s.CinCoproprio
                                    //where s.Annee == annee && s.Mois == mois
                                select new { c.CinCop, c.NomCop, c.PrenomCop, c.NumLogement, c.Email, c.Tel }).ToList();
                //groupBox2.Visible = true;
                GrilleStatuCop.Visible = true;
                GrilleStatuCop.DataSource = listcoprall;
                foreach (DataGridViewRow item in GrilleStatuCop.Rows)
                {
                    string vv = item.Cells[0].Value.ToString();
                    item.DefaultCellStyle.BackColor = white;
                    foreach (var cc in listcopr)
                    {
                        //if (vv == int.Parse(cc.CinCop))
                        //{
                        //    item.DefaultCellStyle.BackColor = green;
                        //}
                        //else if (item.DefaultCellStyle.BackColor == white)
                        //{
                        //    item.DefaultCellStyle.BackColor = red;
                        //}
                    }
                }
            }
        }

        private void frmStatusPaiement_Load(object sender, EventArgs e)
        {

        }
    }
}
