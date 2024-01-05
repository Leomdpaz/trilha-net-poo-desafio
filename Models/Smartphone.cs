using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // Adicione as propriedades faltantes conforme necessário

        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.Write("ligando");
            for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(900); // Pausa de 0.9 segundos
            Console.Write(".");
        }
        }

        public void ReceberLigacao()
        {
            Console.Write("recebendo Ligação");
            for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(900); // Pausa de 0.9 segundos
            Console.Write(".");
        }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
