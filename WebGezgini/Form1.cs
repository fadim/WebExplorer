using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebGezgini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {//git
            timer1.Enabled = true;
            pbDurumu.Value = 0;
            webBrowser1.Navigate(txtAdres.Text);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            txtStatus.Text = "Sayfa Yükleniyor...";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            timer1.Enabled = false;
            pbDurumu.Value = 100;
            txtStatus.Text = "Sayfa Tamanlandı.";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {//yenile
            timer1.Enabled = true;
            pbDurumu.Value = 0;
            webBrowser1.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //geri
            webBrowser1.GoBack();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {//ileri
            webBrowser1.GoForward();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbDurumu.Value++;
            if (pbDurumu.Value==100)
            {
                pbDurumu.Value = 0;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string url = "http://www.google.com.tr/#hl=tr&output=search&sclient=psy-ab&q=" + txtAra.Text
                       + "&oq=" + txtAra.Text + "&aq=f&aqi=g-l1&aql=&gs_nf=1&gs_l=hp.3..0i13.84.5232.0.5465.17.15.0.1.1.1.429.2679.2-7j2j1.11.0.pFNyLW7PX80&pbx=1&bav=on.2,or.r_gc.r_pw.r_qf.,cf.osb&fp=902fa6e8b82d1918";
            webBrowser1.Navigate(url);
        }

        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                webBrowser1.Navigate(txtAdres.Text);
            }
        }
    }
}
