using System;

namespace JuegoAdivinanza
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.Jugar();
        }
    }

    class Juego
    {
        private int numeroAleatorio;
        private int intentosRestantes = 3;

        public Juego()
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1, 11);
        }

        public void Jugar()
        {
            Console.WriteLine("Bienvenido al juego de adivinanza. Tienes 3 intentos para adivinar un número del 1 al 10.");
            
            while (intentosRestantes > 0)
            {
                Console.Write("Ingresa un número: ");
                int numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado == numeroAleatorio)
                {
                    Console.WriteLine("¡Felicidades! Adivinaste el número.");
                    return;
                }
                else
                {
                    intentosRestantes--;
                    Console.WriteLine("Incorrecto. Te quedan " + intentosRestantes + " intentos.");
                }
            }

            Console.WriteLine("Lo siento, perdiste. El número era " + numeroAleatorio + ".");
        }
    }
}