using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace süpermarket.UI
{
    public partial class formmusteriler : Form
    {
        public musteriler müşteriler { get; set; }
        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            müşteriler.ad = txtad.Text;
            müşteriler.soyad = txtsoyad.Text; 
            müşteriler.telefon = txttel.Text;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
