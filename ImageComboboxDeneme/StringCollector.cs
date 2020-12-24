using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageComboboxDeneme
{
    public partial class StringCollector : Form
    {
        public StringCollector()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
            opn.Filter= "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(opn.FileName!=null)
            {
                pictureBox1.ImageLocation = opn.FileName;
                rsm = opn.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public ComboBox my;
        public static ArrayList resimyolları = new ArrayList();
        public static ArrayList veri = new ArrayList();
        String rsm;
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()!=null || rsm!=null)
            {
                my.Items.Add(textBox1.Text);
                resimyolları.Add(rsm);
                veri.Add(textBox1.Text);
                this.Close();
            }
            
        }
    }
}
