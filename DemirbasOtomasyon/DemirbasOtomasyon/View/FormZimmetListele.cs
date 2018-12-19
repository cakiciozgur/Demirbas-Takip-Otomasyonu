using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.View
{
    public partial class FormZimmetListele : DevExpress.XtraEditors.XtraForm
    {
        public FormZimmetListele()
        {
            InitializeComponent();
        }
        private void urunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_ZimmetListele2();
            dgwZimmetListesi.DataSource = data.ToList();
        }
        private void FormZimmetListele_Load(object sender, EventArgs e)
        {
            urunListele();
        }
    }
}