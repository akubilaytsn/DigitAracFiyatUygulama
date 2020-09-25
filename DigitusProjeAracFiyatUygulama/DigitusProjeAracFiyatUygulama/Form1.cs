using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;


namespace DigitusProjeAracFiyatUygulama
{
    public partial class Form1 : Form
    {
        public static string Secim;
        public Form1()
        {
            InitializeComponent();
            Secim = "";
        }

        private void btnNormalBireyFiyatlandir_Click(object sender, EventArgs e)
        {
            Secim = "normalbirey";
            FiyatListe fytListe = new FiyatListe();
            fytListe.Show();
            
        }

        private void btnEngelliBireyFiyatlandir_Click(object sender, EventArgs e)
        {
            Secim = "engellibirey";
            FiyatListe fytListe = new FiyatListe();
            fytListe.Show();
        }
    }
}
