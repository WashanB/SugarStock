using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.Models
{
    internal class Credenciales
    {
     
        public void TextIncorrect(int id , string password)
        {

          
            if (id == 1234 && password == "5678")
            {
                MessageBox.Show("WELCOME COSTUMER");
            }
            else if(id == 0000 && password == "Admin00")
            {
                MessageBox.Show("WELCOME OWNER");
            }
            else
            {
                MessageBox.Show("INVALID LOGIN");
            }

    
        }
    }
}
