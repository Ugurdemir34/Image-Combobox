using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ImageComboboxDeneme
{
    public partial class myCombo : UserControl
    {
        public myCombo()
        {
            InitializeComponent();
            c.AllowFullOpen = true;
           
        }

        private int height, width;
        public int Genişlik
        {
            get
            {
                return width;
            }
            set
            {
                width = (int)value;
                this.Width = width;
            }
        }
     




        Rectangle rectangle;
        Bitmap image;
        float size = 10;
        Font myFont;
        FontFamily family = FontFamily.GenericSansSerif;
        Rectangle boya;
        Color animalColor = Color.Gray;

        private void button1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            StringCollector st = new StringCollector();
            st.my = comboBox1;
            st.ShowDialog();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            e.DrawBackground();
            
            rectangle = new Rectangle(0, e.Bounds.Top, 64, 64);
            boya = new Rectangle(e.Bounds.X + rectangle.Right, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            image = new Bitmap(StringCollector.resimyolları[e.Index].ToString());
            e.Graphics.DrawImage(image, rectangle);
            e.Graphics.FillRectangle(new SolidBrush(c.Color) , boya);
            myFont = new Font(family, size, FontStyle.Bold);
            e.Graphics.DrawString(StringCollector.veri[e.Index].ToString(), myFont, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + rectangle.Right, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
            e.DrawFocusRectangle();
            
            GC.Collect();
            GC.SuppressFinalize(this);
            GC.WaitForPendingFinalizers();
            GC.SuppressFinalize(boya);
            GC.SuppressFinalize(myFont);
            GC.SuppressFinalize(image);
            GC.SuppressFinalize(rectangle);

            image = null;
        }
        ColorDialog c = new ColorDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            
            c.ShowDialog();
           
        }

        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 64;
        }
    }
}
