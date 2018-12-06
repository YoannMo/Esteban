using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  
    
    
        public partial class Play : Form
    {
        
        Random rnd;
        int alea;
        int tortue = 0;
        int lievre = 0;
        int Tour = 0;
        int count=0;

        public Play()
        {
            InitializeComponent();
            rnd = new Random();
           
            Tdepart.Visible = true;
            Ldepart.Visible = true;
            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            T4.Visible = false;
            T5.Visible = false;
            Tarrive.Visible = false;
            Larrive.Visible = false;




        }
        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void cmd_de_Click(object sender, EventArgs e)
        {
            alea = rnd.Next(1, 7);

            if (alea != 6 || count != 6)
            { count = count + 1; }


            if (alea == 6)
            {

                    cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface11;
                    Tdepart.Visible = false;
                    Tarrive.Visible = true;

                    //T1.Visible = false;
                    //T2.Visible = false;
                    //T3.Visible = false;
                    //T4.Visible = false;
                    //T5.Visible = false;

                    Affiche();


            }
            else if (count == 1)
            {
                Afficher(1);
                cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface11;

            }
            else if (count == 2)
            {
                Afficher(2);
                cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface2;

            }
            else if (count == 3)
            {
                Afficher(3);
                cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface3;
            }
            else if (count == 4)
            {
                Afficher(4);
                cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface4;


            }
            else if (count == 5)
            {
                Afficher(5);
                cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface5;


            }
            else if (count == 6)
            {

                Affiche();
                Tarrive.Visible = true;
                cmd_de.Image = WindowsFormsApp1.Properties.Resources.rsz_déface6;

            }

            //switch (count)                      // même utilité que l'enchainement de elif mais plus pratique à ranger et plus propre
            //{
            //    case 1: Afficher(1); break;
            //    case 2: Afficher(2); break;
            //}

        }
        private void Affiche()
        {
            T1.Visible = false; 
            T2.Visible = false;
            T3.Visible = false;
            T4.Visible = false;
            T5.Visible = false;
        }

        private void Afficher(int count)
        {
            T1.Visible = false;
            T2.Visible = false;
            T3.Visible = false;
            T4.Visible = false;
            T5.Visible = false;

            if (count == 1) { T1.Visible = true; }
            if (count == 2) { T2.Visible = true; }
            if (count == 3) { T3.Visible = true; }
            if (count == 4) { T4.Visible = true; }
            if (count == 5) { T5.Visible = true; }


            switch (count)
            {
                case 1: T1.Visible = true;break;
                case 2: T2.Visible = true; break;
                case 3: T3.Visible = true; break;
                case 4: T4.Visible = true; break;
                case 5: T5.Visible = true; break;

            }


        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }

