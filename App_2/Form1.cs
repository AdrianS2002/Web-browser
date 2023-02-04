using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String adresa,veche;

        private void btn_search_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            adresa = textBox1.Text;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           // webBrowser1.GoBack();
            webBrowser1.Navigate(adresa);
        }

        private void btn_farward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                webBrowser1.Navigate(textBox1.Text);
        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("bing.com");
        }
      
    }
}
