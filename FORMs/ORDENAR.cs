using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.FORMs
{
    public partial class ORDENAR : Form
    {
        public ORDENAR()
        {
            InitializeComponent();
        }
        

        public void changeCont(string nombre,string desc, string imagepath, double price)
        {
            Namelb.Text = nombre;
            DescLB.Text = desc;
            PBimage.Image = Image.FromFile(imagepath);
            PriceLB.Text = $"{price} C$";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(CantLB.Text) > 0)
            {
                Lesscant.Enabled = true;
            }
            int index = int.Parse(CantLB.Text);
            index += 1;
            CantLB.Text  = index.ToString();
            
        }

        private void Lesscant_Click(object sender, EventArgs e)
        {
            if (int.Parse(CantLB.Text) < 2) { 
                Lesscant.Enabled=false;
            }
            else
            {
                int index = int.Parse(CantLB.Text);
                index -= 1;
                CantLB.Text = index.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_principal menu_Principal = new Menu_principal();
            menu_Principal.Show();
            this.Hide();
        }
    }
}
