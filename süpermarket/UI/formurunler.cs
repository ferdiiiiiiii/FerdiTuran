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
    public partial class formurunler : Form
    {
        public urunler ürünler { get; set; }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ürünler.urun_ad=txtad.Text;
            ürünler.urun_fiyat = txtfiyat.Text;
            ürünler.stok_miktari=txtstok.Text;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
