using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using süpermarket.BL;   

namespace süpermarket.UI
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            formurunler FormÜrünler = new formurunler()
            {
                Text = "Ürün Ekle",
                ürünler = new urunler { urun_id = Guid.NewGuid(), }
            };
            tekrar:
            var sonuc = FormÜrünler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ürünekle(FormÜrünler.ürünler);
                if (b)
                {
                    DataSet ds = BLogic.ÜrünGetir(toolStripTextBox1.Text);
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        goto tekrar;
                    }
                }
                }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formmusteriler Formmusteriler = new formmusteriler()
            {
                Text = "Müşteri Ekle",
                müşteriler = new musteriler { musteri_id = Guid.NewGuid(), }
            };

            var sonuc1 = Formmusteriler.ShowDialog();
            if (sonuc1 == DialogResult.OK)
            {
                bool b = BLogic.musteriekle(Formmusteriler.müşteriler);
                if (b)
                {
                    DataSet ds = BLogic.musteriGetir(toolStripTextBox1.Text);
                    if (ds != null)
                    {
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                    else
                    {

                    }
                }

            }
        }

        private void btnurunbul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.ÜrünGetir(toolStripTextBox1.Text);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.musteriGetir(toolStripTextBox6.Text);
            if (ds != null)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
        }
    }
}
