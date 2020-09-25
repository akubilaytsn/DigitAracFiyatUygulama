using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;

namespace DigitusProjeAracFiyatUygulama
{
    public partial class FiyatListe : Form
    {
        UrunBilgi urb = new UrunBilgi();
        public FiyatListe()
        {
            InitializeComponent();

        }
        private void btnTabloGetir_Click(object sender, EventArgs e)
        {
            #region ExcelDosyasıİmportİslemi
            ExcelIslemleri.Dosyaoku(txtDosyaYol.Text, grdExcelListe);
            #endregion

            //Hesap islemleri burada baslıyor.
            #region OTV -KDV-SON FİYAT HESAPLA       

            decimal otvtutarSonuc = 0;
            decimal kdvTutarSonuc = 0;
            decimal toplamTutar = 0;

            int i = 0;

            if (Form1.Secim.Equals("normalbirey"))
            {
                while (i < grdExcelListe.Rows.Count)
                {
                    if (Convert.ToString(grdExcelListe.Rows[i].Cells[1].Value) != "")
                    {
                        decimal vergisizSatis = (decimal)urb.GolfFiyat * Convert.ToDecimal(grdExcelListe.Rows[i].Cells[1].Value);
                        if (vergisizSatis < 70000)
                        {
                            otvtutarSonuc = (vergisizSatis * 45 / 100);

                        }
                        else if (vergisizSatis >= 70000 && vergisizSatis < 120000)    //Aracın  vergisiz fiyatının döviz kuruna göre hesaplandıktan sonra fiyatı 70 bin altı 70-120 bin arası ve 120 bin üsütne göre ötv oranı kontrolleri.
                        {
                            otvtutarSonuc = (vergisizSatis * 50 / 100);
                        }
                        else
                        {
                            otvtutarSonuc = (vergisizSatis * 60 / 100);
                        }

                        kdvTutarSonuc = ((vergisizSatis + otvtutarSonuc) * 18 / 100);
                        toplamTutar = (vergisizSatis + otvtutarSonuc + kdvTutarSonuc);
                        otvtutarSonuc = Math.Round(otvtutarSonuc, 2);
                        kdvTutarSonuc = Math.Round(kdvTutarSonuc, 2);
                        toplamTutar = Math.Round(toplamTutar, 2);
                        grdExcelListe.Rows[i].Cells[2].Value = otvtutarSonuc;
                        grdExcelListe.Rows[i].Cells[3].Value = kdvTutarSonuc;
                        grdExcelListe.Rows[i].Cells[4].Value = toplamTutar;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (Form1.Secim.Equals("engellibirey"))
            {
                while (i < grdExcelListe.Rows.Count)
                {
                    if (Convert.ToString(grdExcelListe.Rows[i].Cells[1].Value) != "")
                    {
                        decimal vergisizSatis = (decimal)urb.GolfFiyat * Convert.ToDecimal(grdExcelListe.Rows[i].Cells[1].Value);

                        kdvTutarSonuc = ((vergisizSatis) * 18 / 100);
                        toplamTutar = (vergisizSatis + kdvTutarSonuc);
                        kdvTutarSonuc = Math.Round(kdvTutarSonuc, 2);
                        toplamTutar = Math.Round(toplamTutar, 2);
                        grdExcelListe.Rows[i].Cells[2].Value = 0;
                        grdExcelListe.Rows[i].Cells[3].Value = kdvTutarSonuc;
                        grdExcelListe.Rows[i].Cells[4].Value = toplamTutar;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            #endregion


        }
    }
}
