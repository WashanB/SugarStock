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
    public partial class Listbox : Form
    {
        PostresManager postresManager = new PostresManager();
        public Listbox()
        {
            InitializeComponent();
            postresManager = new PostresManager(); // Inicializa el manager de postres
            CargarPostres();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarPostres();
        }

        private void CargarPostres()
        {
            // Supongamos que tienes un ListBox llamado listBoxPostres en tu formulario
            listBoxPostres.Items.Clear(); // Limpia el ListBox antes de cargar los postres

            foreach (var postre in postresManager.Postres)
            {
                listBoxPostres.Items.Add($"ID: {postre.Id}, Nombre: {postre.Nombre}, Descripción: {postre.Descripcion}, Precio: {postre.Precio} C$");
            }
        }
    }
}
