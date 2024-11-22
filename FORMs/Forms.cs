﻿using SugarStock.FORMs;
using SugarStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        ORDENAR order = new ORDENAR();
        AllProgram programstart = new AllProgram();

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
            this.Hide();


            if (credenciales.Textcorrect(id, password) == true)
            {
                programstart.Show();
                this.Hide();
            }
            else if (id == 0000 && password == "Admin00")
            {
                Owner Menuowner = new Owner(); 
                Menuowner.Show();
                this.Hide(); 
            }




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
            BtnCreate.ForeColor = Color.Black;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            bool isTextNotEmpty = !string.IsNullOrEmpty(TxtPassword.Text);

            if (isTextNotEmpty)
            {
                btnlookpass.IconColor = Color.Black;
                btnlookpass.IconSize = 25;
                btnlookpass.Enabled = true;
            }

            else
            {
                btnlookpass.IconColor = Color.White;
                btnlookpass.IconSize = 1;
                btnlookpass.Enabled = false;
            }

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Username:")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.Black;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Username:";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password:")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.PasswordChar = Convert.ToChar("•");

            }

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password:";
                TxtPassword.ForeColor = Color.LightGray;
                TxtPassword.PasswordChar = (char)0;
                btnlookpass.IconColor = Color.White;
                btnlookpass.IconSize = 1;
                btnlookpass.Enabled = false;

            }
        }

        private void btnlookpass_Click(object sender, EventArgs e)
        {
            if (btnlookpass.Enabled == true)
            {
                if (TxtPassword.PasswordChar == Convert.ToChar("•"))
                {
                    TxtPassword.PasswordChar = (char)0;
                    btnlookpass.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
                else if (TxtPassword.PasswordChar == (char)0)
                {
                    TxtPassword.PasswordChar = Convert.ToChar("•");
                    btnlookpass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                }
            }
        }

        private void Ocultarpass()
        {
            if (TxtPassword.PasswordChar == (char)0)
            {
                TxtPassword.PasswordChar = Convert.ToChar("•");
                btnlookpass.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (TxtPassword.PasswordChar == Convert.ToChar("•"))
            {
                TxtPassword.PasswordChar = (char)0;
            }
        }
    }
}
