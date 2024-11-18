using SugarStock.Models;
using SugarStock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SugarStock.FORMs
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        ORDENAR order = new ORDENAR();
        
        Nav nav = new Nav();

       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string pname = "Pan de Banano";
            string pdesc = "Clásico de la repostería casera, conocido por su sabor dulce y su textura húmeda y esponjosa. Se elabora con bananas maduras, que aportan un dulzor natural y una textura única. ";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "images 3.png");
            double pprice = 120;
            order.changeCont(pname, pdesc, image, pprice);
            order.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string pname = "Cheesecake";
            string pdesc = "Un postre cremoso y delicioso, hecho a base de queso , huevos, azúcar y una base crujiente, normalmente de galletas trituradas. Su textura suave y su sabor ligeramente ácido lo convierten en un postre muy popular en todo el mundo";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "images 4.png");
            double pprice = 200;
            order.changeCont(pname, pdesc, image, pprice);
            order.ShowDialog();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string pname = "Suspiros";
            string pdesc = "Son pequeños bocados de aire puro, ligeros y dulces. Se elaboran principalmente con claras de huevo batidas a punto de nieve y azúcar glasé. Su textura es crujiente por fuera y suave por dentro, con un sabor dulce y delicado";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Merengue-Frances-Receta-6 1.png");
            double pprice = 40;
            order.changeCont(pname, pdesc, image, pprice);
            order.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string pname = "Brownie";
            string pdesc = "Tiene una textura densa y húmeda, con un sabor intenso a chocolate. Su consistencia puede variar entre un centro más jugoso y un exterior ligeramente crujiente. Se suele preparar con chocolate, mantequilla, azúcar, huevos, harina y a menudo nueces.";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "brownies-de-chocolate-2 1.png");
            double pprice = 180;
            order.changeCont(pname, pdesc, image, pprice);
            order.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string pname = "Tiramisú";
            string pdesc = " Postre italiano , compuesto por capas de bizcocho empapado en café, intercaladas con una crema suave y cremosa a base de queso mascarpone, huevos y azúcar. Se suele espolvorear con cacao en polvo .";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "image 6.png");
            double pprice = 180;
            order.changeCont(pname, pdesc, image, pprice);
            order.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string pname = "Créme brulée";
            string pdesc = "El crème brûlée es un postre francés clásico que se caracteriza por su base cremosa y su capa superior de caramelo crujiente. Es un postre perfecto para cualquier ocasión, ya que es elegante, delicioso y fácil de preparar";
            //string image = "C:\\Users\\carlo\\OneDrive\\Music\\PROYECTO METODLOGIA\\SugarStock\\Resources\\images11.png";
            string image = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "images11.png");
            double pprice = 150;
            order.changeCont(pname, pdesc, image, pprice);
            order.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}