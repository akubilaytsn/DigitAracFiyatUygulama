using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DigitusProjeAracFiyatUygulama
{
    public  static class ExcelIslemleri
    {
        public static void Dosyaoku(string yol,DataGridView dgw)
        {
            OpenFileDialog file = new OpenFileDialog();    //OpenFile Dialog ile dosya yolunu seçebiliyoruz.
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Excel Dosyası Seçiniz..";
            file.ShowDialog();

            yol = file.FileName;

            string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + yol + "; Extended Properties =\"Excel 8.0; HDR = Yes;\";";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [EVDS$]", con);   //Dosyayı  oledbconnection ile actım.
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();

            sda.Fill(data);
            dgw.DataSource = data;
            
            data.Columns.Remove("F3");
            data.Columns["TP DK USD A YTL"].ColumnName = "Döviz Günlük Kur";
            data.Columns.Add("OTV Tutar", typeof(decimal));
            data.Columns.Add("KDV Tutar", typeof(decimal));         //Excel dosyası geldikten sonra yanına yaptıgım ıslemlerı  göstermek icin sutunlar ekledım.
            data.Columns.Add("Son Fiyat", typeof(decimal));
        }
    }
}
