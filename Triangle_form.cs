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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            double a, b, c, P, S, H;
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Remove();
                i--;
            }
            try
            {   
                a = Convert.ToDouble(txt_a.Text);
                b = Convert.ToDouble(txt_b.Text);
                c = Convert.ToDouble(txt_c.Text);
                Triangle t = new Triangle(a, b, c);
                if ((perimeter != null) && (perimeter.Text != ""))
                {
                    P = Convert.ToDouble(perimeter.Text);
                }
                else { P = t.Perimeter(); }
                if ((area != null) && (area.Text != ""))
                {
                    S = Convert.ToDouble(area.Text);
                }
                else { S = t.Area(); }
                if ((h != null) && (h.Text != ""))
                {
                    H = Convert.ToDouble(h.Text);
                }
                else { H = t.Height(a, b, c); }

                lv.Items.Add("side A");
                lv.Items[0].SubItems.Add(t.OutputVar(a));
                lv.Items.Add("side B");
                lv.Items[1].SubItems.Add(t.OutputVar(b));
                lv.Items.Add("side C");
                lv.Items[2].SubItems.Add(t.OutputVar(c));
                lv.Items.Add("Perimeter");
                lv.Items[3].SubItems.Add(t.OutputVar(P));
                lv.Items.Add("Area");
                lv.Items[4].SubItems.Add(t.OutputVar(S));
                lv.Items.Add("Height");
                lv.Items[5].SubItems.Add(t.OutputVar(H));
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
