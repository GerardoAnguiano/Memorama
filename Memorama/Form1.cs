using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void artaudcover1_Click(object sender, EventArgs e)
        {
            artaudcover1.Visible = false;
            artaud1.Visible = true;
            if (artaud1.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (artaud1.Visible == false)
            {
                puntaje.Text = "no coincide";
                artaud1.Visible = false;
                artaudcover1.Visible = true;
            }


        }

        private void artaudcover2_Click(object sender, EventArgs e)
        {
            artaudcover2.Visible = false;
            artaud2.Visible = true;
            if (artaud2.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (artaud2.Visible == false)
            {
                puntaje.Text = "no coincide";
                artaud2.Visible = false;
                artaudcover2.Visible = true;
            }
        }

        private void metallicacover1_Click(object sender, EventArgs e)
        {
            metallicacover1.Visible = false;
            metallica1.Visible = true;
            if (metallica1.Visible == true)
            {
                puntaje.Text = "Exitoso";
            }
            else
                if (metallica1.Visible == false)
            {
                puntaje.Text = "no coincide";
                metallica1.Visible = false;
                metallicacover1.Visible = true;
            }
        }

        private void metallicacover2_Click(object sender, EventArgs e)
        {
            metallicacover2.Visible = false;
            metallica2.Visible = true;
            if (metallica2.Visible == true)
            {
                puntaje.Text = "Exitoso";
            }
            else
                if (metallica2.Visible == false)
            {
                puntaje.Text = "no coincide";
                metallica2.Visible = false;
                metallicacover2.Visible = true;
            }
        }

        private void pinkcover1_Click(object sender, EventArgs e)
        {
            pinkcover1.Visible = false;
            pink1.Visible = true;
            if (pink1.Visible == true)
            {
                puntaje.Text = "Exitoso";
            }
            else
                if (pink1.Visible == false)
            {
                puntaje.Text = "no coincide";
                pink1.Visible = false;
                pinkcover1.Visible = true;
            }
        }

        private void pinkcover2_Click(object sender, EventArgs e)
        {
            pinkcover2.Visible = false;
            pink2.Visible = true;
            if (pink2.Visible == true)
            {
                puntaje.Text = "Exitoso";
            }
            else
                if (pink2.Visible == false)
            {
                puntaje.Text = "no coincide";
                pink2.Visible = false;
                pinkcover2.Visible = true;
            }
        }

        private void panteracover1_Click(object sender, EventArgs e)
        {
            panteracover1.Visible = false;
            pantera1.Visible = true;
            if (pantera1.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (pantera1.Visible == false)
            {
                puntaje.Text = "no coincide";
                pantera1.Visible = false;
                panteracover1.Visible = true;
            }
        }

        private void panteracover2_Click(object sender, EventArgs e)
        {
            panteracover2.Visible = false;
            pantera2.Visible = true;
            if (pantera1.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (pantera2.Visible == false)
            {
                puntaje.Text = "no coincide";
                pantera2.Visible = false;
                panteracover2.Visible = true;
            }
        }

        private void tamecover1_Click(object sender, EventArgs e)
        {
            tamecover1.Visible = false;
            tame1.Visible = true;
            if (tame1.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (tame1.Visible == false)
            {
                puntaje.Text = "no coincide";
                tame1.Visible = false;
                tamecover1.Visible = true;
            }
        }

        private void tamecover2_Click(object sender, EventArgs e)
        {
            tamecover2.Visible = false;
            tame2.Visible = true;
            if (tame2.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (tame2.Visible == false)
            {
                puntaje.Text = "no coincide";
                tame2.Visible = false;
                tamecover2.Visible = true;
            }
        }

        private void gunscover1_Click(object sender, EventArgs e)
        {
            gunscover1.Visible = false;
            guns1.Visible = true;
            if (guns1.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (guns1.Visible == false)
            {
                puntaje.Text = "no coincide";
                guns1.Visible = false;
                gunscover1.Visible = true;
            }
        }

        private void gunscover2_Click(object sender, EventArgs e)
        {
            gunscover2.Visible = false;
            guns2.Visible = true;
            if (guns2.Visible == true)
            {
                puntaje.Text = "Existoso";
            }
            else
                if (guns2.Visible == false)
            {
                puntaje.Text = "no coincide";
                guns2.Visible = false;
                gunscover2.Visible = true;
            }
        }
    }
}
