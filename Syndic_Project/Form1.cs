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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void mtCop_Click(object sender, EventArgs e)
        {
            using (frmCoproprietaire f = new frmCoproprietaire())
            {
                f.ShowDialog();
            }
        }

        private void mtLog_Click(object sender, EventArgs e)
        {
            using (frmLogement f = new frmLogement())
            {
                f.ShowDialog();
            }
        }

        private void mtRubrique_Click(object sender, EventArgs e)
        {
            using (frmRubrique f = new frmRubrique())
            {
                f.ShowDialog();
            }
        }

        private void mtDepense_Click(object sender, EventArgs e)
        {
            using (frmDepenses f = new frmDepenses())
            {
                f.ShowDialog();
            }
        }

        private void mtPaiement_Click(object sender, EventArgs e)
        {
            using (frmPaiement f = new frmPaiement())
            {
                f.ShowDialog();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
