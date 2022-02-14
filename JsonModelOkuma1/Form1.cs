using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonModelOkuma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] CoronaVerileri, CoronaGunlukVerileri; //2 adet dizi oluşturduk

            using (WebClient wc = new WebClient())
            {
                var url = wc.DownloadString("https://raw.gıthubusercontent.com/ozanerturk/covid19-turkey-api/master/dataset/timeline.json");
                //guncel bilgileri url olarak aldık
                CoronaVerileri = url.ToString().Split('{');
                // { işareti ile ayırarak diziye aktardık

            }
            for (int i = 1; i <= 10; i++)
            {
                CoronaGunlukVerileri = CoronaVerileri[CoronaVerileri.Length - i].Split('"');
                if (i == 1)
                {
                    baslik.Text = CoronaGunlukVerileri[3] + "COVİD HASTA TABLOSU"; //günün tarih bilgisi gelsin

                }
                //aynı işlemi tarih,test sayısı,vaka ve iyileşen içinde yapalım


                tarih.ListView.Items.Add(CoronaGunlukVerileri[3]);
                testsayisi.ListView.Items.Add(CoronaGunlukVerileri[31]);
                vaka.ListView.Items.Add(CoronaGunlukVerileri[35]);
                iyilesen.ListView.Items.Add(CoronaGunlukVerileri[51]);
                vefat.ListView.Items.Add(CoronaGunlukVerileri[3]);

















            }




        }
    }
}
