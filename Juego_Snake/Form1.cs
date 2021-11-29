using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Snake
{
    public partial class Form1 : Form
    {
        Random randcomida = new Random(); // objeto - POSICION DE COMIDA 

        Graphics papel; // CREA CAMPO DE JUEGO 
        snake snakes = new snake(); // crea a la serpiente 
        Comida comida; // crea a la serpiente 
        bool izquierda = false;
        bool derecha = false;
        bool arriba = false;
        bool abajo = false;
        int score = 0;// --- PUNTUACIÓN

        public Form1()
        {
            InitializeComponent();
            comida = new Comida(randcomida);// posiciona la comida 
        }
        //EVENTO PAINT (DIBUJA LA SERPIENTE Y LA COMIDA)
        private void Form1_Load(object sender, EventArgs e)
        {         
            papel = e.Graphics;
            comida.dibujodecomida(papel);
            snakes.dibujaSnake(papel);
        }
        // EVENTO DE LAS TECLAS 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // si preciona la barra space (INICIA EL JUEGO)
            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                abajo = false;
                arriba = false;
                izquierda = false;
            }
            //si preciona abajo
            abajo = true; // indicación de que es para ABAJO
            if (e.KeyData == Keys.Down && arriba == false)
            {
                abajo = true; // indica que es abajo 
                arriba = false;
                derecha = false;
                izquierda = false;
            }
            //si preciona arriba 
            if (e.KeyData == Keys.Up && abajo == false)
            {
                abajo = false;
                arriba = true;// indica que es arriba 
                derecha = false;
                izquierda = false;
            }
            //si preciona izquierda
            if (e.KeyData == Keys.Left && derecha == false)
            {
                abajo = false;
                arriba = false;
                izquierda = true; //indica que es izquierda 
                derecha = false;
            }
            //si preciona derecha
            if (e.KeyData == Keys.Right && derecha == false)
            {
                abajo = false;
                arriba = false;
                derecha = true;
                izquierda = false;// indica que es derecha
            }
        }

        //USO DEL TIMER PARA CONTROLES DEL JUEGO 
        private void timer1_Tick(object sender, EventArgs e)
        {
            snakeScoreLabel.Text = Convert.ToString(score); // Indica la puntuación actual 

            if (abajo) {
                snakes.movimientoabajo();
            }
            if (arriba) {
                snakes.movimientoarriba();
            }
            if (derecha) {
                snakes.movimientoderecha();
            }
            if (izquierda) {
                snakes.movimientoderecha();
            }

            this.Invalidate(); // vemos el movimiento de la serpiente 

            colision();//revisa si choca la serpiente con alguna pared 

            for (int i = 0; i < snakes.SnakeRec.Length; i++)
            {
                // si la serpiente choca con comida 
                if (snakes.SnakeRec[i].IntersectsWith(comida.comidarec))
                {
                    score += 1;//puntuación sube de uno en uno 
                    snakes.crecimientodeSnake();//la serpiente crece 
                    comida.locaciondecomida(randcomida);
                }
            }
        }

        public void colision()//revisa si choca la serpiente con alguna pared 
        {
            for (int i = 1; i < snakes.SnakeRec.Length; i++)// verifica el tamaño de la serpiente 
            {
                if (snakes.SnakeRec[0].IntersectsWith(snakes.SnakeRec[i]))//si choca con ella misma 
                {
                    reiniciar();
                }
            }
            if (snakes.SnakeRec[0].X < 0 || snakes.SnakeRec[0].X > 290) // si choca izquierda o derecha 
            {
                reiniciar();
            }
            if (snakes.SnakeRec[0].Y < 0 || snakes.SnakeRec[0].X > 290) // si choca arriba o abajo 
            {
                reiniciar();
            }
        }
        public void reiniciar()
        {      
        }
        private void timer1_Tick_1(object sender, EventArgs e)

        {
            timer1.Enabled = false;
            snakes = new snake();// se crea una nueva serpiente 
            MessageBox.Show("GAME OVER \n Puntuación : " + score.ToString());
            snakeScoreLabel.Text = "0";  // reiniciar puntuación 
            Ultimoscore.Text = score.ToString();// ultima puntuación alcanzada 
            score = 0;
            spaceBarLabel.Text = "Preciona Barra Espaciadora para comenzar";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            spaceBarLabel.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            spaceBarLabel.Text = "";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close(); // cerrar juego
        }

        private void spaceBarLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
















