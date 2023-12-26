using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GRAPHIQUE
{

    /*Créer le jou mastermind sur windws form avec les colores secrets les position et il marche just en mode de majuscule 
        prof:Aurélie Curchod
        par :Hanieh Mohajerani
        date de commence:09.11.2023*/

    // corriger etape 10,corrige position,corrige position vide,corige efface


    public partial class Game : Form
    {
        Menu mainMenu;
        public Game(Menu menu)
        {
            InitializeComponent();


            mainMenu = menu;
        }

        /// <summary>
        /// change lr color label 1
        /// </summary> mon choix numero 1
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            Color[] mycolors =
            {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow
            };

        }



        /// <summary>
        /// changer le color label 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lab2_Click(object sender, EventArgs e)
        {
            Color[] mycolors =
            {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow
            };
        }
        /// <summary>
        /// color bleu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       // int cntr = 0;
        private void label11_Click(object sender, EventArgs e)
        {

            //fonction pour le color blue
            changecolorbleu();

        }

        int contor1;
        int contor2;
        //fonction color bleu pour chaque botom
        void changecolorbleu()
        {

            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Blue;

                contor1++;
            }


        }




        /// <summary>
        /// effacer l'ecran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //sortir 
            System.Windows.Forms.Application.Exit();

        }

        /// <summary>
        /// label secret 1
        /// </summary> creer secret color pour labelsecret 1
        /// <param name="sender"></param>
        /// <param name="e"></param>


        // Création d'une instance de Random pour générer des combinaisons aléatoires
        Random random = new Random();
        const int PROPOSE = 4;
        const int DEVINE = 4;
        Color[] mycolors =
        {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow
        };
        Color[] mysecretcolor = new Color[4];

        private void labelsec1_Click(object sender, EventArgs e)
        {


        }


        /// <summary>
        /// creer secret color pour labelsecret 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelsec2_Click_1(object sender, EventArgs e)
        {


        }

        private void labelsec3_Click(object sender, EventArgs e)
        {


        }

        private void labelsec4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// pour choisir la place de bon color (color blanch=just et color noir =pas just
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            contor1 = 0;

            //for 4 fois essay(devine=4)je compare les color deviner avec le code secret

            bool[] colorUsed = new bool[4]; // Utilisez un tableau pour suivre les couleurs déjà utilisées

            int nbCorrect = 0;
            int nbErrors = 0;
            bool[] position = new bool[4];//position



            // Vérifiez les couleurs correctes et bien placées
            for (int i = 0; i < 4; i++)
            {
                if (tableColor[contor2, i].BackColor.ToArgb() == mysecretcolor[i].ToArgb())
                {
                    tblePosition[contor2, nbCorrect].BackColor = Color.White; // couleur correcte et bien placée
                    colorUsed[i] = position[i] = true;
                    nbCorrect++;
                }
            }


            //position et en color noir si color est juste et mal place 
            for (int i = 0; i < 4; i++)
                {
                    if (!colorUsed[i])
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (!position[j] && tableColor[contor2, j].BackColor == mysecretcolor[i])
                            {
                                nbErrors++;
                                colorUsed[i] = true;
                                position[j] = true;
                                tblePosition[contor2, nbCorrect + nbErrors - 1].BackColor = Color.Black; // couleur correcte mais mal placée
                                break;
                            

                            }
                        }
                    }
                }

            // Vérifiez les couleurs incorrectes
            for (int j = 0; j < 4; j++)
            {
                if (!colorUsed[j])
                {
                    tblePosition[contor2, nbCorrect + nbErrors].BackColor = Color.Silver; // couleur incorrecte
                }
            }

           
            contor2++;

        }


        private void lab3_Click(object sender, EventArgs e)
        {
            Color[] mycolors =
        {
    Color.Red,
    Color.Green,
    Color.Blue,
    Color.Yellow
};
        }

        private void lab4_Click(object sender, EventArgs e)
        {
            Color[] mycolors =
        {
    Color.Red,
    Color.Green,
    Color.Blue,
    Color.Yellow
};
        }

        private void lab7_Click(object sender, EventArgs e)
        {
            changecolorred();


        }

        void changecolorred()
        {

            //ceation color red
            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Red;

                contor1++;
            }

        }

        private void lab6_Click(object sender, EventArgs e)
        {
            changecolorgreen();

        }
        void changecolorgreen()
        {

            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Green;

                contor1++;
            }

        }

        private void lab8_Click(object sender, EventArgs e)
        {
            changecoloryellow();

        }
        void changecoloryellow()
        {

            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Yellow;

                contor1++;
            }

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            mainMenu.Show();
        }



        //creer botton noir et blanche
        // private const int LARGEUR_BOUTON1 = 16;
        //  private const int HAUTEUR_BOUTON2 = 19;
        //  Button[,] buttonArray1 = new Button[nomberLigne, nombreDeColonnes];

        // int contor3;
        //  int contor4;
        private const int nombreDeBoutons = 40;
        private const int nombreDeColonnes = 4;
        private const int nomberLigne = 10;
        int tailleBouton = 50;
        int contr = 0;
        int contr1 = 0;
        private const int LARGEUR_BOUTON = 50;
        private const int HAUTEUR_BOUTON = 50;
        private const int HAUTEUT_PANEL = 146;
        private const int LARGEUR_PANEL = 18;
        Button[,] tableColor = new Button[nomberLigne, nombreDeColonnes];
        private const int LARGEUR_BOUTON1 = 20;
        private const int HAUTEUR_BOUTON1 = 20;
        Button[,] tblePosition = new Button[nomberLigne, nombreDeColonnes];
        private void Game_Load(object sender, EventArgs e)
        {
            //creer ligne et colone
            for (int ligne = 0; ligne < nomberLigne; ligne++)
            {
                for (int colone = 0; colone < nombreDeColonnes; colone++)

                {
                    Color[] mycolors =
                    {
                    Color.Red,
                    Color.Green,
                    Color.Blue,
                    Color.Yellow
                            };
                    //nomero de botons ajoute chaque fois
                    contr++;
                    Button bouton = new Button();


                    //taile de botons
                    bouton.Size = new Size(LARGEUR_BOUTON, HAUTEUR_BOUTON);

                    //place de boton
                    bouton.Location = new System.Drawing.Point(colone * tailleBouton + LARGEUR_PANEL, ligne * tailleBouton + HAUTEUT_PANEL);

                    // Ajoutez le bouton au tableau
                    tableColor[ligne, colone] = bouton;

                    // Ajoutez un gestionnaire d'événements pour le click
                    bouton.Click += button1_Click;
                    this.Controls.Add(bouton);


                }

            }
            //creer ligne et colone
            for (int ligne1 = 0; ligne1 < nomberLigne; ligne1++)
            {

                for (int colone1 = 0; colone1 < nombreDeColonnes; colone1++)
                {
                   
                    //nomero de botons ajoute chaque fois
                    contr1++;
                    Button bouton1 = new Button();

                    //taile de botons
                    bouton1.Size = new Size(LARGEUR_BOUTON1, HAUTEUR_BOUTON1);

                    //place de boton
                    bouton1.Location = new System.Drawing.Point(colone1 * LARGEUR_BOUTON1 + 300, ligne1 * HAUTEUR_BOUTON + 150);
                    // Ajoutez le bouton au tableau
                    tblePosition[ligne1, colone1] = bouton1;
                    // Ajoutez un gestionnaire d'événements pour le click
                    bouton1.Click += button1_Click;
                    this.Controls.Add(bouton1);


                }
            }
         

        }


        private void label1_Click(object sender, EventArgs e)
        {
            // Rendre le code secret visible
            labelsec1.Visible = true;
            labelsec2.Visible = true;
            labelsec3.Visible = true;
            labelsec4.Visible = true;

            Random random = new Random();

            int x = 0; //Indice aléatoire 
            const int DEVINE = 4;

            // const int PROPOSE = 4;
            for (int i = 0; i < DEVINE;i++)
            {
                x = random.Next(mycolors.Length);
                mysecretcolor[i] = mycolors[x];
            }
           

            labelsec1.BackColor = mysecretcolor[0];
            labelsec2.BackColor = mysecretcolor[1];
            labelsec3.BackColor = mysecretcolor[2];
            labelsec4.BackColor = mysecretcolor[3];

            Label lab = new Label();
            for (int i = 0; i < PROPOSE; i++)
            {
                lab.BackColor = mysecretcolor[i];
            }

        }

        private void labelsec1_Click_1(object sender, EventArgs e)
        {

        }

        private void lab9_Click(object sender, EventArgs e)
        {
            changecolorpink();

        }

        void changecolorpink()
        {

            //ceation color brun
            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Pink;

                contor1++;
            }

        }

        private void lab10_Click(object sender, EventArgs e)
        {
            changecolorrose();
        }

        void changecolorrose()
        {

            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Fuchsia;

                contor1++;
            }


        }

        private void lab11_Click(object sender, EventArgs e)
        {
            changecolortorquoise();
        }

        void changecolortorquoise()
        {

            if (contor1 < 4)
            {
                tableColor[contor2, contor1].BackColor = Color.Turquoise;

                contor1++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Rendre le code secret invisible
            labelsec1.Visible = false;
            labelsec2.Visible = false;
            labelsec3.Visible = false;
            labelsec4.Visible = false;

            // Rendre le tableau du code secret invisible

           

        }
    }
}













