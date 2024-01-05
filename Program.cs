using DesafioPOO.Models;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o número para o iPhone:");
        string numeroIphone = Console.ReadLine();
        Iphone iphone = new Iphone(numeroIphone);
        Console.Write("O número " + numeroIphone + " está ");
        iphone.Ligar();

        Console.WriteLine("Informe o número para o Nokia:");
        string numeroNokia = Console.ReadLine();
        Nokia nokia = new Nokia(numeroNokia);
        Console.Write("O número " + numeroNokia + " está ");
        nokia.ReceberLigacao();

        Console.WriteLine("--------------------");


        Console.WriteLine("Informe o aplicativo para instalar no iPhone:");
        string appIphone = Console.ReadLine();
        iphone.InstalarAplicativo(appIphone);



        Console.WriteLine("--------------------");

        Console.WriteLine("Informe o aplicativo para instalar no Nokia:");
        string appNokia = Console.ReadLine();
        nokia.InstalarAplicativo(appNokia);
    }
}
