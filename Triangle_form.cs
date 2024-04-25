using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle
{
    public partial class Triangle_form : Form
    {
        public Triangle_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {   
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);
                Triangle t = new Triangle(a, b, c);
                lv.Items.Add("side A");
                lv.Items[0].SubItems.Add(t.OutputA());
                lv.Items.Add("side B");
                lv.Items[1].SubItems.Add(t.OutputB());
                lv.Items.Add("side C");
                lv.Items[2].SubItems.Add(t.OutputC());
                
                lv.Items.Add("Perimeter");
                //lv.Items[3].SubItems.Add(t.Perimeter());
                lv.Items.Add("Area");
                //lv.Items[4].SubItems.Add(t.Area());

            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
