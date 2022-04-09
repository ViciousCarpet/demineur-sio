using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {

        public static char[,] affcases = new char[4, 4];// p ----------
        public static PictureBox[,] affichage = new PictureBox[10, 10];//------------
        public static PictureBox[,] affichagsoluce = new PictureBox[10, 10];
        public string[,] plateau = new string[4, 4];

        public static Image v = Properties.Resources.vide;
        public static Image b = Properties.Resources.bombe;
        public static Image u = Properties.Resources.un;
        public static Image d = Properties.Resources.deux;
        public static Image t = Properties.Resources.trois;
        public static Image q = Properties.Resources.quatre;
        public static Image ci = Properties.Resources.cinq;
        public static Image s = Properties.Resources.six;
        public static Image se = Properties.Resources.sept;
        public static Image h = Properties.Resources.huit;
        public static Image dr = Properties.Resources.drapeau;
        //si vide: v, si bombe: b, si 1: u, si 2: d, si 3: t, si perdu:p,si drapeau:dr
        public static Image p = Properties.Resources.perdu;//si cacher: c si 4:q si 5:ci si 6:s si 7:se si 8:h
        public static Image c = Properties.Resources.cacher;

        public static string fichier = "D:\\sauvegarde.txt";
        public void initialiser()
        {
            //--------------------------a
            affichage[0, 0] = a1;
            affichage[0, 1] = a2;
            affichage[0, 2] = a3;
            affichage[0, 3] = a4;
            affichage[0, 4] = a5;
            affichage[0, 5] = a6;
            affichage[0, 6] = a7;
            affichage[0, 7] = a8;
            affichage[0, 8] = a9;
            affichage[0, 9] = a0;
            //--------------------------b
            affichage[1, 0] = b1;
            affichage[1, 1] = b2;
            affichage[1, 2] = b3;
            affichage[1, 3] = b4;
            affichage[1, 4] = b5;
            affichage[1, 5] = b6;
            affichage[1, 6] = b7;
            affichage[1, 7] = b8;
            affichage[1, 8] = b9;
            affichage[1, 9] = b0;
            //--------------------------c
            affichage[2, 0] = c1;
            affichage[2, 1] = c2;
            affichage[2, 2] = c3;
            affichage[2, 3] = c4;
            affichage[2, 4] = c5;
            affichage[2, 5] = c6;
            affichage[2, 6] = c7;
            affichage[2, 7] = c8;
            affichage[2, 8] = c9;
            affichage[2, 9] = c0;
            //-------------------------d
            affichage[3, 0] = d1;
            affichage[3, 1] = d2;
            affichage[3, 2] = d3;
            affichage[3, 3] = d4;
            affichage[3, 4] = d5;
            affichage[3, 5] = d6;
            affichage[3, 6] = d7;
            affichage[3, 7] = d8;
            affichage[3, 8] = d9;
            affichage[3, 9] = d0;
            //-------------------------e
            affichage[4, 0] = e1;
            affichage[4, 1] = e2;
            affichage[4, 2] = e3;
            affichage[4, 3] = e4;
            affichage[4, 4] = e5;
            affichage[4, 5] = e6;
            affichage[4, 6] = e7;
            affichage[4, 7] = e8;
            affichage[4, 8] = e9;
            affichage[4, 9] = e0;
            //-------------------------f
            affichage[5, 0] = f1;
            affichage[5, 1] = f2;
            affichage[5, 2] = f3;
            affichage[5, 3] = f4;
            affichage[5, 4] = f5;
            affichage[5, 5] = f6;
            affichage[5, 6] = f7;
            affichage[5, 7] = f8;
            affichage[5, 8] = f9;
            affichage[5, 9] = f0;
            //-------------------------g
            affichage[6, 0] = g1;
            affichage[6, 1] = g2;
            affichage[6, 2] = g3;
            affichage[6, 3] = g4;
            affichage[6, 4] = g5;
            affichage[6, 5] = g6;
            affichage[6, 6] = g7;
            affichage[6, 7] = g8;
            affichage[6, 8] = g9;
            affichage[6, 9] = g0;
            //-------------------------h
            affichage[7, 0] = h1;
            affichage[7, 1] = h2;
            affichage[7, 2] = h3;
            affichage[7, 3] = h4;
            affichage[7, 4] = h5;
            affichage[7, 5] = h6;
            affichage[7, 6] = h7;
            affichage[7, 7] = h8;
            affichage[7, 8] = h9;
            affichage[7, 9] = h0;
            //-------------------------i
            affichage[8, 0] = i1;
            affichage[8, 1] = i2;
            affichage[8, 2] = i3;
            affichage[8, 3] = i4;
            affichage[8, 4] = i5;
            affichage[8, 5] = i6;
            affichage[8, 6] = i7;
            affichage[8, 7] = i8;
            affichage[8, 8] = i9;
            affichage[8, 9] = i0;
            //-------------------------j
            affichage[9, 0] = j1;
            affichage[9, 1] = j2;
            affichage[9, 2] = j3;
            affichage[9, 3] = j4;
            affichage[9, 4] = j5;
            affichage[9, 5] = j6;
            affichage[9, 6] = j7;
            affichage[9, 7] = j8;
            affichage[9, 8] = j9;
            affichage[9, 9] = j0;
            //-------------------------FIN
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    affichage[i, j].Image = c;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel1.Visible = false;
            initialiser();
            afficher();
            affichersoluce();
        }

        private void bt_demarrer_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            nouvellepartie();
            afficher();


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    affichage[i, j].Click += new System.EventHandler(this.uneCase_Click);
                }
            }
        }

        private void nouvellepartie()
        {
            Random rnd = new Random();
            StreamWriter fichiersortie = File.CreateText(fichier);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    fichiersortie.Write(rnd.Next(4) + ",");
                }
                fichiersortie.Write(rnd.Next(4));
                fichiersortie.WriteLine();
            }

            fichiersortie.Close();
        }
        public int nbrebombe = 0;
        private void afficher()
        {
            nbrebombe = 0;
            StreamReader fichierentree = File.OpenText(fichier);
            string ligne = "";
            string[] lignesplit = new string[4];
            while (fichierentree.Peek() > 0)
            {
                ligne = fichierentree.ReadLine();
                lignesplit = ligne.Split(',');
                
                for (int i = 0; i < 10; i++)
                {
                    switch (lignesplit[i])
                    {
                        case "0":

                            break;

                        case "1":

                            break;
                        case "2":

                            break;
                        case "3":
                            nbrebombe++;
                            break;

                    }
                }
                
            }
            lb_nbbombe.Text = Convert.ToString(nbrebombe);


            fichierentree.Close();

        }

        private void affichersoluce()
        {
            //panel2.Visible = true;
            //--------------------------a
            affichagsoluce[0, 0] = sa1;
            affichagsoluce[0, 1] = sa2;
            affichagsoluce[0, 2] = sa3;
            affichagsoluce[0, 3] = sa4;
            affichagsoluce[0, 4] = sa5;
            affichagsoluce[0, 5] = sa6;
            affichagsoluce[0, 6] = sa7;
            affichagsoluce[0, 7] = sa8;
            affichagsoluce[0, 8] = sa9;
            affichagsoluce[0, 9] = sa0;
            //--------------------------b
            affichagsoluce[1, 0] = sb1;
            affichagsoluce[1, 1] = sb2;
            affichagsoluce[1, 2] = sb3;
            affichagsoluce[1, 3] = sb4;
            affichagsoluce[1, 4] = sb5;
            affichagsoluce[1, 5] = sb6;
            affichagsoluce[1, 6] = sb7;
            affichagsoluce[1, 7] = sb8;
            affichagsoluce[1, 8] = sb9;
            affichagsoluce[1, 9] = sb0;
            //--------------------------c
            affichagsoluce[2, 0] = sc1;
            affichagsoluce[2, 1] = sc2;
            affichagsoluce[2, 2] = sc3;
            affichagsoluce[2, 3] = sc4;
            affichagsoluce[2, 4] = sc5;
            affichagsoluce[2, 5] = sc6;
            affichagsoluce[2, 6] = sc7;
            affichagsoluce[2, 7] = sc8;
            affichagsoluce[2, 8] = sc9;
            affichagsoluce[2, 9] = sc0;
            //--------------------------d
            affichagsoluce[3, 0] = sd1;
            affichagsoluce[3, 1] = sd2;
            affichagsoluce[3, 2] = sd3;
            affichagsoluce[3, 3] = sd4;
            affichagsoluce[3, 4] = sd5;
            affichagsoluce[3, 5] = sd6;
            affichagsoluce[3, 6] = sd7;
            affichagsoluce[3, 7] = sd8;
            affichagsoluce[3, 8] = sd9;
            affichagsoluce[3, 9] = sd0;
            //--------------------------e
            affichagsoluce[4, 0] = se1;
            affichagsoluce[4, 1] = se2;
            affichagsoluce[4, 2] = se3;
            affichagsoluce[4, 3] = se4;
            affichagsoluce[4, 4] = se5;
            affichagsoluce[4, 5] = se6;
            affichagsoluce[4, 6] = se7;
            affichagsoluce[4, 7] = se8;
            affichagsoluce[4, 8] = se9;
            affichagsoluce[4, 9] = se0;
            //--------------------------f
            affichagsoluce[5, 0] = sf1;
            affichagsoluce[5, 1] = sf2;
            affichagsoluce[5, 2] = sf3;
            affichagsoluce[5, 3] = sf4;
            affichagsoluce[5, 4] = sf5;
            affichagsoluce[5, 5] = sf6;
            affichagsoluce[5, 6] = sf7;
            affichagsoluce[5, 7] = sf8;
            affichagsoluce[5, 8] = sf9;
            affichagsoluce[5, 9] = sf0;
            //--------------------------g
            affichagsoluce[6, 0] = sg1;
            affichagsoluce[6, 1] = sg2;
            affichagsoluce[6, 2] = sg3;
            affichagsoluce[6, 3] = sg4;
            affichagsoluce[6, 4] = sg5;
            affichagsoluce[6, 5] = sg6;
            affichagsoluce[6, 6] = sg7;
            affichagsoluce[6, 7] = sg8;
            affichagsoluce[6, 8] = sg9;
            affichagsoluce[6, 9] = sg0;
            //--------------------------h
            affichagsoluce[7, 0] = sh1;
            affichagsoluce[7, 1] = sh2;
            affichagsoluce[7, 2] = sh3;
            affichagsoluce[7, 3] = sh4;
            affichagsoluce[7, 4] = sh5;
            affichagsoluce[7, 5] = sh6;
            affichagsoluce[7, 6] = sh7;
            affichagsoluce[7, 7] = sh8;
            affichagsoluce[7, 8] = sh9;
            affichagsoluce[7, 9] = sh0;
            //--------------------------i
            affichagsoluce[8, 0] = si1;
            affichagsoluce[8, 1] = si2;
            affichagsoluce[8, 2] = si3;
            affichagsoluce[8, 3] = si4;
            affichagsoluce[8, 4] = si5;
            affichagsoluce[8, 5] = si6;
            affichagsoluce[8, 6] = si7;
            affichagsoluce[8, 7] = si8;
            affichagsoluce[8, 8] = si9;
            affichagsoluce[8, 9] = si0;
            //--------------------------j
            affichagsoluce[9, 0] = sj1;
            affichagsoluce[9, 1] = sj2;
            affichagsoluce[9, 2] = sj3;
            affichagsoluce[9, 3] = sj4;
            affichagsoluce[9, 4] = sj5;
            affichagsoluce[9, 5] = sj6;
            affichagsoluce[9, 6] = sj7;
            affichagsoluce[9, 7] = sj8;
            affichagsoluce[9, 8] = sj9;
            affichagsoluce[9, 9] = sj0;
            //--------------------------FIN
            StreamReader fichierentree = File.OpenText(fichier);
            string ligne = "";
            string[] lignesplit = new string[4];
            int lignecourrante = 0;
            while (fichierentree.Peek() > 0)
            {
                ligne = fichierentree.ReadLine();

                lignesplit = ligne.Split(',');
                for (int i = 0; i < 10; i++)
                {
                    switch (lignesplit[i])
                    {
                        case "0":
                            affichagsoluce[lignecourrante, i].Image = v;
                            break;

                        case "1":
                            affichagsoluce[lignecourrante, i].Image = v;
                            break;
                        case "2":
                            affichagsoluce[lignecourrante, i].Image = v;
                            break;
                        case "3":
                            affichagsoluce[lignecourrante, i].Image = b;
                            break;

                    }
                }
                lignecourrante++;
            }

            fichierentree.Close();
        }

        private void solution_Click(object sender, EventArgs e)
        {
            affichersoluce();
            panel2.Visible = true;
        }
        public int ligne;
        public int colonne;
        
        public void clicdroit(object sender, EventArgs e)
        {
                       
        }
        public void uneCase_Click(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name[0])
            {
                case 'a':
                    ligne = 0;
                    break;
                case 'b':
                    ligne = 1;
                    break;
                case 'c':
                    ligne = 2;
                    break;
                case 'd':
                    ligne = 3;
                    break;
                case 'e':
                    ligne = 4;
                    break;
                case 'f':
                    ligne = 5;
                    break;
                case 'g':
                    ligne = 6;
                    break;
                case 'h':
                    ligne = 7;
                    break;
                case 'i':
                    ligne = 8;
                    break;
                case 'j':
                    ligne = 9;
                    break;
                default:
                    ligne = 99;
                    break;
            }
            switch (((PictureBox)sender).Name[1])
            {
                case '1':
                    colonne = 0;
                    break;
                case '2':
                    colonne = 1;
                    break;
                case '3':
                    colonne = 2;
                    break;
                case '4':
                    colonne = 3;
                    break;
                case '5':
                    colonne = 4;
                    break;
                case '6':
                    colonne = 5;
                    break;
                case '7':
                    colonne = 6;
                    break;
                case '8':
                    colonne = 7;
                    break;
                case '9':
                    colonne = 8;
                    break;
                case '0':
                    colonne = 9;
                    break;

                default:
                    colonne = 99;
                    break;
            }
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Right)
            {
                affichage[ligne, colonne].Image = dr;
                nbrebombe--;
                lb_nbbombe.Text = Convert.ToString(nbrebombe);
            }
            else
            {
                switch (((PictureBox)sender).Name[0])
                {
                    case 'a':
                        ligne = 0;
                        break;
                    case 'b':
                        ligne = 1;
                        break;
                    case 'c':
                        ligne = 2;
                        break;
                    case 'd':
                        ligne = 3;
                        break;
                    case 'e':
                        ligne = 4;
                        break;
                    case 'f':
                        ligne = 5;
                        break;
                    case 'g':
                        ligne = 6;
                        break;
                    case 'h':
                        ligne = 7;
                        break;
                    case 'i':
                        ligne = 8;
                        break;
                    case 'j':
                        ligne = 9;
                        break;
                    default:
                        ligne = 99;
                        break;
                }
                switch (((PictureBox)sender).Name[1])
                {
                    case '1':
                        colonne = 0;
                        break;
                    case '2':
                        colonne = 1;
                        break;
                    case '3':
                        colonne = 2;
                        break;
                    case '4':
                        colonne = 3;
                        break;
                    case '5':
                        colonne = 4;
                        break;
                    case '6':
                        colonne = 5;
                        break;
                    case '7':
                        colonne = 6;
                        break;
                    case '8':
                        colonne = 7;
                        break;
                    case '9':
                        colonne = 8;
                        break;
                    case '0':
                        colonne = 9;
                        break;

                    default:
                        colonne = 99;
                        break;
                }
                if (affichagsoluce[ligne, colonne].Image == b)
                {
                    affichage[ligne, colonne].Image = p;
                    //cdtdefaite();

                }
                else
                {
                    verif();
                }
            }
            
            //panel2.Visible = false; ;
        }
        public int nbre = 0;
        public bool defaite = false;
        public bool victoire = true;
        /*public void cdtvictoire()
        {
            if(nbre==0)
                victoire = true;
            if (victoire == true)
                MessageBox.Show("Bravo vous avez gagné !");    
        }

        public void cdtdefaite()
        {
            if (affichage[ligne, colonne].Image == b)
                defaite = true;
            if (defaite == true)
                MessageBox.Show("Dommage vous avez perdu.");
        }*/
        
        public void verif()
        {
            //panel2.Visible = true; ;
            nbre = 0;

        switch (ligne)
        {
        case 0:
            switch(colonne)
            {
                case 0:
                    if((affichagsoluce[ligne+1,colonne].Image==b))
                    {
                        nbre = nbre + 1;
                    }
                    if((affichagsoluce[ligne + 1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if((affichagsoluce[ligne, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;

                case 9:
                    if ((affichagsoluce[ligne + 1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne + 1, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;

                default:
                    if ((affichagsoluce[ligne + 1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne + 1, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne + 1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne-1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;
            }
            break;

        case 9:
            switch(colonne)
            {
                case 0:
                    if ((affichagsoluce[ligne, colonne+1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne -1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne-1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;

                case 9:
                    if ((affichagsoluce[ligne, colonne-1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne - 1, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne-1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;

                default:
                    if ((affichagsoluce[ligne-1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne - 1, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne - 1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;
            }
            break;

        default:
            switch(colonne)
            {
                case 0:

                    if ((affichagsoluce[ligne - 1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne - 1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne+1, colonne +1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne+1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;

                case 9:

                    if ((affichagsoluce[ligne - 1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne - 1, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne+1, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne+1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;

                default:
                    if ((affichagsoluce[ligne -1, colonne-1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne - 1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne-1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne - 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne, colonne+1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne + 1, colonne-1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne + 1, colonne].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    if ((affichagsoluce[ligne+1, colonne + 1].Image == b))
                    {
                        nbre = nbre + 1;
                    }
                    break;
            }
            break;
            }

           
            
            switch (nbre)
            {
                case 0:
                    affichage[ligne, colonne].Image = v;
                    break;
                case 1:
                    affichage[ligne, colonne].Image = u;
                    break;
                case 2:
                    affichage[ligne, colonne].Image = d;
                    break;
                case 3:
                    affichage[ligne, colonne].Image = t;
                    break;
                case 4:
                    affichage[ligne, colonne].Image = q;
                    break;
                case 5:
                    affichage[ligne, colonne].Image = ci;
                    break;
                case 6:
                    affichage[ligne, colonne].Image = s;
                    break;
                case 7:
                    affichage[ligne, colonne].Image = se;
                    break;
                case 8:
                    affichage[ligne, colonne].Image = h;
                    break;//si cacher: c si 4:q si 5:ci si 6:s si 7:se si 8:h
            }                   //si vide: v, si bombe: b, si 1: u, si 2: d, si 3: t, si perdu:p

            //panel2.Visible = false; ; ; ; ;

        }

        private void lb_nbbombe_Click(object sender, EventArgs e)
        {

        }
    }
}
