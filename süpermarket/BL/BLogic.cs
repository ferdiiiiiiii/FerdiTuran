using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using süpermarket.DL;

namespace süpermarket.BL
{
    public static class BLogic
    {
        public static bool ürünekle(urunler ü)
        {
            try
            {
                int res = DataLayer.ürünekle(ü);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet ÜrünGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.ÜrünGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static bool musteriekle(musteriler m)
        {
            try
            {
                int res = DataLayer.musteriekle(m);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet musteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.musteriGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        
    }
}
