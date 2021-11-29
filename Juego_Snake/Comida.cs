using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Juego_Snake
{
    class Comida
    {
        private int x, y, width, height; // posición 
        private SolidBrush pincel; // dibuja la comida 
        public Rectangle comidarec; // comida 

        public Comida(Random randFood) //creación de la primera comida 
        {
            x = randFood.Next(0, 29) * 10; // posición aleatoria IZQUIERDA O DERECHA
            y = randFood.Next(0, 29) * 10; // posición aleatoria ARRIBA O ABAJO 
            pincel = new SolidBrush(Color.Yellow); // color de la comida 
            width = 10; // ancho de la comida 
            height = 10; // alto de la comida 
            comidarec = new Rectangle(x, y, width, height); // se crea el objeto "COMIDA"                   
        }
        public void locaciondecomida(Random ranFood)// posicion de la comida
        {
            x = ranFood.Next(0, 29) * 10; // posicion aleatoria de IZQUIERDA o DERECHA 
            y = ranFood.Next(0, 29) * 10; // posicion aleatoria de ARRIBA o ABAJO
        }

        public void dibujodecomida(Graphics paper)// dibujo de la comida (CAMPO DE JUEGO)
        {
            comidarec.X = x; // posicion aleatoria IZQUIERDA o DERECHA 
            comidarec.Y = y; // posicion aleatoria ARRIBA o ABAJO

            paper.FillRectangle(pincel, comidarec); // dibujo de la comida en el papel 
        }
    }
}
