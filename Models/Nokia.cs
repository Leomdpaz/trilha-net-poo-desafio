using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write($"Instalando {nomeApp} na plataforma Nokia");
            for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(900); // Pausa de 0.9 segundos
            Console.Write(".");
        }
        }
    }
}
