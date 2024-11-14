using SugarStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock
{
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }
        
        Credenciales credenciales = new Credenciales();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtUser.Text);
            string password  = TxtPassword.Text;
            credenciales.TextIncorrect(id, password);

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_MouseHover(object sender, EventArgs e)
        {
            BtnCreate.ForeColor = Color.White;
            BtnCreate.BackColor = Color.Black;
            
        }

        private void BtnCreate_MouseLeave(object sender, EventArgs e)
        {
            BtnCreate.BackColor = Color.White;
            BtnCreate.ForeColor= Color.Black;
        }
    }
}
