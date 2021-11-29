using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; // Using para dibujar 
using System.Threading.Tasks;

namespace Juego_Snake
{
    class snake
    {
        private Rectangle[] snakeRec; // la serpiente
        private SolidBrush pincel; // "pincel"
        private int x, y, width, height;

        public Rectangle[] SnakeRec // serpiente actual 
        {
            get { return snakeRec; }
        }

        public snake()
        {
            snakeRec = new Rectangle[3]; // tamaño inicial de la serpiente 
            pincel = new SolidBrush(Color.White); // color de la serpiente

            x = 20; // posición izquierda o derrecha 
            y = 0; // posición de arriba o abajo 
            width = 10; // ancho
            height = 10; // altura 
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height); // rectangulo de la serpiente 
                x -= 10; 
            }
        }
        public void dibujaSnake(Graphics papel) // (serpiente)
        {
            foreach (Rectangle rec in snakeRec)
            {
                papel.FillRectangle(pincel, rec); // dibuja a la serpiente 
            }
        }

        public void dibujaSnake() // reposiciona  
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
         }

        // Movimiento de la serpiente
        
        public void movimientoabajo() // posición hacia abajo 
        {
            dibujaSnake();
            snakeRec[0].Y += 10; // suma 10 en "y" ABAJO
        }
        public void movimientoarriba() //posición hacia arriba
        {
            dibujaSnake();
            snakeRec[0].Y -= 10; // resta 10 en "y" ARRIBA
        }
        public void movimientoizquierda() // posición hacia la izquierda 
        {
            dibujaSnake();
            snakeRec[0].X -= 10; // resta 10 en "x" IZQUIERDA
        }
        public void movimientoderecha() // posición hacia la derecha 
        {
            dibujaSnake();
            snakeRec[0].X += 10; // suma 10 en "x" DERECHA
        }
        public void crecimientodeSnake() // agrega un rectangulo más a la serpiente 
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();

        }
    }
}
